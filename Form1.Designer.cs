using System;
using System.Drawing;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Button = System.Windows.Forms.Button;
using ProgressBar = System.Windows.Forms.ProgressBar;

namespace Timer24h
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
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.timerStrob = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();

            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(86, 60);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(333, 56);
            this.trackBar1.TabIndex = 0;
            trackBar1.Maximum = 23;
            trackBar1.Minimum = 0;
            trackBar1.TickFrequency = 1;
            this.trackBar1.ValueChanged += (sender, e) =>
            {

                this.label2.Text = trackBar1.Value.ToString() + " ч";
            };
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(86, 159);
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(333, 56);
            this.trackBar2.TabIndex = 1;
            trackBar2.Maximum = 59;
            trackBar2.Minimum = 0;
            this.trackBar2.ValueChanged += (sender, e) =>
            {

                this.label3.Text = trackBar2.Value.ToString() + " мин";
            };
            // 
            // trackBar3
            // 
            this.trackBar3.Location = new System.Drawing.Point(86, 273);
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Size = new System.Drawing.Size(333, 56);
            this.trackBar3.TabIndex = 2;
            trackBar3.Maximum = 59;
            trackBar3.Minimum = 0;
            this.trackBar3.ValueChanged += (sender, e) =>
            {
                this.label4.Text = trackBar3.Value.ToString() + " сек";
            };
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(535, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = string.Empty;
            this.label1.Font = new Font("Arial", 14, FontStyle.Bold);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(trackBar1.Width + 100, 60);
            this.label2.Name = "label2";
            this.label2.Font = new Font("Arial", 14, FontStyle.Regular);
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(trackBar1.Width + 100, trackBar2.Location.Y);
            this.label3.Name = "label2";
            this.label3.Font = new Font("Arial", 14, FontStyle.Regular);
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(trackBar1.Width + 100, trackBar3.Location.Y);
            this.label4.Name = "label2";
            this.label4.Font = new Font("Arial", 14, FontStyle.Regular);
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 0;

            // 
            // timer
            // 
            this.timer.Enabled = true;
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            // 
            // timerstrob
            // 
            this.timerStrob.Enabled = true;
            timerStrob.Interval = 1000;
            timerStrob.Tick += TimerStrob_Tick;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(610, 145);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 56);
            this.button1.TabIndex = 4;
            this.button1.Text = "START";
            this.button1.Font = new Font("Arial", 10, FontStyle.Bold);
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += button1_Click;

            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(610, 252);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 53);
            this.button2.TabIndex = 5;
            this.button2.Text = "STOP";
            this.button2.Font = new Font("Arial", 10, FontStyle.Bold);
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += Button2_Click;

            // progressBar1
            // 
            progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progressBar1.Location = new System.Drawing.Point(86, 346);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(599, 23);
            this.progressBar1.TabIndex = 6;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 86400;

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 381);
            this.Load += Form1_Load;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.trackBar3);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.progressBar1);
            this.Name = "Form1";
            this.Text = "Timer";





        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timerStrob.Stop();
            timer.Stop();
        }

        private void TimerStrob_Tick(object sender, EventArgs e)
        {
            if (t == 0)
            {
                timerStrob.Stop();

            }
            else if (this.BackColor == Color.Blue)
            {
                this.BackColor = Color.Red;
                t--;
            }

            else
            {
                this.BackColor = Color.Blue;
                t--;

            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            timer.Stop();
            timerStrob.Stop();
            this.BackColor= default;
            this.trackBar3.Enabled = true;
            this.trackBar2.Enabled = true;
            this.trackBar1.Enabled = true;
            this.button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
                i = (trackBar1.Value * 3600) + (trackBar2.Value * 60) + trackBar3.Value;
            if (i == 0)
            {
                MessageBox.Show("Введи нужное количество времени ");
                return;
            }
            timer.Start();
                this.trackBar3.Enabled = false;
                this.trackBar2.Enabled = false;
                this.trackBar1.Enabled = false;
                this.button1.Enabled = false;
                     
        }

        private void Timer_Tick(object sender, EventArgs e)
        {

            label1.Text = $"Осталось - " +(--i).ToString()+ " сек.";
            if (i == 0)
            {
                timer.Stop();
                timerStrob.Start(); 
                label1.Text = $"Время вышло";
            }
            else
                progressBar1.Value = i;
        }

        #endregion


        Timer timer;
        Timer timerStrob;
        System.Windows.Forms.TrackBar trackBar1;
        System.Windows.Forms.TrackBar trackBar2;
        System.Windows.Forms.TrackBar trackBar3;
        Label label1;
        Label label2;
        Label label3;
        Label label4;
        int i ;
        int t = 4;
        Button button1;
        Button button2;
        ProgressBar progressBar1;

    }
}

