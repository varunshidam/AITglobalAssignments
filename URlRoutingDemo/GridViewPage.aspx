﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="GridViewPage.aspx.cs" Inherits="GridViewPage" %>
<%@ Import Namespace="System.Web.Routing" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false">
                <Columns>
                    <asp:TemplateField HeaderText="Title">
                        <ItemTemplate>
                             <asp:HyperLink ID="HyperLink1" runat="server" Text='<%# Eval("Title") %>' href='<%# GetRouteUrl("RouteForArticle",new {id= Eval("ID"),Title =getTitle(Eval("Title"))}) %>' ></asp:HyperLink>   
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Description">
                        <ItemTemplate>
                            <asp:Label Text='<%#Eval("Description")%>' runat="server"></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Author">
                        <ItemTemplate>
                            <asp:Label Text='<%#Eval("Author")%>' runat="server"></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>

        </div>
    </form>
</body>
</html>
