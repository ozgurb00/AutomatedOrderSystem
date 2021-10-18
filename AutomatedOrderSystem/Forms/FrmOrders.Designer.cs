
namespace AutomatedOrderSystem.Forms
{
    partial class FrmOrders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOrders));
            this.PanelFoods = new System.Windows.Forms.Panel();
            this.LblExit = new System.Windows.Forms.Label();
            this.LblOrders = new System.Windows.Forms.Label();
            this.GridOrders = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.BtnShowBill = new System.Windows.Forms.Button();
            this.LblCustomer = new System.Windows.Forms.Label();
            this.TxtCustomer = new System.Windows.Forms.TextBox();
            this.PanelFoods.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelFoods
            // 
            this.PanelFoods.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanelFoods.BackgroundImage")));
            this.PanelFoods.Controls.Add(this.LblExit);
            this.PanelFoods.Controls.Add(this.LblOrders);
            this.PanelFoods.Location = new System.Drawing.Point(0, 0);
            this.PanelFoods.Name = "PanelFoods";
            this.PanelFoods.Size = new System.Drawing.Size(900, 186);
            this.PanelFoods.TabIndex = 108;
            // 
            // LblExit
            // 
            this.LblExit.AutoSize = true;
            this.LblExit.BackColor = System.Drawing.Color.Transparent;
            this.LblExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblExit.ForeColor = System.Drawing.Color.White;
            this.LblExit.Location = new System.Drawing.Point(852, 0);
            this.LblExit.Name = "LblExit";
            this.LblExit.Size = new System.Drawing.Size(57, 55);
            this.LblExit.TabIndex = 4;
            this.LblExit.Text = "X";
            this.LblExit.Click += new System.EventHandler(this.LblExit_Click);
            // 
            // LblOrders
            // 
            this.LblOrders.AutoSize = true;
            this.LblOrders.BackColor = System.Drawing.Color.Transparent;
            this.LblOrders.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblOrders.ForeColor = System.Drawing.Color.SeaShell;
            this.LblOrders.Location = new System.Drawing.Point(287, 82);
            this.LblOrders.Name = "LblOrders";
            this.LblOrders.Size = new System.Drawing.Size(287, 86);
            this.LblOrders.TabIndex = 0;
            this.LblOrders.Text = "ORDERS";
            // 
            // GridOrders
            // 
            this.GridOrders.Location = new System.Drawing.Point(0, 183);
            this.GridOrders.MainView = this.gridView1;
            this.GridOrders.Name = "GridOrders";
            this.GridOrders.Size = new System.Drawing.Size(634, 369);
            this.GridOrders.TabIndex = 109;
            this.GridOrders.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.GridOrders;
            this.gridView1.Name = "gridView1";
            // 
            // BtnShowBill
            // 
            this.BtnShowBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnShowBill.Location = new System.Drawing.Point(728, 240);
            this.BtnShowBill.Name = "BtnShowBill";
            this.BtnShowBill.Size = new System.Drawing.Size(158, 32);
            this.BtnShowBill.TabIndex = 110;
            this.BtnShowBill.Text = "Show The Bill";
            this.BtnShowBill.UseVisualStyleBackColor = true;
            this.BtnShowBill.Click += new System.EventHandler(this.BtnShowBill_Click);
            // 
            // LblCustomer
            // 
            this.LblCustomer.AutoSize = true;
            this.LblCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblCustomer.Location = new System.Drawing.Point(640, 203);
            this.LblCustomer.Name = "LblCustomer";
            this.LblCustomer.Size = new System.Drawing.Size(82, 20);
            this.LblCustomer.TabIndex = 111;
            this.LblCustomer.Text = "Customer:";
            // 
            // TxtCustomer
            // 
            this.TxtCustomer.Location = new System.Drawing.Point(728, 203);
            this.TxtCustomer.Name = "TxtCustomer";
            this.TxtCustomer.Size = new System.Drawing.Size(158, 20);
            this.TxtCustomer.TabIndex = 112;
            // 
            // FrmOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(898, 550);
            this.Controls.Add(this.TxtCustomer);
            this.Controls.Add(this.LblCustomer);
            this.Controls.Add(this.BtnShowBill);
            this.Controls.Add(this.GridOrders);
            this.Controls.Add(this.PanelFoods);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmOrders";
            this.Text = "FrmOrders";
            this.Load += new System.EventHandler(this.FrmOrders_Load);
            this.PanelFoods.ResumeLayout(false);
            this.PanelFoods.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelFoods;
        private System.Windows.Forms.Label LblExit;
        private System.Windows.Forms.Label LblOrders;
        private DevExpress.XtraGrid.GridControl GridOrders;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Button BtnShowBill;
        private System.Windows.Forms.Label LblCustomer;
        private System.Windows.Forms.TextBox TxtCustomer;
    }
}