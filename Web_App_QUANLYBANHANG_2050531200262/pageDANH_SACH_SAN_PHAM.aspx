<%@ Page Title="" Language="C#" MasterPageFile="~/MASTER_USER_PAGE.Master" AutoEventWireup="true" CodeBehind="pageDANH_SACH_SAN_PHAM.aspx.cs" Inherits="Web_App_QUANLYBANHANG_2050531200262.pageDANH_SACH_SAN_PHAM" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:DataList ID="DataList1" runat="server">
        <ItemTemplate>
            <a href='page_CHITIETSANPHAM.aspx?MASANPHAM=<%# Eval("MASANPHAM") %>'>
                <img alt="" src='IMAGES/<%# Eval("HINHANH") %>' width ="150px" height="150px" />
            </a>
            <br />
            Tên sản phẩm: <%# Eval("TENSANPHAM") %>
            <br />
            Đơn giá: <%# Eval("DONGIA") %>
        </ItemTemplate>
    </asp:DataList>
</asp:Content>
