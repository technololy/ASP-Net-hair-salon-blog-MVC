using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ButterCMS.Models;

public partial class BlogDyn : System.Web.UI.Page
{
    public string html { get; set; }
    List<item> blogItems = new List<item>();
    string theWholeHtml { get; set; }
    protected void Page_Load(object sender, EventArgs e)
    {
        //test buttercms
        var butter = new ButterCMSService();
        if (butter.blogPost!=null && butter.blogPost.Data.Count()>0)
        {
            SetUpBlogDisplay(butter.blogPost);
            return;
        }
        var mockItems = new List<item>()
        {
            new item{image="img/700x300.jpg",title="Our Projects 1",title2="NewBingo", summary="Technololy teams is here for you.\n Want more Bootstrap themes & templates?\n Subscribe to our mailing list to receive                        an update when new items arrive!",readMoreLink=""},
               new item{image="img/700x300.jpg",title="Our Projects 2",title2="NewBingo", summary="Technololy teams is here for you.\n Want more Bootstrap themes & templates?\n Subscribe to our mailing list to receive                        an update when new items arrive!",readMoreLink=""},
                  new item{image="img/700x300.jpg",title="Our Projects 3",title2="NewBingo", summary="Technololy teams is here for you.\n Want more Bootstrap themes & templates?\n Subscribe to our mailing list to receive                        an update when new items arrive!",readMoreLink=""}

        };
        foreach (var item in mockItems)
        {
            theWholeHtml = readFromTextFile();
            theWholeHtml = theWholeHtml.Replace("%image%", item.image);
            theWholeHtml = theWholeHtml.Replace("%subject1%", item.title);
            theWholeHtml = theWholeHtml.Replace("%subject2%", item.title2);
            theWholeHtml = theWholeHtml.Replace("%summary%", item.summary);
            theWholeHtml = theWholeHtml.Replace("%link%", item.readMoreLink);

            literalBlog.Text+= theWholeHtml;
           
        }
        literalBlog.Visible = true;
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
            theWholeHtml = theWholeHtml.Replace("%link%", item.Url);

            literalBlog.Text += theWholeHtml;

        }
        literalBlog.Visible = true;
    }

    private string readFromTextFile()
    {
        string path = Server.MapPath("~/TemplateForBlog.txt");
        string read = File.ReadAllText(path);
        
        return read;
    }

    public class item
    {
        public string image { get; set; }
        public string title { get; set; }
        public string title2 { get; set; }
        public string summary { get; set; }
        public string readMoreLink { get; set; }
    }
}