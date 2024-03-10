using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Threading;

namespace DatVeXe
{
    public partial class taotaikhoan : System.Web.UI.Page
    {
        connect_class cnt = new connect_class();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (tb_ttk.Text != "")
            {
                string sql = "insert into USERS values('" + tb_ttk.Text.ToString() + "', '" + tb_mk.Text.ToString() + "', '" + tb_sdt.Text.ToString() + "')";
                int kt = cnt.CapNhat(sql);
                if (kt > 0)
                {
                    lb_thongbao.Text = "Tạo tài khoản thành công.";
                    Thread.Sleep(3000);
                    Response.Redirect("login.aspx");
                }
                else
                {
                    lb_thongbao.Text = "Không thành công (Tên đăng nhập đã tồn tại).";
                }
            }
            else
            {
                lb_thongbao.Text = "Không thành công !!";
            }
        }
    }
}