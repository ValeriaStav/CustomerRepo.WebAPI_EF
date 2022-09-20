<%@ Page Title="AddressesList" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddressesList.aspx.cs" Inherits="CustomerRepo.WebForms.AddressesList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <br />
    <table ID="addressesTable" class="table text-center">
        <thead>
            <tr bgcolor="silver">
                <th class="text-center">Address Id</th>
                <th class="text-center">Customer Id</th>
                <th class="text-center">Address Line</th>
                <th class="text-center">Address Line 2</th>
                <th class="text-center">Address Type</th>
                <th class="text-center">City</th>
                <th class="text-center">Postal Code</th>
                <th class="text-center">State</th>
                <th class="text-center">Country</th>
                <th class="text-center"><span class="glyphicon glyphicon-edit" aria-hidden="true"></span></th>
                <th class="text-center"><a class="btn btn-danger" href="AddressDeleteAll.aspx">Delete All</a></th>
            </tr>
        </thead>
        <tbody>
            <%foreach (var address in Addresses)
                {%>
                    <tr>
                        <td><a href="AddressEdit.aspx?addressId=<%=address.AddressId%>"><%=address.AddressId%></a></td>
                        <td><%=address.CustomerId %></td>
                        <td><%=address.AddressLine %></td>
                        <td><%=address.AddressLine2 %></td>
                        <td><%=address.AddressType %></td>
                        <td><%=address.City %></td>
                        <td><%=address.PostalCode %></td>
                        <td><%=address.State %></td>
                        <td><%=address.Country %></td>
                        <td><a class="btn btn-warning" href="AddressEdit.aspx?addressId=<%=address.AddressId %>">Edit</a></td>
                        <td><a class="btn btn-info" href="AddressDelete.aspx?addressId=<%=address.AddressId %>">Delete</a></td>
                    </tr>
            <%} %>
        </tbody>
    </table>
    <hr />
     <div class="text-center">
        <a runat="server" class="btn btn-success" href="AddressEdit.aspx">Add new address</a>
    </div>

</asp:Content>
