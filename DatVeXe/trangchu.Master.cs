using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace DatVeXe
{
    public partial class trangchu : System.Web.UI.MasterPage
    {
        dulich dl = new dulich();
        connect_class cnt = new connect_class();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;
        }

        protected void btLogin_Click1(object sender, EventArgs e)
        {
            Response.Redirect("login.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("taotaikhoan.aspx");
        }
        
        private void chuyenhot(int a, int b)
        {
            Response.Redirect("dulich.aspx?a=" + a + "&b=" + b);
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            chuyenhot(8, 7);
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            chuyenhot(4, 1);
        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            chuyenhot(1, 2);
        }

        protected void LinkButton4_Click(object sender, EventArgs e)
        {
            chuyenhot(8, 9);
        }

        protected void LinkButton5_Click(object sender, EventArgs e)
        {
            chuyenhot(5, 4);
        }
    }
}