<%@ Page Title="CustomersList" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CustomersList.aspx.cs" Inherits="CustomerRepo.WebForms.CustomersList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <br />
    <table class="table">
        <thead>
            <tr bgcolor="silver">
                <th class="text-center">Customer Id</th>
                <th class="text-center">First name</th>
                <th class="text-center">Last name</th>
                <th class="text-center">Phone number</th>
                <th class="text-center">Email</th>
                <th class="text-right">Total Purchases Amount</th>
                <th class="text-center"><span class="glyphicon glyphicon-edit" aria-hidden="true"></span></th>
                <th class="text-center"><a class="btn btn-danger" href="CustomerDeleteAll.aspx">Delete All</a></th>
            </tr>
        </thead>

        <tbody class="text-center">
           <%foreach(var customer in Customers) 
                {%>
                    <tr>                        
                        <td><a href="CustomerEdit.aspx?customerId=<%=customer.CustomerId%>"><%=customer.CustomerId%></a></td>
                        <td><%=customer.FirstName%></td>
                        <td><%=customer.LastName%></td>
                        <td><%=customer.CustomerPhoneNumber%></td>
                        <td><%=customer.CustomerEmail%></td>
                        <td class="text-right" ><%=customer.TotalPurchaseAmount%></td>
                        <td><a class="btn btn-warning" href="CustomerEdit.aspx?customerId=<%=customer.CustomerId %>">Edit</a></td>
                        <td><a class="btn btn-info" href="CustomerDelete.aspx?customerId=<%=customer.CustomerId %>">Delete</a></td>
                    </tr>
                <%} %>
        </tbody>
    </table>
    <hr />
    <div class="text-center">
        <a runat="server" class="btn btn-success" href="CustomerEdit.aspx">Add new customer</a>
    </div>

</asp:Content>
