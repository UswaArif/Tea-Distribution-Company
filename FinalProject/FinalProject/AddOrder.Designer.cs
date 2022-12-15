
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
            this.btnAdd = new System.Windows.Forms.Button();
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
            this.txtDeliveryDate.Location = new System.Drawing.Point(536, 470);
            this.txtDeliveryDate.Name = "txtDeliveryDate";
            this.txtDeliveryDate.Size = new System.Drawing.Size(480, 29);
            this.txtDeliveryDate.TabIndex = 57;
            // 
            // txtRidrName
            // 
            this.txtRidrName.Location = new System.Drawing.Point(536, 543);
            this.txtRidrName.Name = "txtRidrName";
            this.txtRidrName.Size = new System.Drawing.Size(480, 29);
            this.txtRidrName.TabIndex = 56;
            // 
            // checkDeliveredYes
            // 
            this.checkDeliveredYes.AutoSize = true;
            this.checkDeliveredYes.Location = new System.Drawing.Point(536, 681);
            this.checkDeliveredYes.Name = "checkDeliveredYes";
            this.checkDeliveredYes.Size = new System.Drawing.Size(72, 29);
            this.checkDeliveredYes.TabIndex = 55;
            this.checkDeliveredYes.Text = "Yes";
            this.checkDeliveredYes.UseVisualStyleBackColor = true;
            // 
            // checkPaidNo
            // 
            this.checkPaidNo.AutoSize = true;
            this.checkPaidNo.Location = new System.Drawing.Point(696, 615);
            this.checkPaidNo.Name = "checkPaidNo";
            this.checkPaidNo.Size = new System.Drawing.Size(63, 29);
            this.checkPaidNo.TabIndex = 54;
            this.checkPaidNo.Text = "No";
            this.checkPaidNo.UseVisualStyleBackColor = true;
            // 
            // checkDeliveredNo
            // 
            this.checkDeliveredNo.AutoSize = true;
            this.checkDeliveredNo.Location = new System.Drawing.Point(696, 681);
            this.checkDeliveredNo.Name = "checkDeliveredNo";
            this.checkDeliveredNo.Size = new System.Drawing.Size(63, 29);
            this.checkDeliveredNo.TabIndex = 53;
            this.checkDeliveredNo.Text = "No";
            this.checkDeliveredNo.UseVisualStyleBackColor = true;
            // 
            // checkPaidYes
            // 
            this.checkPaidYes.AutoSize = true;
            this.checkPaidYes.Location = new System.Drawing.Point(536, 615);
            this.checkPaidYes.Name = "checkPaidYes";
            this.checkPaidYes.Size = new System.Drawing.Size(72, 29);
            this.checkPaidYes.TabIndex = 52;
            this.checkPaidYes.Text = "Yes";
            this.checkPaidYes.UseVisualStyleBackColor = true;
            // 
            // lblOrderPaid
            // 
            this.lblOrderPaid.AutoSize = true;
            this.lblOrderPaid.Location = new System.Drawing.Point(69, 616);
            this.lblOrderPaid.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblOrderPaid.Name = "lblOrderPaid";
            this.lblOrderPaid.Size = new System.Drawing.Size(112, 25);
            this.lblOrderPaid.TabIndex = 51;
            this.lblOrderPaid.Text = "Order Paid:";
            // 
            // lblOrderDelivered
            // 
            this.lblOrderDelivered.AutoSize = true;
            this.lblOrderDelivered.Location = new System.Drawing.Point(69, 685);
            this.lblOrderDelivered.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblOrderDelivered.Name = "lblOrderDelivered";
            this.lblOrderDelivered.Size = new System.Drawing.Size(155, 25);
            this.lblOrderDelivered.TabIndex = 50;
            this.lblOrderDelivered.Text = "Order Delivered:";
            // 
            // lblDeliveryDate
            // 
            this.lblDeliveryDate.AutoSize = true;
            this.lblDeliveryDate.Location = new System.Drawing.Point(69, 488);
            this.lblDeliveryDate.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDeliveryDate.Name = "lblDeliveryDate";
            this.lblDeliveryDate.Size = new System.Drawing.Size(185, 25);
            this.lblDeliveryDate.TabIndex = 49;
            this.lblDeliveryDate.Text = "Enter Delivery Date:";
            // 
            // lblRider
            // 
            this.lblRider.AutoSize = true;
            this.lblRider.Location = new System.Drawing.Point(69, 558);
            this.lblRider.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblRider.Name = "lblRider";
            this.lblRider.Size = new System.Drawing.Size(171, 25);
            this.lblRider.TabIndex = 48;
            this.lblRider.Text = "Enter Rider Name:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(1084, 728);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(144, 47);
            this.btnAdd.TabIndex = 47;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(1252, 728);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(144, 47);
            this.btnBack.TabIndex = 46;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // txtOrderId
            // 
            this.txtOrderId.Location = new System.Drawing.Point(536, 139);
            this.txtOrderId.Name = "txtOrderId";
            this.txtOrderId.Size = new System.Drawing.Size(480, 29);
            this.txtOrderId.TabIndex = 45;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(536, 226);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(480, 29);
            this.txtProductName.TabIndex = 44;
            // 
            // txtCNIC
            // 
            this.txtCNIC.Location = new System.Drawing.Point(536, 408);
            this.txtCNIC.Name = "txtCNIC";
            this.txtCNIC.Size = new System.Drawing.Size(480, 29);
            this.txtCNIC.TabIndex = 43;
            // 
            // txtMonth
            // 
            this.txtMonth.Location = new System.Drawing.Point(536, 307);
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Size = new System.Drawing.Size(480, 29);
            this.txtMonth.TabIndex = 42;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(536, 41);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(480, 29);
            this.txtCustomerName.TabIndex = 41;
            // 
            // lblCNIC
            // 
            this.lblCNIC.AutoSize = true;
            this.lblCNIC.Location = new System.Drawing.Point(69, 412);
            this.lblCNIC.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCNIC.Name = "lblCNIC";
            this.lblCNIC.Size = new System.Drawing.Size(118, 25);
            this.lblCNIC.TabIndex = 40;
            this.lblCNIC.Text = "Enter CNIC:";
            // 
            // lblOrderId
            // 
            this.lblOrderId.AutoSize = true;
            this.lblOrderId.Location = new System.Drawing.Point(69, 139);
            this.lblOrderId.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblOrderId.Name = "lblOrderId";
            this.lblOrderId.Size = new System.Drawing.Size(143, 25);
            this.lblOrderId.TabIndex = 39;
            this.lblOrderId.Text = "Enter Order ID:";
            // 
            // lblAddProduct
            // 
            this.lblAddProduct.AutoSize = true;
            this.lblAddProduct.Location = new System.Drawing.Point(69, 226);
            this.lblAddProduct.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblAddProduct.Name = "lblAddProduct";
            this.lblAddProduct.Size = new System.Drawing.Size(193, 25);
            this.lblAddProduct.TabIndex = 38;
            this.lblAddProduct.Text = "Enter Product Name:";
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Location = new System.Drawing.Point(69, 313);
            this.lblMonth.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(124, 25);
            this.lblMonth.TabIndex = 37;
            this.lblMonth.Text = "Enter Month:";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(69, 47);
            this.lblCustomerName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(154, 25);
            this.lblCustomerName.TabIndex = 36;
            this.lblCustomerName.Text = "Enter Customer:";
            // 
            // AddOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1459, 835);
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
            this.Controls.Add(this.btnAdd);
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
            this.Name = "AddOrder";
            this.Text = "AddOrder";
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
        private System.Windows.Forms.Button btnAdd;
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