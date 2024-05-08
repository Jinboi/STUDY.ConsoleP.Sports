using HtmlAgilityPack;

namespace Study.ConsoleP.Sports
{
    class Progam
    {
        static void Main(string[] args)
        {
            HtmlWeb web = new HtmlWeb();
            HtmlDocument document = web.Load("https://example.com/");

            var title = document.DocumentNode.SelectNodes("//div/h1").First().InnerText;
            var description = document.DocumentNode.SelectNodes("//div/p").First().InnerText;

            Console.WriteLine(title);
            Console.WriteLine();
            Console.WriteLine(description); 


        }
    }
}