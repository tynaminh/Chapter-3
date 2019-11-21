using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MadLibsGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void btnLaunch_Click(object sender, EventArgs e)
        {
            double num;
            num = Convert.ToDouble(txtPickANumber1.Text) - Convert.ToDouble(txtPickANumber2.Text);

            lblResult.Text = "The " + txtColor.Text + " Dragon is the " + txtWordEndingInEst.Text +
                " Dragon of all. It has " + num + " " + txtBodyPartPlural.Text +
                ", and a " + txtAnimal.Text + " shaped like a " + txtNoun.Text +
                ", although it will feast on nearly anything.";
        }
    }
}
