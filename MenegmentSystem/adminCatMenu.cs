using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Printing;
using System.Diagnostics;

namespace MenegmentSystem
{
    public partial class adminCatMenu : Form
    {
        //
        string query;
        SQLCommandHelper sqlCommandHelper = new SQLCommandHelper(@"Data Source=PASHA\SQLEXPRESS;Initial Catalog=KursovaDB;Integrated Security=True");
        GoodsClass goods = new GoodsClass(@"Data Source=PASHA\SQLEXPRESS;Initial Catalog=KursovaDB;Integrated Security=True");
        DialogResult res;

        public adminCatMenu()
        {
            InitializeComponent();
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            FormActions.ExitForm(this);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!goods.CheckExistance("ID", txtID.Text, "CategoriesTbl") && !goods.CheckExistance("CatName",txtName.Text, "CategoriesTbl") )
            {
                query = $"INSERT INTO CategoriesTbl VALUES ('{txtID.Text}','{txtName.Text}')";
                sqlCommandHelper.sqlChange(query, "Category successfully added");
                sqlCommandHelper.populate(dgCategory, "SELECT * FROM CategoriesTbl");
            }
            else
            {
                MessageBox.Show("Specify index or category name that doesn't already exist");
            }  
        }
      
        private void adminMenu_Load(object sender, EventArgs e)
        {
            sqlCommandHelper.populate(dgCategory,"SELECT * FROM CategoriesTbl");
        }

        private void dgCategories_CellContentClick(object sender, DataGridViewCellEventArgs e) // SELECTING ROW 
        {
            txtID.Text = dgCategory.SelectedRows[0].Cells[0].Value.ToString();
            txtName.Text = dgCategory.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtID.Text == "")
            {
                MessageBox.Show("Missing information");
            }
            else
            {
                if (goods.CheckExistance("ID", txtID.Text, "CategoriesTbl"))
                {
                    res = MessageBox.Show("Are you sure you want to edit this category?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (res == DialogResult.Yes)
                    {
                        query = $"UPDATE CategoriesTbl SET CatName = '{txtName.Text}' WHERE ID = '{txtID.Text}'";
                        sqlCommandHelper.sqlChange(query, "Ctegory Updated successfully");
                        sqlCommandHelper.populate(dgCategory, "SELECT * FROM CategoriesTbl");
                    }
                }
                else
                {
                    MessageBox.Show("Category with this index does not exist, first create it to edit");
                }
                    
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (goods.CheckExistance("ID", txtID.Text, "CategoriesTbl"))
            {
                res = MessageBox.Show("Are you sure you want to delete category?","",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    query = $"DELETE FROM CategoriesTbl WHERE ID = '{txtID.Text}' AND CatName = '{txtName.Text}'";
                    sqlCommandHelper.sqlChange(query, "Ctegory Deleted successfully");
                    sqlCommandHelper.populate(dgCategory, "SELECT * FROM CategoriesTbl");
                }                
            }
            else
            {
                MessageBox.Show("Select existing index in database to delete");
            }  
        }

        private void goodsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new adminGoodsMenu().Show();
        }

        private void lblMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void sellingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new adminSellingForm().Show();
        }
    }
}
