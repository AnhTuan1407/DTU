<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Kiemloi.aspx.cs" Inherits="Codehtml.Kiemloi" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <%-- <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Không được để trống" ControlToValidate="TextBox1" Display="Dynamic"></asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Không đúng định dạng email" ControlToValidate="TextBox1" Display="Dynamic" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
        <asp:Button ID="Button1" runat="server" Text="Button" />--%>

        <table>
            <tr>
                <td>Email</td>
                <td>
                    <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Không được để trống" ControlToValidate="txtEmail" Display="Dynamic"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Không đúng định dạng email" ControlToValidate="txtEmail" Display="Dynamic" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td>Xac nhan Email</td>
                <td>
                    <asp:TextBox ID="txtXacnhanEmail" runat="server"></asp:TextBox>
                    <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Không giống email" ControlToCompare="txtEmail" ControlToValidate="txtXacnhanEmail" Display="Dynamic"></asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td>Điểm</td>
                <td>
                    <asp:TextBox ID="txtDiem" runat="server"></asp:TextBox>
                    <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="Điểm phải từ 0 đến 10" ControlToValidate="txtDiem" Display="Dynamic" MaximumValue="10" MinimumValue="0" Type="Double"></asp:RangeValidator>
                </td>
            </tr>
            <tr>
                <td>Ngày sinh</td>
                <td>
                    <asp:TextBox ID="txtNgaysinh" runat="server"></asp:TextBox>
                    <asp:CompareValidator ID="CompareValidator2" runat="server" ErrorMessage="Ngày sinh phải trên 16" ControlToValidate="txtNgaysinh" Display="Dynamic" Operator="LessThan" Type="Date"></asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td></td>
                <td>
                    <asp:Button ID="btnKiemloi" runat="server" Text="Kiểm lỗi" />

                </td>
            </tr>
            <tr>
                <td></td>
                <td>
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" HeaderText="Vui lòng khắc phục các lỗi sau"
                        ShowMessageBox="True" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
