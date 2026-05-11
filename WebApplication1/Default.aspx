<%@ Page Title="Home Page" Language="C#"  AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>


<form id="form1" runat="server">
    <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 279px; top: 138px; position: absolute" Text="Reverse Num"></asp:Label>
    <p>
        <asp:TextBox ID="TextBox2" runat="server" style="z-index: 1; left: 390px; top: 132px; position: absolute"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 278px; top: 262px; position: absolute"></asp:Label>
    </p>
    <p>
        <asp:Label ID="Label2" runat="server" style="height: 11px; z-index: 1; left: 277px; top: 84px; position: absolute; bottom: 460px" Text="Enter year"></asp:Label>
    </p>
    <asp:Label ID="Label4" runat="server" style="z-index: 1; left: 475px; top: 261px; position: absolute"></asp:Label>
    <asp:TextBox ID="TextBox1" runat="server" style="z-index: 1; left: 389px; top: 80px; position: absolute"></asp:TextBox>
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="z-index: 1; left: 442px; top: 199px; position: absolute" Text="Reverse" />
    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" style="z-index: 1; left: 299px; top: 199px; position: absolute" Text="Year" />
</form>



