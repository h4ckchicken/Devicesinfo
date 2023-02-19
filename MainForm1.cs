using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using System.Threading;
using System.Diagnostics;

namespace Devicesinfo
{
    public partial class MainForm1 : Form
    {
        public MainForm1()
        {
            InitializeComponent();
            DarkTitleBarClass.UseImmersiveDarkMode(Handle, true);
            this.AutoScroll = true;
            this.HorizontalScroll.Enabled = true;
            this.HorizontalScroll.Visible = true;
            this.VerticalScroll.Enabled = true;
            this.VerticalScroll.Visible = true;
        }

        internal class DarkTitleBarClass
        {
            [DllImport("dwmapi.dll")]
            private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr,
            ref int attrValue, int attrSize);

            private const int DWMWA_USE_IMMERSIVE_DARK_MODE_BEFORE_20H1 = 19;
            private const int DWMWA_USE_IMMERSIVE_DARK_MODE = 20;

            internal static bool UseImmersiveDarkMode(IntPtr handle, bool enabled)
            {
                if (IsWindows10OrGreater(17763))
                {
                    var attribute = DWMWA_USE_IMMERSIVE_DARK_MODE_BEFORE_20H1;
                    if (IsWindows10OrGreater(18985))
                    {
                        attribute = DWMWA_USE_IMMERSIVE_DARK_MODE;
                    }

                    int useImmersiveDarkMode = enabled ? 1 : 0;
                    return DwmSetWindowAttribute(handle, attribute, ref useImmersiveDarkMode, sizeof(int)) == 0;
                }

                return false;
            }
            private static bool IsWindows10OrGreater(int build = -1)
            {
                return Environment.OSVersion.Version.Major >= 10 && Environment.OSVersion.Version.Build >= build;
            }
        }

