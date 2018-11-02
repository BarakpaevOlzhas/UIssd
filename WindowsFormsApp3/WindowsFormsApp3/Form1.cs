﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        private int x = 0; private int y = 0;
        
        private int panel1ColorR = 44;
        private int panel1ColorG = 62;
        private int panel1ColorB = 80;

        private int aquaColorR = 29;
        private int aquaColorG = 210;
        private int aquaColorB = 175;

        private int bufferColorR = 44;
        private int bufferColorG = 62;
        private int bufferColorB = 80;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        public Form1()
        {            
            InitializeComponent();
            //userControl13.BringToFront();
            panel1.BackColor = Color.FromArgb(panel1ColorR, panel1ColorG, panel1ColorB);
            button1.BackColor = Color.FromArgb(panel1ColorR, panel1ColorG, panel1ColorB);
            button2.BackColor = Color.FromArgb(panel1ColorR, panel1ColorG, panel1ColorB);
            button3.BackColor = Color.FromArgb(panel1ColorR, panel1ColorG, panel1ColorB);            
            button4.BackColor = Color.FromArgb(aquaColorR, aquaColorG, aquaColorB);
            timer1.Interval = 20;
            timer2.Interval = 20;
            timer3.Interval = 20;
            
            //button1.BackColor = Color.FromArgb(29,210,175);
            //button2.BackColor = Color.FromArgb(29, 210, 175);
            //button3.BackColor = Color.FromArgb(29, 210, 175);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle,0x112, 0xf012, 0);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                this.Location = new System.Drawing.Point(this.Location.X + (e.X - x), this.Location.Y + (e.Y - y));
            }
        }

        private void ReverseTimerTickToChangeTheColor(object sender, EventArgs e)
        {
            if (bufferColorR != panel1ColorR) bufferColorR++;
            if (bufferColorG != panel1ColorG) bufferColorG--;
            if (bufferColorB != panel1ColorB) bufferColorB--;
            button1.BackColor = Color.FromArgb(bufferColorR, bufferColorG, bufferColorB);
            button2.BackColor = Color.FromArgb(bufferColorR, bufferColorG, bufferColorB);
            button3.BackColor = Color.FromArgb(bufferColorR, bufferColorG, bufferColorB);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            userControl12.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            userControl21.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void userControl21_Load(object sender, EventArgs e)
        {

        }

        private void userControl21_Load_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void AnimationButtom(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void userControl21_Load_2(object sender, EventArgs e)
        {

        }

        private void TurnTimer(object sender, EventArgs e)
        {   
            timer1.Enabled = true;                  
        }

        private void OffTimer(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            bufferColorR = panel1ColorR;
            bufferColorG = panel1ColorG;
            bufferColorB = panel1ColorB;
            button1.BackColor = Color.FromArgb(panel1ColorR, panel1ColorG, panel1ColorB);
            button1.FlatAppearance.BorderColor = Color.FromArgb(255,255,255);
        }

        private void TurnTimerTwo(object sender, EventArgs e)
        {
            timer2.Enabled = true;
        }

        private void OffTimerTwo(object sender, EventArgs e)
        {
            timer2.Enabled = false;
            bufferColorR = panel1ColorR;
            bufferColorG = panel1ColorG;
            bufferColorB = panel1ColorB;
            button2.BackColor = Color.FromArgb(panel1ColorR, panel1ColorG, panel1ColorB);
            button2.FlatAppearance.BorderColor = Color.FromArgb(255, 255, 255);
        }

        private void TurnTimerThree(object sender, EventArgs e)
        {
            timer3.Enabled = true;
        }

        private void OffTimerThree(object sender, EventArgs e)
        {
            timer3.Enabled = false;
            bufferColorR = panel1ColorR;
            bufferColorG = panel1ColorG;
            bufferColorB = panel1ColorB;
            button3.BackColor = Color.FromArgb(panel1ColorR, panel1ColorG, panel1ColorB);
            button3.FlatAppearance.BorderColor = Color.FromArgb(255, 255, 255);
        }

        private void TimerTickToChangeTheColor(object sender, EventArgs e)
        {            
            if (bufferColorR > aquaColorR) bufferColorR-= 20;
            if (bufferColorG < aquaColorG) bufferColorG+= 20;
            if (bufferColorB < aquaColorB) bufferColorB+= 20;
            button1.BackColor = Color.FromArgb(bufferColorR, bufferColorG, bufferColorB);
            button1.FlatAppearance.BorderColor = Color.FromArgb(bufferColorR, bufferColorG + 30, bufferColorB);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (bufferColorR > aquaColorR) bufferColorR -= 20;
            if (bufferColorG < aquaColorG) bufferColorG += 20;
            if (bufferColorB < aquaColorB) bufferColorB += 20;
            button2.BackColor = Color.FromArgb(bufferColorR, bufferColorG, bufferColorB);
            button2.FlatAppearance.BorderColor = Color.FromArgb(bufferColorR, bufferColorG + 30, bufferColorB);
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (bufferColorR > aquaColorR) bufferColorR -= 20;
            if (bufferColorG < aquaColorG) bufferColorG += 20;
            if (bufferColorB < aquaColorB) bufferColorB += 20;
            button3.BackColor = Color.FromArgb(bufferColorR, bufferColorG, bufferColorB);
            button3.FlatAppearance.BorderColor = Color.FromArgb(bufferColorR, bufferColorG + 30, bufferColorB);
        }

        private void exit1_Load(object sender, EventArgs e)
        {

        }

        private void userControl13_Load(object sender, EventArgs e)
        {

        }
    }
}
