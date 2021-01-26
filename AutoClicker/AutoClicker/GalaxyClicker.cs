using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
using Microsoft.VisualBasic.Devices;
namespace AutoClicker
{
    public partial class GalaxyClicker : Form
    {
        private int centerMouseX;
        private int centerMouseY;
        private bool run = false;
        private int minTimeDefault = 1600;
        private int maxTimeDefault = 2600;
        private int minClickBeforeMouseMoveDefault = 1;
        private int maxClickBeforeMouseMoveDefault = 30;
        private int mousePixelsToMoveFromCenter = 3;
        private int mouseClicksThisRun = 0;
        private static object threadLocker = new object();
        delegate void UpdateMouseCoordLabelsCallback(string xCoord, string yCoord);

        public GalaxyClicker()
        {
            InitializeComponent();
            InitializeWaitTimes(minTimeDefault, maxTimeDefault, minClickBeforeMouseMoveDefault, maxClickBeforeMouseMoveDefault);
            Thread mouseCoordinateLabelThread = new Thread(() => ContinuallyUpdateMouseCoordLabel());
            mouseCoordinateLabelThread.IsBackground = true;
            mouseCoordinateLabelThread.Start();
        }

        private void ContinuallyUpdateMouseCoordLabel(int precisionMilliseconds = 60)
        {
            while (true)
            {
                System.Threading.Thread.Sleep(precisionMilliseconds); 
                UpdateMouseCoordLabelsCallback updateMouseCoordInvoker = new UpdateMouseCoordLabelsCallback(SetMouseCoordLabels);
                string currentXCoord = Cursor.Position.X.ToString();
                string currentYCoord = Cursor.Position.Y.ToString();
                try
                {
                    this.Invoke(updateMouseCoordInvoker, new object[] { currentXCoord, currentYCoord });
                }
                catch (Exception) { };
            }
        }
        private void InitializeWaitTimes(int minTime, int maxTime, int minClicksBeforeMouseMove, int maxClicksBeforeMouseMove)
        {
            this.minWait.Text = minTimeDefault + "";
            this.maxWait.Text = maxTimeDefault + "";
            this.minClicksBetweenMovement.Text = minClickBeforeMouseMoveDefault + "";
            this.maxClicksBetweenMovement.Text = maxClickBeforeMouseMoveDefault + "";
        }
        private void StartButton_Click(object sender, EventArgs e)
        {
            StartAutoClicker();
        }
        private void StartAutoClicker()
        {
            String errorType;

            if (ValidFieldData(out errorType))
            {
                if (!this.run)
                    AutoClickOnNewThread();
                this.run = true;
                DisableSettingFields();
            }
            else
            {
                string errorMessage;
                string caption;
                MessageBoxButtons errorButtons = MessageBoxButtons.OK;
                if (errorType == "NON-INT")
                {
                    errorMessage = "Wait Time and Mouse Clicks need to be non-decimal numbers!";
                    caption = "Invalid input(s)";
                    errorButtons = MessageBoxButtons.OK;
                }
                else
                {
                    errorMessage = "Max clicks/Max time cannot be less than Min clicks/Min time!";
                    caption = "Max < Min Error";
                    errorButtons = MessageBoxButtons.OK;
                }
                MessageBox.Show(errorMessage, caption, errorButtons);
            }
        }
        private bool ValidFieldData(out string typeError)
        {
            typeError = "NONE";
            int minClicks;
            int maxClicks;
            int minWait;
            int maxWait;
            try
            {
                minClicks = int.Parse(this.minClicksBetweenMovement.Text.ToString());
                maxClicks = int.Parse(this.maxClicksBetweenMovement.Text.ToString());
                minWait = int.Parse(this.minWait.Text.ToString());
                maxWait = int.Parse(this.maxWait.Text.ToString());
            }
            catch (Exception)
            {
                typeError = "NON-INT";
                return false;
            }
            if (maxClicks < minClicks || maxWait < minWait)
            {
                typeError = "MAX LESS THAN MIN";
                return false;
            }

            return true;
        }
        private void AutoClickOnNewThread()
        {
            centerMouseX = Cursor.Position.X;
            centerMouseY = Cursor.Position.Y;

            Thread t = new Thread(AutoClick);
            t.IsBackground = true;
            t.Start();
        }
        private void AutoClick()
        {

            int minWaitTime = int.Parse(minWait.Text.ToString());
            int maxWaitTime = int.Parse(maxWait.Text.ToString());
            int minClicks = int.Parse(minClicksBetweenMovement.Text.ToString());
            int maxClicks = int.Parse(maxClicksBetweenMovement.Text.ToString());

            while (this.run)
            {
                Random rnd = new Random();
                int numbersToClickBeforeUpdatingPosition = rnd.Next(minClicks, maxClicks); //Number of times to click before changing mouse position
                int counter = 0;
                while (counter < numbersToClickBeforeUpdatingPosition && this.run)
                {
                    int timeBetweenClicks = rnd.Next(minWaitTime, maxWaitTime);
                    DoMouseClick();
                    this.mouseClicksThisRun++;
                    MethodInvoker numClicksLabelUpdater = new MethodInvoker(() => SetMouseClickLabel(this.mouseClicksThisRun));
                    this.Invoke(numClicksLabelUpdater);
                    Thread.Sleep(timeBetweenClicks);
                    counter++;
                }
                MethodInvoker mouseCoordUpdateInvoker = new MethodInvoker(RandomlyUpdateMouseCoordinates);
                this.Invoke(mouseCoordUpdateInvoker);
                Thread.Sleep(1000);
            }
        }
        private void RandomlyUpdateMouseCoordinates()
        {

            if (this.run)
            {
                UpdateMouseCenterIfUserMovedMouse();

                Random rnd = new Random();
                int randX = this.centerMouseX + rnd.Next(1, mousePixelsToMoveFromCenter);
                int randY = this.centerMouseY + rnd.Next(1, mousePixelsToMoveFromCenter);

                Win32.POINT p = new Win32.POINT();

                int sleepTime = rnd.Next(1000, 4500); //Sleep between 1 and 4.5 seconds..?

                Win32.ClientToScreen(this.Handle, ref p);
                Win32.SetCursorPos(randX, randY);
                System.Threading.Thread.Sleep(sleepTime);

                SetMouseCoordLabels(Cursor.Position.X.ToString(), Cursor.Position.Y.ToString());

            }
        }
        private void SetMouseCoordLabels(string xPos, string yPos)
        {
            this.MouseXLabel.Text = "Mouse X Position: " + xPos;
            this.MouseYLabel.Text = "Mouse Y position: " + yPos;
        }

