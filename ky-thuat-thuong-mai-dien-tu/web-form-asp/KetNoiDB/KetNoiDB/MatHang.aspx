<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MatHang.aspx.cs" Inherits="KetNoiDB.MatHang" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
            <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" AutoGenerateColumns="False" Width="203px">
                <Columns>
                    <asp:ImageField DataImageUrlField="Hinh" DataImageUrlFormatString="image/{0}" HeaderText="Hinh">
                    </asp:ImageField>
                    <asp:BoundField DataField="TenHang" HeaderText="Tên Hàng" />
                    <asp:BoundField DataField="MoTa" HeaderText="Mô Tả" />
                    <asp:BoundField DataField="DonGia" HeaderText="Đơn Giá" />
                </Columns>
        </asp:GridView>
    </form>
</body>
</html>
