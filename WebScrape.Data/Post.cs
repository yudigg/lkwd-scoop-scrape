using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebScrape.Data
{
   public class Post
    {
       public string Title { get; set; }
       public string TitleUrl { get; set; }
       public string Date { get; set; }
       public string  Paragraph{ get; set; }
       public string Image { get; set; }
       public string ParagraphUrl { get; set; }
    }
}
