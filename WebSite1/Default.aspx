<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="LOCATION_ID" DataSourceID="SqlDataSource2">
            <Columns>
                <asp:BoundField DataField="LOCATION_ID" HeaderText="LOCATION_ID" ReadOnly="True" SortExpression="LOCATION_ID" />
                <asp:BoundField DataField="STREET_ADDRESS" HeaderText="STREET_ADDRESS" SortExpression="STREET_ADDRESS" />
                <asp:BoundField DataField="POSTAL_CODE" HeaderText="POSTAL_CODE" SortExpression="POSTAL_CODE" />
                <asp:BoundField DataField="CITY" HeaderText="CITY" SortExpression="CITY" />
                <asp:BoundField DataField="STATE_PROVINCE" HeaderText="STATE_PROVINCE" SortExpression="STATE_PROVINCE" />
                <asp:BoundField DataField="COUNTRY_ID" HeaderText="COUNTRY_ID" SortExpression="COUNTRY_ID" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:HRMSDBConnectionString %>" SelectCommand="SELECT * FROM [LOCATIONS]"></asp:SqlDataSource>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
    </form>
</body>
</html>
