<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="AjouterDomage.aspx.vb" Inherits="GestionPlanCar.AjouterDomage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    Description<asp:TextBox ID="txt_desc" runat="server"></asp:TextBox>
    <asp:Button ID="btn_add" runat="server" Text="Add" />
    <asp:Button ID="btn_update" runat="server" Text="Update" />
    <asp:Button ID="btn_delete" runat="server" Text="Delete" />
    <asp:Label ID="lbl_message" runat="server" Text="Label"></asp:Label>


</asp:Content>
