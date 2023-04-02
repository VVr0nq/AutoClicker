using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Runtime.InteropServices.ComTypes;
using System.Globalization;

namespace Clicker_VVr0ng_WHY
{
    public partial class GildiaWhyClicker : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
            (
          int nLeftRect,
          int nTopRect,
          int nRightRect,
          int nBottomRect,
          int nWidthEllipse,
          int nHeightEllipse
            );

        [DllImport("user32.dll", EntryPoint = "PostMessageA")]
        private static extern bool PostMessage(IntPtr hwnd, uint msg, int wParam, int lParam);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll", SetLastError = true)]
        private static extern IntPtr FindWindow(string IpClassName, string IpWindowName);

        [DllImport("user32.dll")]
        private static extern short GetAsyncKeyState(System.Windows.Forms.Keys vkey);







        public GildiaWhyClicker()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CPSTrackBar_Scroll(object sender, ScrollEventArgs e)
        {
            CPSValue.Text = CPSTrackBar.Value.ToString();
        }

        private void btnToggle_Click(object sender, EventArgs e)
        {
            if (btnToggle.Text.Contains("Enable"))
            {
                btnToggle.ForeColor = Color.LightGreen;
                btnToggle.FillColor = Color.Red;
                btnToggle.Text = "Disable";
            }
            else if (btnToggle.Text.Contains("Disable"))
            {
                btnToggle.ForeColor = Color.Red;
                btnToggle.FillColor = Color.LightGreen;
                btnToggle.Text = "Enable";
            }
        }

        private void btnToggle_TextChanged(object sender, EventArgs e)
        {
            if (btnToggle.Text.Contains("Disable"))
            {
                AutoClicker.Start();
            }
            else
            {
                AutoClicker.Stop();
            }
        }

        int min;
        int max;
        IntPtr hwnd;

        public string GetActiveWindowName()
        {
            try
            {
                var activateHandle = GetForegroundWindow();

                Process[] processes = Process.GetProcesses();
                foreach (Process clsProcess in processes)
                {
                    if (activateHandle == clsProcess.MainWindowHandle)
                    {
                        string processName = clsProcess.ProcessName;
                        return processName;
                    }
                }


            }
            catch { }
            return null;
        }



        private void Random_Tick(object sender, EventArgs e)
        {
            if (btnToggle.Text.Contains("Disable"))
            {
                min = CPSTrackBar.Value - 6;
                max = CPSTrackBar.Value + 6;
                Random rand = new Random();
                RandomTrackbar.Value = (rand.Next(min, max));
            }

        }
        private async void AutoClicker_Ticks(object sender, EventArgs e)
        {
            try
            {
                AutoClicker.Interval = 1000 / RandomTrackbar.Value;
            }
            catch { }
            if (btnToggle.Text.Contains("Disable"))
            {
                Process[] processes = Process.GetProcessesByName("javaw");
                foreach (Process process in processes)
                {
                    hwnd = FindWindow(null, process.MainWindowTitle);
                }

                string currentwindow = GetActiveWindowName();
                if (currentwindow == null)
                {
                    return;
                }
                if (currentwindow.Contains("javaw"))
                {
                    if (MouseButtons == MouseButtons.Left)
                    {
                        PostMessage(hwnd, 0x201, 0, 0);
                        await Task.Delay(30);
                        PostMessage(hwnd, 0x202, 0, 0);
                    }
                }
            }
        }

        private void RandomTrackbar_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private bool isHotkeyEnabled = false;
        private Keys hotkey = Keys.None;
        private void Bindbtn_KeyDown(object sender, KeyEventArgs e)
        {
            if (isHotkeyEnabled)
            {
                hotkey = e.KeyCode;
                isHotkeyEnabled = false;
                Bindbtn.Text = "" + hotkey.ToString();
                btnToggle_Click(sender, e);
            }
            if (hotkey != Keys.None && e.KeyCode == hotkey)
            {
                btnToggle_Click(sender, e);
            }
        }

        private void Bindbtn_Click(object sender, EventArgs e)
        {
            if (isHotkeyEnabled)
            {
                isHotkeyEnabled = false;
                Bindbtn.Text = "";
            }
            else
            {
                isHotkeyEnabled = true;
                Bindbtn.Text = "...";
            }
        }

        private void Mining_Click(object sender, EventArgs e)
        {

        }
    }
}