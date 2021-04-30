using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_Project
{
    public partial class Form1 : Form
    {
        bool operandperformed = false;
        string operand = " ";
        double result = 0;



        public Form1()
        {
            InitializeComponent();
        }

        private void btnConv_Click(object sender, EventArgs e)
        {
            double i = double.Parse(this.amount_txt.Text);
            if (txtfrom.SelectedItem == "Miles" && txtTo.SelectedItem == "Kilometers")
            {
                double btnConv = (double)(i * 1.609);
                display_txt.Text = "Converted Amount: " + btnConv;
            }
            else if (txtfrom.SelectedItem == "Kilometers" && txtTo.SelectedItem == "Miles")
            {
                double btnConv = (double)(i / 1.609);
                display_txt.Text = "Converted Amount: " + btnConv;
            }

            else if (txtfrom.SelectedItem == "Pounds" && txtTo.SelectedItem == "Kilograms")
            {
                double btnConv = (double)(i / 2.2046);
                display_txt.Text = "Converted Amount: " + btnConv;
            }
            else if (txtfrom.SelectedItem == "Kilograms" && txtTo.SelectedItem == "Pounds")
            {
                double btnConv = (double)(i * 2.2046);
                display_txt.Text = "Converted Amount: " + btnConv;
            }
            if (txtfrom.SelectedItem == "Miles" && txtTo.SelectedItem == "Kilograms")
            {
                display_txt.Text = "Converted Amount:Conversion not Applicable ";
            }
            else if (txtfrom.SelectedItem == "Kilograms" && txtTo.SelectedItem == "Miles")
            {
                display_txt.Text = "Converted Amount:Conversion not Applicable ";
            }
            if (txtfrom.SelectedItem == "Pounds" && txtTo.SelectedItem == "Kilometers")
            {
                display_txt.Text = "Converted Amount:Conversion not Applicable ";
            }
            else if (txtfrom.SelectedItem == "Kilometers" && txtTo.SelectedItem == "Pounds")
            {
                display_txt.Text = "Converted Amount:Conversion not Applicable ";
            }


        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnnextcalc_Click(object sender, EventArgs e)
        {
            pnlCalculator.Visible = true;
            pnlConverter.Visible = false;


        }

        private void btnnextconvert_Click(object sender, EventArgs e)
        {
            pnlCalculator.Visible = false;
            pnlConverter.Visible = true;

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void txtDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void NumEvent(object sender, EventArgs e)
        {
            if (txtResult.Text == "0" || operandperformed)
                txtResult.Clear();
            Button btn = (Button)sender;
            txtResult.Text += btn.Text;
            operandperformed = false;
        }

        private void Operand(object sender, EventArgs e)
        {
            operandperformed = true;
            Button btn = sender as Button;
            string newoperand = btn.Text;
            lbResult.Text = lbResult.Text + " " + txtResult.Text + " " + newoperand;

            switch (operand)
            {
                case "+": txtResult.Text = (result + Double.Parse(txtResult.Text)).ToString(); break;
                case "-": txtResult.Text = (result - Double.Parse(txtResult.Text)).ToString(); break;
                case "*": txtResult.Text = (result * Double.Parse(txtResult.Text)).ToString(); break;
                case "/": txtResult.Text = (result / Double.Parse(txtResult.Text)).ToString(); break;
                default: break;
            }

            result = Double.Parse(txtResult.Text);
            operand = newoperand;
        }

        private void bCE_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
        }

        private void bC_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
            lbResult.Text = "";
            result = 0;
            operand = "";
        }

        private void bEq_Click(object sender, EventArgs e)
        {
            lbResult.Text = "";
            operandperformed = true;

            switch (operand)
            {
                case "+": txtResult.Text = (result + Double.Parse(txtResult.Text)).ToString(); break;
                case "-": txtResult.Text = (result - Double.Parse(txtResult.Text)).ToString(); break;
                case "*": txtResult.Text = (result * Double.Parse(txtResult.Text)).ToString(); break;
                case "/": txtResult.Text = (result / Double.Parse(txtResult.Text)).ToString(); break;
                default: break;
            }

            result = Double.Parse(txtResult.Text);
            txtResult.Text = result.ToString();
            result = 0;
            operand = "";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (!operandperformed && !txtResult.Text.Contains("."))
            {
                txtResult.Text += ".";
            }
            else if (operandperformed)
            {
                txtResult.Text = "0";
            }

            if (!txtResult.Text.Contains("."))
            {
                txtResult.Text += ".";
            }

            operandperformed = false;
        }
    }
}
