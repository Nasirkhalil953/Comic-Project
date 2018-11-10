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
        Id = 1,
        SeriesTitle = "Google",
        IssueNumber = 1,
        DescriptionHtml = "<p>Originally known as BackRub, Google is a search engine that started development in 1996 by Sergey Brin and Larry Page as a research project at Stanford University to find files on the Internet. Larry and Sergey later decided the name of their search engine needed to change and decide upon Google, which is inspired from the term googol. The company is currently based out of Mountain View, California.</strong></p>",
        Artists = new Artist[]
        {
            new Artist() { Name = "Dan Slott", Role = "Script" },
            new Artist() { Name = "Humberto Ramos", Role = "Pencils" },
            new Artist() { Name = "Victor Olazaba", Role = "Inks" },
            new Artist() { Name = "Edgar Delgado", Role = "Colors" },
            new Artist() { Name = "Chris Eliopoulos", Role = "Letters" },
        },
        Favorites = false
    },
    new Comic()
    {
        Id = 2,
        SeriesTitle = "Strowbery",
        IssueNumber = 2,
        DescriptionHtml = "<p><strong>A strawberry</strong> is both a low-growing, flowering plant and also the name of the fruit that it produces.<Strong> Strawberries</Strong> are soft, sweet, bright red berries. They're also delicious.<Strong> Strawberries</Strong> have tiny edible seeds, which grow all over their surface.</p>",
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
        Id = 3,
        SeriesTitle = "Summer",
        IssueNumber = 3,
        DescriptionHtml = "<p><strong>The Dungeon & The Parapet, Part 1.</strong> Thorn is discovered by Lord Tarsil and the corrupted Stickeaters and thrown into a dungeon with Fone Bone. As she sleeps, a message comes to her about the mysterious \"Crown of Horns\".</p>",
        Artists = new Artist[]
        {
            new Artist() { Name = "Jeff Smith", Role = "Script" },
            new Artist() { Name = "Jeff Smith", Role = "Pencils" },
            new Artist() { Name = "Jeff Smith", Role = "Inks" },
            new Artist() { Name = "Jeff Smith", Role = "Letters" }
        },
        Favorites = false
    },
    new Comic()
    {
        Id = 4,
        SeriesTitle = "iphoneX",
        IssueNumber = 4,
        DescriptionHtml = "<p><strong>The Dungeon & The Parapet, Part 1.</strong> Thorn is discovered by Lord Tarsil and the corrupted Stickeaters and thrown into a dungeon with Fone Bone. As she sleeps, a message comes to her about the mysterious \"Crown of Horns\".</p>",
        Artists = new Artist[]
        {
            new Artist() { Name = "Jeff Smith", Role = "Script" },
            new Artist() { Name = "Jeff Smith", Role = "Pencils" },
            new Artist() { Name = "Jeff Smith", Role = "Inks" },
            new Artist() { Name = "Jeff Smith", Role = "Letters" }
        },
        Favorites = false
    },
    new Comic()
    {
        Id = 5,
        SeriesTitle = "lamborghini",
        IssueNumber = 5,
        DescriptionHtml = "<p><strong>The Dungeon & The Parapet, Part 1.</strong> Thorn is discovered by Lord Tarsil and the corrupted Stickeaters and thrown into a dungeon with Fone Bone. As she sleeps, a message comes to her about the mysterious \"Crown of Horns\".</p>",
        Artists = new Artist[]
        {
            new Artist() { Name = "Jeff Smith", Role = "Script" },
            new Artist() { Name = "Jeff Smith", Role = "Pencils" },
            new Artist() { Name = "Jeff Smith", Role = "Inks" },
            new Artist() { Name = "Jeff Smith", Role = "Letters" }
        },
        Favorites = false
    },
};
        public Comic GetComic(int id)
        {
            Comic comicToReturn = null;
            foreach (var comic in _comics)
            {
                if (comic.Id == id)
                {
                    comicToReturn = comic;
                    break;
                }
            }
            return comicToReturn;
        }
    }
}