﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="KetNoiDB.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        Loại Hàng: 
        <asp:RadioButtonList ID="RadioButtonList1" AutoPostBack="True" runat="server" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged"></asp:RadioButtonList>
        <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
    </form>
</body>
</html>
