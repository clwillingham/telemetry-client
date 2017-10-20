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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.rssiLabel = new System.Windows.Forms.Label();
            this.followOption = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
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
            this.dataSplitContainer.Panel1.Controls.Add(this.button1);
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
            chartArea3.Name = "AltitudeChartArea";
            chartArea4.Name = "AccelerationChart";
            this.chart.ChartAreas.Add(chartArea3);
            this.chart.ChartAreas.Add(chartArea4);
            legend2.Name = "Legend1";
            this.chart.Legends.Add(legend2);
            this.chart.Location = new System.Drawing.Point(3, 3);
            this.chart.Name = "chart";
            series4.BorderWidth = 3;
            series4.ChartArea = "AltitudeChartArea";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series4.Legend = "Legend1";
            series4.Name = "Altitude";
            series4.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time;
            series5.BorderWidth = 3;
            series5.ChartArea = "AltitudeChartArea";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series5.Legend = "Legend1";
            series5.Name = "RSSI";
            series5.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time;
            series5.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series6.BorderWidth = 3;
            series6.ChartArea = "AccelerationChart";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series6.Legend = "Legend1";
            series6.Name = "Acceleration";
            series6.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time;
            this.chart.Series.Add(series4);
            this.chart.Series.Add(series5);
            this.chart.Series.Add(series6);
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
            this.map.MaxZoom = 23;
            this.map.MinZoom = 0;
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
            this.map.Zoom = 0D;
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
            this.receiverPort.BaudRate = 115200;
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
            // rssiLabel
            // 
            this.rssiLabel.AutoSize = true;
            this.rssiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rssiLabel.Location = new System.Drawing.Point(89, 36);
            this.rssiLabel.Name = "rssiLabel";
            this.rssiLabel.Size = new System.Drawing.Size(57, 20);
            this.rssiLabel.TabIndex = 12;
            this.rssiLabel.Text = "RSSI:";
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
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(638, 321);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 592);
            this.Controls.Add(this.followOption);
            this.Controls.Add(this.rssiLabel);
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
        private System.Windows.Forms.Label rssiLabel;
        private System.Windows.Forms.CheckBox followOption;
        private System.Windows.Forms.Button button1;
    }
}

