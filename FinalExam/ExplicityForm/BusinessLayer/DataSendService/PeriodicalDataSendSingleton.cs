using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using BusinessLayer.DataManager;
using DataLayer.DataHelpers;
using Newtonsoft.Json;

namespace ExplicityForm
{
    public class PeriodicalDataSendSingleton
    {
        public static PeriodicalDataSendSingleton _instance = new PeriodicalDataSendSingleton();

        private PeriodicalDataSendSingleton() { }

        private readonly int _virtualMachineId = 3;

        public static PeriodicalDataSendSingleton Instance
        {
            get
            {
                return _instance;
            }
        }

        private NewUsageData GetData()
        {
            FullDataManager dataManager = new FullDataManager();
            NewUsageData newUsageData = new NewUsageData();
            newUsageData.MemoryUsage = dataManager.FreeSpace();
            newUsageData.ProcessorUsage = dataManager.GetComputerCpuUsage();
            newUsageData.TimeStamp = DateTime.Now;
            return newUsageData;
        }

        public bool SendData()
        {
            NewUsageData newUsageData = GetData();

            using (var client = new HttpClient())
            {
                // New code:
                client.BaseAddress = new Uri("http://192.168.10.106/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var newUsageReport = newUsageData;

                var json = JsonConvert.SerializeObject(newUsageReport);

                var content = new StringContent(json);

                content.Headers.ContentType = new MediaTypeWithQualityHeaderValue("application/json");

                var response = client.PostAsync($"api/virtualmachines/{_virtualMachineId}/usagereports", content);

                var result = response.Result;
            }
            return true;
        }
    }
}
