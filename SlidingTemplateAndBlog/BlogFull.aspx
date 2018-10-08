<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="BlogFull.aspx.cs" Inherits="BlogFull" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <div class="padding100" id="blog">
        <div class="container">
            <!-- Page Heading -->
            <div class="row">
    
    <div class="row col-lg-8" id="BlogContent">
       <div class="col-md-12">
                    <a >
                       <%-- <img id="imagePlaceholder" class="img-responsive  animated wow fadeInUp" data-wow-delay="0.2s"    alt="">--%>
                        <asp:Image runat="server" ID="ImagePlaceHolder" CssClass="img-responsive  animated wow fadeInUp" data-wow-delay="0.2s"    alt="" >

                        </asp:Image>
                    </a>
       </div>
        <div class="col-md-12">
           <asp:Literal runat="server" ID="bodyPlaceholder" ></asp:Literal>
        </div>
       
    </div>
    <div class="row col-lg-4" id="advert" >

    </div>
                </div>
            </div>
        </div>
</asp:Content>

