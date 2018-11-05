using System;
using System.Collections.`;
using System.Linq;
using System.Web;

namespace ComicProject.Models
{
    public class Comic
    {
        public int Id { set; get; }
        public string SeriesTitle { get; set; }
        public int IssueNumber { get; set; }
        public string Description { get; set; }
        public Artist[] Artists { get; set; }
        public bool Favorites { get; set; }
    }
}