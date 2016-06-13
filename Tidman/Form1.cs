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
using System.Media;

namespace TidMan {
    public partial class Form1 : Form {
        private int data;
         public Form1()
        {
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

            var endTime = (countDownTimer.Interval / 1000 * data) / 60;
            DateTime localDate = DateTime.Now;            
            localDate = localDate.AddMinutes((countDownTimer.Interval / 1000 * data) / 60);
            finished.Text = localDate.ToLongTimeString();

            countDownTimer.Tick += new EventHandler(tick);
            countDownTimer.Start();

            using (var soundPlayer = new SoundPlayer(@"c:\Windows\Media\chimes.wav")) {
                soundPlayer.Play(); // can also use soundPlayer.PlaySync()
            }
        }

        private void tick(object sender, EventArgs e)
        {
            data -= 1;

            if (data >= 0) {
                counter.Text = data.ToString();
            }
            else {
                countDownTimer.Stop();
                using (var soundPlayer = new SoundPlayer(@"c:\Windows\Media\chimes.wav")) {
                    soundPlayer.Play(); // can also use soundPlayer.PlaySync()
                }
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
