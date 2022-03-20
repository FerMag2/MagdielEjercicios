using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using ScrapySharp.Extensions;
namespace Practica3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Mistitulos = new List<string>();
            HtmlWeb oweb = new HtmlWeb();
            HtmlDocument doc = oweb.Load("https://hdeleon.net/");
            //HtmlNode Body = doc.DocumentNode.CssSelect("head").First();
            //string sBody = Body.InnerHtml;
            foreach (var Nodo in doc.DocumentNode.CssSelect(".entry-title"))
            {
                var NodoAnchor = Nodo.CssSelect("a").First();
                Mistitulos.Add(NodoAnchor.InnerHtml);
            }

        }
    }
}

