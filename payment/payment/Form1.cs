using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace payment
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

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {

            double  d = Convert.ToDouble(txtbxHours.Text);
            double  h = Math.Ceiling(d);
            int hour = Convert.ToInt16(h);   /////?????
            try
            {
                if (rdbCustomer.Checked)
                {
                    CustomerParking cp = new CustomerParking();
                    decimal amountCustomer = cp.Calculate(hour);
                    lblPrice.Text = amountCustomer.ToString();
                }
                else
                {
                    StaffParking sp = new StaffParking();
                    decimal amountStaff = sp.Calculate(hour);
                    lblPrice.Text = "$" + amountStaff.ToString();
                }
            }
                catch (ParkingException pe)

                {
                MessageBox.Show(pe.Message,"Exceeded 24 hours");
                }

            

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (rdbCustomer.Checked)
            {
                
                labelDetails.Text = "Customer Parking" + Environment.NewLine
                                    + "Pay $2 for each hour" + Environment.NewLine
                                    + "Maximum Limit = 24 hours";  
            }
            else {

                labelDetails.Text = "Staff Parking" + Environment.NewLine
                                    + "Pay $2 for first ten hour" + Environment.NewLine
                                    + "Pay $2 for each hour in excess of 10 hours" + Environment.NewLine
                                    + "Maximum Limit = 24 hours";
                
            }
        }

        private void rdbCustomer_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtbxHours_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelDetails_Click(object sender, EventArgs e)
        {

        }

        private void lblPrice_Click(object sender, EventArgs e)
        {

        }
    }
}
