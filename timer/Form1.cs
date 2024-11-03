using System.Configuration;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using System.IO.Ports;

namespace timer
{
    public partial class Form1 : Form
    {
        public static int m = 0;
        public static int s = 0;

        private bool done = true;
        private bool elapsed;
        private bool reset = false;

        public static SerialPort _serialPort;

        //Main
        public Form1()
        {
            InitializeComponent();
            SerialConnect();
            if (_serialPort.IsOpen)
            {
                MessageBox.Show("Serial port connected");
            }
            else
            {
                MessageBox.Show("Error in Serial port connection");
            }
        }

        public void SerialConnect()
        {
            _serialPort = new SerialPort("COM3", 9600);
            _serialPort.Open();
        }

        public void WriteToArduino(int m, int s)
        {
            //_serialPort.Write(new byte[m], 0, 1);
            //_serialPort.Write(new byte[s], 0, 1);

            string minutes = m.ToString();
            string seconds = s.ToString();
            string endof = "\n";

            string time = minutes + seconds + endof;
            label3.Text = time;

            _serialPort.Write(time);
            //_serialPort.Write(endof);
            //MessageBox.Show(minutes);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)   //Label
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)   //NOT NEEDED
        {

        }

        private void timer1_Tick(object sender, EventArgs e) //Timer logic
        {
            timer1.Interval = 1000;

            if (s == 00 && done == false) //Counting seconds
            {
                s = 60;
                m--;
            }

            if (m == 00 & s == 00 && done == false)
            {
                done = true;
                timer1.Stop();
            }

            if (reset == true)
            {
                done = true;
                m = 00;
                s = 00;
                reset = false;
            }

            if (done == false) //Running
            {
                s--;

                if (m == 0 && s == 0)
                {
                    done = true;
                }
            }

            WriteToArduino(m, s);
            label2.Text = $"{m:D2}:{s:D2}";
        }

        //Time configs

        private void button3_Click(object sender, EventArgs e) //3 minutes
        {
            m = 00;
            s = 10;
        }

        private void button1_Click(object sender, EventArgs e) //5 minutes
        {
            m = 05;
            s = 00;
        }

        private void button4_Click(object sender, EventArgs e) //10 minutes
        {
            m = 10;
            s = 00;
        }

        private void button5_Click(object sender, EventArgs e) //15 minutes
        {
            m = 15;
            s = 00;
        }

        //Text labels / Misc buttons

        private void label1_Click(object sender, EventArgs e) //Title text
        {

        }

        private void label2_Click(object sender, EventArgs e) //Timer????
        {

        }

        private void button6_Click(object sender, EventArgs e) //Pause
        {
            timer1.Stop();
        }

        private void button7_Click(object sender, EventArgs e) //Reset
        {
            reset = true;
        }

        //Form

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        //Confirm button

        private void button2_Click(object sender, EventArgs e) //Start timer
        {
            string message = "Is it time?";
            const string caption = "FOOD??!?";
            var confirm = MessageBox.Show(message, caption, MessageBoxButtons.YesNo);

            if (confirm == DialogResult.Yes)
            {
                done = false;
                timer1.Start();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
