<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="chitiet.aspx.cs" Inherits="HuynhAnhTuan_0911.chitiet1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:DataList ID="DataList2" runat="server">
        <ItemTemplate>
        
        <br />
        <asp:Image ID="Image1" runat="server" ImageUrl='<%# "~/images/" + Eval("HinhAnh") %>' Height="76px" Width="91px" />
        <br />
        <asp:Label ID="Label1" runat="server" Text='<%# Eval("TenHoa") %>'></asp:Label>
        <br />
        <asp:Label ID="Label3" runat="server" Text='<%# Eval("MoTa") %>'></asp:Label>
        <br />
        <asp:Label ID="Label2" runat="server" Text='<%# Eval("DonGia", "{0:0,0}") %>'></asp:Label>

    </ItemTemplate>
    </asp:DataList>
</asp:Content>
