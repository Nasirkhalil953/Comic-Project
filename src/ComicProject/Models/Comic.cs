using System;
using System.Collections;
using System.Linq;
using System.Web;

namespace ComicProject.Models
{
    public class Comic
    {
        public int Id { set; get; }
        public string SeriesTitle { get; set; }
        public int IssueNumber { get; set; }
        public string DescriptionHtml { get; set; }
        public Artist[] Artists { get; set; }
        public bool Favorites { get; set; }

        public string DisplayText
        {
            get
            {
                return SeriesTitle + "#" + IssueNumber;
            }
        }

        public string CoverImageFileName
        {
            get
            {
                return SeriesTitle.Replace(" ","-").ToLower() + "-" + IssueNumber+".jpg";
            }
        }
    }
}