using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        Queue<string> order = new Queue<string>();

        Thread tRed;
        Thread tBlue;
        Thread tGreen;

        delegate void CTBMethod(int val);
        delegate void CTFinish(string t);

        public Form1()
        {
            InitializeComponent();
        }


        private void button4_Click(object sender, EventArgs e)
        {

        }
  

        private void btnThread4_Click(object sender, EventArgs e)
        {
            tRed = new Thread( new ParameterizedThreadStart(LoopRed));
            tBlue= new Thread( new ParameterizedThreadStart(LoopBlue));
            tGreen = new Thread(new ParameterizedThreadStart(LoopGreen));

            int r = int.Parse(tbx1.Text);
            int b = int.Parse(tbx2.Text);
            int g = int.Parse(tbx3.Text);

            tRed.Start(r);
            tBlue.Start(b);
            tGreen.Start(g);

        }

        private void btnThread1_Click(object sender, EventArgs e)
        {
            tRed = new Thread(new ParameterizedThreadStart(LoopRed));
            int r = int.Parse(tbx1.Text);
            tRed.Start(r);
        }

        public void LoopRed(object ob)
        {
            int cnt = (int)ob;
            CTBMethod tRed = new CTBMethod(UpdateRed);
            for (int i = 0; i < cnt; i++)
            {

                this.Invoke(tRed, i);
                Thread.Sleep(2);
            }
            CTFinish ctFin = new CTFinish(ThreadFinish);
            this.Invoke(ctFin, "Red");
        }
        public void LoopBlue(object ob)
        {
            int cnt = (int)ob;
            CTBMethod tBlue = new CTBMethod(UpdateBlue);
            for (int i = 0; i < cnt; i++)
            {

                this.Invoke(tBlue, i);
                Thread.Sleep(2);
            }
            CTFinish ctFin = new CTFinish(ThreadFinish);
            this.Invoke(ctFin, "Blue");

        }
        public void LoopGreen(object ob)
        {
            int cnt = (int)ob;
            CTBMethod tGreen = new CTBMethod(UpdateGreen);
            for (int i = 0; i < cnt; i++)
            {
                this.Invoke(tGreen, i);
                Thread.Sleep(2);
            }
            CTFinish ctFin = new CTFinish(ThreadFinish);
            this.Invoke(ctFin, "Green");
        }

        private void UpdateRed(int val)
        {
            pbxRed.Width = val;
            pbxRed.Refresh();

        }
        private void UpdateBlue(int val)
        {
            pbxBlue.Width = val;
            pbxBlue.Refresh();

        }
        private void UpdateGreen(int val)
        {
            pbxGreen.Width = val;
            pbxGreen.Refresh();

        }

        private void btnThread2_Click(object sender, EventArgs e)
        {
            tBlue = new Thread(new ParameterizedThreadStart(LoopBlue));
            int b = int.Parse(tbx2.Text);
            tBlue.Start(b);
        }

        private void btnThread3_Click(object sender, EventArgs e)
        {
            tGreen = new Thread(new ParameterizedThreadStart(LoopGreen));
            int g = int.Parse(tbx3.Text);
            tGreen.Start(g);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ThreadFinish(string t)
        {
            order.Enqueue(t);
            if (order.Count == 3)
            {
                MessageBox.Show("Threads finished in this order :\n" 
                    + order.Dequeue() + "\n" 
                    + order.Dequeue() + "\n"
                    + order.Dequeue() + "\n", "Thread Finished");

            }
        }
    }
}
