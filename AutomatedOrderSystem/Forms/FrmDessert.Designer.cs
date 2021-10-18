
namespace AutomatedOrderSystem.Forms
{
    partial class FrmDessert
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDessert));
            this.TxtCustomerName = new System.Windows.Forms.TextBox();
            this.LblCustomerName = new DevExpress.XtraEditors.LabelControl();
            this.BtnAddToOrders = new System.Windows.Forms.Button();
            this.TxtOrderAmount = new System.Windows.Forms.TextBox();
            this.LblOrderAmount = new DevExpress.XtraEditors.LabelControl();
            this.TxtFoodID = new System.Windows.Forms.TextBox();
            this.LblFoodID = new DevExpress.XtraEditors.LabelControl();
            this.GridDessert = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.PanelFoods = new System.Windows.Forms.Panel();
            this.LblExit = new System.Windows.Forms.Label();
            this.LblDessert = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridDessert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.PanelFoods.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtCustomerName
            // 
            this.TxtCustomerName.Location = new System.Drawing.Point(696, 259);
            this.TxtCustomerName.Name = "TxtCustomerName";
            this.TxtCustomerName.Size = new System.Drawing.Size(187, 20);
            this.TxtCustomerName.TabIndex = 106;
            // 
            // LblCustomerName
            // 
            this.LblCustomerName.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblCustomerName.Appearance.Options.UseFont = true;
            this.LblCustomerName.Location = new System.Drawing.Point(537, 257);
            this.LblCustomerName.Name = "LblCustomerName";
            this.LblCustomerName.Size = new System.Drawing.Size(120, 19);
            this.LblCustomerName.TabIndex = 105;
            this.LblCustomerName.Text = "Customer Name:";
            // 
            // BtnAddToOrders
            // 
            this.BtnAddToOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnAddToOrders.Location = new System.Drawing.Point(696, 298);
            this.BtnAddToOrders.Name = "BtnAddToOrders";
            this.BtnAddToOrders.Size = new System.Drawing.Size(187, 43);
            this.BtnAddToOrders.TabIndex = 104;
            this.BtnAddToOrders.Text = "Add To Orders";
            this.BtnAddToOrders.UseVisualStyleBackColor = true;
            this.BtnAddToOrders.Click += new System.EventHandler(this.BtnAddToOrders_Click);
            // 
            // TxtOrderAmount
            // 
            this.TxtOrderAmount.Location = new System.Drawing.Point(696, 221);
            this.TxtOrderAmount.Name = "TxtOrderAmount";
            this.TxtOrderAmount.Size = new System.Drawing.Size(187, 20);
            this.TxtOrderAmount.TabIndex = 103;
            // 
            // LblOrderAmount
            // 
            this.LblOrderAmount.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblOrderAmount.Appearance.Options.UseFont = true;
            this.LblOrderAmount.Location = new System.Drawing.Point(537, 220);
            this.LblOrderAmount.Name = "LblOrderAmount";
            this.LblOrderAmount.Size = new System.Drawing.Size(109, 19);
            this.LblOrderAmount.TabIndex = 102;
            this.LblOrderAmount.Text = "Order Amount:";
            // 
            // TxtFoodID
            // 
            this.TxtFoodID.Location = new System.Drawing.Point(696, 183);
            this.TxtFoodID.Name = "TxtFoodID";
            this.TxtFoodID.Size = new System.Drawing.Size(187, 20);
            this.TxtFoodID.TabIndex = 101;
            // 
            // LblFoodID
            // 
            this.LblFoodID.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblFoodID.Appearance.Options.UseFont = true;
            this.LblFoodID.Location = new System.Drawing.Point(537, 181);
            this.LblFoodID.Name = "LblFoodID";
            this.LblFoodID.Size = new System.Drawing.Size(63, 19);
            this.LblFoodID.TabIndex = 100;
            this.LblFoodID.Text = "Food ID:";
            // 
            // GridDessert
            // 
            this.GridDessert.Location = new System.Drawing.Point(-7, 159);
            this.GridDessert.MainView = this.gridView1;
            this.GridDessert.Name = "GridDessert";
            this.GridDessert.Size = new System.Drawing.Size(538, 412);
            this.GridDessert.TabIndex = 99;
            this.GridDessert.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.GridDessert;
            this.gridView1.Name = "gridView1";
            // 
            // PanelFoods
            // 
            this.PanelFoods.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanelFoods.BackgroundImage")));
            this.PanelFoods.Controls.Add(this.LblExit);
            this.PanelFoods.Controls.Add(this.LblDessert);
            this.PanelFoods.Location = new System.Drawing.Point(-27, -20);
            this.PanelFoods.Name = "PanelFoods";
            this.PanelFoods.Size = new System.Drawing.Size(924, 183);
            this.PanelFoods.TabIndex = 98;
            // 
            // LblExit
            // 
            this.LblExit.AutoSize = true;
            this.LblExit.BackColor = System.Drawing.Color.Transparent;
            this.LblExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblExit.ForeColor = System.Drawing.Color.White;
            this.LblExit.Location = new System.Drawing.Point(874, 12);
            this.LblExit.Name = "LblExit";
            this.LblExit.Size = new System.Drawing.Size(57, 55);
            this.LblExit.TabIndex = 4;
            this.LblExit.Text = "X";
            this.LblExit.Click += new System.EventHandler(this.LblExit_Click);
            // 
            // LblDessert
            // 
            this.LblDessert.AutoSize = true;
            this.LblDessert.BackColor = System.Drawing.Color.Transparent;
            this.LblDessert.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblDessert.ForeColor = System.Drawing.Color.SeaShell;
            this.LblDessert.Location = new System.Drawing.Point(324, 77);
            this.LblDessert.Name = "LblDessert";
            this.LblDessert.Size = new System.Drawing.Size(303, 86);
            this.LblDessert.TabIndex = 0;
            this.LblDessert.Text = "DESSERT";
            // 
            // FrmDessert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(898, 550);
            this.Controls.Add(this.TxtCustomerName);
            this.Controls.Add(this.LblCustomerName);
            this.Controls.Add(this.BtnAddToOrders);
            this.Controls.Add(this.TxtOrderAmount);
            this.Controls.Add(this.LblOrderAmount);
            this.Controls.Add(this.TxtFoodID);
            this.Controls.Add(this.LblFoodID);
            this.Controls.Add(this.GridDessert);
            this.Controls.Add(this.PanelFoods);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDessert";
            this.Text = "FrmDessert";
            this.Load += new System.EventHandler(this.FrmDessert_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridDessert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.PanelFoods.ResumeLayout(false);
            this.PanelFoods.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtCustomerName;
        private DevExpress.XtraEditors.LabelControl LblCustomerName;
        private System.Windows.Forms.Button BtnAddToOrders;
        private System.Windows.Forms.TextBox TxtOrderAmount;
        private DevExpress.XtraEditors.LabelControl LblOrderAmount;
        private System.Windows.Forms.TextBox TxtFoodID;
        private DevExpress.XtraEditors.LabelControl LblFoodID;
        private DevExpress.XtraGrid.GridControl GridDessert;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Panel PanelFoods;
        private System.Windows.Forms.Label LblExit;
        private System.Windows.Forms.Label LblDessert;
    }
}