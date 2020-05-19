using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Windows.Forms;
using ZedGraph;

namespace ZedGraph
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static void csvSTART(double time, double value, double zoom, string filepath)
        {
            try
            {
                using(System.IO.StreamWriter file = new System.IO.StreamWriter(filepath, true))
                {
                    file.WriteLine(time + "," + value + "," + zoom);
                }
            }
            catch(Exception ex)
            {
                throw new ApplicationException("IT DIDN'T WORK! STOP! BECAUSE: ", ex);
            }
        }

        RollingPointPairList list1 = new RollingPointPairList(10000);
        private delegate void SetTextCallback(string text);
        string InputData;
        double time = 0;
        double ft = 0;
        double st = 0;
        double bpm;
        static double window = 100;
        double Zoom_val;
        double out_val;
        double tmp_max = 0;
        bool beatdetect = false;
        bool check =false;
        bool SAVEME = false;
        string fp = "graphdata.csv";
        private void SetText(string text)
        {
            this.rtbIncoming.Text += text;
            Double.TryParse(text, out out_val);
            if (out_val > tmp_max)
                tmp_max = out_val;
            MaxBOX.Text = (tmp_max * (2.5/4095)).ToString();
            if (MaxBOX.Text == "2.5")
                tmp_max = 0;
            //based on 12-bit microcontroller
            if(check == false && beatdetect == false && out_val > 3000) //3000 seems to be the threshhold hot spot for R wave
            {
                check = true;
            }
            if(beatdetect == false && check == true && out_val < 3000)
            {
                beatdetect = true;
                ft = time;
                check = false;
            }
            if(beatdetect && check == false && out_val > 3000)
            {
                check = true;
            }
            if(beatdetect && check == true && out_val < 3000)
            {
                st = time;
                check = false;
                beatdetect = false;
                bpm = 1500/(st - ft);
                Status.Text = "Beat Detected!";
            }
            BeatsMinute.Text = bpm.ToString();

            //out_val = Convert.ToDouble(text);
            time += 1;
            if (Stream.Checked)
            {
                if (time > window)
                {
                    time = 0;
                    zedGraphControl1.Invalidate();
                    list1.Clear();
                }
            }
            if (out_val < 4095)
            {
                list1.Add(time, out_val * ((2.5 * Zoom_val)/ 4095));
                CreateGraph(zedGraphControl1, list1);
                zedGraphControl1.AxisChange();
                zedGraphControl1.Invalidate();
            }
            if (SAVEME)
                csvSTART(time, out_val, Zoom_val, fp);


        }
        public void CreateGraph(ZedGraphControl zedGraphControl1, RollingPointPairList list1)
        {
            GraphPane myPane = zedGraphControl1.GraphPane;
            myPane.Title.Text = "Oscilloscope";
            myPane.XAxis.Title.Text = "Samples";
            myPane.YAxis.Title.Text = "Volts";
            zedGraphControl1.GraphPane.CurveList.Clear();
            zedGraphControl1.GraphPane.GraphObjList.Clear();
            zedGraphControl1.IsZoomOnMouseCenter = true;
            zedGraphControl1.IsShowHScrollBar = true;
            zedGraphControl1.IsAutoScrollRange = true;
            zedGraphControl1.IsShowVScrollBar = true;
            zedGraphControl1.IsAutoScrollRange = true;
            Double.TryParse(Window_Size.Text, out window);
            LineItem myCurve = myPane.AddCurve("", list1, Color.Red, SymbolType.None);
            //
            if(Stream.Checked)
            {
                myPane.XAxis.Scale.Min = 0;
                myPane.XAxis.Scale.Max = window;
            }
            else
            {
                myPane.XAxis.Scale.Max = time;
                if (time > window) 
                myPane.XAxis.Scale.Min = time - window;
                else
                    myPane.XAxis.Scale.Min = 0;
            }
            myPane.XAxis.MajorGrid.IsVisible = true;
            myPane.YAxis.Scale.MaxAuto = true;
            myPane.YAxis.Scale.FontSpec.FontColor = Color.Red;
            myPane.YAxis.Title.FontSpec.FontColor = Color.Red;
            myPane.YAxis.MajorTic.IsOpposite = false;
            myPane.YAxis.MinorTic.IsOpposite = false;
            myPane.YAxis.MajorGrid.IsZeroLine = false;
            myPane.YAxis.Scale.Align = AlignP.Inside;
            myPane.Chart.Fill = new Fill(Color.White, Color.LightGray, 45.0f);
            zedGraphControl1.AxisChange();
        }

        private void zedGraphControl1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
                return;
            serialPort1.PortName = comboBox1.SelectedItem.ToString();
            serialPort1.BaudRate = int.Parse(comboBox2.SelectedItem.ToString());
            serialPort1.DataBits = 8;
            serialPort1.StopBits = System.IO.Ports.StopBits.One;
            serialPort1.Parity = Parity.None;
            serialPort1.Handshake = Handshake.None;

            try
            {
                serialPort1.Open();
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch
            {
                MessageBox.Show("Just Doesn't work");
            }
        }

        private void Disconnect_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
        }

        private void rtbIncoming_TextChanged_1(object sender, EventArgs e)
        {
            rtbIncoming.SelectionStart = rtbIncoming.Text.Length;
            // scroll it automatically
            rtbIncoming.ScrollToCaret();
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            InputData = serialPort1.ReadLine();
            if (InputData != String.Empty)
            {
                this.BeginInvoke(new SetTextCallback(SetText), new object[] { InputData });
            }

        }
        private XDate _currentTime;
        private void Form1_Load(object sender, EventArgs e)
        {
            _currentTime = new XDate(DateTime.Now);
            foreach (string s in System.IO.Ports.SerialPort.GetPortNames())
            {
                comboBox1.Items.Add(s);
            }//fill the available port name in the combo box
            comboBox2.Items.Add(300);
            comboBox2.Items.Add(1200);
            comboBox2.Items.Add(2400);
            comboBox2.Items.Add(4800);
            comboBox2.Items.Add(9600);
            comboBox2.Items.Add(19200);
            comboBox2.Items.Add(38400);
            comboBox2.Items.Add(76800);
            comboBox2.Items.Add(115200);

            CreateGraph(zedGraphControl1, list1);
            Window_Size.Text = "1000";
            ZoomBox.Text = "1";
            comboBox1.Text = "COM8";
            comboBox2.SelectedIndex = 4;
            Status.Text = "Load Okay";
        }
        private void ResetTime_Click(object sender, EventArgs e)
        {
            list1.Clear();
            time = 0;
            zedGraphControl1.AxisChange();
            zedGraphControl1.Invalidate();
        }
        private void BeatsMinute_TextChanged(object sender, EventArgs e)
        {

        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            foreach (string s in System.IO.Ports.SerialPort.GetPortNames())
            {
                comboBox1.Items.Add(s);
            }//fill the available port name in the combo box
        }

        private void ZoomBox_TextChanged(object sender, EventArgs e)
        {
            Double.TryParse(ZoomBox.Text, out Zoom_val);
        }

        private void csv_btn_Click(object sender, EventArgs e)
        {
            SAVEME = true;
            Status.Text = "Files are saving";
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            SAVEME = false;
            Status.Text = "File saving has stopped";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Default_Click(object sender, EventArgs e)
        {
            zedGraphControl1.GraphPane.CurveList.Clear();
            zedGraphControl1.GraphPane.YAxis.Scale.Min = 0;
            zedGraphControl1.AxisChange();
        }

        private void ZoomScroll_Scroll(object sender, ScrollEventArgs e)
        {
            Zoom_val = ZoomScroll.Value + 1;
            ZoomBox.Text = ZoomScroll.Value.ToString();
        }

    }
}
