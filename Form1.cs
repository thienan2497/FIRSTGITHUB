﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GITHUB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            int so1 = int.Parse(textBox1.Text);
            int so2 = int.Parse(textBox2.Text);
            int d = so1 + so2;//kkk
        }
    }
}
