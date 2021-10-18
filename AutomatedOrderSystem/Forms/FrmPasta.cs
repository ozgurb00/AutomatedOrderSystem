using BusinessLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomatedOrderSystem.Forms
{
    public partial class FrmPasta : Form
    {
        public FrmPasta()
        {
            InitializeComponent();
        }

        private void FrmPasta_Load(object sender, EventArgs e)
        {
            FoodManager fm = new FoodManager();
            GridPasta.DataSource = (from x in fm.GetAll()
                                   select new
                                   {
                                       x.FoodID,
                                       x.FoodName,
                                       x.FoodPrice,
                                       x.FoodCategoryID
                                   }).Where(x => x.FoodCategoryID == 3);
        }

        private void LblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnAddToOrders_Click(object sender, EventArgs e)
        {
            OrderManager ordm = new OrderManager();
            Order o = new Order();
            o.OrderAmount = Convert.ToInt32(TxtOrderAmount.Text);
            o.FoodID = Convert.ToInt32(TxtFoodID.Text);
            o.CustomerName = TxtCustomerName.Text;
            ordm.OrderAddBL(o);
            MessageBox.Show("Order was added successfully.");
        }
    }
}
