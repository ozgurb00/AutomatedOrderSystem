
namespace AutomatedOrderSystem.Forms
{
    partial class FrmSoup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSoup));
            this.PanelFoods = new System.Windows.Forms.Panel();
            this.LblExit = new System.Windows.Forms.Label();
            this.LblSoup = new System.Windows.Forms.Label();
            this.GridSoup = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.LblFoodID = new DevExpress.XtraEditors.LabelControl();
            this.TxtFoodID = new System.Windows.Forms.TextBox();
            this.TxtOrderAmount = new System.Windows.Forms.TextBox();
            this.LblOrderAmount = new DevExpress.XtraEditors.LabelControl();
            this.BtnAddToOrders = new System.Windows.Forms.Button();
            this.TxtCustomerName = new System.Windows.Forms.TextBox();
            this.LblCustomerName = new DevExpress.XtraEditors.LabelControl();
            this.PanelFoods.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridSoup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelFoods
            // 
            this.PanelFoods.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanelFoods.BackgroundImage")));
            this.PanelFoods.Controls.Add(this.LblExit);
            this.PanelFoods.Controls.Add(this.LblSoup);
            this.PanelFoods.Location = new System.Drawing.Point(1, 2);
            this.PanelFoods.Name = "PanelFoods";
            this.PanelFoods.Size = new System.Drawing.Size(890, 157);
            this.PanelFoods.TabIndex = 2;
            // 
            // LblExit
            // 
            this.LblExit.AutoSize = true;
            this.LblExit.BackColor = System.Drawing.Color.Transparent;
            this.LblExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblExit.ForeColor = System.Drawing.Color.White;
            this.LblExit.Location = new System.Drawing.Point(833, -9);
            this.LblExit.Name = "LblExit";
            this.LblExit.Size = new System.Drawing.Size(57, 55);
            this.LblExit.TabIndex = 4;
            this.LblExit.Text = "X";
            this.LblExit.Click += new System.EventHandler(this.LblExit_Click);
            // 
            // LblSoup
            // 
            this.LblSoup.AutoSize = true;
            this.LblSoup.BackColor = System.Drawing.Color.Transparent;
            this.LblSoup.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblSoup.ForeColor = System.Drawing.Color.SeaShell;
            this.LblSoup.Location = new System.Drawing.Point(308, 48);
            this.LblSoup.Name = "LblSoup";
            this.LblSoup.Size = new System.Drawing.Size(207, 86);
            this.LblSoup.TabIndex = 0;
            this.LblSoup.Text = "SOUP";
            // 
            // GridSoup
            // 
            this.GridSoup.Location = new System.Drawing.Point(1, 158);
            this.GridSoup.MainView = this.gridView1;
            this.GridSoup.Name = "GridSoup";
            this.GridSoup.Size = new System.Drawing.Size(547, 392);
            this.GridSoup.TabIndex = 3;
            this.GridSoup.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.GridSoup;
            this.gridView1.Name = "gridView1";
            // 
            // LblFoodID
            // 
            this.LblFoodID.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblFoodID.Appearance.Options.UseFont = true;
            this.LblFoodID.Location = new System.Drawing.Point(554, 165);
            this.LblFoodID.Name = "LblFoodID";
            this.LblFoodID.Size = new System.Drawing.Size(63, 19);
            this.LblFoodID.TabIndex = 4;
            this.LblFoodID.Text = "Food ID:";
            // 
            // TxtFoodID
            // 
            this.TxtFoodID.Location = new System.Drawing.Point(688, 165);
            this.TxtFoodID.Name = "TxtFoodID";
            this.TxtFoodID.Size = new System.Drawing.Size(187, 20);
            this.TxtFoodID.TabIndex = 5;
            // 
            // TxtOrderAmount
            // 
            this.TxtOrderAmount.Location = new System.Drawing.Point(688, 203);
            this.TxtOrderAmount.Name = "TxtOrderAmount";
            this.TxtOrderAmount.Size = new System.Drawing.Size(187, 20);
            this.TxtOrderAmount.TabIndex = 13;
            // 
            // LblOrderAmount
            // 
            this.LblOrderAmount.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblOrderAmount.Appearance.Options.UseFont = true;
            this.LblOrderAmount.Location = new System.Drawing.Point(554, 204);
            this.LblOrderAmount.Name = "LblOrderAmount";
            this.LblOrderAmount.Size = new System.Drawing.Size(109, 19);
            this.LblOrderAmount.TabIndex = 12;
            this.LblOrderAmount.Text = "Order Amount:";
            // 
            // BtnAddToOrders
            // 
            this.BtnAddToOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnAddToOrders.Location = new System.Drawing.Point(688, 289);
            this.BtnAddToOrders.Name = "BtnAddToOrders";
            this.BtnAddToOrders.Size = new System.Drawing.Size(187, 43);
            this.BtnAddToOrders.TabIndex = 14;
            this.BtnAddToOrders.Text = "Add To Orders";
            this.BtnAddToOrders.UseVisualStyleBackColor = true;
            this.BtnAddToOrders.Click += new System.EventHandler(this.BtnAddToOrders_Click);
            // 
            // TxtCustomerName
            // 
            this.TxtCustomerName.Location = new System.Drawing.Point(688, 241);
            this.TxtCustomerName.Name = "TxtCustomerName";
            this.TxtCustomerName.Size = new System.Drawing.Size(187, 20);
            this.TxtCustomerName.TabIndex = 16;
            // 
            // LblCustomerName
            // 
            this.LblCustomerName.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblCustomerName.Appearance.Options.UseFont = true;
            this.LblCustomerName.Location = new System.Drawing.Point(554, 241);
            this.LblCustomerName.Name = "LblCustomerName";
            this.LblCustomerName.Size = new System.Drawing.Size(120, 19);
            this.LblCustomerName.TabIndex = 15;
            this.LblCustomerName.Text = "Customer Name:";
            // 
            // FrmSoup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(884, 550);
            this.Controls.Add(this.TxtCustomerName);
            this.Controls.Add(this.LblCustomerName);
            this.Controls.Add(this.BtnAddToOrders);
            this.Controls.Add(this.TxtOrderAmount);
            this.Controls.Add(this.LblOrderAmount);
            this.Controls.Add(this.TxtFoodID);
            this.Controls.Add(this.LblFoodID);
            this.Controls.Add(this.GridSoup);
            this.Controls.Add(this.PanelFoods);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSoup";
            this.Text = "FrmSoup";
            this.Load += new System.EventHandler(this.FrmSoup_Load);
            this.PanelFoods.ResumeLayout(false);
            this.PanelFoods.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridSoup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelFoods;
        private System.Windows.Forms.Label LblExit;
        private System.Windows.Forms.Label LblSoup;
        private DevExpress.XtraGrid.GridControl GridSoup;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl LblFoodID;
        private System.Windows.Forms.TextBox TxtFoodID;
        private System.Windows.Forms.TextBox TxtOrderAmount;
        private DevExpress.XtraEditors.LabelControl LblOrderAmount;
        private System.Windows.Forms.Button BtnAddToOrders;
        private System.Windows.Forms.TextBox TxtCustomerName;
        private DevExpress.XtraEditors.LabelControl LblCustomerName;
    }
}