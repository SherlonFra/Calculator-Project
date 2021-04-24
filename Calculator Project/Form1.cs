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
        List<Panel> listPanel = new List<Panel>();
        

        public Form1()
        {
            InitializeComponent();
        }

        private void numberValue(object sender, EventArgs e)
        {
        }

        private void btnConv_Click(object sender, EventArgs e)
        {
            double i = double.Parse(this.amount_txt.Text);
            if (txtfrom.SelectedItem == "Miles" && txtTo.SelectedItem == "Kilometers")
            {
                double btnConv = (double)(i * 1.609);
                display_txt.Text = "Converted Amount: " + btnConv;
            }
            if (txtfrom.SelectedItem == "Kilometers" && txtTo.SelectedItem == "Miles")
            {
                double btnConv = (double)(i / 1.609);
                display_txt.Text = "Converted Amount: " + btnConv;
            }

            if (txtfrom.SelectedItem == "Pounds" && txtTo.SelectedItem == "Kilograms")
            {
                double btnConv = (double)(i / 2.2046);
                display_txt.Text = "Converted Amount: " + btnConv;
            }
            if (txtfrom.SelectedItem == "Kilograms" && txtTo.SelectedItem == "Pounds")
            {
                double btnConv = (double)(i * 2.2046);
                display_txt.Text = "Converted Amount: " + btnConv;
            }
            if (txtfrom.SelectedItem == "Miles" && txtTo.SelectedItem == "Kilograms")
            {
                display_txt.Text = "Converted Amount:Conversion not Applicable ";
            }
            if (txtfrom.SelectedItem == "Kilograms" && txtTo.SelectedItem == "Miles")
            {
                display_txt.Text = "Converted Amount:Conversion not Applicable ";
            }
            if (txtfrom.SelectedItem == "Pounds" && txtTo.SelectedItem == "Kilometers")
            {
                display_txt.Text = "Converted Amount:Conversion not Applicable ";
            }
            if (txtfrom.SelectedItem == "Kilometers" && txtTo.SelectedItem == "Pounds")
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
    }
}
