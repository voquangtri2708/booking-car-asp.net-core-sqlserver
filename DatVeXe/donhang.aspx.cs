using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DatVeXe
{
    public partial class donhang : System.Web.UI.Page
    {
        connect_class cnt = new connect_class();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;
            string tendangnhap = Session["username"] + "";
            if (tendangnhap == "") return;
            else
            {
                loadding(tendangnhap);
            }
        }

        private void loadding(string tendangnhap)
        {
            string sql = "select BOOKING.userName, BOOKING.bookingDate, BOOKING.noidi, BOOKING.noiden, BOOKING.bookingID, USERS.phone, PAYMENTS.amount " +
                 "from BOOKING " +
                 "join USERS ON BOOKING.userName = USERS.userName " +
                 "join PAYMENTS ON PAYMENTS.bookingID = BOOKING.bookingID " +
                 "where BOOKING.userName = '" + tendangnhap + "'";


            grw_donhang.DataSource = cnt.laydulieu(sql);
            grw_donhang.DataBind();
        }

        protected void LinkButton6_Click(object sender, EventArgs e)
        {

            string tendangnhap = Session["username"] + "";
            if (tendangnhap == "") return;
            string idbooking = ((LinkButton)sender).CommandArgument;

            string sql = "delete from BOOKING where bookingID=" + idbooking;
            string sql2 = "delete from PAYMENTS where bookingID=" + idbooking;

            int kq = cnt.CapNhat(sql);
            int kq2 = cnt.CapNhat(sql2);

            if (kq > 0)
            {
                //Label1.Text = "HỦY VÉ THÀNH CÔNG";
                loadding(tendangnhap);
            }
            else
            {
                //Label1.Text = "HỦY VÉ KHÔNG THÀNH CÔNG ";
                loadding(tendangnhap);
            }
            
        }
    }
}