<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="pageQUANLYDANHMUC.aspx.cs" Inherits="Web_App_QUANLYBANHANG_2050531200262.ADMIN.pageQUANLYDANHMUC" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style2 {
            width: 233px;
            height: 46px;
        }
        .auto-style3 {
            height: 46px;
        }
        .auto-style4 {
            height: 46px;
            width: 210px;
        }
        .auto-style5 {
            width: 210px;
        }
        .auto-style9 {
            width: 233px;
            height: 50px;
        }
        .auto-style10 {
            height: 50px;
            width: 210px;
        }
        .auto-style11 {
            height: 50px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width:100%;">
                <tr>
                    <td class="auto-style2" style="text-align: center">Mã danh mục</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="txtMaDanhMuc" runat="server" Height="30px" Width="180px"></asp:TextBox>
                    </td>
                    <td class="auto-style3"></td>
                </tr>
                <tr>
                    <td class="auto-style2" style="text-align: center">Tên danh mục</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="txtTenDanhMuc" runat="server" Height="30px" Width="180px"></asp:TextBox>
                    </td>
                    <td class="auto-style3"></td>
                </tr>
                <tr>
                    <td class="auto-style9"></td>
                    <td class="auto-style10">
                        <asp:Button ID="btnLuu" runat="server" Height="30px" Text="Lưu" Width="50px" OnClick="btnLuu_Click" />
                    </td>
                    <td class="auto-style11"></td>
                </tr>
                <tr>
                    <td class="auto-style9"></td>
                    <td class="auto-style10">
                        <asp:Button ID="btnSua" runat="server" Height="30px" Text="Sửa" Width="50px" OnClick="btnSua_Click" />
                    </td>
                    <td class="auto-style11"></td>
                </tr>
                <tr>
                    <td class="auto-style9"></td>
                    <td class="auto-style10">
                        <asp:Button ID="btnXoa" runat="server" Height="30px" Text="Xóa" Width="50px" OnClick="btnXoa_Click" />
                    </td>
                    <td class="auto-style11"></td>
                </tr>
                <tr>
                    <td colspan="3">
                        <asp:GridView ID="grvDANHMUC" runat="server" AllowPaging="True" Height="192px" OnPageIndexChanging="grvDANHMUC_PageIndexChanging" OnRowCancelingEdit="grvDANHMUC_RowCancelingEdit" OnRowEditing="grvDANHMUC_RowEditing" PageSize="3" Width="648px" OnRowDeleting="grvDANHMUC_RowDeleting" OnRowUpdating="grvDANHMUC_RowUpdating">
                            <Columns>
                                <asp:CommandField ButtonType="Button" ShowDeleteButton="True" ShowEditButton="True" />
                            </Columns>
                        </asp:GridView>
                    </td>
                </tr>
                <tr>
                    <td>
                        &nbsp;</td>
                    <td class="auto-style5">
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
