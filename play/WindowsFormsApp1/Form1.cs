﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            button1.Click += Button1_Click;//registering
            button1.Click += button1_Click;

        }
        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("you clicked button1");

        }
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("you clicked button1.you have double clicked");

        }
    }
}
