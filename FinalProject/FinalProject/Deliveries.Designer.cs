
namespace FinalProject
{
    partial class Deliveries
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
            this.Backbtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DeliveredProductstxt = new System.Windows.Forms.Button();
            this.Orderstxt = new System.Windows.Forms.Button();
            this.EndDaytxt = new System.Windows.Forms.Button();
            this.StartDaytxt = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Backbtn
            // 
            this.Backbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Backbtn.FlatAppearance.BorderSize = 2;
            this.Backbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Backbtn.Location = new System.Drawing.Point(689, 405);
            this.Backbtn.Name = "Backbtn";
            this.Backbtn.Size = new System.Drawing.Size(90, 32);
            this.Backbtn.TabIndex = 68;
            this.Backbtn.Text = "Back";
            this.Backbtn.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(798, 51);
            this.panel1.TabIndex = 69;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FinalProject.Properties.Resources.download__1_;
            this.pictureBox1.Location = new System.Drawing.Point(24, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(324, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Deliveries";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel2.Controls.Add(this.DeliveredProductstxt);
            this.panel2.Controls.Add(this.Orderstxt);
            this.panel2.Controls.Add(this.EndDaytxt);
            this.panel2.Controls.Add(this.StartDaytxt);
            this.panel2.Location = new System.Drawing.Point(287, 97);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(211, 287);
            this.panel2.TabIndex = 70;
            // 
            // DeliveredProductstxt
            // 
            this.DeliveredProductstxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DeliveredProductstxt.FlatAppearance.BorderSize = 2;
            this.DeliveredProductstxt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeliveredProductstxt.Location = new System.Drawing.Point(60, 225);
            this.DeliveredProductstxt.Name = "DeliveredProductstxt";
            this.DeliveredProductstxt.Size = new System.Drawing.Size(90, 38);
            this.DeliveredProductstxt.TabIndex = 72;
            this.DeliveredProductstxt.Text = "Delivered Products";
            this.DeliveredProductstxt.UseVisualStyleBackColor = true;
            // 
            // Orderstxt
            // 
            this.Orderstxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Orderstxt.FlatAppearance.BorderSize = 2;
            this.Orderstxt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Orderstxt.Location = new System.Drawing.Point(60, 156);
            this.Orderstxt.Name = "Orderstxt";
            this.Orderstxt.Size = new System.Drawing.Size(90, 32);
            this.Orderstxt.TabIndex = 73;
            this.Orderstxt.Text = "Total Orders";
            this.Orderstxt.UseVisualStyleBackColor = true;
            // 
            // EndDaytxt
            // 
            this.EndDaytxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EndDaytxt.FlatAppearance.BorderSize = 2;
            this.EndDaytxt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EndDaytxt.Location = new System.Drawing.Point(60, 93);
            this.EndDaytxt.Name = "EndDaytxt";
            this.EndDaytxt.Size = new System.Drawing.Size(90, 32);
            this.EndDaytxt.TabIndex = 74;
            this.EndDaytxt.Text = "End Day";
            this.EndDaytxt.UseVisualStyleBackColor = true;
            // 
            // StartDaytxt
            // 
            this.StartDaytxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StartDaytxt.FlatAppearance.BorderSize = 2;
            this.StartDaytxt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartDaytxt.Location = new System.Drawing.Point(60, 30);
            this.StartDaytxt.Name = "StartDaytxt";
            this.StartDaytxt.Size = new System.Drawing.Size(90, 32);
            this.StartDaytxt.TabIndex = 75;
            this.StartDaytxt.Text = "Start Day";
            this.StartDaytxt.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::FinalProject.Properties.Resources._3022495;
            this.pictureBox2.Location = new System.Drawing.Point(619, 128);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(160, 163);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 71;
            this.pictureBox2.TabStop = false;
            // 
            // Deliveries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Backbtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Deliveries";
            this.Text = "Deliveries";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Backbtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button DeliveredProductstxt;
        private System.Windows.Forms.Button Orderstxt;
        private System.Windows.Forms.Button EndDaytxt;
        private System.Windows.Forms.Button StartDaytxt;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}