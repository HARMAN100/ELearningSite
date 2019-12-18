<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddData.aspx.cs" Inherits="ELearningSite.AddData" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

     <div class="container">
        <div class="row">
            <h1> Add Content  </h1>
            <div class="form-control">
                
                <asp:TextBox ID="txtCategory" runat="server" name="txtCategory" placeholder="Enter Name of Category "></asp:TextBox>
            </div>
            


            <div class="form-control">
                <asp:TextBox ID="TxtData" runat="server" name="txtData" placeholder="Enter Password "></asp:TextBox>
                

            </div>

            <div class="form-control">
                <asp:Button ID="Button1" runat="server" Text="Submit" Class="btn btn-primary" OnClick="Button1_Click"  />

            </div>
            <h1 id="data" runat="server"></h1>

        </div>
    </div>
</asp:Content>
