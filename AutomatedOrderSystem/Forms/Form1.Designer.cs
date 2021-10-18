
namespace AutomatedOrderSystem
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.PanelMain = new DevExpress.XtraEditors.PanelControl();
            this.PicOrders = new DevExpress.XtraEditors.PictureEdit();
            this.LblOrd = new DevExpress.XtraEditors.LabelControl();
            this.PicFoods = new DevExpress.XtraEditors.PictureEdit();
            this.LblFoods = new DevExpress.XtraEditors.LabelControl();
            this.LblAOS = new System.Windows.Forms.Label();
            this.LblExit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PanelMain)).BeginInit();
            this.PanelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicOrders.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicFoods.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelMain
            // 
            this.PanelMain.Appearance.BackColor = System.Drawing.Color.White;
            this.PanelMain.Appearance.Options.UseBackColor = true;
            this.PanelMain.Controls.Add(this.PicOrders);
            this.PanelMain.Controls.Add(this.LblOrd);
            this.PanelMain.Controls.Add(this.PicFoods);
            this.PanelMain.Controls.Add(this.LblFoods);
            this.PanelMain.Location = new System.Drawing.Point(206, 123);
            this.PanelMain.Name = "PanelMain";
            this.PanelMain.Size = new System.Drawing.Size(455, 266);
            this.PanelMain.TabIndex = 0;
            // 
            // PicOrders
            // 
            this.PicOrders.EditValue = ((object)(resources.GetObject("PicOrders.EditValue")));
            this.PicOrders.Location = new System.Drawing.Point(249, 58);
            this.PicOrders.Name = "PicOrders";
            this.PicOrders.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.PicOrders.Size = new System.Drawing.Size(192, 175);
            this.PicOrders.TabIndex = 6;
            this.PicOrders.Click += new System.EventHandler(this.PicOrders_Click);
            // 
            // LblOrd
            // 
            this.LblOrd.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblOrd.Appearance.Options.UseFont = true;
            this.LblOrd.Location = new System.Drawing.Point(296, 23);
            this.LblOrd.Name = "LblOrd";
            this.LblOrd.Size = new System.Drawing.Size(100, 29);
            this.LblOrd.TabIndex = 5;
            this.LblOrd.Text = "ORDERS";
            // 
            // PicFoods
            // 
            this.PicFoods.EditValue = ((object)(resources.GetObject("PicFoods.EditValue")));
            this.PicFoods.Location = new System.Drawing.Point(22, 58);
            this.PicFoods.Name = "PicFoods";
            this.PicFoods.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.PicFoods.Size = new System.Drawing.Size(184, 175);
            this.PicFoods.TabIndex = 4;
            this.PicFoods.EditValueChanged += new System.EventHandler(this.PicFoods_EditValueChanged);
            this.PicFoods.Click += new System.EventHandler(this.PicFoods_Click);
            // 
            // LblFoods
            // 
            this.LblFoods.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblFoods.Appearance.Options.UseFont = true;
            this.LblFoods.Location = new System.Drawing.Point(58, 23);
            this.LblFoods.Name = "LblFoods";
            this.LblFoods.Size = new System.Drawing.Size(83, 29);
            this.LblFoods.TabIndex = 3;
            this.LblFoods.Text = "FOODS";
            // 
            // LblAOS
            // 
            this.LblAOS.AutoSize = true;
            this.LblAOS.BackColor = System.Drawing.Color.Transparent;
            this.LblAOS.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblAOS.ForeColor = System.Drawing.Color.SeaShell;
            this.LblAOS.Location = new System.Drawing.Point(284, 76);
            this.LblAOS.Name = "LblAOS";
            this.LblAOS.Size = new System.Drawing.Size(295, 30);
            this.LblAOS.TabIndex = 2;
            this.LblAOS.Text = "AUTOMATED ORDER SYSTEM";
            // 
            // LblExit
            // 
            this.LblExit.AutoSize = true;
            this.LblExit.BackColor = System.Drawing.Color.Transparent;
            this.LblExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblExit.ForeColor = System.Drawing.Color.White;
            this.LblExit.Location = new System.Drawing.Point(849, -2);
            this.LblExit.Name = "LblExit";
            this.LblExit.Size = new System.Drawing.Size(39, 37);
            this.LblExit.TabIndex = 3;
            this.LblExit.Text = "X";
            this.LblExit.Click += new System.EventHandler(this.LblExit_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(884, 550);
            this.Controls.Add(this.LblExit);
            this.Controls.Add(this.LblAOS);
            this.Controls.Add(this.PanelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PanelMain)).EndInit();
            this.PanelMain.ResumeLayout(false);
            this.PanelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicOrders.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicFoods.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl PanelMain;
        private DevExpress.XtraEditors.PictureEdit PicFoods;
        private DevExpress.XtraEditors.LabelControl LblFoods;
        private System.Windows.Forms.Label LblAOS;
        private DevExpress.XtraEditors.PictureEdit PicOrders;
        private DevExpress.XtraEditors.LabelControl LblOrd;
        private System.Windows.Forms.Label LblExit;
    }
}

