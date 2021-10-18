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
    public partial class FrmFoods : Form
    {
        public FrmFoods()
        {
            InitializeComponent();
        }

        private void LblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PicSoup_Click(object sender, EventArgs e)
        {
            Forms.FrmSoup frm = new Forms.FrmSoup();
            frm.Show();
            this.Hide();
        }

        private void PicSalad_Click(object sender, EventArgs e)
        {
            Forms.FrmSalad frm = new Forms.FrmSalad();
            frm.Show();
            this.Hide();
        }

        private void PicPasta_Click(object sender, EventArgs e)
        {
            Forms.FrmPasta frm = new Forms.FrmPasta();
            frm.Show();
            this.Hide();
        }

        private void PicMeat_Click(object sender, EventArgs e)
        {
            Forms.FrmMeat frm = new Forms.FrmMeat();
            frm.Show();
            this.Hide();
        }

        private void PicBurger_Click(object sender, EventArgs e)
        {
            Forms.FrmBurger frm = new Forms.FrmBurger();
            frm.Show();
            this.Hide();
        }

        private void PicPizza_Click(object sender, EventArgs e)
        {
            Forms.FrmPizza frm = new Forms.FrmPizza();
            frm.Show();
            this.Hide();
        }

        private void PicCold_Click(object sender, EventArgs e)
        {
            Forms.FrmColdDrinks frm = new Forms.FrmColdDrinks();
            frm.Show();
            this.Hide();
        }

        private void PicHot_Click(object sender, EventArgs e)
        {
            Forms.FrmHotDrinks frm = new Forms.FrmHotDrinks();
            frm.Show();
            this.Hide();
        }

        private void PicBeverage_Click(object sender, EventArgs e)
        {
            Forms.FrmBeverage frm = new Forms.FrmBeverage();
            frm.Show();
            this.Hide();
        }

        private void PicFry_Click(object sender, EventArgs e)
        {
            Forms.FrmFries frm = new Forms.FrmFries();
            frm.Show();
            this.Hide();
        }

        private void PicDessert_Click(object sender, EventArgs e)
        {
            Forms.FrmDessert frm = new Forms.FrmDessert();
            frm.Show();
            this.Hide();
        }

        private void PicBakery_Click(object sender, EventArgs e)
        {
            Forms.FrmBakery frm = new Forms.FrmBakery();
            frm.Show();
            this.Hide();
        }
    }
}
