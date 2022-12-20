
namespace FinalProject
{
    partial class ViewRider
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnViewRiderBack = new System.Windows.Forms.Button();
            this.btnViewRiderAdd = new System.Windows.Forms.Button();
            this.gvRider = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvRider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(798, 51);
            this.panel1.TabIndex = 59;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(305, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "View Rider";
            // 
            // btnViewRiderBack
            // 
            this.btnViewRiderBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnViewRiderBack.FlatAppearance.BorderSize = 2;
            this.btnViewRiderBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewRiderBack.Location = new System.Drawing.Point(684, 406);
            this.btnViewRiderBack.Name = "btnViewRiderBack";
            this.btnViewRiderBack.Size = new System.Drawing.Size(90, 32);
            this.btnViewRiderBack.TabIndex = 62;
            this.btnViewRiderBack.Text = "Back";
            this.btnViewRiderBack.UseVisualStyleBackColor = true;
            this.btnViewRiderBack.Click += new System.EventHandler(this.btnViewRiderBack_Click);
            // 
            // btnViewRiderAdd
            // 
            this.btnViewRiderAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnViewRiderAdd.FlatAppearance.BorderSize = 2;
            this.btnViewRiderAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewRiderAdd.Location = new System.Drawing.Point(588, 406);
            this.btnViewRiderAdd.Name = "btnViewRiderAdd";
            this.btnViewRiderAdd.Size = new System.Drawing.Size(90, 32);
            this.btnViewRiderAdd.TabIndex = 61;
            this.btnViewRiderAdd.Text = "Add";
            this.btnViewRiderAdd.UseVisualStyleBackColor = true;
            this.btnViewRiderAdd.Click += new System.EventHandler(this.btnViewRiderAdd_Click);
            // 
            // gvRider
            // 
            this.gvRider.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.gvRider.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gvRider.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvRider.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Count,
            this.Column8,
            this.Column9});
            this.gvRider.Location = new System.Drawing.Point(25, 87);
            this.gvRider.Name = "gvRider";
            this.gvRider.Size = new System.Drawing.Size(749, 295);
            this.gvRider.TabIndex = 60;
            this.gvRider.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvRider_CellContentClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(24, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Count
            // 
            this.Count.HeaderText = "Count";
            this.Count.Name = "Count";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Edit";
            this.Column8.Name = "Column8";
            this.Column8.Text = "Edit";
            this.Column8.UseColumnTextForButtonValue = true;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Delete";
            this.Column9.Name = "Column9";
            this.Column9.Text = "Delete";
            this.Column9.UseColumnTextForButtonValue = true;
            // 
            // ViewRider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnViewRiderBack);
            this.Controls.Add(this.btnViewRiderAdd);
            this.Controls.Add(this.gvRider);
            this.Name = "ViewRider";
            this.Text = "ViewRider";
            this.Load += new System.EventHandler(this.ViewRider_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvRider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnViewRiderBack;
        private System.Windows.Forms.Button btnViewRiderAdd;
        private System.Windows.Forms.DataGridView gvRider;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
        private System.Windows.Forms.DataGridViewButtonColumn Column8;
        private System.Windows.Forms.DataGridViewButtonColumn Column9;
    }
}