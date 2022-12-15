
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
            this.txtDeliveryDate = new System.Windows.Forms.TextBox();
            this.txtRidrName = new System.Windows.Forms.TextBox();
            this.checkDeliveredYes = new System.Windows.Forms.CheckBox();
            this.checkPaidNo = new System.Windows.Forms.CheckBox();
            this.checkDeliveredNo = new System.Windows.Forms.CheckBox();
            this.checkPaidYes = new System.Windows.Forms.CheckBox();
            this.lblOrderPaid = new System.Windows.Forms.Label();
            this.lblOrderDelivered = new System.Windows.Forms.Label();
            this.lblDeliveryDate = new System.Windows.Forms.Label();
            this.lblRider = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtOrderId = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtCNIC = new System.Windows.Forms.TextBox();
            this.txtMonth = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lblCNIC = new System.Windows.Forms.Label();
            this.lblOrderId = new System.Windows.Forms.Label();
            this.lblAddProduct = new System.Windows.Forms.Label();
            this.lblMonth = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtDeliveryDate
            // 
            this.txtDeliveryDate.Location = new System.Drawing.Point(567, 436);
            this.txtDeliveryDate.Name = "txtDeliveryDate";
            this.txtDeliveryDate.Size = new System.Drawing.Size(480, 29);
            this.txtDeliveryDate.TabIndex = 79;
            // 
            // txtRidrName
            // 
            this.txtRidrName.Location = new System.Drawing.Point(567, 509);
            this.txtRidrName.Name = "txtRidrName";
            this.txtRidrName.Size = new System.Drawing.Size(480, 29);
            this.txtRidrName.TabIndex = 78;
            // 
            // checkDeliveredYes
            // 
            this.checkDeliveredYes.AutoSize = true;
            this.checkDeliveredYes.Location = new System.Drawing.Point(567, 647);
            this.checkDeliveredYes.Name = "checkDeliveredYes";
            this.checkDeliveredYes.Size = new System.Drawing.Size(72, 29);
            this.checkDeliveredYes.TabIndex = 77;
            this.checkDeliveredYes.Text = "Yes";
            this.checkDeliveredYes.UseVisualStyleBackColor = true;
            // 
            // checkPaidNo
            // 
            this.checkPaidNo.AutoSize = true;
            this.checkPaidNo.Location = new System.Drawing.Point(727, 581);
            this.checkPaidNo.Name = "checkPaidNo";
            this.checkPaidNo.Size = new System.Drawing.Size(63, 29);
            this.checkPaidNo.TabIndex = 76;
            this.checkPaidNo.Text = "No";
            this.checkPaidNo.UseVisualStyleBackColor = true;
            // 
            // checkDeliveredNo
            // 
            this.checkDeliveredNo.AutoSize = true;
            this.checkDeliveredNo.Location = new System.Drawing.Point(727, 647);
            this.checkDeliveredNo.Name = "checkDeliveredNo";
            this.checkDeliveredNo.Size = new System.Drawing.Size(63, 29);
            this.checkDeliveredNo.TabIndex = 75;
            this.checkDeliveredNo.Text = "No";
            this.checkDeliveredNo.UseVisualStyleBackColor = true;
            // 
            // checkPaidYes
            // 
            this.checkPaidYes.AutoSize = true;
            this.checkPaidYes.Location = new System.Drawing.Point(567, 581);
            this.checkPaidYes.Name = "checkPaidYes";
            this.checkPaidYes.Size = new System.Drawing.Size(72, 29);
            this.checkPaidYes.TabIndex = 74;
            this.checkPaidYes.Text = "Yes";
            this.checkPaidYes.UseVisualStyleBackColor = true;
            // 
            // lblOrderPaid
            // 
            this.lblOrderPaid.AutoSize = true;
            this.lblOrderPaid.Location = new System.Drawing.Point(100, 582);
            this.lblOrderPaid.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblOrderPaid.Name = "lblOrderPaid";
            this.lblOrderPaid.Size = new System.Drawing.Size(112, 25);
            this.lblOrderPaid.TabIndex = 73;
            this.lblOrderPaid.Text = "Order Paid:";
            // 
            // lblOrderDelivered
            // 
            this.lblOrderDelivered.AutoSize = true;
            this.lblOrderDelivered.Location = new System.Drawing.Point(100, 651);
            this.lblOrderDelivered.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblOrderDelivered.Name = "lblOrderDelivered";
            this.lblOrderDelivered.Size = new System.Drawing.Size(155, 25);
            this.lblOrderDelivered.TabIndex = 72;
            this.lblOrderDelivered.Text = "Order Delivered:";
            // 
            // lblDeliveryDate
            // 
            this.lblDeliveryDate.AutoSize = true;
            this.lblDeliveryDate.Location = new System.Drawing.Point(100, 454);
            this.lblDeliveryDate.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDeliveryDate.Name = "lblDeliveryDate";
            this.lblDeliveryDate.Size = new System.Drawing.Size(185, 25);
            this.lblDeliveryDate.TabIndex = 71;
            this.lblDeliveryDate.Text = "Enter Delivery Date:";
            // 
            // lblRider
            // 
            this.lblRider.AutoSize = true;
            this.lblRider.Location = new System.Drawing.Point(100, 524);
            this.lblRider.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblRider.Name = "lblRider";
            this.lblRider.Size = new System.Drawing.Size(171, 25);
            this.lblRider.TabIndex = 70;
            this.lblRider.Text = "Enter Rider Name:";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(1115, 694);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(144, 47);
            this.btnEdit.TabIndex = 69;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(1283, 694);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(144, 47);
            this.btnBack.TabIndex = 68;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // txtOrderId
            // 
            this.txtOrderId.Location = new System.Drawing.Point(567, 105);
            this.txtOrderId.Name = "txtOrderId";
            this.txtOrderId.Size = new System.Drawing.Size(480, 29);
            this.txtOrderId.TabIndex = 67;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(567, 192);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(480, 29);
            this.txtProductName.TabIndex = 66;
            // 
            // txtCNIC
            // 
            this.txtCNIC.Location = new System.Drawing.Point(567, 374);
            this.txtCNIC.Name = "txtCNIC";
            this.txtCNIC.Size = new System.Drawing.Size(480, 29);
            this.txtCNIC.TabIndex = 65;
            // 
            // txtMonth
            // 
            this.txtMonth.Location = new System.Drawing.Point(567, 273);
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Size = new System.Drawing.Size(480, 29);
            this.txtMonth.TabIndex = 64;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(567, 7);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(480, 29);
            this.txtCustomerName.TabIndex = 63;
            // 
            // lblCNIC
            // 
            this.lblCNIC.AutoSize = true;
            this.lblCNIC.Location = new System.Drawing.Point(100, 378);
            this.lblCNIC.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCNIC.Name = "lblCNIC";
            this.lblCNIC.Size = new System.Drawing.Size(118, 25);
            this.lblCNIC.TabIndex = 62;
            this.lblCNIC.Text = "Enter CNIC:";
            // 
            // lblOrderId
            // 
            this.lblOrderId.AutoSize = true;
            this.lblOrderId.Location = new System.Drawing.Point(100, 105);
            this.lblOrderId.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblOrderId.Name = "lblOrderId";
            this.lblOrderId.Size = new System.Drawing.Size(143, 25);
            this.lblOrderId.TabIndex = 61;
            this.lblOrderId.Text = "Enter Order ID:";
            // 
            // lblAddProduct
            // 
            this.lblAddProduct.AutoSize = true;
            this.lblAddProduct.Location = new System.Drawing.Point(100, 192);
            this.lblAddProduct.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblAddProduct.Name = "lblAddProduct";
            this.lblAddProduct.Size = new System.Drawing.Size(193, 25);
            this.lblAddProduct.TabIndex = 60;
            this.lblAddProduct.Text = "Enter Product Name:";
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Location = new System.Drawing.Point(100, 279);
            this.lblMonth.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(124, 25);
            this.lblMonth.TabIndex = 59;
            this.lblMonth.Text = "Enter Month:";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(100, 13);
            this.lblCustomerName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(154, 25);
            this.lblCustomerName.TabIndex = 58;
            this.lblCustomerName.Text = "Enter Customer:";
            // 
            // EditOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1547, 845);
            this.Controls.Add(this.txtDeliveryDate);
            this.Controls.Add(this.txtRidrName);
            this.Controls.Add(this.checkDeliveredYes);
            this.Controls.Add(this.checkPaidNo);
            this.Controls.Add(this.checkDeliveredNo);
            this.Controls.Add(this.checkPaidYes);
            this.Controls.Add(this.lblOrderPaid);
            this.Controls.Add(this.lblOrderDelivered);
            this.Controls.Add(this.lblDeliveryDate);
            this.Controls.Add(this.lblRider);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtOrderId);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.txtCNIC);
            this.Controls.Add(this.txtMonth);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.lblCNIC);
            this.Controls.Add(this.lblOrderId);
            this.Controls.Add(this.lblAddProduct);
            this.Controls.Add(this.lblMonth);
            this.Controls.Add(this.lblCustomerName);
            this.Name = "EditOrder";
            this.Text = "EditOrder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDeliveryDate;
        private System.Windows.Forms.TextBox txtRidrName;
        private System.Windows.Forms.CheckBox checkDeliveredYes;
        private System.Windows.Forms.CheckBox checkPaidNo;
        private System.Windows.Forms.CheckBox checkDeliveredNo;
        private System.Windows.Forms.CheckBox checkPaidYes;
        private System.Windows.Forms.Label lblOrderPaid;
        private System.Windows.Forms.Label lblOrderDelivered;
        private System.Windows.Forms.Label lblDeliveryDate;
        private System.Windows.Forms.Label lblRider;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtOrderId;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtCNIC;
        private System.Windows.Forms.TextBox txtMonth;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lblCNIC;
        private System.Windows.Forms.Label lblOrderId;
        private System.Windows.Forms.Label lblAddProduct;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.Label lblCustomerName;
    }
}