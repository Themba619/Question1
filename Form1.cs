using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Question3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int firstBox_total = 0;
        public int secondBox_total = 0;
        public int thirdBox_total = 0;
        public int totalAmountDue = 0;

        private void firstGroupBox_Enter(object sender, EventArgs e)
        {
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Final amount label
        private void label2_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = totalAmountDue.ToString();
        }

        // Buttons in first group
        private void smallBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (smallBtn.Checked == true)
            {
                firstBox_total = 20;
                Update_Total_Amount_Due();
            }
        }

        private void mediumBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (mediumBtn.Checked)
            {
                firstBox_total = 35;
                Update_Total_Amount_Due(); ;
            }
        }

        private void largeBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (largeBtn.Checked)
            {
                firstBox_total = 55;
                Update_Total_Amount_Due();
            }
        }


        // Buttons in second group
        private void thickBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (thickBtn.Checked)
            {
                secondBox_total = 2;
                Update_Total_Amount_Due();
            }
        }

        private void thinBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (thinBtn.Checked)
            {
                secondBox_total = 1;
                Update_Total_Amount_Due();
            }
        }

        // Buttons in third group
        private void groupBox_CheckBoxes_Click(object sender, EventArgs e)
        {
            // Loop through GroupBoxes in groupBox
            // CheckBox c in groupBox_CheckBoxes.Controls.OfType<CheckBox>()

            // Access checkBox Controls in groupBox
            var checkedBoxes = 0;
            foreach ( var gb in groupBox_CheckBoxes.Controls.OfType<GroupBox>() )
            {
                foreach (var item in gb.Controls.OfType<CheckBox>() )
                {
                    if (item is CheckBox cb)
                    {
                        MessageBox.Show("This is a checkbox");
                        if (cb.Checked)
                        {
                            checkedBoxes++;
                        }
                    }
                }
            }
            MessageBox.Show($"{checkedBoxes} boxes are checked.");
            Update_Total_Amount_Due();
        }

        // Update total
        private void Update_Total_Amount_Due()
        {
            totalAmountDue = firstBox_total + secondBox_total + thirdBox_total;
            label2.Text = totalAmountDue.ToString();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {

        }
    }

}
