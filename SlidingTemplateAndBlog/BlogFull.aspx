<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="BlogFull.aspx.cs" Inherits="BlogFull" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <div>
        <div>
            <asp:Literal runat="server" ID="title" ></asp:Literal>
        </div>
        <div>
            <asp:Literal runat="server" ID="image" ></asp:Literal>
        </div>
        <div>
            <asp:Literal runat="server" ID="body" ></asp:Literal>
        </div>
    </div>
</asp:Content>

