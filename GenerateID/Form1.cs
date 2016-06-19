/*
The MIT License(MIT)
Copyright(c) 2016 Romel Vera Cadena<http://www.github.com/romelsan>
Read Full notice in file LICENSE.txt
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management; //Need to manually add to the References
using System.Security.Cryptography;
using System.Net.NetworkInformation;

namespace GenerateID
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string getCPUID()
        {
            string cpuInfo = "";
            ManagementClass managClass = new ManagementClass("win32_processor");
            ManagementObjectCollection managCollec = managClass.GetInstances();

            foreach (ManagementObject managObj in managCollec)
            {
                if (cpuInfo == "")
                {
                    //Get only the first CPU's ID
                    cpuInfo = managObj.Properties["processorID"].Value.ToString();
                    break;
                }
            }

            return cpuInfo;
        }

        private string getVolumeSerial(string drive)
        {
            ManagementObject disk = new ManagementObject(@"win32_logicaldisk.deviceid=""" + drive + @":""");
            disk.Get();

            string volumeSerial = disk["VolumeSerialNumber"].ToString();
            disk.Dispose();

            return volumeSerial;
        }
        public string GetSHA1HashData(string data)
        {
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                var hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(data));
                var sb = new StringBuilder(hash.Length * 2);

                foreach (byte b in hash)
                {
                    // can be "x2" if you want lowercase
                    sb.Append(b.ToString("X2"));
                }
                return sb.ToString();
            }
        }
        #region Get Serial From MAC
        public string getMACSerial()
        {
            string macaddr = "";
            IPGlobalProperties computerProperties = IPGlobalProperties.GetIPGlobalProperties();
            NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
            if (nics == null || nics.Length < 1)
            {
                return "No network interfaces found.";
            }
            foreach (NetworkInterface adapter in nics)
            {
                //if (adapter.OperationalStatus == OperationalStatus.Up)
                IPInterfaceProperties properties = adapter.GetIPProperties(); //  .GetIPInterfaceProperties();
                if (adapter.NetworkInterfaceType == NetworkInterfaceType.Wireless80211 || adapter.NetworkInterfaceType == NetworkInterfaceType.Ethernet)
                {
                    PhysicalAddress address = adapter.GetPhysicalAddress();
                    byte[] bytes = address.GetAddressBytes();
                    for (int i = 0; i < bytes.Length; i++)
                    {
                        // Display the physical address in hexadecimal.
                        macaddr += bytes[i].ToString("X2");
                        // Insert a hyphen after each byte, unless we are at the end of the address.
                        if (i != bytes.Length - 1)
                        {
                            macaddr += "-";
                        }
                    }
                }
                break;
            }
            return macaddr;
        }
        #endregion
        public string cpu_Drive()
        {
            string volumeSerial = getVolumeSerial("C");
            string cpuID = getCPUID();
            //Mix them up and remove some useless 0's
            return cpuID.Substring(13) + cpuID.Substring(1, 4) + volumeSerial + cpuID.Substring(4, 4);
        }

        public string hash_cpuDrive()
        {
            string data0 = cpu_Drive();
            return GetSHA1HashData(data0);
        }
        private void button1_CPU_Click(object sender, EventArgs e)
        {
            textBox1_CPU.Text = getCPUID();
        }

        private void button2_DriveSerial_Click(object sender, EventArgs e)
        {
            textBox2_Drive.Text = getVolumeSerial("C");
        }

        private void button3_MAC_Click(object sender, EventArgs e)
        {
            textBox3_MAC.Text = getMACSerial();
        }

        private void button4_Combined1_Click(object sender, EventArgs e)
        {
            textBox4_Combined1.Text = cpu_Drive();
        }

        private void button5_hashCombined1_Click(object sender, EventArgs e)
        {
            textBox5_hashComb1.Text = hash_cpuDrive();
        }
    }
}
