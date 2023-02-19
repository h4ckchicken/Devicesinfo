using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Devicesinfo
{
    public partial class Manager : Form
    {
        public Manager()
        {
            InitializeComponent();
            this.AutoScroll = true;
            this.HorizontalScroll.Enabled = true;
            this.HorizontalScroll.Visible = true;
            this.VerticalScroll.Enabled = true;
            this.VerticalScroll.Visible = true;


            Thread thread = new Thread(() =>
            {
                while (true)
                {
                    // CPU bilgilerini al
                    PerformanceCounter cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
                    ManagementObjectSearcher searcher = new ManagementObjectSearcher("select * from Win32_Processor");
                    ManagementObjectCollection collection = searcher.Get();
                    foreach (ManagementObject obj in collection)
                    {
                        cpuname.Text = "CPU Adı: " + obj["Name"];
                    }
                    while (true)
                    {
                        float cpuUsage = cpuCounter.NextValue();
                        string formattedCpuUsage = string.Format("{0:N2}%", cpuUsage);
                        cpukullanım.Text = "CPU Kullanımı: " + formattedCpuUsage;

                        ManagementObjectSearcher ramMonitor = new ManagementObjectSearcher("SELECT Capacity FROM Win32_PhysicalMemory");
                        ulong totalRam = 0;
                        foreach (ManagementObject mo in ramMonitor.Get())
                        {
                            totalRam += Convert.ToUInt64(mo["Capacity"]);
                        }
                        blkkullanım.Text = "RAM Miktarı:  " + totalRam / (1024 * 1024 * 1024) + " GB";

                        searcher = new ManagementObjectSearcher("select * from Win32_PhysicalMemory");
                        collection = searcher.Get();
                        foreach (ManagementObject obj in collection)
                        {

                            blkspeed.Text = "Bellek Hızı: " + obj["Speed"] + " Mhz";
                        }

                        // Sistem performansı bilgilerini al
                        PerformanceCounter ramCounter = new PerformanceCounter("Memory", "Available MBytes");
                        blkboşta.Text = "Boşta Bellek: " + ramCounter.NextValue() + "MB";

                        long usedMemory = GC.GetTotalMemory(false);
                        rmmiktar.Text = "Ram Kullanımı: " + usedMemory + " MB";


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

                            // Tüm ağ arabirimlerini al
                            NetworkInterface[] interfaces = NetworkInterface.GetAllNetworkInterfaces();

                            foreach (NetworkInterface nic in interfaces)
                            {
                                // Sadece Ethernet arabirimlerine bak
                                if (nic.NetworkInterfaceType == NetworkInterfaceType.Ethernet)
                                {
                                    IPv4InterfaceStatistics stats = nic.GetIPv4Statistics();
                                    long bytesReceived2 = stats.BytesReceived;
                                    long bytesSent2 = stats.BytesSent;

                                    Intfc.Text = ($"Interface: {nic.Name}");
                                    recei.Text = ($"Received: {bytesReceived2} bytes");
                                    sent.Text = ($"Sent: {bytesSent2} bytes");
                                }
                            }

                            // Sonuçları kullanarak işlemler yapabilirsiniz
                            NetworkInterface wifiInterface2 = NetworkInterface.GetAllNetworkInterfaces()
                            .FirstOrDefault(ni => ni.NetworkInterfaceType == NetworkInterfaceType.Wireless80211 && ni.OperationalStatus == OperationalStatus.Up);

                            if (wifiInterface != null)
                            {
                                interface2.Text = "Kartı Adı: " + wifiInterface2.Name;
                            }
                            else
                            {
                                interface2.Text = "Kartı Adı: Wİ-Fİ kartı bulunamadı";
                            }
                            wifigonder.Text = "Gönderme hızı: " + sendSpeed + " bytes/saniye";
                            wifial.Text = "Alma hızı: " + receiveSpeed + " bytes/saniye";
                        }



                        ManagementObjectSearcher searcher2 = new ManagementObjectSearcher("select MaxClockSpeed from Win32_Processor");
                        foreach (ManagementObject mo in searcher2.Get())
                        {
                            float cpuSpeed = (float)(Convert.ToDouble(mo["MaxClockSpeed"]) / 1000); // MHz'yi GHz'ye dönüştür
                            string formattedCpuSpeed = string.Format("{0:N2} GHz", cpuSpeed);
                            cpuclock.Text = "CPU Hızı: " + formattedCpuSpeed;
                        }
                        Thread.Sleep(700);



                    }


                }
            });
            thread.Start();
        }
    }
}
