<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" Async="true" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1 style="background-color:#000066;color:#ffffff">Northwind History!!</h1>
        <hr />
        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <p>Contact Name <%#Eval("ContactName") %></p>
            </ItemTemplate>
        </asp:Repeater><hr />
        Total No of Orders - <asp:Label ID="lblTotalOrders" runat="server" Text="Label"></asp:Label><br /><hr />
        Total No of Products - <asp:Label ID="lblTotalProducts" runat="server" Text="Label"></asp:Label><br /><hr />
        Total Time of Execution (MS)- <asp:Label ID="lblTotalExecutionTime" runat="server" Text="Label"></asp:Label>
    </div>
    </form>
</body>
</html>
