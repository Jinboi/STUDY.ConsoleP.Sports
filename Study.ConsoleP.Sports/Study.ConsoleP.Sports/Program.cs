using HtmlAgilityPack;

namespace Study.ConsoleP.Sports
{
    class Progam
    {
        static void Main(string[] args)
        {
            var scraper = new StaticWebScrapper();
            var url = "https://www.basketball-reference.com/boxscores/";
            var results = scraper.GetResults(url);
            Console.WriteLine(results);
        }
    }
}