using System.Collections.Generic;
using DataLayer.DataHelpers;

namespace DataLayer.DatabaseData
{
    public class ComputerDetail
    {
        public int ComputerDetailId { get; set; }
        public string Name { get; set; }
        public string User { get; set; }
        public string Cpu { get; set; }
        public int Ram { get; set; }
        public string VideoCard { get; set; }
        public string Ip { get; set; }
        public List<UsageData> UsageDataCollection { get; set; }

        public ComputerDetail(ComputerSummary computerSummary)
        {
            Name = computerSummary.Name;
            User = computerSummary.User;
            Cpu = computerSummary.Cpu;
            Ram = computerSummary.Ram;
            VideoCard = computerSummary.VideoCard;
            Ip = computerSummary.Ip.ToString();
        }
    }
}
