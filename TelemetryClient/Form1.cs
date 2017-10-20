using GMap.NET;
using GMap.NET.MapProviders;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelemetryClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void refresh()
        {
            commboBox.DataSource = SerialPort.GetPortNames();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            refresh();
            map.MapProvider = GoogleSatelliteMapProvider.Instance;
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            receiverPort.Close();
            Environment.Exit(1);
        }

        private void receiverPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string line = receiverPort.ReadLine();

            Console.WriteLine(line);
            File.AppendAllText(outputBox.Text, line + "\n");

            outputBox.Invoke(new MethodInvoker(delegate
            {
                outputBox.Text += line + "\n";
            }));
            try
            {
                Packet packet = JsonConvert.DeserializeObject<Packet>(line);

                idLabel.Text = "ID: " + packet.id;
                altitudeLabel.Text = "Altitude: " + packet.altitude;
                accelerationLabel.Text = "Acceleration: " + packet.acceleration;
                latLabel.Text = "Latitude: "  + packet.lat;
                lngLabel.Text = "Longitude: " + packet.lng;

                map.Position = new PointLatLng(packet.lat, packet.lng);
            }
            catch
            {
                File.AppendAllText(errorTextBox.Text, "unable to parse: " + line + "\n");
                Console.Error.WriteLine("unable to parse: " + line);
            }
        }

        private void connectBtn_Click(object sender, EventArgs e)
        {
            if (receiverPort.IsOpen)
            {
                receiverPort.Close();
                connectBtn.Text = "Open";
            }
            else
            {
                receiverPort.PortName = commboBox.Text;
                receiverPort.Open();
                connectBtn.Text = "Close";
            }
        }
    }
}
