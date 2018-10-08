using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for BlogModel
/// </summary>
public class BlogModel
{
    public BlogModel()
    {
        //
        // TODO: Add constructor logic here
        //
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