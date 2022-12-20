
namespace FinalProject
{
    partial class EditOrder
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
            this.label1 = new System.Windows.Forms.Label();
            this.Backbtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Editbtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.RiderComboBox = new System.Windows.Forms.ComboBox();
            this.Quantitytxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.DeliveryDate = new System.Windows.Forms.DateTimePicker();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.PaidYesCheckBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.CustomerComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Monthtxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.OrderIdtxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ProductComboBox = new System.Windows.Forms.ComboBox();
            this.AddMorebtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
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
            this.label1.Size = new System.Drawing.Size(252, 55);
            this.label1.TabIndex = 3;
            this.label1.Text = "Edit Order";
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
            this.Backbtn.TabIndex = 59;
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
            this.panel1.TabIndex = 60;
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
            // Editbtn
            // 
            this.Editbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Editbtn.FlatAppearance.BorderSize = 2;
            this.Editbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Editbtn.Location = new System.Drawing.Point(1021, 748);
            this.Editbtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Editbtn.Name = "Editbtn";
            this.Editbtn.Size = new System.Drawing.Size(165, 59);
            this.Editbtn.TabIndex = 58;
            this.Editbtn.Text = "Edit";
            this.Editbtn.UseVisualStyleBackColor = true;
            this.Editbtn.Click += new System.EventHandler(this.Editbtn_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel2.Controls.Add(this.AddMorebtn);
            this.panel2.Controls.Add(this.ProductComboBox);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.RiderComboBox);
            this.panel2.Controls.Add(this.Quantitytxt);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.DeliveryDate);
            this.panel2.Controls.Add(this.checkBox2);
            this.panel2.Controls.Add(this.PaidYesCheckBox);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.CustomerComboBox);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.Monthtxt);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.OrderIdtxt);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(119, 210);
            this.panel2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1230, 477);
            this.panel2.TabIndex = 61;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(94, 83);
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
            this.RiderComboBox.Location = new System.Drawing.Point(556, 79);
            this.RiderComboBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.RiderComboBox.Name = "RiderComboBox";
            this.RiderComboBox.Size = new System.Drawing.Size(576, 32);
            this.RiderComboBox.TabIndex = 60;
            // 
            // Quantitytxt
            // 
            this.Quantitytxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Quantitytxt.Location = new System.Drawing.Point(879, 142);
            this.Quantitytxt.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Quantitytxt.Name = "Quantitytxt";
            this.Quantitytxt.Size = new System.Drawing.Size(253, 29);
            this.Quantitytxt.TabIndex = 58;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(94, 142);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 29);
            this.label7.TabIndex = 57;
            this.label7.Text = "Enter Product";
            // 
            // DeliveryDate
            // 
            this.DeliveryDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DeliveryDate.Location = new System.Drawing.Point(556, 437);
            this.DeliveryDate.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.DeliveryDate.Name = "DeliveryDate";
            this.DeliveryDate.Size = new System.Drawing.Size(363, 29);
            this.DeliveryDate.TabIndex = 56;
            // 
            // checkBox2
            // 
            this.checkBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(799, 345);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(63, 29);
            this.checkBox2.TabIndex = 53;
            this.checkBox2.Text = "No";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // PaidYesCheckBox
            // 
            this.PaidYesCheckBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PaidYesCheckBox.AutoSize = true;
            this.PaidYesCheckBox.Location = new System.Drawing.Point(556, 345);
            this.PaidYesCheckBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.PaidYesCheckBox.Name = "PaidYesCheckBox";
            this.PaidYesCheckBox.Size = new System.Drawing.Size(72, 29);
            this.PaidYesCheckBox.TabIndex = 52;
            this.PaidYesCheckBox.Text = "Yes";
            this.PaidYesCheckBox.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(94, 27);
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
            this.label8.Location = new System.Drawing.Point(94, 229);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(168, 29);
            this.label8.TabIndex = 41;
            this.label8.Text = "Enter Order ID";
            // 
            // CustomerComboBox
            // 
            this.CustomerComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CustomerComboBox.FormattingEnabled = true;
            this.CustomerComboBox.Items.AddRange(new object[] {
            "Small",
            "Medium",
            "Large"});
            this.CustomerComboBox.Location = new System.Drawing.Point(556, 20);
            this.CustomerComboBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.CustomerComboBox.Name = "CustomerComboBox";
            this.CustomerComboBox.Size = new System.Drawing.Size(576, 32);
            this.CustomerComboBox.TabIndex = 51;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(94, 437);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 29);
            this.label6.TabIndex = 45;
            this.label6.Text = "Enter Date";
            // 
            // Monthtxt
            // 
            this.Monthtxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Monthtxt.Location = new System.Drawing.Point(556, 284);
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
            this.label3.Location = new System.Drawing.Point(94, 284);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 29);
            this.label3.TabIndex = 42;
            this.label3.Text = "Enter Order Month";
            // 
            // OrderIdtxt
            // 
            this.OrderIdtxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OrderIdtxt.Location = new System.Drawing.Point(556, 229);
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
            this.label5.Location = new System.Drawing.Point(94, 343);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 29);
            this.label5.TabIndex = 44;
            this.label5.Text = "Order Paid";
            // 
            // ProductComboBox
            // 
            this.ProductComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ProductComboBox.FormattingEnabled = true;
            this.ProductComboBox.Items.AddRange(new object[] {
            "Small",
            "Medium",
            "Large"});
            this.ProductComboBox.Location = new System.Drawing.Point(556, 139);
            this.ProductComboBox.Margin = new System.Windows.Forms.Padding(6);
            this.ProductComboBox.Name = "ProductComboBox";
            this.ProductComboBox.Size = new System.Drawing.Size(245, 32);
            this.ProductComboBox.TabIndex = 61;
            // 
            // AddMorebtn
            // 
            this.AddMorebtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddMorebtn.FlatAppearance.BorderSize = 2;
            this.AddMorebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddMorebtn.Location = new System.Drawing.Point(1006, 179);
            this.AddMorebtn.Margin = new System.Windows.Forms.Padding(6);
            this.AddMorebtn.Name = "AddMorebtn";
            this.AddMorebtn.Size = new System.Drawing.Size(126, 38);
            this.AddMorebtn.TabIndex = 62;
            this.AddMorebtn.Text = "Add";
            this.AddMorebtn.UseVisualStyleBackColor = true;
            this.AddMorebtn.Click += new System.EventHandler(this.AddMorebtn_Click);
            // 
            // EditOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1467, 831);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Backbtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Editbtn);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "EditOrder";
            this.Text = "EditOrder";
            this.Load += new System.EventHandler(this.EditOrder_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Backbtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Editbtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox RiderComboBox;
        private System.Windows.Forms.TextBox Quantitytxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker DeliveryDate;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox PaidYesCheckBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox CustomerComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Monthtxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox OrderIdtxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ProductComboBox;
        private System.Windows.Forms.Button AddMorebtn;
    }
}