using ButterCMS.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static BlogModel;

public partial class _Default : Page
{
    public string html { get; set; }
    List<item> blogItems = new List<item>();
    string theWholeHtml { get; set; }
    protected void Page_Load(object sender, EventArgs e)
    {
        var butter = new ButterCMSService();
        if (butter.blogPost != null && butter.blogPost.Data.Count() > 0)
        {
            Session["AllBlogContentList"] = butter.blogPost;
            SetUpBlogDisplay(butter.blogPost);
            return;
        }



    }

    private void SetUpBlogDisplay(PostsResponse blogPost)
    {
        foreach (var item in blogPost.Data)
        {
            
            theWholeHtml = readFromTextFile();
            theWholeHtml = theWholeHtml.Replace("%image%", item.FeaturedImage);
            theWholeHtml = theWholeHtml.Replace("%subject1%", item.Title);
            theWholeHtml = theWholeHtml.Replace("%subject2%", item.SeoTitle);
            theWholeHtml = theWholeHtml.Replace("%summary%", item.Summary);
            theWholeHtml = theWholeHtml.Replace("%link%", $"/blogfull.aspx?slug={item.Slug}");
           
            literalBlog.Text += theWholeHtml;
            //PlaceHolder1.Controls.Add(buton);

        }
        literalBlog.Visible = true;
    }

    private void Buton_Command(object sender, CommandEventArgs e)
    {
        string a = "j";
    }

    private string readFromTextFile()
    {
        string path = Server.MapPath("~/TemplateForBlog.txt");
        string read = File.ReadAllText(path);

        return read;
    }

    protected void Unnamed_ServerClick(object sender, EventArgs e)
    {

    }


    protected void ReadFullBlog_Click(object sender, EventArgs e)
    {
        string a = "j";
    }
}