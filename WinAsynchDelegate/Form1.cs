﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAsynchDelegate
{
    public partial class Form1 : Form
    {
        private delegate void TimeConsumingMethodDelegate(int seconds);
        private delegate void SetProgressDelegate(int val);

        bool Cansel;

        public bool Cancel { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Поле должно содержать цифры");
            }
        }


        private void TimeConsumingMethod(int seconds)
        {
            for (int j = 1; j <= seconds; j++)
            {
                System.Threading.Thread.Sleep(1000);
                SetProgress((int)(j * 100) / seconds);
                if (Cancel) break;
            }

            if (Cancel)
            {
                MessageBox.Show("Cancelled");
            }
            else
            {
                MessageBox.Show("Complete");
            }
        }


        public void SetProgress(int val)
        {
            if (progressBar1.InvokeRequired)
            {
                SetProgressDelegate del = new SetProgressDelegate(SetProgress);
                this.Invoke(del, new object[] { val });
            }
            else
            {
                progressBar1.Value = val;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cancel = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
