<%@ Page Title="Home Page" Language="C#"  AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="FormValidation._Default" %>


<head>
    <style type="text/css">
        #TextArea1 {
            z-index: 1;
            left: 336px;
            top: 408px;
            position: absolute;
        }
    </style>
</head>



<form id="form1" runat="server">
    <p>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 208px; top: 53px; position: absolute" Text="Enter the name"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server" style="z-index: 1; left: 349px; top: 105px; position: absolute; height: 22px"></asp:TextBox>
        <asp:TextBox ID="TextBox3" runat="server" style="z-index: 1; left: 348px; top: 215px; position: absolute"></asp:TextBox>
        <asp:CheckBoxList ID="CheckBoxList1" runat="server" style="z-index: 1; left: 344px; top: 309px; position: absolute; height: 27px; width: 82px">
            <asp:ListItem Value="male"></asp:ListItem>
            <asp:ListItem Value="Female"></asp:ListItem>
            <asp:ListItem Value="Others"></asp:ListItem>
        </asp:CheckBoxList>
    </p>
    <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 203px; top: 151px; position: absolute" Text="Enter Confirm email"></asp:Label>
    <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 208px; top: 219px; position: absolute" Text="Enter Age"></asp:Label>
    <asp:Label ID="Label4" runat="server" style="z-index: 1; left: 208px; top: 274px; position: absolute; height: 14px" Text="Course"></asp:Label>
    <asp:Label ID="Label5" runat="server" style="z-index: 1; left: 208px; top: 324px; position: absolute; right: 674px" Text="Gender"></asp:Label>
    <p>
        <asp:TextBox ID="TextBox1" runat="server" style="z-index: 1; left: 351px; top: 52px; position: absolute"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Must  be enter the name" ForeColor="Red" style="z-index: 1; left: 549px; top: 52px; position: absolute"></asp:RequiredFieldValidator>
    </p>
    <asp:TextBox ID="TextBox4" runat="server" style="height: 22px; z-index: 1; left: 348px; top: 152px; position: absolute"></asp:TextBox>
    <p>
        <asp:Label ID="Label7" runat="server" style="z-index: 1; left: 208px; top: 104px; position: absolute" Text="Enter Email"></asp:Label>
        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBox4" ControlToValidate="TextBox2" ErrorMessage="Must be Same email and confirm email" ForeColor="Red" style="z-index: 1; left: 550px; top: 115px; position: absolute"></asp:CompareValidator>
        <asp:TextBox ID="TextBox5" runat="server" style="z-index: 1; left: 321px; top: 387px; position: absolute; height: 72px; width: 276px"></asp:TextBox>
    </p>
    <asp:DropDownList ID="DropDownList1" runat="server" style="z-index: 1; left: 346px; top: 268px; position: absolute">
        <asp:ListItem Value="B.Sc cs"></asp:ListItem>
        <asp:ListItem Value="BCA"></asp:ListItem>
        <asp:ListItem Value="B.Sc cs (R)"></asp:ListItem>
        <asp:ListItem Value="B.Sc ds"></asp:ListItem>
    </asp:DropDownList>
    <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="TextBox3" ErrorMessage="Age must be 1 to 100" ForeColor="Red" MaximumValue="100" MinimumValue="1" style="z-index: 1; left: 560px; top: 214px; position: absolute"></asp:RangeValidator>
    <p>
        <asp:Label ID="Label6" runat="server" style="z-index: 1; left: 204px; top: 404px; position: absolute" Text="Address"></asp:Label>
    </p>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="DropDownList1" ErrorMessage="Choose one option" ForeColor="Red" style="z-index: 1; left: 561px; top: 269px; position: absolute"></asp:RequiredFieldValidator>
    <asp:CustomValidator ID="CustomValidator1" runat="server" ErrorMessage="Choose  one option" ForeColor="Red" OnServerValidate="CustomValidator1_ServerValidate" style="z-index: 1; left: 559px; top: 324px; position: absolute; height: 10px"></asp:CustomValidator>
    <p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="z-index: 1; left: 348px; top: 509px; position: absolute" Text="Submit" />
    </p>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox5" ErrorMessage="Must be enter Address" ForeColor="Red" style="z-index: 1; left: 641px; top: 414px; position: absolute"></asp:RequiredFieldValidator>
    <asp:Label ID="Label8" runat="server" style="z-index: 1; left: 484px; top: 515px; position: absolute; height: 17px; width: 44px"></asp:Label>
</form>



