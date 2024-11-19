<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DEMO1._Default" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <div class="container">
            <h1>Reporte 001</h1>
            <hr />
            <table class="table">
                <tr>
                    <%
                        foreach (System.Data.DataColumn item in data.Tables[0].Columns)
                        { 
                    %>
                    <td>
                        <% = item  %>
                    <td>
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
                </tr>
                            <%
                    }
                    %>
            </table>
        </div>
    </main>
</asp:Content>
