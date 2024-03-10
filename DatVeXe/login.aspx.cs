using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace DatVeXe
{
    public partial class login : System.Web.UI.Page
    {
        connect_class cnt = new connect_class();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Login1_Authenticate1(object sender, AuthenticateEventArgs e)
        {
            string tendangnhap = Login1.UserName;
            string matkhau = Login1.Password;
            string sql = "select * from USERS where userName='"
                    + tendangnhap + "' and password='" + matkhau + "'";
            DataTable dt = new DataTable();
            dt = cnt.laydulieu(sql);
            if (dt.Rows.Count > 0)
            {
                Session["username"] = tendangnhap;
                Login1.FailureText = "Đăng nhập thành công.";
                Response.Redirect("dulich.aspx");
            }
            else
            {
                Login1.FailureText = "Tên đăng nhập và mật khẩu không đúng";
            }
        }
    }
}