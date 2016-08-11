using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;
using System.Management;
using System.Linq;
using DataLayer.DataHelpers;

namespace BusinessLayer.DataManager
{
    public class FullDataManager : DataManager
    {
        public readonly ulong GigaByte = (1024 * 1024 * 1024);
        public readonly int MegaByte = (1024 * 1024);

        public override ComputerSummary GetComputerSummary()
        {
            ComputerSummary comSum = new ComputerSummary {Name = Environment.MachineName};
            try
            {
                comSum.CpuUsage = Convert.ToInt32(ManagerGeneric.GetComponent("Win32_PerfFormattedData_PerfOS_Processor", "PercentProcessorTime").ToString());
            }
            catch
            {
                comSum.CpuUsage = -1;
            }
            comSum.User = Environment.UserName;
            comSum.Cpu = ManagerGeneric.GetComponent("Win32_OperatingSystem", "OSArchitecture").ToString();
            comSum.AvailableDiskSpaceGb = FreeSpace();
            comSum.AverageDiskQueueLength = QueLenght();
            comSum.Ram = GetRam();
            comSum.VideoCard = GetVideoCard();
            comSum.Ip = GetLocalIPAddress();
            //We get current ram use by substracting free physical memory from total memory
            comSum.RamUsage = comSum.Ram - GetFreePhysicalMem();
            return comSum;
        }

        public override int GetComputerCpuUsage()
        {
            return Convert.ToInt32(ManagerGeneric.GetComponent("Win32_PerfFormattedData_PerfOS_Processor", "PercentProcessorTime").ToString());
        }

        public override Task<List<string>> GetApplicationList()
        {
            return Task.Factory.StartNew(() =>
            {
                List<string> listBox1 = new List<string>();
                var products = new ManagementObjectSearcher(new ObjectQuery("SELECT * FROM Win32_Product"));
                var result = products.Get();

                foreach (var product in result)
                {
                    try
                    {
                        if (!string.IsNullOrEmpty(product.GetPropertyValue("Name").ToString()))
                            listBox1.Add(product.GetPropertyValue("Name").ToString());
                    }
                    catch (Exception e)
                    {
                        return listBox1;
                    }
                }
                return listBox1;
            });
        }

        public override List<string> GetHardwareList()
        {
            List<string> hardWare = new List<string>();
            hardWare.AddRange(GetComponentList("Win32_Processor", "Name"));
            hardWare.AddRange(GetComponentList("Win32_VideoController", "Name"));
            hardWare.AddRange(GetComponentList("Win32_BaseBoard", "Product"));
            return hardWare;
        }

        private List<string> GetComponentList(string hwclass, string syntax)
        {
            List<string> components = new List<string>();
            ManagementObjectSearcher mos = new ManagementObjectSearcher("select * from " + hwclass);
            foreach (ManagementObject mj in mos.Get().Cast<ManagementObject>())
            {
                components.Add(Convert.ToString(mj[syntax]));
            }
            return components;
        }

        public override int GetRam()
        {
            try
            {
                ManagementObjectSearcher searcher =
                    new ManagementObjectSearcher("root\\CIMV2",
                    "SELECT TotalPhysicalMemory FROM Win32_ComputerSystem");

                foreach (ManagementObject queryObj in searcher.Get())
                {
                    double dblMemory;
                    if (double.TryParse(Convert.ToString(queryObj["TotalPhysicalMemory"]), out dblMemory))
                    {
                        return Convert.ToInt32(dblMemory / MegaByte);
                    }
                }
            }
            catch (ManagementException e)
            {

            }
            return -1;
        }

        public override int FreeSpace()
        {
            ManagementObject disk = new ManagementObject("win32_logicaldisk.deviceid=\"c:\"");
            disk.Get();
            return Convert.ToInt32(Convert.ToString((UInt64)disk["FreeSpace"] / GigaByte));
        }

        private int QueLenght()
        {
            return Convert.ToInt32(ManagerGeneric.GetComponent("Win32_PerfFormattedData_PerfDisk_PhysicalDisk", "AvgDiskQueueLength"));
        }

        private string GetVideoCard()
        {
            ManagementObjectSearcher searcher
                = new ManagementObjectSearcher("SELECT * FROM Win32_DisplayConfiguration");

            string graphicsCard = string.Empty;
            foreach (ManagementObject mo in searcher.Get())
            {
                foreach (PropertyData property in mo.Properties)
                {
                    if (property.Name == "Description")
                    {
                        return property.Value.ToString();
                    }
                }
            }
            return "";
        }

        private IPAddress GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip;
                }
            }
            throw new Exception("Local IP Address Not Found!");
        }

        private int GetFreePhysicalMem()
        {
            return Convert.ToInt32(Convert.ToString(ManagerGeneric.GetComponent("Win32_OperatingSystem", "FreePhysicalMemory"))) / MegaByte;
        }

        public override int GetComputerAverageLenght()
        {
            return QueLenght();
        }
    }
}
