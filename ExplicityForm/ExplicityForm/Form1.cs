using System;
using System.Windows.Forms;
using BusinessLayer.ComputerDataService;
using BusinessLayer.DataManager;
using DataLayer.DatabaseData;
using DataLayer.DataHelpers;
using ExplicityForm.ChartHelpingClasses;

namespace ExplicityForm
{
    public partial class Form1 : Form
    {
        private readonly DataManager _data;
        private readonly IComputerDataService _computerDataService;
        private ComputerSummary _computerPar;
        private readonly string[] _seriesTypes = {"Cpu usage", "Average disk quequ lenght", "Used ram"};

        public Form1()
        {
            _computerDataService = new ComputerDataService();
            var chartFiller = new ChartFiller();
            _data = new FullDataManager();
            this.DoEveryXTime += chartFiller.OnDoEveryXTime;

            _computerPar = _data.GetComputerSummary();
            InitializeComponent();
            ClearAndAddSeries();
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
            _computerPar = _data.GetComputerSummary();
            SetValues();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void SetValues()
        {
            TName.Text = _computerPar.Name;
            TAvailableD.Text = _computerPar.AvailableDiskSpaceGb.ToString();
            TAverageDisk.Text = _computerPar.AverageDiskQueueLength.ToString();
            TCpu.Text = _computerPar.Cpu;
            TCpuUse.Text = _computerPar.CpuUsage.ToString();
            TIp.Text = _computerPar.Ip.ToString();
            TRam.Text = _computerPar.Ram.ToString();
            TRamUsage.Text = _computerPar.RamUsage.ToString();
            TVideo.Text = _computerPar.VideoCard;
            TUser.Text = _computerPar.User;
        }

        public delegate void DoEveryXTimeEventHandler(object source, ChartParams args);

        public event DoEveryXTimeEventHandler DoEveryXTime;

        protected virtual void OnDoEveryXTime()
        {
            DoEveryXTime?.Invoke(this, new ChartParams(C_CpuChar, C_Ram, _seriesTypes, _data, _computerPar.Name));
        }

        private void TCpuChart_Tick(object sender, EventArgs e)
        {
            OnDoEveryXTime();
        }

        private void BAddToDb_Click(object sender, EventArgs e)
        {           
            _computerDataService.AddComputer(new ComputerDetail(_computerPar));
        }
    }
}
