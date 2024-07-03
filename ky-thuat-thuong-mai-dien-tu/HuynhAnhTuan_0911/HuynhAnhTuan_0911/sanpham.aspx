<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="sanpham.aspx.cs" Inherits="HuynhAnhTuan_0911.sanpham" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:DataList ID="DataList1" runat="server">
    <ItemTemplate>
        <asp:Label ID="Label1" runat="server" Text='<%# Eval("TenHoa") %>'></asp:Label>
        <br />
        <asp:Image ID="Image1" runat="server" ImageUrl='<%# "~/images/" + Eval("HinhAnh") %>' Height="76px" Width="91px" />
        <br />
        <asp:Label ID="Label2" runat="server" Text='<%# Eval("DonGia", "{0:0,0}") %>'></asp:Label>

        <asp:LinkButton ID="LinkButton1" runat="server" CommandArgument='<%# Eval("MaHoa") %>' OnClick="LinkButton1_Click" >LinkButton</asp:LinkButton>
    </ItemTemplate>
</asp:DataList>
</asp:Content>
