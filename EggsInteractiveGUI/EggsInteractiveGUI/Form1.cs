﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EggsInteractiveGUI
{
    public partial class lblResult : Form
    {
        public lblResult()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int eggsTotal;
            int dozenEggs = 12;
            int numDozen;
            int numEggsRemaining;

            eggsTotal = Convert.ToInt32(txtEntry1.Text) + Convert.ToInt32(txtEntry2.Text) +
            Convert.ToInt32(txtEntry3.Text) + Convert.ToInt32(txtEntry4.Text) +
            Convert.ToInt32(txtEntry5.Text);

            numDozen = eggsTotal / dozenEggs;
            numEggsRemaining = eggsTotal % dozenEggs;

            lblCalculate.Text = eggsTotal + " eggs is " + numDozen + "dozen with " +
                numEggsRemaining + " left over.";
        }

        
    }
}
