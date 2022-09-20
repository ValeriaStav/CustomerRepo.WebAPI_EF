<%@ Page Title="CustomerEdit" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CustomerEdit.aspx.cs" Inherits="CustomerRepo.WebForms.CustomerEdit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <br />
    <div>
    <div class="form-group">
            <asp:Label Text="First Name" runat="server"></asp:Label>
            <asp:TextBox ID="firstName" Placeholder="Ivan" class="form-control" runat="server"></asp:TextBox>
            <asp:RegularExpressionValidator CssClass="text-danger" display="Dynamic" ErrorMessage="Max length cannot exceed 50 characters" ValidationExpression="^.{0,50}$"  ControlToValidate="firstName" runat="server" ></asp:RegularExpressionValidator>
    </div>
    
    <div class="form-group">
            <asp:Label Text="Last Name" runat="server"></asp:Label>
            <asp:TextBox ID="lastName" Placeholder="Petrov" class="form-control" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator CssClass="text-danger" ErrorMessage="Please enter a value" ControlToValidate="lastName" runat="server" />
            <asp:RegularExpressionValidator CssClass="text-danger" ErrorMessage="Max length cannot exceed 50 characters" ValidationExpression="^.{0,50}$" ControlToValidate="lastName" runat="server" />
    </div>
    
    <div class="form-group">
            <asp:Label Text="Customer Phone Number" runat="server"></asp:Label>
            <asp:TextBox ID="customerPhoneNumber" Placeholder="1234567890" class="form-control" runat="server"></asp:TextBox>
            <asp:RegularExpressionValidator CssClass="text-danger" ErrorMessage="Invalid number format" ValidationExpression="^\d{0,14}$" ControlToValidate="customerPhoneNumber" runat="server" />
    </div>
    
    <div class="form-group">
            <asp:Label Text="Customer Email" runat="server"></asp:Label>
            <asp:TextBox ID="customerEmail" Placeholder="Login@gmail.com" class="form-control" runat="server"></asp:TextBox>
            <asp:RegularExpressionValidator CssClass="text-danger" ErrorMessage="Wrong email format" ValidationExpression="^\S+@\S+\.\S+$" ControlToValidate="customerEmail" runat="server" />
    </div>
    
    <div class="form-group">
            <asp:Label Text="Total Purchase Amount" runat="server"></asp:Label>
            <asp:TextBox ID="totalPurchaseAmount" Placeholder="1000" class="form-control" runat="server"></asp:TextBox>
            <asp:RegularExpressionValidator CssClass="text-danger" ErrorMessage="Only numbers" ValidationExpression="^\d+$" ControlToValidate="totalPurchaseAmount" runat="server" />
        </div>
        <div>
            <asp:Button class="btn btn-primary" Text="Save" runat="server" OnClick="OnClickSave"/>
        </div>
    </div>

</asp:Content>
