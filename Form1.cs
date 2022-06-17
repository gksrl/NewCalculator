using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewCalculator
{
    public partial class Form1 : Form
    {
        int n1 = 0;
        int n2 = 0;
        int temp = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_one_Click(object sender, EventArgs e)
        {
            processbox.Text += ("1");
        }

        private void btn_two_Click(object sender, EventArgs e)
        {
            processbox.Text += ("2");
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            processbox.Text += ("3");
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            processbox.Text += ("4");
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            processbox.Text += ("5");
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            processbox.Text += ("6");
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            processbox.Text += ("7");
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            processbox.Text += ("8");
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            processbox.Text += ("9");
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            processbox.Text += ("0");
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {

        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            if (processbox.Text.Length > 0)
            {
                Convert.ToString(processbox.Text).EndsWith(" ");
                processbox.Text = processbox.Text.Substring(0, processbox.Text.Length - 1);
            }


            else
                return;
        }

        private void resultbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void processbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_plus_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToInt32(processbox.Text);
            processbox.Text = Convert.ToString(n1);
            processbox.Text += "+";
            processbox.Text += " ";
        }

        private void btn_minus_Click(object sender, EventArgs e)
        {

        }

        private void btn_multiple_Click(object sender, EventArgs e)
        {

        }

        private void btn_divide_Click(object sender, EventArgs e)
        {

        }

        private void btn_result_Click(object sender, EventArgs e)
        {

        }
    }
}
