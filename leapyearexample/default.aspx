<script runat="server">

    Protected Sub Page_Load(sender As Object, e As EventArgs)

    End Sub

    Protected Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs)
        String Year() = TextBox1.Text



    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub
</script>
<form id="form1" runat="server">
    <asp:TextBox ID="TextBox1" runat="server" style="z-index: 1; left: 442px; top: 88px; position: absolute" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
    <asp:TextBox ID="TextBox2" runat="server" style="z-index: 1; left: 442px; top: 139px; position: absolute"></asp:TextBox>
    <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 345px; top: 89px; position: absolute" Text="Enter year"></asp:Label>
    <p>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 315px; top: 139px; position: absolute; margin-top: 1px" Text="Reverse Number"></asp:Label>
        <asp:Label ID="Label5" runat="server" style="z-index: 1; left: 338px; top: 271px; position: absolute"></asp:Label>
    </p>
    <asp:Button ID="Button2" runat="server" style="z-index: 1; left: 363px; top: 211px; position: absolute" Text="year" OnClick="Button2_Click" />
    <p>
        <asp:Button ID="Button1" runat="server" Text="reverse" style="z-index: 1; left: 541px; top: 209px; position: absolute" OnClick="Button1_Click" />
    </p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <asp:Label ID="Label6" runat="server" style="z-index: 1; left: 522px; top: 275px; position: absolute"></asp:Label>
</form>
