<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Tính tích hai số</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Tính tích hai số</h2>

            <label for="so_a">Nhập giá trị a: </label>
            <asp:TextBox ID="so_a" runat="server"></asp:TextBox>
            <br /><br />

            <label for="so_b">Nhập giá trị b: </label>
            <asp:TextBox ID="so_b" runat="server"></asp:TextBox>
            <br /><br />


            <asp:Button ID="btnCalculate" runat="server" Text="Tính Toán" OnClick="btnCalculate_Click" />
            <br /><br />

            <asp:Label ID="lblResult" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
