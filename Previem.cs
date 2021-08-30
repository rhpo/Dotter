using System;
using System.Windows.Forms;
using CefSharp.WinForms;
using CefSharp;
using System.Runtime.InteropServices;

namespace Dotterl
{
    public partial class Previem : Form
    {
        public static ChromiumWebBrowser browser;
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public Previem()
        {
            InitializeComponent();
            InitBrowser();
        }

        private void Previem_Load(object sender, EventArgs e)
        {

        }

        public void InitBrowser()
        {
            Cef.Initialize(new CefSettings());
            browser = new ChromiumWebBrowser("google.com");
            this.Controls.Add(browser);
            browser.Dock = DockStyle.Bottom;
            browser.Location = new System.Drawing.Point(browser.Location.X, titleBar.Height);
            browser.Height = Height - titleBar.Height;
            browser.LoadHtml("<html><body><center><br><br><h1 style=\"font-family: Segoe UI, Frutiger, Frutiger Linotype, Dejavu Sans, Helvetica Neue, Arial, sans-serif;\">Hello, World!</h1><br><button>Welcome !</button></center></body></html>");
            // browser.LoadHtml();
            //browser.ExecuteScriptAsyncWhenPageLoaded("waitForElm('notice-3bPHh- colorDefault-22HBa0').then(elm => alert('form_loaded'));");
        }

        public void changeText(string html)
        {
            if (browser != null)
            browser.LoadHtml(html);
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void titleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void Previem_Resize(object sender, EventArgs e)
        {
            BarButtons.Location = new System.Drawing.Point((Width/* + Width*/ - BarButtons.Width), BarButtons.Location.Y);
        }
    }
}
