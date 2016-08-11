using System;
using System.Linq;
using System.Windows.Forms;
using BusinessLayer.DataManager;
using DataLayer.DatabaseData;
using DataLayer.DataHelpers;
using ExplicityForm.ChartHelpingClasses;

namespace ExplicityForm
{
    public partial class Form1 : Form
    {
        private readonly DataManager _data;
        private ComputerSummary _computerPar;
        private const int timer = 5000;
        private readonly string[] _seriesTypes = {"Cpu usage", "Average disk quequ lenght", "Used ram"};

        public Form1()
        {
            
            var chartFiller = new ChartFiller();
            _data = new FullDataManager();
            this.DoEveryXTime += chartFiller.OnDoEveryXTime;

            _computerPar = _data.GetComputerSummary();
            InitializeComponent();
            ClearAndAddSeries();
            TCpuChart.Interval = timer;
        }

        private void ClearAndAddSeries()
        {
            C_CpuChar.Series.Clear();
            C_Ram.Series.Clear();
            C_CpuChar.Series.Add(_seriesTypes[0]);
            C_CpuChar.Series.Add(_seriesTypes[1]);
            C_Ram.Series.Add(_seriesTypes[2]);
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // _computerPar = _data.GetComputerSummary();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public delegate void DoEveryXTimeEventHandler(object source, ChartParams args);

        public event DoEveryXTimeEventHandler DoEveryXTime;

        protected virtual void OnDoEveryXTime()
        {
            DoEveryXTime?.Invoke(this, new ChartParams(C_CpuChar, C_Ram, _seriesTypes, _data, _computerPar.Name));
        }

        private void TCpuChart_Tick(object sender, EventArgs e)
        {
            PeriodicalDataSendSingleton._instance.SendData();
            OnDoEveryXTime();
        }

        private void BAddToDb_Click(object sender, EventArgs e)
        {           
        }
    }
}
