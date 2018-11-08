using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ComicProject.Models;

namespace ComicProject.Data
{
    public class ComicRepository
    {
        private static Comic[] _comics = new Comic[]
        {
            new Comic()
            {
                SeriesTitle = "The Amazing Spider Man",
                IssueNumber = 700,
                DescriptionHtml = "<p>Based on<Strong> Marvel Comics'</Strong> superhero character," +
                                  " this is a story of <Strong>Peter Parker</Strong> who is a nerdy high school." +
                                  " He was orphaned as a child, bullied by jocks, and can't confess " +
                                  "his crush for his stunning neighborhood girl <Strong>Mary Jane Watson</Strong>." +
                                  " To say his life is is an understatement</p>",
                Artists = new Artist[]
                {
                    new Artist() {Name = "script",Role = "Alpha"},
                    new Artist() {Name = "Pencil",Role = "HB Products"},
                    new Artist() {Name = "Ink color",Role = "eown Library"},
                    new Artist() {Name = "Writer",Role = "Nasir Khalil"}
                },
                Favorites = false
            },
            new Comic()
            {
                SeriesTitle = "The Amazing Spider-Man",
                IssueNumber = 657,
                DescriptionHtml = "<p><strong>FF: THREE TIE-IN.</strong> Spider-Man visits the FF for a very private wake--just for family.</p>",
                Artists = new Artist[]
                {
                    new Artist() { Name = "Dan Slott", Role = "Script" },
                    new Artist() { Name = "Marcos Martin", Role = "Pencils" },
                    new Artist() { Name = "Marcos Martin", Role = "Inks" },
                    new Artist() { Name = "Muntsa Vicente", Role = "Colors" },
                    new Artist() { Name = "Joe Caramagna", Role = "Letters" }
                },
                Favorites = false
            },
            new Comic()
            {
                SeriesTitle = "Bone",
                IssueNumber = 50,
                DescriptionHtml = "<p><strong>The Dungeon & The Parapet, Part 1.</strong> Thorn is discovered by Lord Tarsil and the corrupted Stickeaters and thrown into a dungeon with Fone Bone. As she sleeps, a message comes to her about the mysterious \"Crown of Horns\".</p>",
                Artists = new Artist[]
                {
                    new Artist() { Name = "Jeff Smith", Role = "Script" },
                    new Artist() { Name = "Jeff Smith", Role = "Pencils" },
                    new Artist() { Name = "Jeff Smith", Role = "Inks" },
                    new Artist() { Name = "Jeff Smith", Role = "Letters" }
                },
                Favorites = false
            }
    };
        public Comic GetComic(int id)
        {
            Comic comicToReturn = null;
            foreach (var comic in _comics)
            {
                if (comic.Id == id)
                {
                    comicToReturn = comic;
                }
                break;
            }
            return comicToReturn;
        }
    }
}