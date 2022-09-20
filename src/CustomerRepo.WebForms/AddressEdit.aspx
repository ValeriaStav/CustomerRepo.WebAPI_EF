<%@ Page Title="AddressEdit" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddressEdit.aspx.cs" Inherits="CustomerRepo.WebForms.AddressEdit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <br />
    <div>
        <div class="form-group">
            <asp:Label Text="Customer Id" runat="server"></asp:Label>
            <asp:TextBox ID="customerId" Placeholder="1" class="form-control" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator CssClass="text-danger" ErrorMessage="Please enter a value" ControlToValidate="customerId" runat="server" />
        </div>
        <div class="form-group">
            <asp:Label Text="Address line 1" runat="server"></asp:Label>
            <asp:TextBox ID="addressLine1" Placeholder="First Line" class="form-control" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator CssClass="text-danger" ErrorMessage="Please enter a value" ControlToValidate="addressLine1" runat="server" />
            <asp:RegularExpressionValidator CssClass="text-danger" ErrorMessage="Max length cannot exceed 100 characters" ValidationExpression="^.{0,100}$" ControlToValidate="addressLine1" runat="server" />
        </div>
        <div class="form-group">
            <asp:Label Text="Address line 2" runat="server"></asp:Label>
            <asp:TextBox ID="addressLine2" Placeholder="Second Line" class="form-control" runat="server"></asp:TextBox>
            <asp:RegularExpressionValidator CssClass="text-danger" ErrorMessage="Max length cannot exceed 100 characters" ValidationExpression="^.{0,100}$" ControlToValidate="addressLine2" runat="server" />
        </div>
        <div class="form-group">
            <asp:Label Text="Address type" runat="server"></asp:Label>
            <asp:DropDownList ID="addressType" class="form-control" runat="server">
                <asp:ListItem Text=" " />
                <asp:ListItem Text="Shipping" />
                <asp:ListItem Text="Billing" />
            </asp:DropDownList>
            <asp:RequiredFieldValidator CssClass="text-danger" ErrorMessage="Please choose a value" ControlToValidate="addressType" runat="server" />
            <asp:RegularExpressionValidator CssClass="text-danger" ErrorMessage="Max length cannot exceed 8 characters" ValidationExpression="^.{0,8}$" ControlToValidate="addressType" runat="server" />
        </div>
        <div class="form-group">
            <asp:Label Text="City" runat="server"></asp:Label>
            <asp:TextBox ID="city" Placeholder="Toronto" class="form-control" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator CssClass="text-danger" ErrorMessage="Please enter a value" ControlToValidate="city" runat="server" />
            <asp:RegularExpressionValidator CssClass="text-danger" ErrorMessage="Max length cannot exceed 50 characters" ValidationExpression="^.{0,50}$" ControlToValidate="city" runat="server" />
        </div>
        <div class="form-group">
            <asp:Label Text="Postal Code" runat="server"></asp:Label>
            <asp:TextBox ID="postalCode" Placeholder="66777" class="form-control" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator CssClass="text-danger" ErrorMessage="Please enter a value" ControlToValidate="postalCode" runat="server" />
            <asp:RegularExpressionValidator CssClass="text-danger" ErrorMessage="Max length cannot exceed 6 characters" ValidationExpression="^.{0,6}$" ControlToValidate="postalCode" runat="server" />
        </div>
        <div class="form-group">
            <asp:Label Text="State" runat="server"></asp:Label>
            <asp:TextBox ID="state" Placeholder="Ontario" class="form-control" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator CssClass="text-danger" ErrorMessage="Please enter a value" ControlToValidate="state" runat="server" />
            <asp:RegularExpressionValidator CssClass="text-danger" ErrorMessage="Max length cannot exceed 20 characters" ValidationExpression="^.{0,20}$" ControlToValidate="state" runat="server" />
        </div>
        <div class="form-group">
            <asp:Label Text="Country" runat="server"></asp:Label>
            <asp:TextBox ID="country" Placeholder="Canada" class="form-control" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator CssClass="text-danger" ErrorMessage="Please enter a value" ControlToValidate="country" runat="server" />
            <asp:RegularExpressionValidator CssClass="text-danger" ErrorMessage="Max length cannot exceed 30 characters" ValidationExpression="^.{0,30}$" ControlToValidate="country" runat="server" />
        </div>

        <div>
            <asp:Button class="btn btn-primary" Text="Save" runat="server" OnClick="OnClickSave"/>
        </div>
    </div>

</asp:Content>
