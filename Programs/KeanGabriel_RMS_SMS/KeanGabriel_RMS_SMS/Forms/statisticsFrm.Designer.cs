namespace KeanGabriel_RMS_SMS.Forms
{
    partial class statisticsFrm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(statisticsFrm));
            this.statisticChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ControlTabChart = new System.Windows.Forms.TabControl();
            this.graphChartTabMF = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.pieTab = new System.Windows.Forms.TabPage();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.sideGraphChartTab = new System.Windows.Forms.TabPage();
            this.sideGraphChartAge = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbFilterCHARTS = new System.Windows.Forms.ComboBox();
            this.border = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.hidePb = new System.Windows.Forms.PictureBox();
            this.closePb = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            ((System.ComponentModel.ISupportInitialize)(this.statisticChart)).BeginInit();
            this.ControlTabChart.SuspendLayout();
            this.graphChartTabMF.SuspendLayout();
            this.pieTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.sideGraphChartTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sideGraphChartAge)).BeginInit();
            this.border.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hidePb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closePb)).BeginInit();
            this.SuspendLayout();
            // 
            // statisticChart
            // 
            this.statisticChart.BorderlineColor = System.Drawing.Color.Black;
            this.statisticChart.BorderSkin.BackColor = System.Drawing.Color.Black;
            chartArea1.Name = "ChartArea1";
            this.statisticChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.statisticChart.Legends.Add(legend1);
            this.statisticChart.Location = new System.Drawing.Point(4, 64);
            this.statisticChart.Name = "statisticChart";
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.MediumSeaGreen;
            series1.CustomProperties = "PointWidth=0.5";
            series1.Legend = "Legend1";
            series1.Name = "Male";
            series2.ChartArea = "ChartArea1";
            series2.Color = System.Drawing.Color.Gray;
            series2.CustomProperties = "PointWidth=0.5";
            series2.Legend = "Legend1";
            series2.Name = "Female";
            this.statisticChart.Series.Add(series1);
            this.statisticChart.Series.Add(series2);
            this.statisticChart.Size = new System.Drawing.Size(769, 303);
            this.statisticChart.TabIndex = 0;
            this.statisticChart.Text = "chart1";
            // 
            // ControlTabChart
            // 
            this.ControlTabChart.Controls.Add(this.graphChartTabMF);
            this.ControlTabChart.Controls.Add(this.pieTab);
            this.ControlTabChart.Controls.Add(this.sideGraphChartTab);
            this.ControlTabChart.ItemSize = new System.Drawing.Size(30, 10);
            this.ControlTabChart.Location = new System.Drawing.Point(12, 177);
            this.ControlTabChart.Name = "ControlTabChart";
            this.ControlTabChart.SelectedIndex = 0;
            this.ControlTabChart.Size = new System.Drawing.Size(785, 390);
            this.ControlTabChart.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.ControlTabChart.TabIndex = 2;
            // 
            // graphChartTabMF
            // 
            this.graphChartTabMF.BackColor = System.Drawing.Color.Gainsboro;
            this.graphChartTabMF.Controls.Add(this.label1);
            this.graphChartTabMF.Controls.Add(this.statisticChart);
            this.graphChartTabMF.Location = new System.Drawing.Point(4, 14);
            this.graphChartTabMF.Name = "graphChartTabMF";
            this.graphChartTabMF.Padding = new System.Windows.Forms.Padding(3);
            this.graphChartTabMF.Size = new System.Drawing.Size(777, 372);
            this.graphChartTabMF.TabIndex = 0;
            this.graphChartTabMF.Text = "Normal Graph";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(769, 58);
            this.label1.TabIndex = 1;
            this.label1.Text = "Most Reported Cases\r\n(Male VS. Female)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pieTab
            // 
            this.pieTab.BackColor = System.Drawing.Color.Gainsboro;
            this.pieTab.Controls.Add(this.chart1);
            this.pieTab.Location = new System.Drawing.Point(4, 14);
            this.pieTab.Name = "pieTab";
            this.pieTab.Padding = new System.Windows.Forms.Padding(3);
            this.pieTab.Size = new System.Drawing.Size(777, 372);
            this.pieTab.TabIndex = 1;
            this.pieTab.Text = "Pie Chart";
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(6, 6);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(765, 363);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // sideGraphChartTab
            // 
            this.sideGraphChartTab.BackColor = System.Drawing.Color.Gainsboro;
            this.sideGraphChartTab.Controls.Add(this.sideGraphChartAge);
            this.sideGraphChartTab.Controls.Add(this.label2);
            this.sideGraphChartTab.Location = new System.Drawing.Point(4, 14);
            this.sideGraphChartTab.Name = "sideGraphChartTab";
            this.sideGraphChartTab.Padding = new System.Windows.Forms.Padding(3);
            this.sideGraphChartTab.Size = new System.Drawing.Size(777, 372);
            this.sideGraphChartTab.TabIndex = 2;
            this.sideGraphChartTab.Text = "Side Graph Bar Chart";
            // 
            // sideGraphChartAge
            // 
            this.sideGraphChartAge.BorderlineColor = System.Drawing.Color.Black;
            this.sideGraphChartAge.BorderSkin.BackColor = System.Drawing.Color.Black;
            chartArea3.Name = "ChartArea1";
            this.sideGraphChartAge.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.sideGraphChartAge.Legends.Add(legend3);
            this.sideGraphChartAge.Location = new System.Drawing.Point(5, 61);
            this.sideGraphChartAge.Name = "sideGraphChartAge";
            series4.ChartArea = "ChartArea1";
            series4.Color = System.Drawing.Color.Peru;
            series4.CustomProperties = "PointWidth=0.6";
            series4.Legend = "Legend1";
            series4.Name = "19 Above";
            series5.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            series5.ChartArea = "ChartArea1";
            series5.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series5.CustomProperties = "PointWidth=0.6";
            series5.Legend = "Legend1";
            series5.MarkerColor = System.Drawing.Color.Transparent;
            series5.Name = "13-18";
            series6.ChartArea = "ChartArea1";
            series6.Color = System.Drawing.Color.MediumSeaGreen;
            series6.Legend = "Legend1";
            series6.Name = "6-12";
            series7.ChartArea = "ChartArea1";
            series7.Color = System.Drawing.Color.YellowGreen;
            series7.Legend = "Legend1";
            series7.Name = "0-5";
            this.sideGraphChartAge.Series.Add(series4);
            this.sideGraphChartAge.Series.Add(series5);
            this.sideGraphChartAge.Series.Add(series6);
            this.sideGraphChartAge.Series.Add(series7);
            this.sideGraphChartAge.Size = new System.Drawing.Size(769, 303);
            this.sideGraphChartAge.TabIndex = 4;
            this.sideGraphChartAge.Text = "chart1";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(769, 58);
            this.label2.TabIndex = 3;
            this.label2.Text = "Most Reported Cases\r\n(Per Age)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbFilterCHARTS
            // 
            this.cmbFilterCHARTS.BackColor = System.Drawing.Color.White;
            this.cmbFilterCHARTS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilterCHARTS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbFilterCHARTS.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFilterCHARTS.FormattingEnabled = true;
            this.cmbFilterCHARTS.Items.AddRange(new object[] {
            "Most Reported Cases (Male VS. Female)",
            "Most Reported Cases (Per Age)"});
            this.cmbFilterCHARTS.Location = new System.Drawing.Point(449, 140);
            this.cmbFilterCHARTS.Name = "cmbFilterCHARTS";
            this.cmbFilterCHARTS.Size = new System.Drawing.Size(348, 31);
            this.cmbFilterCHARTS.TabIndex = 3;
            this.cmbFilterCHARTS.SelectedIndexChanged += new System.EventHandler(this.cmbFilterCHARTS_SelectedIndexChanged);
            // 
            // border
            // 
            this.border.BackColor = System.Drawing.Color.White;
            this.border.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.border.Controls.Add(this.label5);
            this.border.Controls.Add(this.panel4);
            this.border.Controls.Add(this.hidePb);
            this.border.Controls.Add(this.closePb);
            this.border.Location = new System.Drawing.Point(1, 1);
            this.border.Name = "border";
            this.border.Size = new System.Drawing.Size(807, 38);
            this.border.TabIndex = 4;
            this.border.MouseDown += new System.Windows.Forms.MouseEventHandler(this.border_MouseDown);
            this.border.MouseMove += new System.Windows.Forms.MouseEventHandler(this.border_MouseMove);
            this.border.MouseUp += new System.Windows.Forms.MouseEventHandler(this.border_MouseUp);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(33, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 21);
            this.label5.TabIndex = 19;
            this.label5.Text = "- Statistics";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Purple;
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(28, 28);
            this.panel4.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(6, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 22);
            this.label4.TabIndex = 18;
            this.label4.Text = "S";
            // 
            // hidePb
            // 
            this.hidePb.Image = global::KeanGabriel_RMS_SMS.Properties.Resources.hideCirc;
            this.hidePb.Location = new System.Drawing.Point(755, 7);
            this.hidePb.Name = "hidePb";
            this.hidePb.Size = new System.Drawing.Size(20, 20);
            this.hidePb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hidePb.TabIndex = 1;
            this.hidePb.TabStop = false;
            this.hidePb.Click += new System.EventHandler(this.hidePb_Click);
            // 
            // closePb
            // 
            this.closePb.Image = global::KeanGabriel_RMS_SMS.Properties.Resources.closeCirc;
            this.closePb.Location = new System.Drawing.Point(781, 7);
            this.closePb.Name = "closePb";
            this.closePb.Size = new System.Drawing.Size(20, 20);
            this.closePb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closePb.TabIndex = 0;
            this.closePb.TabStop = false;
            this.closePb.Click += new System.EventHandler(this.closePb_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(348, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 31);
            this.button1.TabIndex = 5;
            this.button1.Text = "Print";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // statisticsFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 579);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.border);
            this.Controls.Add(this.cmbFilterCHARTS);
            this.Controls.Add(this.ControlTabChart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "statisticsFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "statisticsFrm";
            this.Load += new System.EventHandler(this.statisticsFrm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.statisticsFrm_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.statisticChart)).EndInit();
            this.ControlTabChart.ResumeLayout(false);
            this.graphChartTabMF.ResumeLayout(false);
            this.pieTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.sideGraphChartTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sideGraphChartAge)).EndInit();
            this.border.ResumeLayout(false);
            this.border.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hidePb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closePb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart statisticChart;
        private System.Windows.Forms.TabControl ControlTabChart;
        private System.Windows.Forms.TabPage graphChartTabMF;
        private System.Windows.Forms.TabPage pieTab;
        private System.Windows.Forms.TabPage sideGraphChartTab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbFilterCHARTS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart sideGraphChartAge;
        private System.Windows.Forms.Panel border;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox hidePb;
        private System.Windows.Forms.PictureBox closePb;
        private System.Windows.Forms.Button button1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}