        int Move;
        int Mouse_X;
        int Mouse_Y;

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            Move = 0;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            Move = 1;
            Mouse_X = e.X;
            Mouse_Y = e.Y;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (Move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - Mouse_X, MousePosition.Y - Mouse_Y);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            try
            {
                string processName = "Devicesinfo.exe";
                Process[] processes = Process.GetProcessesByName(processName);

                foreach (Process process in processes)
                {
                    process.Kill();
                }
            }
            catch
            {
                //
            }
        }

        private void theme_Click(object sender, EventArgs e)
        {
            try
            {
                if(Başlık.BackColor == Color.FromArgb(32, 32, 32))
                {
                    Başlık.BackColor = Color.FromArgb(255, 255, 255);
                    icon.ImageLocation = @"assets\\dark\\lighticon.gif";
                    closed.Image = Image.FromFile(@"assets\\dark\\lightclose.png");
                    closed.BackColor = Color.FromArgb(255, 255, 255);
                    minimize.Image = Image.FromFile(@"assets\\dark\\lightminimize.png");
                    minimize.BackColor = Color.FromArgb(255, 255, 255);
                    icon.BackColor = Color.FromArgb(255, 255, 255);
                    title.ForeColor = Color.FromArgb(0, 0, 0);
                    theme.BackColor = Color.FromArgb(255,255,255);

                    this.BackColor = Color.FromArgb(240, 240, 240);

                    Menu.BackColor = Color.FromArgb(200, 200, 200);
                    Menu.ForeColor = Color.FromArgb(0, 0, 0);

                    ayrıntı.BackColor = Color.FromArgb(200, 200, 200);
                    ayrıntı.ForeColor = Color.FromArgb(0, 0, 0);

                    managerbtn.BackColor = Color.FromArgb(200, 200, 200);
                    managerbtn.ForeColor = Color.FromArgb(0, 0, 0);

                    development.BackColor = Color.FromArgb(200, 200, 200);
                    development.ForeColor = Color.FromArgb(0, 0, 0);

                    github.BackColor = Color.FromArgb(200, 200, 200);
                    github.ForeColor = Color.FromArgb(0, 0, 0);

                    quit.BackColor = Color.FromArgb(200, 200, 200);
                    quit.ForeColor = Color.FromArgb(0, 0, 0);
                }
                else
                {
                    Başlık.BackColor = Color.FromArgb(32, 32, 32);
                    icon.ImageLocation = @"assets\\light\\darkicon.png";
                    closed.Image = Image.FromFile(@"assets\\light\\darkclose.png");
                    closed.BackColor = Color.FromArgb(32, 32, 32);
                    minimize.Image = Image.FromFile(@"assets\\light\\darkminimize.png");
                    minimize.BackColor = Color.FromArgb(32, 32, 32);
                    icon.BackColor = Color.FromArgb(32, 32, 32);
                    title.ForeColor = Color.FromArgb(240, 240, 240);
                    theme.BackColor = Color.FromArgb(32, 32, 32);

                    this.BackColor = Color.FromArgb(26, 26, 26);

                    Menu.BackColor = Color.FromArgb(48, 48, 48);
                    Menu.ForeColor = Color.FromArgb(240, 240, 240);

                    ayrıntı.BackColor = Color.FromArgb(48, 48, 48);
                    ayrıntı.ForeColor = Color.FromArgb(240, 240, 240);

                    managerbtn.BackColor = Color.FromArgb(48, 48, 48);
                    managerbtn.ForeColor = Color.FromArgb(240, 240, 240);

                    development.BackColor = Color.FromArgb(48, 48, 48);
                    development.ForeColor = Color.FromArgb(240, 240, 240);

                    github.BackColor = Color.FromArgb(48, 48, 48);
                    github.ForeColor = Color.FromArgb(240, 240, 240);

                    quit.BackColor = Color.FromArgb(48, 48, 48);
                    quit.ForeColor = Color.FromArgb(240, 240, 240);
                }
            }
            catch
            {
                MessageBox.Show("Bilinmeyen bir hata sonucu tema değiştirilemedi!", "Hata!" + MessageBoxIcon.Information);
            }
        }

        private void quit_Click(object sender, EventArgs e)
        {
            this.Close();
            try
            {
                string processName = "Devicesinfo.exe";
                Process[] processes = Process.GetProcessesByName(processName);

                foreach (Process process in processes)
                {
                    process.Kill();
                }
            }
            catch
            {
                //
            }
        }

        private void Menu_Click(object sender, EventArgs e)
        {
            menu form2 = new menu();
            form2.TopLevel = false;
            sayfa.Controls.Clear();
            sayfa.Controls.Add(form2);
            form2.Show();

            Thread thread = new Thread(() =>
            {
                while (true)
                {
                    try
                    {
                        string processName = "Devicesinfo.exe";
                        Process[] processes = Process.GetProcessesByName(processName);

                        foreach (Process process in processes)
                        {
                            process.Kill();
                        }
                    }
                    catch
                    {
                        //
                    }

                    if (Başlık.BackColor == Color.FromArgb(32, 32, 32))
                    {
                        form2.BackColor = Color.FromArgb(26, 26, 26);
                        form2.ForeColor = Color.White;
                        sayfa.BackColor = Color.FromArgb(26, 26, 26);

                    }
                    else
                    {
                        form2.BackColor = Color.FromArgb(240, 240, 240);
                        form2.ForeColor = Color.Black;
                        sayfa.BackColor = Color.FromArgb(240, 240, 240);
                    }
                }
            });

            thread.Start(); // İş parçacığını başlat

        }

        private void github_Click(object sender, EventArgs e)
        {
            Process.Start(@"link.bat");
        }

        private void ayrıntı_Click(object sender, EventArgs e)
        {
            ayrıntılar form3 = new ayrıntılar();
            form3.TopLevel = false;
            sayfa.Controls.Clear();
            sayfa.Controls.Add(form3);
            form3.Show();

            Thread thread2 = new Thread(() =>
            {
                while (true)
                {
                    try
                    {
                        string processName = "Devicesinfo.exe";
                        Process[] processes = Process.GetProcessesByName(processName);

                        foreach (Process process in processes)
                        {
                            process.Kill();
                        }
                    }
                    catch
                    {
                        //
                    }

                    if (Başlık.BackColor == Color.FromArgb(32, 32, 32))
                    {
                        form3.BackColor = Color.FromArgb(26, 26, 26);
                        form3.ForeColor = Color.White;
                        sayfa.BackColor = Color.FromArgb(26, 26, 26);

                    }
                    else
                    {
                        form3.BackColor = Color.FromArgb(240, 240, 240);
                        form3.ForeColor = Color.Black;
                        sayfa.BackColor = Color.FromArgb(240, 240, 240);
                    }
                }
            });

            thread2.Start(); // İş parçacığını başlat
        }

        private void development_Click(object sender, EventArgs e)
        {
            Process.Start("dvlp.bat");
        }

        private void managerbtn_Click(object sender, EventArgs e)
        {
            Manager mngform = new Manager();
            mngform.TopLevel = false;
            sayfa.Controls.Clear();
            sayfa.Controls.Add(mngform);
            mngform.Show();

            Thread thread2 = new Thread(() =>
            {
                while (true)
                {
                    try
                    {
                        string processName = "Devicesinfo.exe";
                        Process[] processes = Process.GetProcessesByName(processName);

                        foreach (Process process in processes)
                        {
                            process.Kill();
                        }
                    }
                    catch
                    {
                        //
                    }

                    if (Başlık.BackColor == Color.FromArgb(32, 32, 32))
                    {
                        mngform.BackColor = Color.FromArgb(26, 26, 26);
                        mngform.ForeColor = Color.White;
                        sayfa.BackColor = Color.FromArgb(26, 26, 26);

                    }
                    else
                    {
                        mngform.BackColor = Color.FromArgb(240, 240, 240);
                        mngform.ForeColor = Color.Black;
                        sayfa.BackColor = Color.FromArgb(240, 240, 240);
                    }
                }
            });

            thread2.Start(); // İş parçacığını başlat
        }
    }
}
