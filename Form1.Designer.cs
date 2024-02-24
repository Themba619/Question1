namespace Question3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.firstGroupBox = new System.Windows.Forms.GroupBox();
            this.mediumBtn = new System.Windows.Forms.RadioButton();
            this.largeBtn = new System.Windows.Forms.RadioButton();
            this.smallBtn = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.thinBtn = new System.Windows.Forms.RadioButton();
            this.thickBtn = new System.Windows.Forms.RadioButton();
            this.amountDueLabel = new System.Windows.Forms.Label();
            this.Amount_lbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox_CheckBoxes = new System.Windows.Forms.GroupBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.firstGroupBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox_CheckBoxes.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(218, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(454, 108);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pizza Hut";
            // 
            // firstGroupBox
            // 
            this.firstGroupBox.Controls.Add(this.mediumBtn);
            this.firstGroupBox.Controls.Add(this.largeBtn);
            this.firstGroupBox.Controls.Add(this.smallBtn);
            this.firstGroupBox.Location = new System.Drawing.Point(23, 170);
            this.firstGroupBox.Name = "firstGroupBox";
            this.firstGroupBox.Size = new System.Drawing.Size(622, 100);
            this.firstGroupBox.TabIndex = 3;
            this.firstGroupBox.TabStop = false;
            this.firstGroupBox.Enter += new System.EventHandler(this.firstGroupBox_Enter);
            // 
            // mediumBtn
            // 
            this.mediumBtn.AutoSize = true;
            this.mediumBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mediumBtn.Location = new System.Drawing.Point(235, 35);
            this.mediumBtn.Name = "mediumBtn";
            this.mediumBtn.Size = new System.Drawing.Size(175, 30);
            this.mediumBtn.TabIndex = 3;
            this.mediumBtn.TabStop = true;
            this.mediumBtn.Text = "Medium (R35)";
            this.mediumBtn.UseVisualStyleBackColor = true;
            this.mediumBtn.CheckedChanged += new System.EventHandler(this.mediumBtn_CheckedChanged);
            // 
            // largeBtn
            // 
            this.largeBtn.AutoSize = true;
            this.largeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.largeBtn.Location = new System.Drawing.Point(464, 38);
            this.largeBtn.Name = "largeBtn";
            this.largeBtn.Size = new System.Drawing.Size(152, 30);
            this.largeBtn.TabIndex = 2;
            this.largeBtn.TabStop = true;
            this.largeBtn.Text = "Large (R55)";
            this.largeBtn.UseVisualStyleBackColor = true;
            this.largeBtn.CheckedChanged += new System.EventHandler(this.largeBtn_CheckedChanged);
            // 
            // smallBtn
            // 
            this.smallBtn.AutoSize = true;
            this.smallBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smallBtn.Location = new System.Drawing.Point(23, 38);
            this.smallBtn.Name = "smallBtn";
            this.smallBtn.Size = new System.Drawing.Size(153, 30);
            this.smallBtn.TabIndex = 0;
            this.smallBtn.TabStop = true;
            this.smallBtn.Text = "Small (R20)";
            this.smallBtn.UseVisualStyleBackColor = true;
            this.smallBtn.CheckedChanged += new System.EventHandler(this.smallBtn_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.thinBtn);
            this.groupBox2.Controls.Add(this.thickBtn);
            this.groupBox2.Location = new System.Drawing.Point(23, 292);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(622, 100);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // thinBtn
            // 
            this.thinBtn.AutoSize = true;
            this.thinBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thinBtn.Location = new System.Drawing.Point(376, 38);
            this.thinBtn.Name = "thinBtn";
            this.thinBtn.Size = new System.Drawing.Size(126, 30);
            this.thinBtn.TabIndex = 2;
            this.thinBtn.TabStop = true;
            this.thinBtn.Text = "Thin (R1)";
            this.thinBtn.UseVisualStyleBackColor = true;
            this.thinBtn.CheckedChanged += new System.EventHandler(this.thinBtn_CheckedChanged);
            // 
            // thickBtn
            // 
            this.thickBtn.AutoSize = true;
            this.thickBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thickBtn.Location = new System.Drawing.Point(92, 38);
            this.thickBtn.Name = "thickBtn";
            this.thickBtn.Size = new System.Drawing.Size(136, 30);
            this.thickBtn.TabIndex = 0;
            this.thickBtn.TabStop = true;
            this.thickBtn.Text = "Thick (R2)";
            this.thickBtn.UseVisualStyleBackColor = true;
            this.thickBtn.CheckedChanged += new System.EventHandler(this.thickBtn_CheckedChanged);
            // 
            // amountDueLabel
            // 
            this.amountDueLabel.AutoSize = true;
            this.amountDueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountDueLabel.Location = new System.Drawing.Point(152, 675);
            this.amountDueLabel.Name = "amountDueLabel";
            this.amountDueLabel.Size = new System.Drawing.Size(162, 26);
            this.amountDueLabel.TabIndex = 6;
            this.amountDueLabel.Text = "Amount Due: R";
            // 
            // Amount_lbl
            // 
            this.Amount_lbl.AutoSize = true;
            this.Amount_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Amount_lbl.Location = new System.Drawing.Point(320, 675);
            this.Amount_lbl.Name = "Amount_lbl";
            this.Amount_lbl.Size = new System.Drawing.Size(0, 26);
            this.Amount_lbl.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(306, 675);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 26);
            this.label2.TabIndex = 9;
            this.label2.Text = "label2";
            this.label2.Click += new System.EventHandler(this.label2_CheckedChanged);
            // 
            // groupBox_CheckBoxes
            // 
            this.groupBox_CheckBoxes.Controls.Add(this.checkBox9);
            this.groupBox_CheckBoxes.Controls.Add(this.checkBox8);
            this.groupBox_CheckBoxes.Controls.Add(this.checkBox7);
            this.groupBox_CheckBoxes.Controls.Add(this.checkBox6);
            this.groupBox_CheckBoxes.Controls.Add(this.checkBox5);
            this.groupBox_CheckBoxes.Controls.Add(this.checkBox4);
            this.groupBox_CheckBoxes.Controls.Add(this.checkBox3);
            this.groupBox_CheckBoxes.Controls.Add(this.checkBox2);
            this.groupBox_CheckBoxes.Controls.Add(this.checkBox1);
            this.groupBox_CheckBoxes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_CheckBoxes.Location = new System.Drawing.Point(23, 424);
            this.groupBox_CheckBoxes.Name = "groupBox_CheckBoxes";
            this.groupBox_CheckBoxes.Size = new System.Drawing.Size(622, 237);
            this.groupBox_CheckBoxes.TabIndex = 10;
            this.groupBox_CheckBoxes.TabStop = false;
            this.groupBox_CheckBoxes.Text = "Toppings (each @ R7)";
            this.groupBox_CheckBoxes.Enter += new System.EventHandler(this.groupBox_CheckBoxes_Click);
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Location = new System.Drawing.Point(412, 177);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(185, 30);
            this.checkBox9.TabIndex = 8;
            this.checkBox9.Text = "Grounded Beef";
            this.checkBox9.UseVisualStyleBackColor = true;
            this.checkBox9.CheckedChanged += new System.EventHandler(this.checkBox9_CheckedChanged);
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(412, 117);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(210, 30);
            this.checkBox8.TabIndex = 7;
            this.checkBox8.Text = "Shedded Chicken";
            this.checkBox8.UseVisualStyleBackColor = true;
            this.checkBox8.CheckedChanged += new System.EventHandler(this.checkBox8_CheckedChanged);
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(412, 56);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(117, 30);
            this.checkBox7.TabIndex = 6;
            this.checkBox7.Text = "Spinach";
            this.checkBox7.UseVisualStyleBackColor = true;
            this.checkBox7.CheckedChanged += new System.EventHandler(this.checkBox7_CheckedChanged);
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(220, 177);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(166, 30);
            this.checkBox6.TabIndex = 5;
            this.checkBox6.Text = "Dried Shrimp";
            this.checkBox6.UseVisualStyleBackColor = true;
            this.checkBox6.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(220, 117);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(135, 30);
            this.checkBox5.TabIndex = 4;
            this.checkBox5.Text = "Pineapple";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(220, 56);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(126, 30);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "Jalapeno";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(23, 177);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(141, 30);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "Mushroom";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(23, 117);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(170, 30);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Extra Cheese";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(23, 56);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(137, 30);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Pepperoni";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 709);
            this.Controls.Add(this.groupBox_CheckBoxes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Amount_lbl);
            this.Controls.Add(this.amountDueLabel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.firstGroupBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.firstGroupBox.ResumeLayout(false);
            this.firstGroupBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox_CheckBoxes.ResumeLayout(false);
            this.groupBox_CheckBoxes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox firstGroupBox;
        private System.Windows.Forms.RadioButton largeBtn;
        private System.Windows.Forms.RadioButton smallBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton thinBtn;
        private System.Windows.Forms.RadioButton thickBtn;
        private System.Windows.Forms.Label amountDueLabel;
        private System.Windows.Forms.Label Amount_lbl;
        private System.Windows.Forms.RadioButton mediumBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox_CheckBoxes;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
    }
}

