using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Deployment.Internal;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenegmentSystem
{
    public class GoodsClass : SQLCommandHelper 
    {
        public GoodsClass(string ConnString):base(ConnString) { }

        public void populate(ComboBox combo, string query) // in this case it is about filling/populating comboBox
        {
            try
            {
                string columnName = query.Split(' ')[1]; // Getting second word 
                connection.Open(); 
                SqlCommand sql = new SqlCommand(query,connection);
                SqlDataReader reader = sql.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add(columnName, typeof(string));
                dt.Load(reader);
                combo.ValueMember = columnName;
                combo.DataSource = dt;
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

        public void populate(ComboBox combo, string query,string ErrorMessage) // in this case it is about filling/populating comboBox
        {
            try
            {
                string columnName = query.Split(' ')[1]; // Getting second word 
                connection.Open();
                SqlCommand sql = new SqlCommand(query, connection);
                SqlDataReader reader = sql.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add(columnName, typeof(string));
                dt.Load(reader);
                combo.ValueMember = columnName;
                combo.DataSource = dt;
            }
            catch
            {
                if (ErrorMessage != "")MessageBox.Show(ErrorMessage, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        public bool CheckExistance(int ID,string UserName)
        {
            SqlCommand cmd = new SqlCommand($"select * from OrderTbl where ID = '{ID}' AND UserName = '{UserName}'", connection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds1 = new DataSet();
            da.Fill(ds1);
            int i = ds1.Tables[0].Rows.Count;
            return (i>0)?true:false;
        }

        public bool CheckExistance(string ColName,string ColValue,string TblName)
        {
            SqlCommand cmd = new SqlCommand($"select * from {TblName} where {ColName} = '{ColValue}'", connection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds1 = new DataSet();
            try
            {
                da.Fill(ds1);
            }
            catch
            {
                MessageBox.Show("Use suitable data types");
            }
            int i = ds1.Tables[0].Rows.Count;
            return (i > 0) ? true : false;
        }

        public int SQlGetInt(string query)
        {
            int Integer = 0;
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query,connection);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Integer = int.Parse(reader.GetValue(0).ToString());
                }
            }
            catch
            {
                MessageBox.Show("CONNECTION ERROR", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
            return Integer;
        }
    }
}
