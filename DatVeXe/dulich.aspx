<%@ Page Title="" Language="C#" MasterPageFile="~/trangchu.Master" AutoEventWireup="true" CodeBehind="dulich.aspx.cs" Inherits="DatVeXe.dulich" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="dulich">
        <tr>
            <td>Chọn địa điểm đi
                <asp:DropDownList ID="drdlDuLich_F" runat="server"  AutoPostBack="true">
                    <asp:ListItem Value="1" Text="Hà Nội"></asp:ListItem>
                    <asp:ListItem Value="2" Text="Hải Phòng"></asp:ListItem>
                    <asp:ListItem Value="3" Text="Huế"></asp:ListItem>
                    <asp:ListItem Value="4" Text="Đà Nẵng"></asp:ListItem>
                    <asp:ListItem Value="5" Text="Quy Nhơn"></asp:ListItem>
                    <asp:ListItem Value="6" Text="Nha Trang"></asp:ListItem>
                    <asp:ListItem Value="7" Text="Đà Lạt"></asp:ListItem>
                    <asp:ListItem Value="8" Text="Thành Phố Hồ Chí Minh"></asp:ListItem>
                    <asp:ListItem Value="9" Text="Cần Thơ"></asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>Chọn địa điểm đến
                <asp:DropDownList ID="drdlDuLich_L" runat="server" AutoPostBack="true">
                    <asp:ListItem Value="1" Text="Hà Nội"></asp:ListItem>
                    <asp:ListItem Value="2" Text="Hải Phòng"></asp:ListItem>
                    <asp:ListItem Value="3" Text="Huế"></asp:ListItem>
                    <asp:ListItem Value="4" Text="Đà Nẵng"></asp:ListItem>
                    <asp:ListItem Value="5" Text="Quy Nhơn"></asp:ListItem>
                    <asp:ListItem Value="6" Text="Nha Trang"></asp:ListItem>
                    <asp:ListItem Value="7" Text="Đà Lạt"></asp:ListItem>
                    <asp:ListItem Value="8" Text="Thành Phố Hồ Chí Minh"></asp:ListItem>
                    <asp:ListItem Value="9" Text="Cần Thơ"></asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>Chọn ngày đi  <br />
                <asp:Calendar ID="booking_date" runat="server" OnClick="booking_date" OnSelectionChanged="Calendar1_SelectionChanged" BackColor="White" BorderColor="Black" BorderStyle="Solid" CellSpacing="1" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="250px" NextPrevFormat="ShortMonth" Width="330px">
                    <DayHeaderStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" Height="8pt" />
                    <DayStyle BackColor="#CCCCCC" />
                    <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="White" />
                    <OtherMonthDayStyle ForeColor="#999999" />
                    <SelectedDayStyle BackColor="#333399" ForeColor="White" />
                    <TitleStyle BackColor="#333399" BorderStyle="Solid" Font-Bold="True" Font-Size="12pt" ForeColor="White" Height="12pt" />
                    <TodayDayStyle BackColor="#999999" ForeColor="White" />
                </asp:Calendar>
                <asp:Label ID="lb_tbNgay" runat="server" Text=""></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="3">
                <br /> 

                <asp:Button ID="bt_xacnhan" runat="server" Text="Xác nhận" OnClick="bt_xacnhan_Click" />

            </td>
        </tr>
        <tr>
            <td colspan="3">
                <asp:Label ID="lb_sup" runat="server" Text=""></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>
