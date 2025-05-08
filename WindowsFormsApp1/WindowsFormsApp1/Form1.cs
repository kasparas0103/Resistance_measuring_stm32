using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
namespace WindowsFormsApp1

{
    public partial class Form1 : Form
    {
        SerialPort serialPort = new SerialPort();
        string incomingData = "";
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(SerialPort.GetPortNames());
            serialPort.BaudRate = 115200;
            serialPort.DataReceived += SerialPort_DataReceived;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Pasirink COM portą!");
                return;
            }

            serialPort.PortName = comboBox1.SelectedItem.ToString();
            try
            {
                serialPort.Open();
                MessageBox.Show("Prisijungta!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Klaida jungiant: " + ex.Message);
            }
        }
        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                incomingData = serialPort.ReadLine(); // expects: A1:123.45;A2:234.56
                this.BeginInvoke(new Action(UpdateLabels));
            }
            catch { }
        }

        private void Disconnect_Click(object sender, EventArgs e)
        {
        if (serialPort.IsOpen)
        {
            serialPort.Close();
            MessageBox.Show("Atjungta.");
        }
        }
    
        private void Ref1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Rref2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Send_Click(object sender, EventArgs e)
        {
        if (!serialPort.IsOpen) return;

            float r1 = float.Parse(Ref1.Text);
            float r2 = float.Parse(Rref2.Text);

            byte[] buffer = new byte[8];
            BitConverter.GetBytes(r1).CopyTo(buffer, 0);
            BitConverter.GetBytes(r2).CopyTo(buffer, 4);

            serialPort.Write(buffer, 0, 8);
            //string toSend = $"{rref1},{rref2}\n";
        //serialPort.WriteLine(toSend);
        }

        private void labelADC1_Click(object sender, EventArgs e)
        {

        }

        private void labelADC2_Click(object sender, EventArgs e)
        {

        }



        private void timer1_Tick(object sender, EventArgs e)
        {

        }
        private void UpdateLabels()
        {
            if (incomingData.StartsWith("R1="))
            {
                try
                {
                    string[] parts = incomingData.Split(',');
                    string r1Str = parts[0].Split('=')[1].Replace("Ohm", "").Trim();
                    string r2Str = parts[1].Split('=')[1].Replace("Ohm", "").Trim();

                    if (float.TryParse(r1Str, out float r1) &&
                        float.TryParse(r2Str, out float r2))
                    {   
                        if (r1<12000)
                            labelADC1.Text = $"R1: {r1:F2} Ω";
                        else
                            labelADC1.Text = $"R1: - Ω";
                        if (r2 < 12000)
                            labelADC2.Text = $"R2: {r2:F2} Ω";
                        else
                            labelADC2.Text = $"R2: - Ω";

                    }
                }
                catch { }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
