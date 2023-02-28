<%@ Page Title="" Language="C#" MasterPageFile="~/MASTER_USER_PAGE.Master" AutoEventWireup="true" CodeBehind="page_CHITIETSANPHAM.aspx.cs" Inherits="Web_App_QUANLYBANHANG_2050531200262.page_CHITIETSANPHAM" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Repeater ID="Repeater2" runat="server">
        <ItemTemplate>
            <img alt="" src='IMAGES/<%# Eval("HINHANH") %>' width="150px" height="150px" />
            <h1>Tên sản phẩm: <%# Eval("TENSANPHAM") %></h1>
            <%# Eval("MOTA") %>
            <br />
        </ItemTemplate>
    </asp:Repeater>
    <asp:DropDownList ID="drSOLUONG" runat="server"></asp:DropDownList>
    <asp:Button ID="btn_GIOHANG" runat="server" Text="Giỏ hàng" OnClick="btn_GIOHANG_Click" />
</asp:Content>
