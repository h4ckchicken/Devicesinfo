using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Devicesinfo
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
            this.AutoScroll = true;
            this.HorizontalScroll.Enabled = true;
            this.HorizontalScroll.Visible = true;
            this.VerticalScroll.Enabled = true;
            this.VerticalScroll.Visible = true;

            // Cihaz adını al
            string deviceName = Environment.MachineName;
            Cihazadı.Text = "Cihaz Adı: " + deviceName;

            string kullaniciadi = Environment.UserName.ToString();
            kuladı.Text = "Kullanıcı Adı  " + kullaniciadi;

            // İşletim sistemi adını al
            string osName = RuntimeInformation.OSDescription;
            işletimad.Text = "Operating System: " + osName;

            // Takılı RAM miktarını al
            ManagementObjectSearcher ramMonitor = new ManagementObjectSearcher("SELECT Capacity FROM Win32_PhysicalMemory");
            ulong totalRam = 0;
            foreach (ManagementObject mo in ramMonitor.Get())
            {
                totalRam += Convert.ToUInt64(mo["Capacity"]);
            }
            ram.Text = "Takılı RAM Miktarı:  " + totalRam / (1024 * 1024 * 1024) + " GB";

            // Sistem türünü al
            string systemType = string.Empty;
            using (ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_ComputerSystem"))
            {
                foreach (ManagementObject mo in searcher.Get())
                {
                    systemType = mo["SystemType"].ToString();
                    break;
                }
            }
            tür.Text = "Sistem Türü:  " + systemType;
        }
    }
}
