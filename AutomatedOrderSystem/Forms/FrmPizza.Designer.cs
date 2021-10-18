
namespace AutomatedOrderSystem.Forms
{
    partial class FrmPizza
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPizza));
            this.TxtCustomerName = new System.Windows.Forms.TextBox();
            this.LblCustomerName = new DevExpress.XtraEditors.LabelControl();
            this.BtnAddToOrders = new System.Windows.Forms.Button();
            this.TxtOrderAmount = new System.Windows.Forms.TextBox();
            this.LblOrderAmount = new DevExpress.XtraEditors.LabelControl();
            this.TxtFoodID = new System.Windows.Forms.TextBox();
            this.LblFoodID = new DevExpress.XtraEditors.LabelControl();
            this.GridPizza = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.PanelFoods = new System.Windows.Forms.Panel();
            this.LblExit = new System.Windows.Forms.Label();
            this.LblPizza = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridPizza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.PanelFoods.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtCustomerName
            // 
            this.TxtCustomerName.Location = new System.Drawing.Point(697, 239);
            this.TxtCustomerName.Name = "TxtCustomerName";
            this.TxtCustomerName.Size = new System.Drawing.Size(187, 20);
            this.TxtCustomerName.TabIndex = 61;
            // 
            // LblCustomerName
            // 
            this.LblCustomerName.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblCustomerName.Appearance.Options.UseFont = true;
            this.LblCustomerName.Location = new System.Drawing.Point(538, 237);
            this.LblCustomerName.Name = "LblCustomerName";
            this.LblCustomerName.Size = new System.Drawing.Size(120, 19);
            this.LblCustomerName.TabIndex = 60;
            this.LblCustomerName.Text = "Customer Name:";
            // 
            // BtnAddToOrders
            // 
            this.BtnAddToOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnAddToOrders.Location = new System.Drawing.Point(697, 278);
            this.BtnAddToOrders.Name = "BtnAddToOrders";
            this.BtnAddToOrders.Size = new System.Drawing.Size(187, 43);
            this.BtnAddToOrders.TabIndex = 59;
            this.BtnAddToOrders.Text = "Add To Orders";
            this.BtnAddToOrders.UseVisualStyleBackColor = true;
            this.BtnAddToOrders.Click += new System.EventHandler(this.BtnAddToOrders_Click);
            // 
            // TxtOrderAmount
            // 
            this.TxtOrderAmount.Location = new System.Drawing.Point(697, 201);
            this.TxtOrderAmount.Name = "TxtOrderAmount";
            this.TxtOrderAmount.Size = new System.Drawing.Size(187, 20);
            this.TxtOrderAmount.TabIndex = 58;
            // 
            // LblOrderAmount
            // 
            this.LblOrderAmount.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblOrderAmount.Appearance.Options.UseFont = true;
            this.LblOrderAmount.Location = new System.Drawing.Point(538, 200);
            this.LblOrderAmount.Name = "LblOrderAmount";
            this.LblOrderAmount.Size = new System.Drawing.Size(109, 19);
            this.LblOrderAmount.TabIndex = 57;
            this.LblOrderAmount.Text = "Order Amount:";
            // 
            // TxtFoodID
            // 
            this.TxtFoodID.Location = new System.Drawing.Point(697, 163);
            this.TxtFoodID.Name = "TxtFoodID";
            this.TxtFoodID.Size = new System.Drawing.Size(187, 20);
            this.TxtFoodID.TabIndex = 56;
            // 
            // LblFoodID
            // 
            this.LblFoodID.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblFoodID.Appearance.Options.UseFont = true;
            this.LblFoodID.Location = new System.Drawing.Point(538, 161);
            this.LblFoodID.Name = "LblFoodID";
            this.LblFoodID.Size = new System.Drawing.Size(63, 19);
            this.LblFoodID.TabIndex = 55;
            this.LblFoodID.Text = "Food ID:";
            // 
            // GridPizza
            // 
            this.GridPizza.Location = new System.Drawing.Point(-2, 142);
            this.GridPizza.MainView = this.gridView1;
            this.GridPizza.Name = "GridPizza";
            this.GridPizza.Size = new System.Drawing.Size(534, 412);
            this.GridPizza.TabIndex = 54;
            this.GridPizza.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.GridPizza;
            this.gridView1.Name = "gridView1";
            // 
            // PanelFoods
            // 
            this.PanelFoods.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanelFoods.BackgroundImage")));
            this.PanelFoods.Controls.Add(this.LblExit);
            this.PanelFoods.Controls.Add(this.LblPizza);
            this.PanelFoods.Location = new System.Drawing.Point(-16, -28);
            this.PanelFoods.Name = "PanelFoods";
            this.PanelFoods.Size = new System.Drawing.Size(914, 173);
            this.PanelFoods.TabIndex = 53;
            // 
            // LblExit
            // 
            this.LblExit.AutoSize = true;
            this.LblExit.BackColor = System.Drawing.Color.Transparent;
            this.LblExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblExit.ForeColor = System.Drawing.Color.White;
            this.LblExit.Location = new System.Drawing.Point(867, 20);
            this.LblExit.Name = "LblExit";
            this.LblExit.Size = new System.Drawing.Size(57, 55);
            this.LblExit.TabIndex = 4;
            this.LblExit.Text = "X";
            this.LblExit.Click += new System.EventHandler(this.LblExit_Click);
            // 
            // LblPizza
            // 
            this.LblPizza.AutoSize = true;
            this.LblPizza.BackColor = System.Drawing.Color.Transparent;
            this.LblPizza.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblPizza.ForeColor = System.Drawing.Color.SeaShell;
            this.LblPizza.Location = new System.Drawing.Point(329, 70);
            this.LblPizza.Name = "LblPizza";
            this.LblPizza.Size = new System.Drawing.Size(219, 86);
            this.LblPizza.TabIndex = 0;
            this.LblPizza.Text = "PIZZA";
            // 
            // FrmPizza
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
            this.Controls.Add(this.GridPizza);
            this.Controls.Add(this.PanelFoods);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPizza";
            this.Text = "FrmPizza";
            this.Load += new System.EventHandler(this.FrmPizza_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridPizza)).EndInit();
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
        private DevExpress.XtraGrid.GridControl GridPizza;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Panel PanelFoods;
        private System.Windows.Forms.Label LblExit;
        private System.Windows.Forms.Label LblPizza;
    }
}