
namespace FinalProject
{
    partial class RiderMap
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
            this.btnBack = new System.Windows.Forms.Button();
            this.btnGetPosition1 = new System.Windows.Forms.Button();
            this.lblPLace = new System.Windows.Forms.Label();
            this.txtPlace = new System.Windows.Forms.TextBox();
            this.chkMouseClick = new System.Windows.Forms.CheckBox();
            this.txtRichAddress = new System.Windows.Forms.RichTextBox();
            this.lblDistance = new System.Windows.Forms.Label();
            this.lblDistanceInKM = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.addPoint = new System.Windows.Forms.Button();
            this.GetRoute = new System.Windows.Forms.Button();
            this.btnLoadMap = new System.Windows.Forms.Button();
            this.txtLongitude = new System.Windows.Forms.TextBox();
            this.lblLongitude = new System.Windows.Forms.Label();
            this.txtLatitude = new System.Windows.Forms.TextBox();
            this.lblLatitude = new System.Windows.Forms.Label();
            this.gMapDisplayArea = new GMap.NET.WindowsForms.GMapControl();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.Location = new System.Drawing.Point(718, 415);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 48;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnGetPosition1
            // 
            this.btnGetPosition1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGetPosition1.Location = new System.Drawing.Point(651, 217);
            this.btnGetPosition1.Name = "btnGetPosition1";
            this.btnGetPosition1.Size = new System.Drawing.Size(75, 23);
            this.btnGetPosition1.TabIndex = 47;
            this.btnGetPosition1.Text = "Get Position1";
            this.btnGetPosition1.UseVisualStyleBackColor = true;
            this.btnGetPosition1.Click += new System.EventHandler(this.btnGetPosition1_Click);
            // 
            // lblPLace
            // 
            this.lblPLace.AutoSize = true;
            this.lblPLace.Location = new System.Drawing.Point(608, 198);
            this.lblPLace.Name = "lblPLace";
            this.lblPLace.Size = new System.Drawing.Size(37, 13);
            this.lblPLace.TabIndex = 46;
            this.lblPLace.Text = "Place:";
            // 
            // txtPlace
            // 
            this.txtPlace.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPlace.Location = new System.Drawing.Point(651, 191);
            this.txtPlace.Name = "txtPlace";
            this.txtPlace.Size = new System.Drawing.Size(111, 20);
            this.txtPlace.TabIndex = 45;
            // 
            // chkMouseClick
            // 
            this.chkMouseClick.AutoSize = true;
            this.chkMouseClick.Location = new System.Drawing.Point(605, 255);
            this.chkMouseClick.Name = "chkMouseClick";
            this.chkMouseClick.Size = new System.Drawing.Size(120, 17);
            this.chkMouseClick.TabIndex = 44;
            this.chkMouseClick.Text = "Enable Mouse Click";
            this.chkMouseClick.UseVisualStyleBackColor = true;
            // 
            // txtRichAddress
            // 
            this.txtRichAddress.Location = new System.Drawing.Point(605, 278);
            this.txtRichAddress.Name = "txtRichAddress";
            this.txtRichAddress.Size = new System.Drawing.Size(132, 115);
            this.txtRichAddress.TabIndex = 43;
            this.txtRichAddress.Text = "";
            // 
            // lblDistance
            // 
            this.lblDistance.AutoSize = true;
            this.lblDistance.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDistance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDistance.Location = new System.Drawing.Point(697, 163);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.Size = new System.Drawing.Size(81, 15);
            this.lblDistance.TabIndex = 42;
            this.lblDistance.Text = "Distance in KM";
            // 
            // lblDistanceInKM
            // 
            this.lblDistanceInKM.AutoSize = true;
            this.lblDistanceInKM.Location = new System.Drawing.Point(608, 165);
            this.lblDistanceInKM.Name = "lblDistanceInKM";
            this.lblDistanceInKM.Size = new System.Drawing.Size(82, 13);
            this.lblDistanceInKM.TabIndex = 41;
            this.lblDistanceInKM.Text = "Distance in KM:";
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Location = new System.Drawing.Point(693, 90);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 40;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // addPoint
            // 
            this.addPoint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addPoint.Location = new System.Drawing.Point(608, 90);
            this.addPoint.Name = "addPoint";
            this.addPoint.Size = new System.Drawing.Size(75, 23);
            this.addPoint.TabIndex = 39;
            this.addPoint.Text = "Add Point";
            this.addPoint.UseVisualStyleBackColor = true;
            this.addPoint.Click += new System.EventHandler(this.addPoint_Click);
            // 
            // GetRoute
            // 
            this.GetRoute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GetRoute.Location = new System.Drawing.Point(697, 119);
            this.GetRoute.Name = "GetRoute";
            this.GetRoute.Size = new System.Drawing.Size(75, 23);
            this.GetRoute.TabIndex = 38;
            this.GetRoute.Text = "Get Route";
            this.GetRoute.UseVisualStyleBackColor = true;
            this.GetRoute.Click += new System.EventHandler(this.GetRoute_Click);
            // 
            // btnLoadMap
            // 
            this.btnLoadMap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadMap.Location = new System.Drawing.Point(608, 119);
            this.btnLoadMap.Name = "btnLoadMap";
            this.btnLoadMap.Size = new System.Drawing.Size(75, 23);
            this.btnLoadMap.TabIndex = 37;
            this.btnLoadMap.Text = "Load Map";
            this.btnLoadMap.UseVisualStyleBackColor = true;
            this.btnLoadMap.Click += new System.EventHandler(this.btnLoadMap_Click);
            // 
            // txtLongitude
            // 
            this.txtLongitude.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLongitude.Location = new System.Drawing.Point(608, 64);
            this.txtLongitude.Name = "txtLongitude";
            this.txtLongitude.Size = new System.Drawing.Size(100, 20);
            this.txtLongitude.TabIndex = 36;
            // 
            // lblLongitude
            // 
            this.lblLongitude.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLongitude.AutoSize = true;
            this.lblLongitude.Location = new System.Drawing.Point(605, 48);
            this.lblLongitude.Name = "lblLongitude";
            this.lblLongitude.Size = new System.Drawing.Size(94, 13);
            this.lblLongitude.TabIndex = 35;
            this.lblLongitude.Text = "Source Longitude:";
            // 
            // txtLatitude
            // 
            this.txtLatitude.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLatitude.Location = new System.Drawing.Point(608, 25);
            this.txtLatitude.Name = "txtLatitude";
            this.txtLatitude.Size = new System.Drawing.Size(100, 20);
            this.txtLatitude.TabIndex = 34;
            // 
            // lblLatitude
            // 
            this.lblLatitude.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLatitude.AutoSize = true;
            this.lblLatitude.Location = new System.Drawing.Point(605, 9);
            this.lblLatitude.Name = "lblLatitude";
            this.lblLatitude.Size = new System.Drawing.Size(85, 13);
            this.lblLatitude.TabIndex = 33;
            this.lblLatitude.Text = "Source Latitude:";
            // 
            // gMapDisplayArea
            // 
            this.gMapDisplayArea.Bearing = 0F;
            this.gMapDisplayArea.CanDragMap = true;
            this.gMapDisplayArea.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapDisplayArea.GrayScaleMode = false;
            this.gMapDisplayArea.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapDisplayArea.LevelsKeepInMemory = 5;
            this.gMapDisplayArea.Location = new System.Drawing.Point(7, 2);
            this.gMapDisplayArea.MarkersEnabled = true;
            this.gMapDisplayArea.MaxZoom = 2;
            this.gMapDisplayArea.MinZoom = 2;
            this.gMapDisplayArea.MouseWheelZoomEnabled = true;
            this.gMapDisplayArea.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapDisplayArea.Name = "gMapDisplayArea";
            this.gMapDisplayArea.NegativeMode = false;
            this.gMapDisplayArea.PolygonsEnabled = true;
            this.gMapDisplayArea.RetryLoadTile = 0;
            this.gMapDisplayArea.RoutesEnabled = true;
            this.gMapDisplayArea.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapDisplayArea.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapDisplayArea.ShowTileGridLines = false;
            this.gMapDisplayArea.Size = new System.Drawing.Size(580, 446);
            this.gMapDisplayArea.TabIndex = 32;
            this.gMapDisplayArea.Zoom = 0D;
            this.gMapDisplayArea.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gMapDisplayArea_MouseClick);
            // 
            // RiderMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnGetPosition1);
            this.Controls.Add(this.lblPLace);
            this.Controls.Add(this.txtPlace);
            this.Controls.Add(this.chkMouseClick);
            this.Controls.Add(this.txtRichAddress);
            this.Controls.Add(this.lblDistance);
            this.Controls.Add(this.lblDistanceInKM);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.addPoint);
            this.Controls.Add(this.GetRoute);
            this.Controls.Add(this.btnLoadMap);
            this.Controls.Add(this.txtLongitude);
            this.Controls.Add(this.lblLongitude);
            this.Controls.Add(this.txtLatitude);
            this.Controls.Add(this.lblLatitude);
            this.Controls.Add(this.gMapDisplayArea);
            this.Name = "RiderMap";
            this.Text = "RiderMap";
            this.Load += new System.EventHandler(this.RiderMap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnGetPosition1;
        private System.Windows.Forms.Label lblPLace;
        private System.Windows.Forms.TextBox txtPlace;
        private System.Windows.Forms.CheckBox chkMouseClick;
        private System.Windows.Forms.RichTextBox txtRichAddress;
        private System.Windows.Forms.Label lblDistance;
        private System.Windows.Forms.Label lblDistanceInKM;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button addPoint;
        private System.Windows.Forms.Button GetRoute;
        private System.Windows.Forms.Button btnLoadMap;
        private System.Windows.Forms.TextBox txtLongitude;
        private System.Windows.Forms.Label lblLongitude;
        private System.Windows.Forms.TextBox txtLatitude;
        private System.Windows.Forms.Label lblLatitude;
        private GMap.NET.WindowsForms.GMapControl gMapDisplayArea;
    }
}