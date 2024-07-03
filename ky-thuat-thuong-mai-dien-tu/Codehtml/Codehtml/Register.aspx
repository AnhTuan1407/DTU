<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Codehtml.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="dk.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <div class="form">
        <h2>Đăng ký Thành viên</h2>
        <asp:textbox Cssclass="txt" runat="server" placeholder="Ten dang nhap"></asp:textbox>
        <asp:textbox Cssclass="txt" runat="server" placeholder="Mat khau"></asp:textbox>
        <asp:textbox Cssclass="txt" runat="server" placeholder="Xac nhan mat khau"></asp:textbox>
        <asp:button Cssclass="btnDK" runat="server" text="Đăng Ký" />
    </div>
</asp:Content>
