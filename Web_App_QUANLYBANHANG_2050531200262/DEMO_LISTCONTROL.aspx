<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DEMO_LISTCONTROL.aspx.cs" Inherits="Web_App_QUANLYBANHANG_2050531200262.DEMO_LISTCONTROL" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style2 {
            width: 292px;
            height: 147px;
        }
        .auto-style3 {
            height: 147px;
        }
        .auto-style4 {
            width: 292px;
            height: 139px;
        }
        .auto-style5 {
            height: 139px;
        }
        .auto-style6 {
            width: 292px;
            height: 127px;
        }
        .auto-style7 {
            height: 127px;
        }
        .auto-style8 {
            width: 292px;
            height: 148px;
        }
        .auto-style9 {
            height: 148px;
        }
        .table, th, td {
            border: 1px solid black;
            border-collapse: collapse;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width:100%;">
                <tr>
                    <td class="auto-style8">LISTBOX</td>
                    <td class="auto-style8">
                        <asp:ListBox ID="ListBox1" runat="server">
                            <%--<asp:ListItem>LE A</asp:ListItem>
                            <asp:ListItem>LE B</asp:ListItem>
                            <asp:ListItem>LE C</asp:ListItem>--%>
                        </asp:ListBox>
                    </td>
                    <td class="auto-style9"></td>
                </tr>
                <tr>
                    <td class="auto-style6">DROPDOWNLIST</td>
                    <td class="auto-style6">
                        <asp:DropDownList ID="DropDownList1" runat="server">
                            <%--<asp:ListItem>A</asp:ListItem>
                            <asp:ListItem>B</asp:ListItem>
                            <asp:ListItem>C</asp:ListItem>--%>
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style7"></td>
                </tr>
                <tr>
                    <td class="auto-style4">CHECKBOXLIST</td>
                    <td class="auto-style4">
                        <asp:CheckBoxList ID="CheckBoxList1" runat="server">
                            <%--<asp:ListItem>A</asp:ListItem>
                            <asp:ListItem>B</asp:ListItem>
                            <asp:ListItem>C</asp:ListItem>--%>
                        </asp:CheckBoxList>
                    </td>
                    <td class="auto-style5"></td>
                </tr>
                <tr>
                    <td class="auto-style2">RADIOBUTTONLIST</td>
                    <td class="auto-style2">
                        <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                            <%--<asp:ListItem>A</asp:ListItem>
                            <asp:ListItem>B</asp:ListItem>
                            <asp:ListItem>C</asp:ListItem>--%>
                        </asp:RadioButtonList>
                    </td>
                    <td class="auto-style3"></td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Button ID="Button1" runat="server" Height="50px" OnClick="Button1_Click" Text="Selected Item" Width="165px" />
                    </td>
                    <td class="auto-style2">
                        <asp:Button ID="Button2" runat="server" Height="50px" Text="Remove Item Selected" Width="165px" OnClick="Button2_Click" />
                    </td>
                    <td class="auto-style3">
                        <asp:Button ID="Button3" runat="server" Height="50px" Text="Clear All" Width="165px" OnClick="Button3_Click" />
                        <asp:Button ID="Button4" runat="server" Height="50px" Text="Enable Item" Width="165px" OnClick="Button4_Click" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
