<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="DEMO1.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main aria-labelledby="title">
        <table class="table">
            <tr>
                <%
                    foreach (System.Data.DataColumn item in data.Tables[0].Columns)
                    { 
                %>
                <td>
                    <% = item  %>
                </td>
                    <%
                    }
                %> 
            </tr>
            <%
                foreach (System.Data.DataRow item in data.Tables[0].Rows)
                {
                        %>
            <tr>
                <td><%=item[0] %></td>
                <td><%=item[1] %></td>
                <td><%=item[2] %></td>
                <td><%=item[3] %></td>
                <td><%=item[4] %></td>
            </tr>
                        <%
                }
                %>
        </table>
    </main>
</asp:Content>
