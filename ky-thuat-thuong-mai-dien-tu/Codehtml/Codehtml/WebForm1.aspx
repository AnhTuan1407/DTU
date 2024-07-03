<link href="StyleSheet1.css" rel="stylesheet" />
<body>
    <form id="form1" runat="server">
        <div class="container">
            <header>
                <asp:HyperLink CssClass="logo_link" ID="LogoLink" NavigateUrl="/" runat="server">
                    <asp:Image ID="logo_image" runat="server" ImageUrl="./img/logo.jpg" />
                </asp:HyperLink>
                <nav class="nav_menu">
                    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Home.aspx">Home</asp:HyperLink>
                    <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/About.aspx">About</asp:HyperLink>
                    <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/Product.aspx">Products</asp:HyperLink>
                    <asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="~/News.aspx">News</asp:HyperLink>
                    <asp:HyperLink ID="HyperLink5" runat="server" NavigateUrl="~/Contact.aspx">Contact</asp:HyperLink>
                    <asp:HyperLink ID="HyperLink10" runat="server" NavigateUrl="~/Register.aspx">Register</asp:HyperLink>

                </nav>
            </header>
            <div class="banner">
                
            </div>
            <div class="main">
                <div class="sidebar">
                    <h2>Menu</h2>
                    <div class="list_menu">
                        <asp:HyperLink ID="HyperLink6" runat="server">Home</asp:HyperLink>
                        <asp:HyperLink ID="HyperLink7" runat="server">About</asp:HyperLink>
                        <asp:HyperLink ID="HyperLink8" runat="server">Products</asp:HyperLink>
                        <asp:HyperLink ID="HyperLink9" runat="server">News</asp:HyperLink>
                        <asp:HyperLink ID="HyperLink11" runat="server">Contact</asp:HyperLink>
                    </div>
                </div>
                <div class="right_content">
                    <div class="bread_crum">
                        <p class="bread_crum-text">Uu dai cuc hot !! Iphone 15 Promax gia moi phien ban hong xxmax.</p>
                    </div>
                    <div class="content">
                        <h1>Content</h1>
                    </div>
                </div>
            </div>
            <footer>
                &copy; Copyright Khoa Dang - 54452351511
            </footer>
        </div>
    </form>
</body>