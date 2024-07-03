<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Product.aspx.cs" Inherits="Codehtml.Product" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <h1>Ngày ngay sản phẩm ngày càng đắt đỏ và có giá trị</h1>
    <asp:DataList ID="DataList1" runat="server" RepeatColumns="4" RepeatDirection="Horizontal">
        <ItemTemplate>
            <asp:Image ID="Image1" runat="server" ImageUrl='<%# "~/img/"+Eval("hinh") %>' With="200px" />
        </ItemTemplate>
    </asp:DataList>
    <asp:LinkButton ID="LinkButton1" runat="server" 
        CommandArgument='<%# Eval("mahang") %>' OnClick="LinkButton1_Click">Chi tiet</asp:LinkButton>
</asp:Content>
