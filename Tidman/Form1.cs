using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApplicationTest {
    public partial class Form1 : Form {
        private int data;
        private CultureInfo culture;
        public Form1()
        {
            culture = new CultureInfo(Thread.CurrentThread.CurrentCulture.Name, true);
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxTotal.Text != "" && textBoxStart.Text != "") {
                data = Int32.Parse(textBoxTotal.Text) - Int32.Parse(textBoxStart.Text);
            }
            else {
                data = 1;
            }

            if (resting.Checked) {
                countDownTimer.Interval = 1000 * 60; //60 seconds..
            }else {
                countDownTimer.Interval = 1000 * 60 * 3; //60 seconds..
            }

            DateTime localDate = DateTime.Now;            
            localDate = localDate.AddMinutes(countDownTimer.Interval/1000);
            finished.Text = localDate.ToLongTimeString();

            countDownTimer.Tick += new EventHandler(tick);
            countDownTimer.Start();
        }

        private void tick(object sender, EventArgs e)
        {
            data -= 1;

            if (data >= 0) {
                counter.Text = data.ToString();
            }
            else {
                countDownTimer.Stop();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            countDownTimer.Stop();
        }
    }
}
