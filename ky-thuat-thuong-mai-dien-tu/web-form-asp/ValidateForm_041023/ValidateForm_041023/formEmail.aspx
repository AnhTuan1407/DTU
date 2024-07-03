<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="formEmail.aspx.cs" Inherits="ValidateForm_041023.formEmail" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
          <table>
              <tr>
                  <th>Email</th>
                  <td>
                      <asp:TextBox ID="txtEmail" runat="server"  placeholder="@gmail.com"></asp:TextBox></td>
              </tr>
              <tr>
                  <th>Email Verification</th>
                  <td>
                      <asp:TextBox ID="txtXacNhanEmail" runat="server" placeholder="Enter email"></asp:TextBox></td>
              </tr>
              <tr>
                  <th>Mark</th>
                  <td>
                      <asp:TextBox ID="txtDiem" runat="server" placeholder="0->10"></asp:TextBox>
                  </td>
              </tr>
              <tr>
                  <th>Birthday</th>
                  <td>
                      <asp:TextBox ID="txtNgaySinh" runat="server"></asp:TextBox></td>
              </tr>
              <tr>
                  <th></th>
                  <td>
                      <asp:Button ID="Button1" runat="server" Text="Click" /></td>
              </tr>
          </table>
        </div>
    </form>
</body>
</html>
