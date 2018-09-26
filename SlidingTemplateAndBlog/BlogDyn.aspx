<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="BlogDyn.aspx.cs" Inherits="BlogDyn" Async="true" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
        <div class="padding100" id="blog">
        <div class="container">
            <div class="row">
                <div class="col-lg-12">
                    <h2 class="background double animated wow fadeInUp" data-wow-delay="0.2s">
                        <span><strong>B</strong>log</span></h2>
                
                </div>
            </div>
    <asp:Literal id="literalBlog" Visible="false" runat="server" />
            </div>
            </div>
</asp:Content>

