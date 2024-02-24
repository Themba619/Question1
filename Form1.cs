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

            foreach (var checkbox in groupBox_CheckBoxes.Controls.OfType<CheckBox>())
            {
                checkbox.CheckedChanged += groupBox_CheckBoxes_CheckedChange;
            }
        }

        public int firstBox_total = 0;
        public int secondBox_total = 0;
        public int thirdBox_total = 0;
        public int totalAmountDue = 0;


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
        private void groupBox_CheckBoxes_CheckedChange(object sender, EventArgs e)
        {
            thirdBox_total = 0;
            // Loop through GroupBoxes in groupBox
            // CheckBox c in groupBox_CheckBoxes.Controls.OfType<CheckBox>()

            // Access checkBox Controls in groupBox
            foreach (var item in groupBox_CheckBoxes.Controls.OfType<CheckBox>())
            {
                if (item.Checked)
                {
                    thirdBox_total += 7;
                }
            }
            Update_Total_Amount_Due();
        }

        // Update total
        private void Update_Total_Amount_Due()
        {
            totalAmountDue = firstBox_total + secondBox_total + thirdBox_total;
            label2.Text = totalAmountDue.ToString();
        }
    }

}
