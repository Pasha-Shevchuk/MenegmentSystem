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

namespace MenegmentSystem
{
    public partial class regForm : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=PASHA\SQLEXPRESS;Initial Catalog=KursovaDB;Integrated Security=True");
        SqlCommand cmd;
        string sql;
        bool checkmail;

        public regForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            FormActions.ClearTxts(txtConfPass,txtEmail,txtPassword,txtUsername);
            txtUsername.Focus();
        }

        private void lblBackLog_Click(object sender, EventArgs e)
        {
            this.Hide();
            new logForm().Show();
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            FormActions.ExitForm(this);
        }

        private void btnReg_Click(object sender, EventArgs e) 
        {
            checkmail = FormActions.EmailValidator(txtEmail.Text);
            if (txtConfPass.Text == "" || txtEmail.Text=="" || txtPassword.Text=="" || txtUsername.Text=="")
            {
                MessageBox.Show("Fields have to be filled","",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else if (txtConfPass.Text == txtPassword.Text && checkmail)
            {
                sql = $"INSERT INTO UserData (username,password) values ('{txtUsername.Text}','{txtPassword.Text}')";
                try
                {
                    conn.Open();
                    cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Account successfully created", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    new logForm().Show();
                }
                catch
                {
                    MessageBox.Show("Connection Error", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show("Passwords don't match", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            btnClear_Click(sender, e);
        }

        private void regForm_Load(object sender, EventArgs e)
        {
        }

        private void checkShowPas_CheckedChanged(object sender, EventArgs e)
        {
            FormActions.ShowPas(checkShowPas,txtPassword,txtConfPass);
        }

        private void lblMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
