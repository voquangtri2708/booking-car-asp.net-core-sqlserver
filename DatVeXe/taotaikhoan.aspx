<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="taotaikhoan.aspx.cs" Inherits="DatVeXe.taotaikhoan" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="style/mainstyle.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div >
            <table class="ttk">
                <tr>
                    <td colspan="2">
                        <h2>TẠO TÀI KHOẢN</h2>
                    </td>
                </tr>
                <tr>
                    <td>Tên tài khoản</td>
                    <td>
                        <asp:TextBox ID="tb_ttk" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Mật khẩu</td>
                    <td>
                        <asp:TextBox ID="tb_mk" runat="server" TextMode="Password"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Số điện thoại</td>
                    <td>
                        <asp:TextBox ID="tb_sdt" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="Button1" runat="server" Text="Xác nhận" OnClick="Button1_Click" /></td>
                </tr>
                <tr>
                    <td colspan="3">
                        <asp:Label ID="lb_thongbao" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
