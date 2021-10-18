
namespace AutomatedOrderSystem.Forms
{
    partial class FrmColdDrinks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmColdDrinks));
            this.TxtCustomerName = new System.Windows.Forms.TextBox();
            this.LblCustomerName = new DevExpress.XtraEditors.LabelControl();
            this.BtnAddToOrders = new System.Windows.Forms.Button();
            this.TxtOrderAmount = new System.Windows.Forms.TextBox();
            this.LblOrderAmount = new DevExpress.XtraEditors.LabelControl();
            this.TxtFoodID = new System.Windows.Forms.TextBox();
            this.LblFoodID = new DevExpress.XtraEditors.LabelControl();
            this.GridColdDrinks = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.PanelFoods = new System.Windows.Forms.Panel();
            this.LblExit = new System.Windows.Forms.Label();
            this.LblColdDrinks = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridColdDrinks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.PanelFoods.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtCustomerName
            // 
            this.TxtCustomerName.Location = new System.Drawing.Point(700, 248);
            this.TxtCustomerName.Name = "TxtCustomerName";
            this.TxtCustomerName.Size = new System.Drawing.Size(187, 20);
            this.TxtCustomerName.TabIndex = 70;
            // 
            // LblCustomerName
            // 
            this.LblCustomerName.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblCustomerName.Appearance.Options.UseFont = true;
            this.LblCustomerName.Location = new System.Drawing.Point(541, 246);
            this.LblCustomerName.Name = "LblCustomerName";
            this.LblCustomerName.Size = new System.Drawing.Size(120, 19);
            this.LblCustomerName.TabIndex = 69;
            this.LblCustomerName.Text = "Customer Name:";
            // 
            // BtnAddToOrders
            // 
            this.BtnAddToOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnAddToOrders.Location = new System.Drawing.Point(700, 287);
            this.BtnAddToOrders.Name = "BtnAddToOrders";
            this.BtnAddToOrders.Size = new System.Drawing.Size(187, 43);
            this.BtnAddToOrders.TabIndex = 68;
            this.BtnAddToOrders.Text = "Add To Orders";
            this.BtnAddToOrders.UseVisualStyleBackColor = true;
            this.BtnAddToOrders.Click += new System.EventHandler(this.BtnAddToOrders_Click);
            // 
            // TxtOrderAmount
            // 
            this.TxtOrderAmount.Location = new System.Drawing.Point(700, 210);
            this.TxtOrderAmount.Name = "TxtOrderAmount";
            this.TxtOrderAmount.Size = new System.Drawing.Size(187, 20);
            this.TxtOrderAmount.TabIndex = 67;
            // 
            // LblOrderAmount
            // 
            this.LblOrderAmount.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblOrderAmount.Appearance.Options.UseFont = true;
            this.LblOrderAmount.Location = new System.Drawing.Point(541, 209);
            this.LblOrderAmount.Name = "LblOrderAmount";
            this.LblOrderAmount.Size = new System.Drawing.Size(109, 19);
            this.LblOrderAmount.TabIndex = 66;
            this.LblOrderAmount.Text = "Order Amount:";
            // 
            // TxtFoodID
            // 
            this.TxtFoodID.Location = new System.Drawing.Point(700, 172);
            this.TxtFoodID.Name = "TxtFoodID";
            this.TxtFoodID.Size = new System.Drawing.Size(187, 20);
            this.TxtFoodID.TabIndex = 65;
            // 
            // LblFoodID
            // 
            this.LblFoodID.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblFoodID.Appearance.Options.UseFont = true;
            this.LblFoodID.Location = new System.Drawing.Point(541, 170);
            this.LblFoodID.Name = "LblFoodID";
            this.LblFoodID.Size = new System.Drawing.Size(63, 19);
            this.LblFoodID.TabIndex = 64;
            this.LblFoodID.Text = "Food ID:";
            // 
            // GridColdDrinks
            // 
            this.GridColdDrinks.Location = new System.Drawing.Point(1, 151);
            this.GridColdDrinks.MainView = this.gridView1;
            this.GridColdDrinks.Name = "GridColdDrinks";
            this.GridColdDrinks.Size = new System.Drawing.Size(534, 412);
            this.GridColdDrinks.TabIndex = 63;
            this.GridColdDrinks.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.GridColdDrinks;
            this.gridView1.Name = "gridView1";
            // 
            // PanelFoods
            // 
            this.PanelFoods.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanelFoods.BackgroundImage")));
            this.PanelFoods.Controls.Add(this.LblExit);
            this.PanelFoods.Controls.Add(this.LblColdDrinks);
            this.PanelFoods.Location = new System.Drawing.Point(-13, -19);
            this.PanelFoods.Name = "PanelFoods";
            this.PanelFoods.Size = new System.Drawing.Size(914, 173);
            this.PanelFoods.TabIndex = 62;
            // 
            // LblExit
            // 
            this.LblExit.AutoSize = true;
            this.LblExit.BackColor = System.Drawing.Color.Transparent;
            this.LblExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblExit.ForeColor = System.Drawing.Color.White;
            this.LblExit.Location = new System.Drawing.Point(867, 12);
            this.LblExit.Name = "LblExit";
            this.LblExit.Size = new System.Drawing.Size(57, 55);
            this.LblExit.TabIndex = 4;
            this.LblExit.Text = "X";
            this.LblExit.Click += new System.EventHandler(this.LblExit_Click);
            // 
            // LblColdDrinks
            // 
            this.LblColdDrinks.AutoSize = true;
            this.LblColdDrinks.BackColor = System.Drawing.Color.Transparent;
            this.LblColdDrinks.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblColdDrinks.ForeColor = System.Drawing.Color.SeaShell;
            this.LblColdDrinks.Location = new System.Drawing.Point(224, 69);
            this.LblColdDrinks.Name = "LblColdDrinks";
            this.LblColdDrinks.Size = new System.Drawing.Size(461, 86);
            this.LblColdDrinks.TabIndex = 0;
            this.LblColdDrinks.Text = "COLD DRINKS";
            // 
            // FrmColdDrinks
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
            this.Controls.Add(this.GridColdDrinks);
            this.Controls.Add(this.PanelFoods);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmColdDrinks";
            this.Text = "FrmColdDrinks";
            this.Load += new System.EventHandler(this.FrmColdDrinks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridColdDrinks)).EndInit();
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
        private DevExpress.XtraGrid.GridControl GridColdDrinks;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Panel PanelFoods;
        private System.Windows.Forms.Label LblExit;
        private System.Windows.Forms.Label LblColdDrinks;
    }
}