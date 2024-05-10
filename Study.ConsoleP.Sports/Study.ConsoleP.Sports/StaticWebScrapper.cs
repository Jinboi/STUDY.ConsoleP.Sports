using HtmlAgilityPack;
using Newtonsoft.Json;

namespace Study.ConsoleP.Sports;
internal class StaticWebScrapper
{  
    public List<Result> GetResults(string url)
    {
        var uri = new Uri(url);
        List<Result> results = new List<Result>();

        HtmlWeb web = new HtmlWeb();
        
        var doc = web.Load(url);
        var nodes = doc.DocumentNode.SelectNodes("//*[@id=\"content\"]/div[3]/div/table[1]/tbody/tr[1]");

        if (nodes != null)
    {
        foreach (var node in nodes)
        {
            var result = new Result
            {
                Winner = node.SelectSingleNode("td[1]").InnerText,
                Loser = node.SelectSingleNode("td[2]").InnerText,
                WinnerScore = int.Parse(node.SelectSingleNode("td[3]").InnerText),
                LoserScore = int.Parse(node.SelectSingleNode("td[4]").InnerText), // Fixed index here
            };

            results.Add(result);
        }
    }
    else
    {
        Console.WriteLine("No matching nodes found.");
    }

        return results;
    }
}