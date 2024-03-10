using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace DatVeXe
{
    public partial class dulich : System.Web.UI.Page
    {
        connect_class cnt = new connect_class();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;
            if (Request.QueryString["a"] != null && Request.QueryString["b"] != null)
            {
                int a = int.Parse(Request.QueryString["a"]);
                int b = int.Parse(Request.QueryString["b"]);
                chuyenxehot(a, b);
            }

            string tendangnhap = Session["username"] + "";
            if (tendangnhap == "")
            {
                lb_sup.Text = "Bạn phải đăng nhập !!";
                return;
            }

        }


        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            if (booking_date.SelectedDate < DateTime.Today)
            {
                lb_tbNgay.Text = "Vui long chọn ngày đi trước ngày hiện tại !!";
            }
            else
            {
                lb_tbNgay.Text = "";
            }
        }

        protected void bt_xacnhan_Click(object sender, EventArgs e)
        {
            string tendangnhap = Session["username"] + "";
            if (tendangnhap != "")
            {
                if (booking_date.SelectedDate > DateTime.Today && drdlDuLich_F.SelectedValue != drdlDuLich_L.SelectedValue)
                {
                    DateTime currentTime = DateTime.Now;
                    int x = currentTime.Hour * 10000 + currentTime.Minute * 100 + currentTime.Second;
                    string sql = "insert into BOOKING values('" + x.ToString() + "', '" + tendangnhap + "', '" +
                        booking_date.SelectedDate.ToString("MM/dd/yyy") + "', '" + drdlDuLich_L.SelectedItem.Text +
                        "', '" + drdlDuLich_F.SelectedItem.Text + "')";

                    string sql2 = "insert into PAYMENTS values('" + (x + 300).ToString() + "', '" + x.ToString() + "', " + 300 + ", '" +
                        booking_date.SelectedDate.ToString("MM/dd/yyy") + "')";

                    int kt = cnt.CapNhat(sql);
                    int kt2 = cnt.CapNhat(sql2);
                    if (kt > 0 && kt2 > 0)
                    {
                        lb_sup.Text = "Bạn đã đặt vé thành công.";
                    }
                    else
                    {
                        lb_sup.Text = "Bạn đã đặt vé không thành công. Vui lòng kiểm tra lại nơi đi và ngày đi!";
                    }
                }
                else
                {
                    lb_sup.Text = "Bạn đã đặt vé không thành công. Vui lòng kiểm tra lại nơi đi và ngày đi!";
                }

            }
            else
            {
                lb_sup.Text = "Bạn phải đăng nhập !!";

            }
        }

        public void chuyenxehot(int newvalue1, int newvalue2)
        {
            drdlDuLich_F.SelectedValue = newvalue1.ToString();
            drdlDuLich_L.SelectedValue = newvalue2.ToString();
        }

    }
}