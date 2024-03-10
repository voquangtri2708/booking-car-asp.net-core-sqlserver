<%@ Page Title="" Language="C#" MasterPageFile="~/trangchu.Master" AutoEventWireup="true" CodeBehind="donhang.aspx.cs" Inherits="DatVeXe.donhang" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="grw_donhang" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" Height="350px" Width="880px">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:BoundField DataField="bookingID" HeaderText="Mã vé" />
            <asp:BoundField DataField="userName" HeaderText="Tên người dùng" />
            <asp:BoundField DataField="phone" HeaderText="Số điện thoại" />
            <asp:BoundField DataField="bookingDate" HeaderText="Ngày đi" />
            <asp:BoundField DataField="noiden" HeaderText="Nơi đi" />
            <asp:BoundField DataField="noidi" HeaderText="Nơi đến" />
            <asp:BoundField DataField="amount" HeaderText="Giá vé" />
            <asp:TemplateField HeaderText="Hủy vé">
                <ItemTemplate>
                    <asp:LinkButton ID="LinkButton6" runat="server" OnClick="LinkButton6_Click" CommandArgument='<%# Eval("bookingID") %>'>Hủy</asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
        <EditRowStyle BackColor="#2461BF" />
        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#EFF3FB" />
        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#F5F7FB" />
        <SortedAscendingHeaderStyle BackColor="#6D95E1" />
        <SortedDescendingCellStyle BackColor="#E9EBEF" />
        <SortedDescendingHeaderStyle BackColor="#4870BE" />
    </asp:GridView>
    <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
</asp:Content>