        private void DoMouseClick()
        {
            if (this.run)
            {
                //Call the imported function with the cursor's current position
                uint X = (uint)Cursor.Position.X;
                uint Y = (uint)Cursor.Position.Y;
                Win32.mouse_event(Win32.MOUSEEVENTF_LEFTDOWN | Win32.MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
            }
        }
        private void UpdateMouseCenterIfUserMovedMouse()
        {
            if (Math.Abs(Cursor.Position.X - centerMouseX) > mousePixelsToMoveFromCenter
                || Math.Abs(Cursor.Position.Y - centerMouseY) > mousePixelsToMoveFromCenter)
            {
                centerMouseX = Cursor.Position.X;
                centerMouseY = Cursor.Position.Y;
            }
        }
        public class Win32
        {
            [DllImport("User32.Dll")]
            public static extern long SetCursorPos(int x, int y);
            [DllImport("User32.Dll")]
            public static extern bool ClientToScreen(IntPtr hWnd, ref POINT point);
            [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
            public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);
            public const int MOUSEEVENTF_LEFTDOWN = 0x02;
            public const int MOUSEEVENTF_LEFTUP = 0x04;
            public const int MOUSEEVENTF_RIGHTDOWN = 0x08;
            public const int MOUSEEVENTF_RIGHTUP = 0x10;

            [StructLayout(LayoutKind.Sequential)]
            public struct POINT
            {
                public int x;
                public int y;
            }
        }
        private void SetMouseClickLabel(int numClicks)
        {
            this.numMouseClicks.Text = numClicks + " Total Mouse Clicks";
        }
        private void StopButton_Click(object sender, EventArgs e)
        {
            this.run = false;
            this.mouseClicksThisRun = 0;
            SetMouseClickLabel(mouseClicksThisRun);
            EnableSettingFields();
        }
        #region Enable/Disable Setting Fields
        private void EnableSettingFields()
        {
            this.startButton.Enabled = true;
            this.maxClicksBetweenMovement.Enabled = true;
            this.minClicksBetweenMovement.Enabled = true;
            this.minWait.Enabled = true;
            this.maxWait.Enabled = true;
        }

        private void DisableSettingFields()
        {
            this.startButton.Enabled = false;
            this.maxClicksBetweenMovement.Enabled = false;
            this.minClicksBetweenMovement.Enabled = false;
            this.minWait.Enabled = false;
            this.maxWait.Enabled = false;
        }
        #endregion

        private void AutoClicker_Load(object sender, EventArgs e)
        {
        }
        private void startButton_Click_1(object sender, EventArgs e)
        {
            StartAutoClicker();
        }
        //50726f7065727479204f662050737963686f204e6574776f726b732f47322d4234445350305254
        private void stopButton_Click_1(object sender, EventArgs e)
        {
            this.run = false;
            this.mouseClicksThisRun = 0;
            SetMouseClickLabel(mouseClicksThisRun);
            EnableSettingFields();
        }
        private void logInButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void logInButton2_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                form.WindowState = FormWindowState.Minimized;
            }
        }
        private void AutoClicker_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        Point lastPoint;

        private void AutoClicker_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        private void numMouseClicks_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.youtube.com/channel/UCr8Nm2vFMnn10-Nj9CcUB_A");
        }

        private void MouseYLabel_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.youtube.com/channel/UCr8Nm2vFMnn10-Nj9CcUB_A");
        }

        private void MouseXLabel_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.youtube.com/channel/UCr8Nm2vFMnn10-Nj9CcUB_A");
        }

        private void startButton_Click_2(object sender, EventArgs e)
        {
            StartAutoClicker();
        }

        private void stopbutton_Click_2(object sender, EventArgs e)
        {
            this.run = false;
            this.mouseClicksThisRun = 0;
            SetMouseClickLabel(mouseClicksThisRun);
            EnableSettingFields();
        }

        private void guna2GradientPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2GradientPanel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void label4_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void label4_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
    }
}
