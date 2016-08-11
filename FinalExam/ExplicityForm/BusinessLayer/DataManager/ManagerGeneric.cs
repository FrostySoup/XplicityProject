using System.Linq;
using System.Management;

namespace BusinessLayer.DataManager
{
    public class ManagerGeneric
    {
        public static object GetComponent(string hwclass, string syntax)
        {
            ManagementObject obj = new ManagementObjectSearcher("select * from " + hwclass)
                .Get()
                .Cast<ManagementObject>()
                .First();
            return obj[syntax];
        }
    }
}
