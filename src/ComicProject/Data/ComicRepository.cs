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
        DescriptionHtml = "<p>Originally known as BackRub, <Strong>Google</Strong> is a <Strong>search engine</Strong> that started development in <Strong>1996</Strong> by <Strong>Sergey Brin</Strong> and <Strong>Larry Page</Strong> as a research project at <Strong>Stanford University</Strong> to find files on the <Strong>Internet</Strong>. <Strong>Larry and Sergey</Strong> later decided the name of their search engine needed to change and decide upon <Strong>Google</Strong>, which is inspired from the term <Strong>googol</Strong>.The company is currently based out of Mountain View, <Strong>California</Strong>.</p>",
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
        DescriptionHtml = "<p>People generally take advantage of the high temperatures by spending more time outdoors during <Strong>summer</Strong>. Activities such as travelling to the beach and picnics occur during the summer months</p>",
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
        DescriptionHtml = "<p>The <Strong>iPhone X</Strong> is intended to showcase what <Strong>Apple</Strong> considers technology of the future, specifically adopting <Strong>OLED screen technology</Strong> for the first time in iPhone history, as well as using a glass and stainless-steel form factor, offering <Strong>wireless charging</Strong>, and removing the <Strong>home button</Strong> in favor of introducing a new <Strong>bezel-less design</Strong>, almost removing all the bezels in the Smart Phone</p>",
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
        DescriptionHtml = "<p>An <Strong>Italian</Strong> manufacturing magnate, founded <Strong>Automobili Ferruccio Lamborghini S.p.A.</Strong> in 1963 to compete with established <Strong>marques</Strong>, including <Strong>Ferrari</Strong>. The company gained wide acclaim in <Strong>1966</Strong> for the <Strong>Miura sports coupé</Strong></p>",
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

        public Comic[] GetComics()
        {
            return _comics;
        }

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