using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ScrapeLib
{
    public class Scrape
    {
        public string ScrapeWebpage(string url)
        {
            return GetWebpage(url);

        }

        public string ScrapeWebpage(string url, string filepath)
        {
            string reply = GetWebpage(url);

            File.WriteAllText(filepath, reply);
            return reply;
        }

        private string GetWebpage(string url)
        {
            WebClient client = new();
            return client.DownloadString(url);
        }

    }
}