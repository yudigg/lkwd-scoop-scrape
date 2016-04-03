using AngleSharp.Parser.Html;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WebScrape.Data
{
    public class Manager
    {
        public IEnumerable<Post> GetAllPosts()
        {
            var parser = new HtmlParser();
            var client = new WebClient();
           // client.Headers["User-Agent"] = "foo-Yudi";
            string html = client.DownloadString("http://www.thelakewoodscoop.com");
            var document = parser.Parse(html);
            var list = new List<Post>();
            var posts = document.QuerySelectorAll(".post");
            foreach (var post in posts)
            {
                Post p = new Post();
                p.Title = post.QuerySelector("h2").TextContent;
                p.TitleUrl = post.QuerySelector("h2 a").GetAttribute("href");
                var img = post.QuerySelector("img");
                if (img != null)
                {
                    p.Image = post.QuerySelector("img").GetAttribute("src");
                }

                p.Date = post.QuerySelector("small").TextContent;
                var pr = post.QuerySelector("p");
                p.Paragraph = post.QuerySelector("p").TextContent;
                if (p.Paragraph != "")
                {
                    var url = post.QuerySelector("p a:nth-of-type(2)");
                    if (url != null)
                    {
                        p.ParagraphUrl = post.QuerySelector("p a:nth-of-type(2)").GetAttribute("href");
                    }
                }
                list.Add(p);
            }
            return list;
        }
        public string GetFullHtml(string urlSource)
        {
            var Parser = new HtmlParser();
            var client =new WebClient();
            string html = client.DownloadString(urlSource);
            var doc = Parser.Parse(html);
         var fullPost = doc.QuerySelector(".post").InnerHtml;
            return fullPost;
        }
    }
}
