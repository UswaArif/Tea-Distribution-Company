
namespace Email
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
            this.Totxt = new System.Windows.Forms.TextBox();
            this.Subjecttxt = new System.Windows.Forms.TextBox();
            this.Bodytxt = new System.Windows.Forms.TextBox();
            this.sendbtn = new System.Windows.Forms.Button();
            this.lblSendEmail = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblBody = new System.Windows.Forms.Label();
            this.lblSubject = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Totxt
            // 
            this.Totxt.Location = new System.Drawing.Point(157, 104);
            this.Totxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Totxt.Multiline = true;
            this.Totxt.Name = "Totxt";
            this.Totxt.Size = new System.Drawing.Size(341, 33);
            this.Totxt.TabIndex = 0;
            // 
            // Subjecttxt
            // 
            this.Subjecttxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subjecttxt.Location = new System.Drawing.Point(157, 153);
            this.Subjecttxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Subjecttxt.Multiline = true;
            this.Subjecttxt.Name = "Subjecttxt";
            this.Subjecttxt.Size = new System.Drawing.Size(341, 33);
            this.Subjecttxt.TabIndex = 1;
            // 
            // Bodytxt
            // 
            this.Bodytxt.Location = new System.Drawing.Point(157, 228);
            this.Bodytxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Bodytxt.Multiline = true;
            this.Bodytxt.Name = "Bodytxt";
            this.Bodytxt.Size = new System.Drawing.Size(421, 165);
            this.Bodytxt.TabIndex = 2;
            // 
            // sendbtn
            // 
            this.sendbtn.Location = new System.Drawing.Point(606, 419);
            this.sendbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sendbtn.Name = "sendbtn";
            this.sendbtn.Size = new System.Drawing.Size(87, 26);
            this.sendbtn.TabIndex = 3;
            this.sendbtn.Text = "Send";
            this.sendbtn.UseVisualStyleBackColor = true;
            this.sendbtn.Click += new System.EventHandler(this.sendbtn_Click);
            // 
            // lblSendEmail
            // 
            this.lblSendEmail.AutoSize = true;
            this.lblSendEmail.BackColor = System.Drawing.SystemColors.Window;
            this.lblSendEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSendEmail.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblSendEmail.Location = new System.Drawing.Point(280, 9);
            this.lblSendEmail.Name = "lblSendEmail";
            this.lblSendEmail.Size = new System.Drawing.Size(218, 42);
            this.lblSendEmail.TabIndex = 6;
            this.lblSendEmail.Text = "Send Email";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Email.Properties.Resources.download;
            this.pictureBox2.Location = new System.Drawing.Point(-3, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(68, 62);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Email.Properties.Resources.download__1_;
            this.pictureBox1.Location = new System.Drawing.Point(-3, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(806, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // lblBody
            // 
            this.lblBody.AutoSize = true;
            this.lblBody.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBody.Location = new System.Drawing.Point(62, 228);
            this.lblBody.Name = "lblBody";
            this.lblBody.Size = new System.Drawing.Size(58, 24);
            this.lblBody.TabIndex = 11;
            this.lblBody.Text = "Body:";
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubject.Location = new System.Drawing.Point(62, 162);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(78, 24);
            this.lblSubject.TabIndex = 10;
            this.lblSubject.Text = "Subject:";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTo.Location = new System.Drawing.Point(62, 113);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(38, 24);
            this.lblTo.TabIndex = 9;
            this.lblTo.Text = "To:";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(705, 419);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(87, 26);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 456);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblBody);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.lblSendEmail);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.sendbtn);
            this.Controls.Add(this.Bodytxt);
            this.Controls.Add(this.Subjecttxt);
            this.Controls.Add(this.Totxt);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Totxt;
        private System.Windows.Forms.TextBox Subjecttxt;
        private System.Windows.Forms.TextBox Bodytxt;
        private System.Windows.Forms.Button sendbtn;
        private System.Windows.Forms.Label lblSendEmail;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblBody;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Button btnBack;
    }
}

