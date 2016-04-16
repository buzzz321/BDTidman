namespace TidMan
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
            this.startButton = new System.Windows.Forms.Button();
            this.textBoxStart = new System.Windows.Forms.TextBox();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.counter = new System.Windows.Forms.Label();
            this.countDownTimer = new System.Windows.Forms.Timer(this.components);
            this.resting = new System.Windows.Forms.CheckBox();
            this.resetButton = new System.Windows.Forms.Button();
            this.finished = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(15, 122);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxStart
            // 
            this.textBoxStart.Location = new System.Drawing.Point(12, 40);
            this.textBoxStart.Name = "textBoxStart";
            this.textBoxStart.Size = new System.Drawing.Size(62, 20);
            this.textBoxStart.TabIndex = 1;
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Location = new System.Drawing.Point(80, 40);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.Size = new System.Drawing.Size(62, 20);
            this.textBoxTotal.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "start energy";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Total energy";
            // 
            // counter
            // 
            this.counter.AutoSize = true;
            this.counter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.counter.Location = new System.Drawing.Point(148, 43);
            this.counter.Name = "counter";
            this.counter.Size = new System.Drawing.Size(13, 13);
            this.counter.TabIndex = 5;
            this.counter.Text = "0";
            // 
            // countDownTimer
            // 
            this.countDownTimer.Interval = 1000;
            // 
            // resting
            // 
            this.resting.AutoSize = true;
            this.resting.Location = new System.Drawing.Point(15, 4);
            this.resting.Name = "resting";
            this.resting.Size = new System.Drawing.Size(62, 17);
            this.resting.TabIndex = 6;
            this.resting.Text = "Resting";
            this.resting.UseVisualStyleBackColor = true;
            this.resting.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(96, 122);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 7;
            this.resetButton.Text = "reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // finished
            // 
            this.finished.Enabled = false;
            this.finished.Location = new System.Drawing.Point(12, 86);
            this.finished.Name = "finished";
            this.finished.Size = new System.Drawing.Size(62, 20);
            this.finished.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Finished";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(194, 167);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.finished);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.resting);
            this.Controls.Add(this.counter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxTotal);
            this.Controls.Add(this.textBoxStart);
            this.Controls.Add(this.startButton);
            this.Name = "Form1";
            this.Text = "Avsath";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.TextBox textBoxStart;
        private System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label counter;
        private System.Windows.Forms.Timer countDownTimer;
        private System.Windows.Forms.CheckBox resting;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.TextBox finished;
        private System.Windows.Forms.Label label3;
    }
}

