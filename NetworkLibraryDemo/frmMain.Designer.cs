namespace NetworkLibraryDemo
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            groupBox1 = new GroupBox();
            numFallTime = new NumericUpDown();
            label7 = new Label();
            numRiseTime = new NumericUpDown();
            label6 = new Label();
            label5 = new Label();
            numFrequency = new NumericUpDown();
            numAmplitude = new NumericUpDown();
            label4 = new Label();
            cboWaveType = new ComboBox();
            label3 = new Label();
            txtSdgPort = new TextBox();
            label2 = new Label();
            txtSdgIp = new TextBox();
            label1 = new Label();
            btnSdgConnect = new Button();
            groupBox2 = new GroupBox();
            txtMsoPort = new TextBox();
            label8 = new Label();
            txtMsoIp = new TextBox();
            label9 = new Label();
            chrtScopeData = new System.Windows.Forms.DataVisualization.Charting.Chart();
            tmrUpdateChart = new System.Windows.Forms.Timer(components);
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numFallTime).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numRiseTime).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numFrequency).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numAmplitude).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chrtScopeData).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(numFallTime);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(numRiseTime);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(numFrequency);
            groupBox1.Controls.Add(numAmplitude);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(cboWaveType);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtSdgPort);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtSdgIp);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(187, 248);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "SDG Config";
            // 
            // numFallTime
            // 
            numFallTime.Location = new Point(100, 213);
            numFallTime.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numFallTime.Name = "numFallTime";
            numFallTime.Size = new Size(81, 23);
            numFallTime.TabIndex = 15;
            numFallTime.Value = new decimal(new int[] { 10, 0, 0, 0 });
            numFallTime.ValueChanged += fgenInput_Changed;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(100, 195);
            label7.Name = "label7";
            label7.Size = new Size(77, 15);
            label7.TabIndex = 14;
            label7.Text = "Fall Time (ns)";
            // 
            // numRiseTime
            // 
            numRiseTime.Location = new Point(6, 213);
            numRiseTime.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numRiseTime.Name = "numRiseTime";
            numRiseTime.Size = new Size(81, 23);
            numRiseTime.TabIndex = 13;
            numRiseTime.Value = new decimal(new int[] { 10, 0, 0, 0 });
            numRiseTime.ValueChanged += fgenInput_Changed;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 195);
            label6.Name = "label6";
            label6.Size = new Size(80, 15);
            label6.TabIndex = 11;
            label6.Text = "Rise Time (ns)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 151);
            label5.Name = "label5";
            label5.Size = new Size(87, 15);
            label5.TabIndex = 10;
            label5.Text = "Frequency (Hz)";
            // 
            // numFrequency
            // 
            numFrequency.Increment = new decimal(new int[] { 1000, 0, 0, 0 });
            numFrequency.Location = new Point(6, 169);
            numFrequency.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            numFrequency.Minimum = new decimal(new int[] { 100, 0, 0, 0 });
            numFrequency.Name = "numFrequency";
            numFrequency.Size = new Size(175, 23);
            numFrequency.TabIndex = 9;
            numFrequency.Value = new decimal(new int[] { 1000000, 0, 0, 0 });
            numFrequency.ValueChanged += fgenInput_Changed;
            // 
            // numAmplitude
            // 
            numAmplitude.DecimalPlaces = 2;
            numAmplitude.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            numAmplitude.Location = new Point(6, 125);
            numAmplitude.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            numAmplitude.Minimum = new decimal(new int[] { 1, 0, 0, 65536 });
            numAmplitude.Name = "numAmplitude";
            numAmplitude.Size = new Size(175, 23);
            numAmplitude.TabIndex = 8;
            numAmplitude.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numAmplitude.ValueChanged += fgenInput_Changed;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 107);
            label4.Name = "label4";
            label4.Size = new Size(81, 15);
            label4.TabIndex = 7;
            label4.Text = "Amplitude (V)";
            // 
            // cboWaveType
            // 
            cboWaveType.DropDownStyle = ComboBoxStyle.DropDownList;
            cboWaveType.FormattingEnabled = true;
            cboWaveType.Items.AddRange(new object[] { "SINE", "SQUARE", "RAMP" });
            cboWaveType.Location = new Point(6, 81);
            cboWaveType.Name = "cboWaveType";
            cboWaveType.Size = new Size(175, 23);
            cboWaveType.TabIndex = 6;
            cboWaveType.SelectedIndexChanged += fgenInput_Changed;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 63);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 5;
            label3.Text = "Wave Type";
            // 
            // txtSdgPort
            // 
            txtSdgPort.Location = new Point(112, 37);
            txtSdgPort.Name = "txtSdgPort";
            txtSdgPort.Size = new Size(69, 23);
            txtSdgPort.TabIndex = 3;
            txtSdgPort.Text = "5025";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(112, 19);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 2;
            label2.Text = "Port";
            // 
            // txtSdgIp
            // 
            txtSdgIp.Location = new Point(6, 37);
            txtSdgIp.Name = "txtSdgIp";
            txtSdgIp.Size = new Size(100, 23);
            txtSdgIp.TabIndex = 1;
            txtSdgIp.Text = "10.0.0.102";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 0;
            label1.Text = "IP Address";
            // 
            // btnSdgConnect
            // 
            btnSdgConnect.Location = new Point(12, 336);
            btnSdgConnect.Name = "btnSdgConnect";
            btnSdgConnect.Size = new Size(187, 41);
            btnSdgConnect.TabIndex = 4;
            btnSdgConnect.Text = "Connect";
            btnSdgConnect.UseVisualStyleBackColor = true;
            btnSdgConnect.Click += btnSdgConnect_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtMsoPort);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(txtMsoIp);
            groupBox2.Controls.Add(label9);
            groupBox2.Location = new Point(12, 266);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(187, 64);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "MSO Config";
            // 
            // txtMsoPort
            // 
            txtMsoPort.Location = new Point(112, 33);
            txtMsoPort.Name = "txtMsoPort";
            txtMsoPort.Size = new Size(69, 23);
            txtMsoPort.TabIndex = 8;
            txtMsoPort.Text = "5555";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(112, 15);
            label8.Name = "label8";
            label8.Size = new Size(29, 15);
            label8.TabIndex = 7;
            label8.Text = "Port";
            // 
            // txtMsoIp
            // 
            txtMsoIp.Location = new Point(6, 33);
            txtMsoIp.Name = "txtMsoIp";
            txtMsoIp.Size = new Size(100, 23);
            txtMsoIp.TabIndex = 6;
            txtMsoIp.Text = "10.0.0.74";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 15);
            label9.Name = "label9";
            label9.Size = new Size(62, 15);
            label9.TabIndex = 5;
            label9.Text = "IP Address";
            // 
            // chrtScopeData
            // 
            chrtScopeData.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            chartArea1.Name = "ChartArea1";
            chrtScopeData.ChartAreas.Add(chartArea1);
            chrtScopeData.Location = new Point(205, 12);
            chrtScopeData.Name = "chrtScopeData";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Name = "Channel 1";
            chrtScopeData.Series.Add(series1);
            chrtScopeData.Size = new Size(583, 426);
            chrtScopeData.TabIndex = 2;
            chrtScopeData.Text = "chart1";
            title1.Name = "Title1";
            title1.Text = "Oscilloscope Waveform";
            chrtScopeData.Titles.Add(title1);
            // 
            // tmrUpdateChart
            // 
            tmrUpdateChart.Enabled = true;
            tmrUpdateChart.Interval = 1000;
            tmrUpdateChart.Tick += tmrUpdateChart_Tick;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(chrtScopeData);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnSdgConnect);
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Scope Viewer";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numFallTime).EndInit();
            ((System.ComponentModel.ISupportInitialize)numRiseTime).EndInit();
            ((System.ComponentModel.ISupportInitialize)numFrequency).EndInit();
            ((System.ComponentModel.ISupportInitialize)numAmplitude).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chrtScopeData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private NumericUpDown numFallTime;
        private Label label7;
        private NumericUpDown numRiseTime;
        private Label label6;
        private Label label5;
        private NumericUpDown numFrequency;
        private NumericUpDown numAmplitude;
        private Label label4;
        private ComboBox cboWaveType;
        private Label label3;
        private Button btnSdgConnect;
        private TextBox txtSdgPort;
        private Label label2;
        private TextBox txtSdgIp;
        private Label label1;
        private GroupBox groupBox2;
        private TextBox txtMsoPort;
        private Label label8;
        private TextBox txtMsoIp;
        private Label label9;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrtScopeData;
        private System.Windows.Forms.Timer tmrUpdateChart;
    }
}