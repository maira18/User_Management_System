﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myForm1
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 updatePassword = new Form6();
            updatePassword.Show();

        }

        private void Form5_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
