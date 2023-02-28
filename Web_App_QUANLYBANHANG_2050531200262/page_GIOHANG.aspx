<%@ Page Title="" Language="C#" MasterPageFile="~/MASTER_USER_PAGE.Master" AutoEventWireup="true" CodeBehind="page_GIOHANG.aspx.cs" Inherits="Web_App_QUANLYBANHANG_2050531200262.page_GIOHANG" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="grvCART" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" ShowFooter="True" GridLines="Horizontal">
        <AlternatingRowStyle BackColor="#F7F7F7" />
        <Columns>
            <asp:BoundField DataField="MASANPHAM" HeaderText="Mã sản phẩm" />
            <asp:BoundField DataField="TENSANPHAM" HeaderText="Tên sản phẩm" />
            <asp:BoundField DataField="SOLUONG" HeaderText="Số lượng" />
            <asp:BoundField DataField="DONGIA" HeaderText="Đơn giá" />
            <asp:BoundField DataField="THANHTIEN" HeaderText="Thành tiền" />
            <asp:ImageField DataAlternateTextField="HINHANH" DataImageUrlField="HINHANH" DataImageUrlFormatString="IMAGES/{0}" HeaderText="Ảnh" ControlStyle-Width="100px" ControlStyle-Height="100px">
<ControlStyle Height="100px" Width="100px"></ControlStyle>
            </asp:ImageField>
            <asp:TemplateField HeaderText="Trả hàng">
                <ItemTemplate>
                    <asp:CheckBox ID="ckbREMOVEITEM" runat="server" />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
        <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
        <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
        <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
        <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
        <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
        <SortedAscendingCellStyle BackColor="#F4F4FD" />
        <SortedAscendingHeaderStyle BackColor="#5A4C9D" />
        <SortedDescendingCellStyle BackColor="#D8D8F0" />
        <SortedDescendingHeaderStyle BackColor="#3E3277" />
    </asp:GridView>
    <asp:Button ID="btnDELETE" runat="server" OnClick="btnDELETE_Click" Text="Trả hàng" Height="54px" Width="147px" />
</asp:Content>
