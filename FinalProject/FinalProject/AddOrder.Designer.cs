
namespace FinalProject
{
    partial class AddOrder
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PaidNoCheckBox = new System.Windows.Forms.CheckBox();
            this.PaidYesCheckBox = new System.Windows.Forms.CheckBox();
            this.AddMorebtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.RiderComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.DeliveryDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.CustomerNametxt = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Monthtxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.OrderIdtxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Backbtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Addbtn = new System.Windows.Forms.Button();
            this.productComboBox = new System.Windows.Forms.ComboBox();
            this.Quantitytxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FinalProject.Properties.Resources.download__1_;
            this.pictureBox1.Location = new System.Drawing.Point(44, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // PaidNoCheckBox
            // 
            this.PaidNoCheckBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PaidNoCheckBox.AutoSize = true;
            this.PaidNoCheckBox.Location = new System.Drawing.Point(832, 334);
            this.PaidNoCheckBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.PaidNoCheckBox.Name = "PaidNoCheckBox";
            this.PaidNoCheckBox.Size = new System.Drawing.Size(63, 29);
            this.PaidNoCheckBox.TabIndex = 53;
            this.PaidNoCheckBox.Text = "No";
            this.PaidNoCheckBox.UseVisualStyleBackColor = true;
            // 
            // PaidYesCheckBox
            // 
            this.PaidYesCheckBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PaidYesCheckBox.AutoSize = true;
            this.PaidYesCheckBox.Location = new System.Drawing.Point(589, 334);
            this.PaidYesCheckBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.PaidYesCheckBox.Name = "PaidYesCheckBox";
            this.PaidYesCheckBox.Size = new System.Drawing.Size(72, 29);
            this.PaidYesCheckBox.TabIndex = 52;
            this.PaidYesCheckBox.Text = "Yes";
            this.PaidYesCheckBox.UseVisualStyleBackColor = true;
            // 
            // AddMorebtn
            // 
            this.AddMorebtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddMorebtn.FlatAppearance.BorderSize = 2;
            this.AddMorebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddMorebtn.Location = new System.Drawing.Point(1039, 175);
            this.AddMorebtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.AddMorebtn.Name = "AddMorebtn";
            this.AddMorebtn.Size = new System.Drawing.Size(126, 38);
            this.AddMorebtn.TabIndex = 57;
            this.AddMorebtn.Text = "Add";
            this.AddMorebtn.UseVisualStyleBackColor = true;
            this.AddMorebtn.Click += new System.EventHandler(this.AddMorebtn_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel2.Controls.Add(this.Quantitytxt);
            this.panel2.Controls.Add(this.productComboBox);
            this.panel2.Controls.Add(this.AddMorebtn);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.RiderComboBox);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.DeliveryDate);
            this.panel2.Controls.Add(this.PaidNoCheckBox);
            this.panel2.Controls.Add(this.PaidYesCheckBox);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.CustomerNametxt);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.Monthtxt);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.OrderIdtxt);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(132, 234);
            this.panel2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1296, 467);
            this.panel2.TabIndex = 56;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(127, 78);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 29);
            this.label9.TabIndex = 59;
            this.label9.Text = "Select Rider";
            // 
            // RiderComboBox
            // 
            this.RiderComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RiderComboBox.FormattingEnabled = true;
            this.RiderComboBox.Items.AddRange(new object[] {
            "Small",
            "Medium",
            "Large"});
            this.RiderComboBox.Location = new System.Drawing.Point(589, 74);
            this.RiderComboBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.RiderComboBox.Name = "RiderComboBox";
            this.RiderComboBox.Size = new System.Drawing.Size(576, 32);
            this.RiderComboBox.TabIndex = 60;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(127, 137);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 29);
            this.label7.TabIndex = 57;
            this.label7.Text = "Enter Product";
            // 
            // DeliveryDate
            // 
            this.DeliveryDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DeliveryDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DeliveryDate.Location = new System.Drawing.Point(589, 426);
            this.DeliveryDate.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.DeliveryDate.Name = "DeliveryDate";
            this.DeliveryDate.Size = new System.Drawing.Size(363, 29);
            this.DeliveryDate.TabIndex = 56;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(127, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 29);
            this.label2.TabIndex = 40;
            this.label2.Text = "Select Customer";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(127, 218);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(168, 29);
            this.label8.TabIndex = 41;
            this.label8.Text = "Enter Order ID";
            // 
            // CustomerNametxt
            // 
            this.CustomerNametxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CustomerNametxt.FormattingEnabled = true;
            this.CustomerNametxt.Items.AddRange(new object[] {
            "Small",
            "Medium",
            "Large"});
            this.CustomerNametxt.Location = new System.Drawing.Point(589, 15);
            this.CustomerNametxt.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.CustomerNametxt.Name = "CustomerNametxt";
            this.CustomerNametxt.Size = new System.Drawing.Size(576, 32);
            this.CustomerNametxt.TabIndex = 51;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(127, 426);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 29);
            this.label6.TabIndex = 45;
            this.label6.Text = "Enter Date";
            // 
            // Monthtxt
            // 
            this.Monthtxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Monthtxt.Location = new System.Drawing.Point(589, 273);
            this.Monthtxt.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Monthtxt.Name = "Monthtxt";
            this.Monthtxt.Size = new System.Drawing.Size(576, 29);
            this.Monthtxt.TabIndex = 48;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(127, 273);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 29);
            this.label3.TabIndex = 42;
            this.label3.Text = "Enter Order Month";
            // 
            // OrderIdtxt
            // 
            this.OrderIdtxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OrderIdtxt.Location = new System.Drawing.Point(589, 218);
            this.OrderIdtxt.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.OrderIdtxt.Name = "OrderIdtxt";
            this.OrderIdtxt.Size = new System.Drawing.Size(576, 29);
            this.OrderIdtxt.TabIndex = 50;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(127, 332);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 29);
            this.label5.TabIndex = 44;
            this.label5.Text = "Order Paid";
            // 
            // Backbtn
            // 
            this.Backbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Backbtn.FlatAppearance.BorderSize = 2;
            this.Backbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Backbtn.Location = new System.Drawing.Point(1197, 748);
            this.Backbtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Backbtn.Name = "Backbtn";
            this.Backbtn.Size = new System.Drawing.Size(165, 59);
            this.Backbtn.TabIndex = 54;
            this.Backbtn.Text = "Back";
            this.Backbtn.UseVisualStyleBackColor = true;
            this.Backbtn.Click += new System.EventHandler(this.Backbtn_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1463, 94);
            this.panel1.TabIndex = 55;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(559, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 55);
            this.label1.TabIndex = 3;
            this.label1.Text = "Add Order";
            // 
            // Addbtn
            // 
            this.Addbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Addbtn.FlatAppearance.BorderSize = 2;
            this.Addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Addbtn.Location = new System.Drawing.Point(1021, 748);
            this.Addbtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(165, 59);
            this.Addbtn.TabIndex = 53;
            this.Addbtn.Text = "Add";
            this.Addbtn.UseVisualStyleBackColor = true;
            // 
            // productComboBox
            // 
            this.productComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.productComboBox.FormattingEnabled = true;
            this.productComboBox.Items.AddRange(new object[] {
            "Small",
            "Medium",
            "Large"});
            this.productComboBox.Location = new System.Drawing.Point(589, 134);
            this.productComboBox.Margin = new System.Windows.Forms.Padding(6);
            this.productComboBox.Name = "productComboBox";
            this.productComboBox.Size = new System.Drawing.Size(277, 32);
            this.productComboBox.TabIndex = 61;
            // 
            // Quantitytxt
            // 
            this.Quantitytxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Quantitytxt.Location = new System.Drawing.Point(889, 134);
            this.Quantitytxt.Margin = new System.Windows.Forms.Padding(6);
            this.Quantitytxt.Name = "Quantitytxt";
            this.Quantitytxt.Size = new System.Drawing.Size(276, 29);
            this.Quantitytxt.TabIndex = 62;
            // 
            // AddOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1467, 831);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Backbtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Addbtn);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddOrder";
            this.Text = "AddOrder";
            this.Load += new System.EventHandler(this.AddOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox PaidNoCheckBox;
        private System.Windows.Forms.CheckBox PaidYesCheckBox;
        private System.Windows.Forms.Button AddMorebtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker DeliveryDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox CustomerNametxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Monthtxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox OrderIdtxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Backbtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Addbtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox RiderComboBox;
        private System.Windows.Forms.ComboBox productComboBox;
        private System.Windows.Forms.TextBox Quantitytxt;
    }
}