<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="StaffAspWeb.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
  <asp:Label ID="lbl_NameFam" runat="server" Text="نام و نام خانوادگی "></asp:Label>
    <asp:TextBox ID="txt_NameFam" runat="server"></asp:TextBox>
    </br>
     <asp:Label ID="lbl_Code" runat="server" Text="کد سازمانی "></asp:Label>
    <asp:TextBox ID="txt_Code" runat="server"></asp:TextBox>
    </br>
     <asp:Label ID="lbl_Salary" runat="server" Text="حقوق "></asp:Label>
    <asp:TextBox ID="txt_Salary" runat="server"></asp:TextBox>
    </br>
    <asp:Button ID="btn_Save" runat="server" Text="ذخیره" OnClick="btn_Save_Click" />
</asp:Content>
