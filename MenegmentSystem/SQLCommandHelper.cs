using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Data;
using System.Deployment.Application;

namespace MenegmentSystem
{
    interface IHelper
    {
        SqlConnection connection { get; set; }
        void sqlChange(string query, string message = "");
        void populate(DataGridView dg, string query);
    }

    public class SQLCommandHelper : IHelper
    {
        public SqlConnection connection { get; set; }
        public bool SuccessConnState;

        public SQLCommandHelper(string ConnString)
        {
            connection = new SqlConnection(ConnString);
        }

        public virtual void sqlChange(string query, string message = "") // Named because it can be good at Inserting/Updating/Deleting info from database
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                if (!message.Equals(""))MessageBox.Show(message);
                SuccessConnState = true;
            }
            catch
            {
                MessageBox.Show("CONNECTION ERROR", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SuccessConnState = false;
            }
            finally
            {
                connection.Close();
            }
        }

        public virtual void populate(DataGridView dg,string query) // for filling and refreshing datagrid 
        {
            try
            {
                connection.Open();
                SqlDataAdapter sda= new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dg.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("CONNECTION ERROR", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        public virtual void populate(DataGridView dg, string query, string ErrorMessage="") // for filling and refreshing datagrid 
        {
            try
            {
                connection.Open();
                SqlDataAdapter sda = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dg.DataSource = dt;
            }
            catch
            {
                if (ErrorMessage == ""){}
                else{MessageBox.Show(ErrorMessage, "", MessageBoxButtons.OK, MessageBoxIcon.Error);}
            }
            finally
            {
                connection.Close();
            }
        }

        public bool GetConnectionState()
        {
            return SuccessConnState;
        }

    }
}
