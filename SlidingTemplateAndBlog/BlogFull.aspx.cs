using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class BlogFull : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        var paramz = Request.QueryString["slug"];
        var getAllBlogList = Session["AllBlogContentList"] as ButterCMS.Models.PostsResponse;
        var getSingleBlogContent = getAllBlogList.Data.First(x => x.Slug == paramz);
        bodyPlaceholder.Text = getSingleBlogContent.Body;
        ImagePlaceHolder.ImageUrl = getSingleBlogContent.FeaturedImage;
    }
}