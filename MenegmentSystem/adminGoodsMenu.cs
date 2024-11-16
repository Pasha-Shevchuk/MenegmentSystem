using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenegmentSystem
{
    public partial class adminGoodsMenu : Form
    {
        string query;
        GoodsClass goods_obj = new GoodsClass(@"Data Source=PASHA\SQLEXPRESS;Initial Catalog=KursovaDB;Integrated Security=True");
        DialogResult res;

        public adminGoodsMenu()
        {
            InitializeComponent();
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            FormActions.ExitForm(this);
        }

        private void categoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new adminCatMenu().Show();
        }

        private void adminGoodsMenu_Load(object sender, EventArgs e)
        {
            goods_obj.populate(comboCat,"SELECT CatName FROM CategoriesTbl");
            goods_obj.populate(dgGoods, "SELECT * FROM GoodsTbl");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtAmount.Text == "" || txtID.Text == "" || txtNameGoods.Text == "" || txtPrice.Text == "")
            {
                MessageBox.Show("Missing data");
            }
            else if (!goods_obj.CheckExistance("ID", txtID.Text,"GoodsTbl"))
            {
                res = MessageBox.Show("Are you really want to add goods?","",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (res==DialogResult.Yes)
                {
                    query = $"INSERT INTO GoodsTbl VALUES ('{txtID.Text}', '{txtNameGoods.Text}', '{txtAmount.Text}', '{txtPrice.Text}', '{comboCat.SelectedValue.ToString()}')";
                    goods_obj.sqlChange(query, "Goods successfully added");
                    goods_obj.populate(dgGoods, "SELECT * FROM GoodsTbl");
                }
            }
            else
            {
                MessageBox.Show("Specify index that doesn't already exist");
            }
        }

        private void dgGoods_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dgGoods.SelectedRows[0].Cells[0].Value.ToString();
            txtNameGoods.Text = dgGoods.SelectedRows[0].Cells[1].Value.ToString();
            txtAmount.Text = dgGoods.SelectedRows[0].Cells[2].Value.ToString();
            txtPrice.Text = dgGoods.SelectedRows[0].Cells[3].Value.ToString();
            comboCat.SelectedValue = dgGoods.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtAmount.Text == "" || txtID.Text == "" || txtNameGoods.Text == "" || txtPrice.Text == "")
            {
                MessageBox.Show("Missing data");
            }
            else if (goods_obj.CheckExistance("ID", txtID.Text, "GoodsTbl"))
            {
                res = MessageBox.Show("Are you really want to delete goods from list?","",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    query = $"DELETE FROM GoodsTbl WHERE ID = '{txtID.Text}' AND Name = '{txtNameGoods.Text}' AND Amount = '{txtAmount.Text}' AND Price = '{txtPrice.Text}' AND Category = '{comboCat.SelectedValue}'";
                    goods_obj.sqlChange(query, "Goods deleted successfully");
                    goods_obj.populate(dgGoods, "SELECT * FROM GoodsTbl");
                }
            }
            else
            {
                MessageBox.Show("For deleting you have to specify goods with existing ID");
            }
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtAmount.Text == "" || txtID.Text == "" || txtNameGoods.Text == "" || txtPrice.Text == "")
            {
                MessageBox.Show("Missing data");
            }
            else if (goods_obj.CheckExistance("ID", txtID.Text, "GoodsTbl"))
            {
                res = MessageBox.Show("Are you really want to edit goods?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    query = $"UPDATE GoodsTbl SET Name = '{txtNameGoods.Text}', Amount = '{txtAmount.Text}', Price = '{txtPrice.Text}',Category = '{comboCat.SelectedValue}' WHERE ID = '{txtID.Text}'";
                    goods_obj.sqlChange(query, "Goods Updated successfully");
                    goods_obj.populate(dgGoods, "SELECT * FROM GoodsTbl");
                }
            }
            else
            {
                MessageBox.Show("Goods with this index does not exist, first create it to edit");
            }
        }

        private void lblMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void comboCat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void sellingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new adminSellingForm().Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
