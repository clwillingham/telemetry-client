namespace TelemetryClient
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.connectBtn = new System.Windows.Forms.Button();
            this.commboBox = new System.Windows.Forms.ComboBox();
            this.errorTextBox = new System.Windows.Forms.TextBox();
            this.outTextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.consoleSplitContainer = new System.Windows.Forms.SplitContainer();
            this.dataSplitContainer = new System.Windows.Forms.SplitContainer();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.map = new GMap.NET.WindowsForms.GMapControl();
            this.outputBox = new System.Windows.Forms.TextBox();
            this.receiverPort = new System.IO.Ports.SerialPort(this.components);
            this.idLabel = new System.Windows.Forms.Label();
            this.altitudeLabel = new System.Windows.Forms.Label();
            this.accelerationLabel = new System.Windows.Forms.Label();
            this.apogeeLabel = new System.Windows.Forms.Label();
            this.latLabel = new System.Windows.Forms.Label();
            this.lngLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.followOption = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.consoleSplitContainer)).BeginInit();
            this.consoleSplitContainer.Panel1.SuspendLayout();
            this.consoleSplitContainer.Panel2.SuspendLayout();
            this.consoleSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSplitContainer)).BeginInit();
            this.dataSplitContainer.Panel1.SuspendLayout();
            this.dataSplitContainer.Panel2.SuspendLayout();
            this.dataSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // connectBtn
            // 
            this.connectBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.connectBtn.Location = new System.Drawing.Point(957, 12);
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.Size = new System.Drawing.Size(131, 21);
            this.connectBtn.TabIndex = 0;
            this.connectBtn.Text = "Connect";
            this.connectBtn.UseVisualStyleBackColor = true;
            this.connectBtn.Click += new System.EventHandler(this.connectBtn_Click);
            // 
            // commboBox
            // 
            this.commboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.commboBox.FormattingEnabled = true;
            this.commboBox.Location = new System.Drawing.Point(353, 12);
            this.commboBox.Name = "commboBox";
            this.commboBox.Size = new System.Drawing.Size(598, 21);
            this.commboBox.TabIndex = 1;
            // 
            // errorTextBox
            // 
            this.errorTextBox.ForeColor = System.Drawing.Color.Maroon;
            this.errorTextBox.Location = new System.Drawing.Point(223, 12);
            this.errorTextBox.Name = "errorTextBox";
            this.errorTextBox.Size = new System.Drawing.Size(124, 20);
            this.errorTextBox.TabIndex = 2;
            this.errorTextBox.Text = "error.txt";
            // 
            // outTextBox
            // 
            this.outTextBox.Location = new System.Drawing.Point(93, 12);
            this.outTextBox.Name = "outTextBox";
            this.outTextBox.Size = new System.Drawing.Size(124, 20);
            this.outTextBox.TabIndex = 3;
            this.outTextBox.Text = "out.txt";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 20);
            this.button2.TabIndex = 4;
            this.button2.Text = "Refresh";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // consoleSplitContainer
            // 
            this.consoleSplitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.consoleSplitContainer.Location = new System.Drawing.Point(12, 59);
            this.consoleSplitContainer.Name = "consoleSplitContainer";
            this.consoleSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // consoleSplitContainer.Panel1
            // 
            this.consoleSplitContainer.Panel1.Controls.Add(this.dataSplitContainer);
            // 
            // consoleSplitContainer.Panel2
            // 
            this.consoleSplitContainer.Panel2.Controls.Add(this.outputBox);
            this.consoleSplitContainer.Size = new System.Drawing.Size(1076, 521);
            this.consoleSplitContainer.SplitterDistance = 347;
            this.consoleSplitContainer.TabIndex = 5;
            // 
            // dataSplitContainer
            // 
            this.dataSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.dataSplitContainer.Name = "dataSplitContainer";
            // 
            // dataSplitContainer.Panel1
            // 
            this.dataSplitContainer.Panel1.Controls.Add(this.chart);
            // 
            // dataSplitContainer.Panel2
            // 
            this.dataSplitContainer.Panel2.Controls.Add(this.map);
            this.dataSplitContainer.Size = new System.Drawing.Size(1076, 347);
            this.dataSplitContainer.SplitterDistance = 716;
            this.dataSplitContainer.TabIndex = 0;
            // 
            // chart
            // 
            this.chart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea5.Name = "AltitudeChartArea";
            chartArea6.Name = "AccelerationChart";
            this.chart.ChartAreas.Add(chartArea5);
            this.chart.ChartAreas.Add(chartArea6);
            legend3.Name = "Legend1";
            this.chart.Legends.Add(legend3);
            this.chart.Location = new System.Drawing.Point(3, 3);
            this.chart.Name = "chart";
            series7.BorderWidth = 3;
            series7.ChartArea = "AltitudeChartArea";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series7.Legend = "Legend1";
            series7.Name = "Altitude";
            series7.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time;
            series8.BorderWidth = 3;
            series8.ChartArea = "AltitudeChartArea";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series8.Legend = "Legend1";
            series8.Name = "RSSI";
            series8.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time;
            series8.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series9.BorderWidth = 3;
            series9.ChartArea = "AccelerationChart";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series9.Legend = "Legend1";
            series9.Name = "Acceleration";
            series9.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time;
            this.chart.Series.Add(series7);
            this.chart.Series.Add(series8);
            this.chart.Series.Add(series9);
            this.chart.Size = new System.Drawing.Size(710, 344);
            this.chart.TabIndex = 0;
            this.chart.Text = "chart1";
            // 
            // map
            // 
            this.map.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.map.Bearing = 0F;
            this.map.CanDragMap = true;
            this.map.EmptyTileColor = System.Drawing.Color.Navy;
            this.map.GrayScaleMode = false;
            this.map.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.map.LevelsKeepInMemmory = 5;
            this.map.Location = new System.Drawing.Point(3, 3);
            this.map.MarkersEnabled = true;
            this.map.MaxZoom = 18;
            this.map.MinZoom = -5;
            this.map.MouseWheelZoomEnabled = true;
            this.map.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.map.Name = "map";
            this.map.NegativeMode = false;
            this.map.PolygonsEnabled = true;
            this.map.RetryLoadTile = 0;
            this.map.RoutesEnabled = true;
            this.map.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.map.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.map.ShowTileGridLines = false;
            this.map.Size = new System.Drawing.Size(350, 341);
            this.map.TabIndex = 0;
            this.map.Zoom = 2D;
            // 
            // outputBox
            // 
            this.outputBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputBox.Location = new System.Drawing.Point(3, 3);
            this.outputBox.Multiline = true;
            this.outputBox.Name = "outputBox";
            this.outputBox.ReadOnly = true;
            this.outputBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outputBox.Size = new System.Drawing.Size(1070, 167);
            this.outputBox.TabIndex = 0;
            // 
            // receiverPort
            // 
            this.receiverPort.BaudRate = 11520;
            this.receiverPort.PortName = "COM4";
            this.receiverPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.receiverPort_DataReceived);
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLabel.Location = new System.Drawing.Point(12, 36);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(33, 20);
            this.idLabel.TabIndex = 6;
            this.idLabel.Text = "ID:";
            // 
            // altitudeLabel
            // 
            this.altitudeLabel.AutoSize = true;
            this.altitudeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.altitudeLabel.Location = new System.Drawing.Point(184, 35);
            this.altitudeLabel.Name = "altitudeLabel";
            this.altitudeLabel.Size = new System.Drawing.Size(76, 20);
            this.altitudeLabel.TabIndex = 7;
            this.altitudeLabel.Text = "Altitude:";
            // 
            // accelerationLabel
            // 
            this.accelerationLabel.AutoSize = true;
            this.accelerationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accelerationLabel.Location = new System.Drawing.Point(321, 35);
            this.accelerationLabel.Name = "accelerationLabel";
            this.accelerationLabel.Size = new System.Drawing.Size(114, 20);
            this.accelerationLabel.TabIndex = 8;
            this.accelerationLabel.Text = "Acceleration:";
            // 
            // apogeeLabel
            // 
            this.apogeeLabel.AutoSize = true;
            this.apogeeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apogeeLabel.Location = new System.Drawing.Point(501, 35);
            this.apogeeLabel.Name = "apogeeLabel";
            this.apogeeLabel.Size = new System.Drawing.Size(76, 20);
            this.apogeeLabel.TabIndex = 9;
            this.apogeeLabel.Text = "Apogee:";
            // 
            // latLabel
            // 
            this.latLabel.AutoSize = true;
            this.latLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.latLabel.Location = new System.Drawing.Point(669, 35);
            this.latLabel.Name = "latLabel";
            this.latLabel.Size = new System.Drawing.Size(80, 20);
            this.latLabel.TabIndex = 10;
            this.latLabel.Text = "Latitude:";
            // 
            // lngLabel
            // 
            this.lngLabel.AutoSize = true;
            this.lngLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lngLabel.Location = new System.Drawing.Point(867, 36);
            this.lngLabel.Name = "lngLabel";
            this.lngLabel.Size = new System.Drawing.Size(94, 20);
            this.lngLabel.TabIndex = 11;
            this.lngLabel.Text = "Longitude:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "RSSI:";
            // 
            // followOption
            // 
            this.followOption.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.followOption.AutoSize = true;
            this.followOption.BackColor = System.Drawing.Color.Transparent;
            this.followOption.Location = new System.Drawing.Point(1004, 36);
            this.followOption.Name = "followOption";
            this.followOption.Size = new System.Drawing.Size(81, 17);
            this.followOption.TabIndex = 1;
            this.followOption.Text = "Auto Follow";
            this.followOption.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 592);
            this.Controls.Add(this.followOption);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lngLabel);
            this.Controls.Add(this.latLabel);
            this.Controls.Add(this.apogeeLabel);
            this.Controls.Add(this.accelerationLabel);
            this.Controls.Add(this.altitudeLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.consoleSplitContainer);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.outTextBox);
            this.Controls.Add(this.errorTextBox);
            this.Controls.Add(this.commboBox);
            this.Controls.Add(this.connectBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.consoleSplitContainer.Panel1.ResumeLayout(false);
            this.consoleSplitContainer.Panel2.ResumeLayout(false);
            this.consoleSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.consoleSplitContainer)).EndInit();
            this.consoleSplitContainer.ResumeLayout(false);
            this.dataSplitContainer.Panel1.ResumeLayout(false);
            this.dataSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataSplitContainer)).EndInit();
            this.dataSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button connectBtn;
        private System.Windows.Forms.ComboBox commboBox;
        private System.Windows.Forms.TextBox errorTextBox;
        private System.Windows.Forms.TextBox outTextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.SplitContainer consoleSplitContainer;
        private System.Windows.Forms.SplitContainer dataSplitContainer;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private GMap.NET.WindowsForms.GMapControl map;
        private System.Windows.Forms.TextBox outputBox;
        private System.IO.Ports.SerialPort receiverPort;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label altitudeLabel;
        private System.Windows.Forms.Label accelerationLabel;
        private System.Windows.Forms.Label apogeeLabel;
        private System.Windows.Forms.Label latLabel;
        private System.Windows.Forms.Label lngLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox followOption;
    }
}

