using BusinessLayer;
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
    public partial class FrmOrders : Form
    {
        public FrmOrders()
        {
            InitializeComponent();
        }

        private void FrmOrders_Load(object sender, EventArgs e)
        {
            OrderManager om = new OrderManager();
            FoodManager fm = new FoodManager();
            FoodCategoryManager fcm = new FoodCategoryManager();
            GridOrders.DataSource = (from x1 in om.GetAll()
                                     join x2 in fm.GetAll()
                                     on x1.FoodID equals x2.FoodID
                                     join x3 in fcm.GetAll()
                                     on x2.FoodCategoryID equals x3.FoodCategoryID
                                     select new
                                     {
                                         x1.CustomerName,
                                         x1.OrderAmount,
                                         x1.FoodID,
                                         FoodPrice = x2.FoodPrice * x1.OrderAmount
                                     });
        }

        private void BtnShowBill_Click(object sender, EventArgs e)
        {
            OrderManager om = new OrderManager();
            FoodManager fm = new FoodManager();
            FoodCategoryManager fcm = new FoodCategoryManager();
            var query = (from x1 in om.GetAll()
                         group x1 by x1.CustomerName into g
                         join x2 in fm.GetAll()
                         on g.FirstOrDefault().FoodID equals x2.FoodID
                         join x3 in fcm.GetAll()
                         on x2.FoodCategoryID equals x3.FoodCategoryID
                         select new
                         {
                             CustomerName = g.FirstOrDefault().CustomerName
                         });
            GridOrders.DataSource = query.ToList();
        }

        private void LblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
