using ButterCMS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ButterCMSService
/// </summary>
public class ButterCMSService
{
    string apiToken = "e52dfef7f669b409aa5bb17b72c0e21ce0fe7b2e";
   public ButterCMS.Models.PostsResponse blogPost = null;
    public ButterCMSService()
    {
        //
        // TODO: Add constructor logic here
        //
        CallButterCMS();
    }

    private  void CallButterCMS()
    {
        var page = "1";
        var pageSize = "10";
        var parameterDict = new Dictionary<string, string>()
            {
                {"page", page.ToString()},
                {"page_size", pageSize.ToString()}
            };

       
        var client = new ButterCMSClient(apiToken);
        //var caseStudyPages = client.ListPages<BlogAlpha>("BlogAlpha", parameterDict);
        blogPost = new ButterCMS.Models.PostsResponse();
        blogPost = client.ListPosts(1, 10); // testing butter api
       // var responsex =  client.RetrievePage<BlogAlpha>("*", "*"); // calling my first page created on ButterCMS
        //var d = 2;
    }

    public class BlogAlpha
    {
        public string page_seo_title { get; set; }
        public string page_short_desc { get; set; }
        public string page_long_desc { get; set; }
        public string page_body { get; set; }
    }

}