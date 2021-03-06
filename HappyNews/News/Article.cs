using System;
using System.Collections.Generic;

namespace News
{
    public class Article
    {
        public string Title { get; set; }
        public string Link { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public DateTime PublishDate { get; set; }

        public Article(string title, string link, string desc, string author, string publishDate)
        {
            this.Title = title;
            this.Link = link;
            this.Description = desc;
            this.Author = author;
            this.PublishDate = DateTime.Parse(publishDate);
        }
    }
}
