﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectedRaisesGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btn_Raise_Click
        {
            double salaryIncrease;
            double entry;

            entry = Convert.ToDouble(txtEntry.Text);
            salaryIncrease = entry * 1.04;



}
