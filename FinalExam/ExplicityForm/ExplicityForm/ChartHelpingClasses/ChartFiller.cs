using BusinessLayer.DataManager;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
using DataLayer.DatabaseData;

namespace ExplicityForm.ChartHelpingClasses
{
    public class ChartFiller
    {
        private int _timer = 0;
        private const int MaxPoints = 10;

        private void SetCharValues(Chart cCpu, int value, int time, string type)
        {
            cCpu.Series[type].Points.AddXY(time, value);
        }

        //seriesTypes = {"Cpu usage", "Average disk quequ lenght", "Used ram"};
        public void FillCharts(Chart cCpuChar, Chart cRam, string[] seriesTypes, DataManager data, string userName)
        {
            UsageData useData = new UsageData(data.GetComputerCpuUsage(), data.GetRam(), 50, data.GetComputerAverageLenght());
            SetCharValues(cCpuChar, useData.CpuUsage, _timer, seriesTypes[0]);
            SetCharValues(cCpuChar, useData.AverageDiskQueueLength, _timer, seriesTypes[1]);
            SetCharValues(cRam, useData.RamUsage, _timer, seriesTypes[2]);

            if (cCpuChar.Series[seriesTypes[0]].Points.Count > MaxPoints)
            {
                cRam.Series[seriesTypes[2]].Points.RemoveAt(0);
                cCpuChar.Series[seriesTypes[1]].Points.RemoveAt(0); ;
                cCpuChar.Series[seriesTypes[0]].Points.RemoveAt(0);
                cCpuChar.ResetAutoValues();
                cRam.ResetAutoValues();
            }           
            _timer += 5;
        }

        public void OnDoEveryXTime(object source, ChartParams charparams)
        {
            FillCharts(charparams.CCpuChar, charparams.CRam, charparams.SeriesTyper, charparams.Data, charparams.UserName);
        }

    }

    public class ChartParams : EventArgs
    {
        public Chart CCpuChar { get; set; }
        public Chart CRam { get; set; }
        public string[] SeriesTyper { get; set; }
        public DataManager Data { get; set; }
        public string UserName { get; set; }

        public ChartParams(Chart cCpuChar, Chart cRam, string[] seriesTyper, DataManager data, string username)
        {
            CCpuChar = cCpuChar;
            CRam = cRam;
            SeriesTyper = seriesTyper;
            Data = data;
            UserName = username;
        }
    }
}
