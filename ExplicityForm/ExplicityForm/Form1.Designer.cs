namespace ExplicityForm
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.BWriteParams = new System.Windows.Forms.Button();
            this.TName = new System.Windows.Forms.TextBox();
            this.TUser = new System.Windows.Forms.TextBox();
            this.TCpu = new System.Windows.Forms.TextBox();
            this.TRam = new System.Windows.Forms.TextBox();
            this.TVideo = new System.Windows.Forms.TextBox();
            this.TIp = new System.Windows.Forms.TextBox();
            this.TCpuUse = new System.Windows.Forms.TextBox();
            this.LName = new System.Windows.Forms.Label();
            this.LUser = new System.Windows.Forms.Label();
            this.LCpu = new System.Windows.Forms.Label();
            this.LRam = new System.Windows.Forms.Label();
            this.LVideoCard = new System.Windows.Forms.Label();
            this.LIp = new System.Windows.Forms.Label();
            this.LCpuUsage = new System.Windows.Forms.Label();
            this.TRamUsage = new System.Windows.Forms.TextBox();
            this.TAvailableD = new System.Windows.Forms.TextBox();
            this.TAverageDisk = new System.Windows.Forms.TextBox();
            this.LRamUsage = new System.Windows.Forms.Label();
            this.LDiskSpace = new System.Windows.Forms.Label();
            this.LAverageDisk = new System.Windows.Forms.Label();
            this.C_CpuChar = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.TCpuChart = new System.Windows.Forms.Timer(this.components);
            this.C_Ram = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.BAddToDb = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.C_CpuChar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.C_Ram)).BeginInit();
            this.SuspendLayout();
            // 
            // BWriteParams
            // 
            this.BWriteParams.BackColor = System.Drawing.SystemColors.Info;
            this.BWriteParams.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BWriteParams.Location = new System.Drawing.Point(149, 339);
            this.BWriteParams.Name = "BWriteParams";
            this.BWriteParams.Size = new System.Drawing.Size(139, 35);
            this.BWriteParams.TabIndex = 0;
            this.BWriteParams.Text = "Get computer parametres";
            this.BWriteParams.UseVisualStyleBackColor = false;
            this.BWriteParams.Click += new System.EventHandler(this.button1_Click);
            // 
            // TName
            // 
            this.TName.Location = new System.Drawing.Point(149, 57);
            this.TName.Name = "TName";
            this.TName.Size = new System.Drawing.Size(174, 20);
            this.TName.TabIndex = 1;
            // 
            // TUser
            // 
            this.TUser.Location = new System.Drawing.Point(149, 83);
            this.TUser.Name = "TUser";
            this.TUser.Size = new System.Drawing.Size(174, 20);
            this.TUser.TabIndex = 2;
            // 
            // TCpu
            // 
            this.TCpu.Location = new System.Drawing.Point(149, 109);
            this.TCpu.Name = "TCpu";
            this.TCpu.Size = new System.Drawing.Size(174, 20);
            this.TCpu.TabIndex = 3;
            // 
            // TRam
            // 
            this.TRam.Location = new System.Drawing.Point(149, 135);
            this.TRam.Name = "TRam";
            this.TRam.Size = new System.Drawing.Size(174, 20);
            this.TRam.TabIndex = 4;
            // 
            // TVideo
            // 
            this.TVideo.Location = new System.Drawing.Point(149, 161);
            this.TVideo.Name = "TVideo";
            this.TVideo.Size = new System.Drawing.Size(174, 20);
            this.TVideo.TabIndex = 5;
            // 
            // TIp
            // 
            this.TIp.Location = new System.Drawing.Point(149, 187);
            this.TIp.Name = "TIp";
            this.TIp.Size = new System.Drawing.Size(174, 20);
            this.TIp.TabIndex = 6;
            // 
            // TCpuUse
            // 
            this.TCpuUse.Location = new System.Drawing.Point(149, 213);
            this.TCpuUse.Name = "TCpuUse";
            this.TCpuUse.Size = new System.Drawing.Size(174, 20);
            this.TCpuUse.TabIndex = 7;
            // 
            // LName
            // 
            this.LName.AutoSize = true;
            this.LName.Location = new System.Drawing.Point(108, 60);
            this.LName.Name = "LName";
            this.LName.Size = new System.Drawing.Size(35, 13);
            this.LName.TabIndex = 8;
            this.LName.Text = "Name";
            // 
            // LUser
            // 
            this.LUser.AutoSize = true;
            this.LUser.Location = new System.Drawing.Point(114, 90);
            this.LUser.Name = "LUser";
            this.LUser.Size = new System.Drawing.Size(29, 13);
            this.LUser.TabIndex = 9;
            this.LUser.Text = "User";
            // 
            // LCpu
            // 
            this.LCpu.AutoSize = true;
            this.LCpu.Location = new System.Drawing.Point(114, 112);
            this.LCpu.Name = "LCpu";
            this.LCpu.Size = new System.Drawing.Size(26, 13);
            this.LCpu.TabIndex = 10;
            this.LCpu.Text = "Cpu";
            // 
            // LRam
            // 
            this.LRam.AutoSize = true;
            this.LRam.Location = new System.Drawing.Point(114, 138);
            this.LRam.Name = "LRam";
            this.LRam.Size = new System.Drawing.Size(29, 13);
            this.LRam.TabIndex = 11;
            this.LRam.Text = "Ram";
            // 
            // LVideoCard
            // 
            this.LVideoCard.AutoSize = true;
            this.LVideoCard.Location = new System.Drawing.Point(85, 164);
            this.LVideoCard.Name = "LVideoCard";
            this.LVideoCard.Size = new System.Drawing.Size(58, 13);
            this.LVideoCard.TabIndex = 12;
            this.LVideoCard.Text = "Video card";
            // 
            // LIp
            // 
            this.LIp.AutoSize = true;
            this.LIp.Location = new System.Drawing.Point(124, 190);
            this.LIp.Name = "LIp";
            this.LIp.Size = new System.Drawing.Size(16, 13);
            this.LIp.TabIndex = 13;
            this.LIp.Text = "Ip";
            // 
            // LCpuUsage
            // 
            this.LCpuUsage.AutoSize = true;
            this.LCpuUsage.Location = new System.Drawing.Point(85, 216);
            this.LCpuUsage.Name = "LCpuUsage";
            this.LCpuUsage.Size = new System.Drawing.Size(58, 13);
            this.LCpuUsage.TabIndex = 14;
            this.LCpuUsage.Text = "Cpu usage";
            // 
            // TRamUsage
            // 
            this.TRamUsage.Location = new System.Drawing.Point(149, 239);
            this.TRamUsage.Name = "TRamUsage";
            this.TRamUsage.Size = new System.Drawing.Size(174, 20);
            this.TRamUsage.TabIndex = 15;
            // 
            // TAvailableD
            // 
            this.TAvailableD.Location = new System.Drawing.Point(149, 265);
            this.TAvailableD.Name = "TAvailableD";
            this.TAvailableD.Size = new System.Drawing.Size(174, 20);
            this.TAvailableD.TabIndex = 16;
            // 
            // TAverageDisk
            // 
            this.TAverageDisk.Location = new System.Drawing.Point(149, 291);
            this.TAverageDisk.Name = "TAverageDisk";
            this.TAverageDisk.Size = new System.Drawing.Size(174, 20);
            this.TAverageDisk.TabIndex = 17;
            // 
            // LRamUsage
            // 
            this.LRamUsage.AutoSize = true;
            this.LRamUsage.Location = new System.Drawing.Point(85, 242);
            this.LRamUsage.Name = "LRamUsage";
            this.LRamUsage.Size = new System.Drawing.Size(61, 13);
            this.LRamUsage.TabIndex = 18;
            this.LRamUsage.Text = "Ram usage";
            // 
            // LDiskSpace
            // 
            this.LDiskSpace.AutoSize = true;
            this.LDiskSpace.Location = new System.Drawing.Point(33, 268);
            this.LDiskSpace.Name = "LDiskSpace";
            this.LDiskSpace.Size = new System.Drawing.Size(107, 13);
            this.LDiskSpace.TabIndex = 19;
            this.LDiskSpace.Text = "Available disk  space";
            // 
            // LAverageDisk
            // 
            this.LAverageDisk.AutoSize = true;
            this.LAverageDisk.Location = new System.Drawing.Point(12, 294);
            this.LAverageDisk.Name = "LAverageDisk";
            this.LAverageDisk.Size = new System.Drawing.Size(134, 13);
            this.LAverageDisk.TabIndex = 20;
            this.LAverageDisk.Text = "Average disk quequ lenght";
            // 
            // C_CpuChar
            // 
            chartArea1.Name = "ChartArea1";
            this.C_CpuChar.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.C_CpuChar.Legends.Add(legend1);
            this.C_CpuChar.Location = new System.Drawing.Point(374, 10);
            this.C_CpuChar.Name = "C_CpuChar";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.C_CpuChar.Series.Add(series1);
            this.C_CpuChar.Size = new System.Drawing.Size(478, 444);
            this.C_CpuChar.TabIndex = 21;
            this.C_CpuChar.Text = "Information about Cpu";
            // 
            // TCpuChart
            // 
            this.TCpuChart.Enabled = true;
            this.TCpuChart.Interval = 5000;
            this.TCpuChart.Tick += new System.EventHandler(this.TCpuChart_Tick);
            // 
            // C_Ram
            // 
            chartArea2.Name = "ChartArea1";
            this.C_Ram.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.C_Ram.Legends.Add(legend2);
            this.C_Ram.Location = new System.Drawing.Point(871, 10);
            this.C_Ram.Name = "C_Ram";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.C_Ram.Series.Add(series2);
            this.C_Ram.Size = new System.Drawing.Size(465, 444);
            this.C_Ram.TabIndex = 22;
            this.C_Ram.Text = "chart1";
            // 
            // BAddToDb
            // 
            this.BAddToDb.BackColor = System.Drawing.SystemColors.Info;
            this.BAddToDb.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BAddToDb.Location = new System.Drawing.Point(149, 380);
            this.BAddToDb.Name = "BAddToDb";
            this.BAddToDb.Size = new System.Drawing.Size(139, 35);
            this.BAddToDb.TabIndex = 23;
            this.BAddToDb.Text = "Add computer to database";
            this.BAddToDb.UseVisualStyleBackColor = false;
            this.BAddToDb.Click += new System.EventHandler(this.BAddToDb_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1400, 491);
            this.Controls.Add(this.BAddToDb);
            this.Controls.Add(this.C_Ram);
            this.Controls.Add(this.C_CpuChar);
            this.Controls.Add(this.LAverageDisk);
            this.Controls.Add(this.LDiskSpace);
            this.Controls.Add(this.LRamUsage);
            this.Controls.Add(this.TAverageDisk);
            this.Controls.Add(this.TAvailableD);
            this.Controls.Add(this.TRamUsage);
            this.Controls.Add(this.LCpuUsage);
            this.Controls.Add(this.LIp);
            this.Controls.Add(this.LVideoCard);
            this.Controls.Add(this.LRam);
            this.Controls.Add(this.LCpu);
            this.Controls.Add(this.LUser);
            this.Controls.Add(this.LName);
            this.Controls.Add(this.TCpuUse);
            this.Controls.Add(this.TIp);
            this.Controls.Add(this.TVideo);
            this.Controls.Add(this.TRam);
            this.Controls.Add(this.TCpu);
            this.Controls.Add(this.TUser);
            this.Controls.Add(this.TName);
            this.Controls.Add(this.BWriteParams);
            this.Name = "Form1";
            this.Text = "Window";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.C_CpuChar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.C_Ram)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BWriteParams;
        private System.Windows.Forms.TextBox TName;
        private System.Windows.Forms.TextBox TUser;
        private System.Windows.Forms.TextBox TCpu;
        private System.Windows.Forms.TextBox TRam;
        private System.Windows.Forms.TextBox TVideo;
        private System.Windows.Forms.TextBox TIp;
        private System.Windows.Forms.TextBox TCpuUse;
        private System.Windows.Forms.Label LName;
        private System.Windows.Forms.Label LUser;
        private System.Windows.Forms.Label LCpu;
        private System.Windows.Forms.Label LRam;
        private System.Windows.Forms.Label LVideoCard;
        private System.Windows.Forms.Label LIp;
        private System.Windows.Forms.Label LCpuUsage;
        private System.Windows.Forms.TextBox TRamUsage;
        private System.Windows.Forms.TextBox TAvailableD;
        private System.Windows.Forms.TextBox TAverageDisk;
        private System.Windows.Forms.Label LRamUsage;
        private System.Windows.Forms.Label LDiskSpace;
        private System.Windows.Forms.Label LAverageDisk;
        private System.Windows.Forms.DataVisualization.Charting.Chart C_CpuChar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Timer TCpuChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart C_Ram;
        private System.Windows.Forms.Button BAddToDb;
    }
}

