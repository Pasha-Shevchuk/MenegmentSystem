using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace MenegmentSystem
{
    public partial class userMenu : Form
    {
        string querry;
        GoodsClass order_obj = new GoodsClass(@"Data Source=PASHA\SQLEXPRESS;Initial Catalog=KursovaDB;Integrated Security=True");

        int Id; //
        string GoodsName; //
        int MenuAmount; // Common Amount from GoodsTbl
        int OrderAmount; // Order Amount of user goods
        int Price; //Price for unit
        int TotalPrice; // Price for goods by id -> From OrderTbl
        string Category; //
        string UserName = logForm.UserName; // Get UserName from registration to write it to OrderTbl as UserName column
        int TOTAL = 0; //Total price for all goods that user bought


        public userMenu()
        {
            InitializeComponent();
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            FormActions.ExitForm(this);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lblLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            new logForm().Show();
        }

        private void userMenu_Load(object sender, EventArgs e)
        {
            order_obj.populate(comboCatSel, "SELECT CatName FROM CategoriesTbl");
            order_obj.populate(dgCatalog, "SELECT * FROM GoodsTbl");
            order_obj.populate(dgOrder, $"SELECT * FROM OrderTbl WHERE UserName = '{UserName}'");
            dgOrder.Columns[0].HeaderText = "BarCode";
            if (dgOrder.Rows != null && dgOrder.Rows.Count != 0)
            {
                for (int i = 0; i < dgOrder.Rows.Count-1; i++)
                {
                    TOTAL += int.Parse(dgOrder.Rows[i].Cells[3].Value.ToString());
                }
            }
            else
            {
                TOTAL = 0;

            }
            lblTOTAL.Text = "TOTAL: " + TOTAL.ToString() + "UAH";
        }

        private void dgCatalog_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Id = Convert.ToInt32(dgCatalog.SelectedRows[0].Cells[0].Value.ToString());
            GoodsName = dgCatalog.SelectedRows[0].Cells[1].Value.ToString();
            MenuAmount = Convert.ToInt32(dgCatalog.SelectedRows[0].Cells[2].Value.ToString());
            Price = Convert.ToInt32(dgCatalog.SelectedRows[0].Cells[3].Value.ToString());
            Category = dgCatalog.SelectedRows[0].Cells[4].Value.ToString();
            label6.Text = Id.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //ID
            //GoodsName
            try
            {
                OrderAmount = int.Parse(txtAmount.Text);
            }
            catch { MessageBox.Show("Missing Amount"); }
            TotalPrice = Price * OrderAmount;
            //Category
            //UserName
            ////////////////////////////////////////// HERE
            if(OrderAmount <= MenuAmount && OrderAmount >0 && txtAmount.Text!="") // ok
            {
                if (order_obj.CheckExistance(Id,UserName)) // exist 
                {
                    order_obj.sqlChange($"UPDATE OrderTbl SET OrderAmount = OrderAmount+{OrderAmount},TotalPrice=TotalPrice+((SELECT Price FROM GoodsTbl WHERE ID={Id})*{OrderAmount}) WHERE ID = '{Id}' AND UserName = '{UserName}'"); // WE CAN INCREASE VALUES IN DB
                }
                else // not exists
                {
                    order_obj.sqlChange($"INSERT INTO OrderTbl VALUES ('{Id}','{GoodsName}','{OrderAmount}','{TotalPrice}','{Category}','{UserName}')");
                }
                MenuAmount -= OrderAmount;
                order_obj.sqlChange($"UPDATE GoodsTbl SET Amount = '{MenuAmount}' WHERE ID = '{Id}'", "Goods added to your order");

            }
            else
            {
                MessageBox.Show("You cannot order more than in warehouse");
            }
            order_obj.populate(dgCatalog,"SELECT * FROM GoodsTbl");
            order_obj.populate(dgOrder, $"SELECT * FROM OrderTbl WHERE UserName = '{UserName}'");
            TOTAL += TotalPrice;
            lblTOTAL.Text ="TOTAL: " + TOTAL.ToString() + "UAH";
        }

        private void Refresh(object sender, EventArgs e)
        {
            order_obj.populate(dgCatalog, $"SELECT * FROM GoodsTbl WHERE Category = '{comboCatSel.SelectedValue.ToString()}'","");
        }

        private void dtnDelete_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you really want to delete an order?","",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (res==DialogResult.Yes)
            {
                order_obj.sqlChange($"DELETE FROM OrderTbl WHERE ID='{Id}' AND UserName = '{UserName}'");//delete from OrderTbl
                MenuAmount += OrderAmount;
                order_obj.sqlChange($"UPDATE GoodsTbl SET Amount = '{MenuAmount}' WHERE ID='{Id}'");//uptade to GoodsTbl
                order_obj.populate(dgCatalog, "SELECT * FROM GoodsTbl");
                order_obj.populate(dgOrder, $"SELECT * FROM OrderTbl WHERE UserName = '{UserName}'");
                TOTAL -= TotalPrice;
                lblTOTAL.Text = "TOTAL: " + TOTAL.ToString() + "UAH";
            }
            
        }

        private void dgOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Id = int.Parse(dgOrder.SelectedRows[0].Cells[0].Value.ToString());
            OrderAmount = int.Parse(dgOrder.SelectedRows[0].Cells[2].Value.ToString());
            TotalPrice = int.Parse(dgOrder.SelectedRows[0].Cells[3].Value.ToString());
            lblOrderSelect.Text = Id.ToString();
            MenuAmount = order_obj.SQlGetInt($"SELECT Amount FROM GoodsTbl WHERE ID = {Id} ");
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            if (dgOrder.Rows.Count > 1)
            {
                DialogResult res = MessageBox.Show("Press OK to continue purchasing", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (res == DialogResult.OK)
                {
                    int i = rand.Next(0, 1000);
                    var dateAndTime = DateTime.Now;
                    MessageBox.Show($"PROCESSING YOUR ORDER\nUserName: {UserName}\nOrderNumber: {i}\nTotal: {TOTAL}\nDate: {dateAndTime}");
                }
            }
            else
            {
                MessageBox.Show("You haven't ordered any item");
            }
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            order_obj.populate(dgCatalog,"SELECT * FROM GoodsTbl");
        }

        private void comboCatSel_SelectedIndexChanged(object sender, EventArgs e)
        {
            Refresh(sender, e);
        }
    }
}
