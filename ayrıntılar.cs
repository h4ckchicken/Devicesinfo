using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Net;
using System.Net.Sockets;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using System.Security.Cryptography;
using System.Net.NetworkInformation;

namespace Devicesinfo
{
    public partial class ayrıntılar : Form
    {

        public ayrıntılar()
        {
            InitializeComponent();
            this.AutoScroll = true;
            this.HorizontalScroll.Enabled = true;
            this.HorizontalScroll.Visible = true;
            this.VerticalScroll.Enabled = true;
            this.VerticalScroll.Visible = true;

            Thread thread = new Thread(() =>
            {

                ManagementObjectSearcher searcher6 = new ManagementObjectSearcher("SELECT * FROM Win32_VideoController");

                foreach (ManagementObject queryObj in searcher6.Get())
                {
                    grfüretici.Text = "Grafik Kartı Üreticisi: " + queryObj["AdapterCompatibility"];
                    krtname.Text = "Grafik Kartı Adı: " + queryObj["Name"];
                    grfram.Text = "Grafik Kartı RAM Boyutu: " + Math.Round(Convert.ToDouble(queryObj["AdapterRAM"]) / (1024 * 1024)) + " MB";
                    gfrsürücü.Text = "Grafik Kartı Sürücüsü Versiyonu: " + queryObj["DriverVersion"];
                    grfsürücütime.Text = "Grafik Kartı Sürücüsü Tarihi: " + queryObj["DriverDate"];
                    grfözellik.Text = "Grafik Kartı Özellikleri: " + queryObj["VideoModeDescription"];
                    grfyonga.Text = "Grafik Kartı Yonga Seti: " + queryObj["VideoProcessor"];
                    grfçözünürlük.Text = "Grafik Kartı Çözünürlüğü: " + queryObj["CurrentHorizontalResolution"] + " x " + queryObj["CurrentVerticalResolution"];
                }

                string deviceId = string.Empty;
                ManagementClass mc = new ManagementClass("win32_processor");
                ManagementObjectCollection moc = mc.GetInstances();

                foreach (ManagementObject mo in moc)
                {
                    if (deviceId == string.Empty)
                    {
                        deviceId = mo.Properties["processorID"].Value.ToString();
                        ürnkimlik.Text =  "Cihaz Kimliği:  " + deviceId;
                        break;
                    }
                }



                while (true)
                {
                    // CPU bilgilerini al
                    ManagementObjectSearcher searcher = new ManagementObjectSearcher("select * from Win32_Processor");
                    ManagementObjectCollection collection = searcher.Get();
                    foreach (ManagementObject obj in collection)
                    {
                        cpuname.Text = "CPU Adı: " + obj["Name"];
                        cpuman.Text = "CPU Üretici Firma: " + obj["Manufacturer"];
                        cpuclock.Text = "CPU Max Çekirdek Hızı: " + obj["MaxClockSpeed"] + "Mhz";
                    }

                    // Takılı RAM miktarını al
                    ManagementObjectSearcher ramMonitor = new ManagementObjectSearcher("SELECT Capacity FROM Win32_PhysicalMemory");
                    ulong totalRam = 0;
                    foreach (ManagementObject mo in ramMonitor.Get())
                    {
                        totalRam += Convert.ToUInt64(mo["Capacity"]);
                    }
                    mamcap.Text = "RAM Miktarı:  " + totalRam / (1024 * 1024 * 1024) + " GB";


                    // Bellek bilgilerini al
                    

                    // CPU kullanımını al
                    PerformanceCounter cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
                    while (true)
                    {

                        if (this.BackColor == Color.FromArgb(26, 26, 26))
                        {
                            writebtn.BackColor = Color.FromArgb(48, 48, 48);
                            writebtn.ForeColor = Color.FromArgb(240, 240, 240);
                        }
                        else
                        {
                            writebtn.BackColor = Color.FromArgb(200, 200, 200);
                            writebtn.ForeColor = Color.Black;
                        }

                        IPAddress[] localIPs = Dns.GetHostAddresses(Dns.GetHostName());
                        foreach (IPAddress addr in localIPs)
                        {
                            if (addr.AddressFamily == AddressFamily.InterNetwork)
                            {
                                string localIP = addr.ToString();
                                lclıp.Text = "Local (yerel) IP: " + localIP;
                            }
                            else
                            {
                                lclıp.Text = "Local (yerel) IP: Bağlantı Sağlanamadı";
                            }
                        }
                        foreach (IPAddress addr in localIPs)
                        {
                            try
                            {
                                string externalIP = new WebClient().DownloadString("http://icanhazip.com").Trim();
                                pblıp.Text = "Public (Dış) IP: " + externalIP;
                            }
                            catch
                            {
                                pblıp.Text = "Public (Dış) IP: Bağlantı Sağlanamadı";
                            }
                        }

                        // Wi-Fi arabirimine ait ağ bağlantı bilgisini al
                        NetworkInterface wifiInterface = NetworkInterface.GetAllNetworkInterfaces()
                            .FirstOrDefault(i => i.NetworkInterfaceType == NetworkInterfaceType.Wireless80211);

                        if (wifiInterface != null)
                        {
                            // İstatistikleri al
                            IPv4InterfaceStatistics statistics = wifiInterface.GetIPv4Statistics();

                            // Gönderme hızını al
                            long bytesSent = statistics.BytesSent;
                            DateTime start = DateTime.Now;
                            // Ağa veri gönder
                            // Burada ağa veri gönderen işlemler yazılır
                            // ...

                            // Geçen süreyi hesapla ve hızı hesapla
                            double seconds = (DateTime.Now - start).TotalSeconds;
                            double sendSpeed = (statistics.BytesSent - bytesSent) / seconds;

                            // Alım hızını al
                            long bytesReceived = statistics.BytesReceived;
                            start = DateTime.Now;
                            // Ağdan veri al
                            // Burada ağdan veri alan işlemler yazılır
                            // ...

                            // Geçen süreyi hesapla ve hızı hesapla
                            seconds = (DateTime.Now - start).TotalSeconds;
                            double receiveSpeed = (statistics.BytesReceived - bytesReceived) / seconds;

                            // Sonuçları kullanarak işlemler yapabilirsiniz
                            foreach (NetworkInterface ni in NetworkInterface.GetAllNetworkInterfaces())
                            {
                                interface2.Text = ($"Interface: {ni.Name}");
                            }
                            wifigonder.Text = "Gönderme hızı: " + sendSpeed + " bytes/saniye";
                            wifial.Text = "Alma hızı: " + receiveSpeed + " bytes/saniye";
                        }

                        // Tüm ağ arabirimlerini al
                        NetworkInterface[] interfaces = NetworkInterface.GetAllNetworkInterfaces();

                        foreach (NetworkInterface nic in interfaces)
                        {
                            // Sadece Ethernet arabirimlerine bak
                            if (nic.NetworkInterfaceType == NetworkInterfaceType.Ethernet)
                            {
                                IPv4InterfaceStatistics stats = nic.GetIPv4Statistics();
                                long bytesReceived = stats.BytesReceived;
                                long bytesSent = stats.BytesSent;

                                Intfc.Text = ($"Interface: {nic.Name}");
                                recei.Text = ($"Received: {bytesReceived} bytes");
                                sent.Text = ($"Sent: {bytesSent} bytes");
                            }
                        }

                        Thread.Sleep(200);
                        float cpuUsage = cpuCounter.NextValue();
                        cpuuse.Text = ("CPU Kullanımı: " +  cpuUsage) + "%";

                        searcher = new ManagementObjectSearcher("select * from Win32_PhysicalMemory");
                        collection = searcher.Get();
                        foreach (ManagementObject obj in collection)
                        {

                            memspeed.Text = "Bellek Hızı: " + obj["Speed"] + " Mhz";
                        }

                        // Sistem performansı bilgilerini al
                        PerformanceCounter ramCounter = new PerformanceCounter("Memory", "Available MBytes");
                        availablemem.Text = "Boşta Bellek: " + ramCounter.NextValue() + "MB";

                        ManagementObjectSearcher searcher3 = new ManagementObjectSearcher("SELECT * FROM Win32_BaseBoard");
                        ManagementObjectCollection collection3 = searcher3.Get();

                        foreach (ManagementObject obj in collection3)
                        {
                            krtmodel.Text = "Anakart Modeli:  " + obj["Product"];
                        }

                        ManagementObjectSearcher searcher4 = new ManagementObjectSearcher("SELECT * FROM Win32_BaseBoard");

                        foreach (ManagementObject queryObj in searcher4.Get())
                        {
                            krtüretici.Text = "Anakart Üreticisi: " + queryObj["Manufacturer"];
                            krtsürüm.Text = "Anakart Sürümü: " + queryObj["Version"];
                        }
                    }


                }
            });

            thread.Start(); // İş parçacığını başlat
            Thread.Sleep(500);
        }

        private void writebtn_Click(object sender, EventArgs e)
        {
            string fileName = $"Device_İnfo_Logs_{DateTime.Now.ToString("yyyyMMdd_HHmmss")}.txt";

            // Etiketleri içeren bir dosya oluştur
            using (StreamWriter sw = File.CreateText(fileName))
            {
                // Formdaki her bir etiket nesnesini bul ve metinlerini dosyaya yazdır
                foreach (Control control in Controls)
                {
                    if (control is Label label)
                    {
                        sw.WriteLine(label.Text);
                    }
                }
            }

            // Dosyanın kaydedildiği konumu dosya gezginiyle aç
            Process.Start("explorer.exe", $"/select,\"{Path.GetFullPath(fileName)}\"");
            Application.Restart();
        }


    }
}
