using System;
using System.Linq;
using System.Xml.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using HtmlAgilityPack;

namespace Davaleba_8
{
    class Program
    {
        static void Main(string[] args)
        {
            var Currencies = ParseCurrencies();

            Console.WriteLine(Currencies["USD"]);
        }

        public static IDictionary<string, double> ParseCurrencies()
        {
            XElement rss = XElement.Load("http://www.nbg.ge/rss.php");
            XElement description = rss.Descendants("item").FirstOrDefault().Descendants("description").FirstOrDefault();

            string value = description.Value;
            value = Regex.Replace(value, "(src=\\\"[^\\\"]+\\\")", "$1/");
            var document = new HtmlDocument();
            document.LoadHtml(value);
            var div = document.DocumentNode.SelectNodes("//tr");
            Dictionary<string, double> Currencies = new Dictionary<string, double> { { "GEL", 1.0 } };

            foreach (var elem in document.DocumentNode.SelectNodes("table")[0].ChildNodes)
            {
                Currencies[elem.ChildNodes[1].InnerText] = double.Parse(elem.ChildNodes[5].InnerText) / int.Parse(elem.ChildNodes[3].InnerText.Split(' ')[0]); // *1
            }

            return Currencies;
        }
    }
}
