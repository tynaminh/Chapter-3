﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FixedDebugThree2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void helloButton_Click(object sender, EventArgs e)
        {
            outputLabel = "Goodbye, " + textBox1.Text + "!";
        }

        private void goodbyeButton_Click(object sender, EventArgs e)
        {
            outputLabel = "Goodbye, " + textBox1.Text + "!";
        }
    }
}
