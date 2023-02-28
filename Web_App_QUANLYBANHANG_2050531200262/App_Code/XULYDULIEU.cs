using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace Web_App_QUANLYBANHANG_2050531200262.App_Code
{
    public class XULYDULIEU
    {
        SqlConnection con;
        public XULYDULIEU()
        {
            con = new SqlConnection();
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\project_ASP\Sales-Management\Web_App_QUANLYBANHANG_2050531200262\App_Data\dbQUANLYBANHANG.mdf;Integrated Security=True";
        }
        private void MoKetNoi()
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
        }
        private void DongKetNoi()
        {
            if (con.State == ConnectionState.Open)
                con.Close();
        }
        public DataTable getTable(String SQL)
        {
            this.MoKetNoi();
            SqlDataAdapter adp = new SqlDataAdapter(SQL, con);
            DataTable tb = new DataTable();
            adp.Fill(tb);
            this.DongKetNoi();
            return tb;
        }
        public DataTable getTable(String nameprocedurce, SqlParameter[] pr)
        {
            this.MoKetNoi();
            DataTable tb = new DataTable();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = nameprocedurce;
            if (pr != null)
            {
                cmd.Parameters.AddRange(pr);
            }
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp.Fill(tb);
            this.DongKetNoi();
            return tb;
        }
        public void getDataSet(ref DataSet ds, String SQL)
        {
            ds.Tables.Add(this.getTable(SQL));
        }
        public void getDataSet(ref DataSet ds, String nameprocedurce, SqlParameter[] pr)
        {
            ds.Tables.Add(this.getTable(nameprocedurce, pr));
        }
        /// <summary>
        /// Đối tượng command thực thi lệnh SQL
        /// </summary>
        /// <param name="SQL">SQL:insert, update, Delete</param>
        /// <returns>K(<>0, =0) trong đó <>0 thành công và =0 lỗi khi thực thi</returns>
        public int ExeCute(string SQL)
        {
            this.MoKetNoi();
            SqlCommand cmd = new SqlCommand(SQL, this.con);
            int k = (int)cmd.ExecuteNonQuery();
            this.DongKetNoi();
            return k;
        }
        public int ExeCute(string nameprocedurce, SqlParameter[] pr)
        {
            this.MoKetNoi();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = nameprocedurce;
            if (pr != null)
                cmd.Parameters.AddRange(pr);
            int k = (int)cmd.ExecuteNonQuery();
            this.DongKetNoi();
            return k;
        }
    }
}