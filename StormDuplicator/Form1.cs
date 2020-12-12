using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StormDuplicator
{
    public partial class StormDuplicator : MetroFramework.Forms.MetroForm
    {
        public StormDuplicator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BringToFront();
            openanimation.AnimateWindow(this.Handle, 750, openanimation.CENTER);

            timer1.Start();
            timer1.Interval = 900; //control text speed flashig
            timer2.Start();
            timer2.Interval = 900; //control text speed flashig
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Loading...");
            (metroProgressBar1).Value = (100);
            MessageBox.Show("The Duplication Has Worked!");
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            try
            {
                Application.ExitThread();
            }
            catch (Exception)
            {
                Environment.Exit(0);
            }
            return;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
            return;
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Loading...");
            (metroProgressBar2).Value = (100);
            MessageBox.Show("The Growtopia Has Been injected!");

        }

        private void metroProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random r = new Random();

            int A = r.Next(0, 255);
            int R = r.Next(0, 255);
            int G = r.Next(0, 255);
            int B = r.Next(0, 255);

            label1.ForeColor = Color.FromArgb(A, R, G, B);
        }

        private void metroLabel1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click_2(object sender, EventArgs e)
        {
            
        }

        private void FontStyle(string v)
        {
            throw new NotImplementedException();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            (metroProgressBar1).Value = (0);
        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            (metroProgressBar2).Value = (0);
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void timer2_Tick_1(object sender, EventArgs e)
        {

        }

        private void timer2_Tick_2(object sender, EventArgs e)
        {
            Random r = new Random();

            int A = r.Next(0, 255);
            int R = r.Next(0, 255);
            int G = r.Next(0, 255);
            int B = r.Next(0, 255);

            label2.ForeColor = Color.FromArgb(A, R, G, B);
        }
    }
}
