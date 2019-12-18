<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ELearningSite.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <div class="container">
        <div class="row">
            <h1> Admin Login </h1>
            <div class="form-control">
                
                <asp:TextBox ID="txtName" runat="server" name="txtName" placeholder="Enter Name "></asp:TextBox>
            </div>
            


            <div class="form-control">
                <asp:TextBox ID="TxtPassword" runat="server" name="txtPassword" placeholder="Enter Password "></asp:TextBox>
                

            </div>

            <div class="form-control">
                <asp:Button ID="Button1" runat="server" Text="Login" Class="btn btn-primary" OnClick="Button1_Click" />

            </div>
            <h1 id="data" runat="server"></h1>

        </div>
    </div>
</asp:Content>
