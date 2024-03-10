using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
namespace DatVeXe
{
    public class connect_class : System.Web.UI.Page
    {
        SqlConnection cn;
        private void layketnoi()
        {
            string sqlCon = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Server.MapPath("/App_Data/DB_datvexe.mdf") + ";Integrated Security=True";
            cn = new SqlConnection(sqlCon);
            cn.Open();
        }
        private void dongketnoi()
        {
            if (cn.State == ConnectionState.Open)
                cn.Close();
        }
        public DataTable laydulieu(string sql)
        {
            DataTable dt = new DataTable();
            try
            {
                layketnoi();
                SqlDataAdapter da = new SqlDataAdapter(sql, cn);
                da.Fill(dt);
            }
            catch
            {
                dt = null;
                // thong bao loi
            }
            finally
            {
                dongketnoi();
            }
            return dt;
        }
        public int CapNhat(string sql)
        {
            int ketqua = 0;
            try
            {
                layketnoi();
                SqlCommand cmd = new SqlCommand(sql, cn);
                ketqua = cmd.ExecuteNonQuery();
            }
            catch
            {
                ketqua = 0;
            }
            finally
            {
                dongketnoi();
            }
            return ketqua;
        }
    }
}