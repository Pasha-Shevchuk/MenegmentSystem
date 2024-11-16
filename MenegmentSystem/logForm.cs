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
using System.Diagnostics;

namespace MenegmentSystem
{
    public partial class logForm : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=PASHA\SQLEXPRESS;Initial Catalog=KursovaDB;Integrated Security=True");
        SqlDataAdapter adapter;
        DataTable dt = new DataTable();
        string query;
        public static string UserName;

        public logForm()
        {
            InitializeComponent();
        }

        private void lb_exit_Click(object sender, EventArgs e)
        {
            FormActions.ExitForm(this);
        }

        private void logForm_Load(object sender, EventArgs e)
        {
        }

        private void checkAdmin_CheckedChanged(object sender, EventArgs e)
        {
            if (checkAdmin.Checked)
            {
                DialogResult res = MessageBox.Show("This property is only for admins!", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                checkAdmin.Checked = (res.Equals(DialogResult.OK)) ? true : false;
            }
            label1.Text = (checkAdmin.Checked) ? "Admin name" : "Username";
        }

        private void lblCreateAcc_Click(object sender, EventArgs e)
        {
            this.Hide();
            new regForm().Show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            FormActions.ClearTxts(txtPassword,txtName);
            txtPassword.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (checkAdmin.Checked)
            {
                query = $"SELECT * FROM AdminData WHERE nameAdm = '{txtName.Text}' AND password = '{txtPassword.Text}'";
            }
            else
            {
                query = $"SELECT * FROM UserData WHERE username = '{txtName.Text}' AND password = '{txtPassword.Text}'";
            }
            try
            {
                conn.Open();
                adapter = new SqlDataAdapter(query, conn);
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    this.Hide();
                    if (checkAdmin.Checked)
                    {
                        new adminCatMenu().Show();
                    }
                    else
                    {
                        UserName = txtName.Text;
                        new userMenu().Show();
                    }
                }
                else
                {
                    MessageBox.Show("Login error", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("Connection Error", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
                btnClear_Click(sender, e);
                txtName.Focus();
            }
        }

        private void checkShowPas_CheckedChanged(object sender, EventArgs e)
        {
            FormActions.ShowPas(checkShowPas,txtPassword);
        }

        private void lblMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }       
    }
}
