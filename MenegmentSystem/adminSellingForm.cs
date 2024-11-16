using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MenegmentSystem
{
    public partial class adminSellingForm : Form
    {
        GoodsClass orderExecution = new GoodsClass(@"Data Source=PASHA\SQLEXPRESS;Initial Catalog=KursovaDB;Integrated Security=True");

        int ID, OrderAmount, TotalPrice;
        string GoodsName, Category, UserName;
        DialogResult res;
        
        
        public adminSellingForm()
        {
            InitializeComponent();
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            FormActions.ExitForm(this);
        }

        private void lblMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void SellingAdminForm_Load(object sender, EventArgs e)
        {
            orderExecution.populate(dgOrderExecution, "SELECT * FROM OrderTbl","");
            orderExecution.populate(comboNames, "SELECT username FROM UserData","");
        }

        private void goodsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new adminGoodsMenu().Show();
        }

        private void lblAll_Click(object sender, EventArgs e)
        {
            orderExecution.populate(dgOrderExecution, "SELECT * FROM OrderTbl");
        }

        private void comboNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            Refreshk(sender, e);
        }

        private void categoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new adminCatMenu().Show();
        }

        private void Refreshk(object sender, EventArgs e)
        {
            orderExecution.populate(dgOrderExecution, $"SELECT * FROM OrderTbl WHERE UserName = '{comboNames.SelectedValue}'","");
        }

        private void btnExucute_Click(object sender, EventArgs e)
        {
            if (dgOrderExecution.Rows.Count>1)
            {
                res = MessageBox.Show("Execute an order processing?","",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
                if (res == DialogResult.OK)
                {
                    orderExecution.sqlChange($"DELETE FROM OrderTbl WHERE ID= '{ID}' AND UserName = '{UserName}'", "Success");
                    orderExecution.populate(dgOrderExecution, $"SELECT * FROM OrderTbl", "");
                }
            }
            else
            {
                MessageBox.Show("You cannot Sell goods that doesn't exist");
            }
            
        }

        private void dgOrderExecution_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ID = Convert.ToInt32(dgOrderExecution.SelectedRows[0].Cells[0].Value.ToString());
                Name = dgOrderExecution.SelectedRows[0].Cells[1].Value.ToString();
                OrderAmount = Convert.ToInt32(dgOrderExecution.SelectedRows[0].Cells[2].Value.ToString());
                TotalPrice = Convert.ToInt32(dgOrderExecution.SelectedRows[0].Cells[3].Value.ToString());
                Category = dgOrderExecution.SelectedRows[0].Cells[4].Value.ToString();
                UserName = dgOrderExecution.SelectedRows[0].Cells[5].Value.ToString();
            }
            catch
            {

            }
           
        }
    }
}
