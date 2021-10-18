using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomatedOrderSystem
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PicFoods_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        private void PicFoods_Click(object sender, EventArgs e)
        {
            Forms.FrmFoods frm = new Forms.FrmFoods();
            frm.Show();
            this.Hide();
        }

        private void PicOrders_Click(object sender, EventArgs e)
        {
            Forms.FrmOrders frm = new Forms.FrmOrders();
            frm.Show();
            this.Hide();
        }
    }
}
