using System.Net;
using System.Text;
using System.Text.RegularExpressions;

namespace SitePeek
{
    public class SearchService
    {
        /// <summary> Site source code. </summary>
        private readonly string _siteCode;

        /// <summary> Constructor with parameters. </summary>
        public SearchService(string link)
        {
            var webClient = new WebClient
            {
                Proxy = new WebProxy()
            };

            _siteCode = webClient.DownloadString(link);
        }

        /// <summary> Get all links on the target site. </summary>
        /// <returns> Links on site. </returns>
        public string GetLinks()
        {
            return GetElements(@"""http\S{5,1000}""");
        }

        /// <summary> Get all telephones on the target site. </summary>
        /// <returns> Telephones on site. </returns>
        public string GetTelephones()
        {
            return GetElements(@"[0-9() +-]{15,17}");
        }

        /// <summary> Get all emails on the target site. </summary>
        /// <returns> Emails on site. </returns>
        public string GetEmails()
        {
            return GetElements(@"[a-zA-Z0-9]+@[a-zA-Z0-9.]+");
        }

        /// <summary> Get some elements on target site. </summary>
        /// <param name="pattern"> Pattarn of target elements. </param>
        /// <returns></returns>
        private string GetElements(string pattern)
        {
            var regex = new Regex(pattern);

            var links = new StringBuilder();

            foreach (Match match in regex.Matches(_siteCode))
            {
                if (match.Value[0] == ' ' && match.Value[1] == ' ')
                {
                    continue;
                }

                links.Append(match.Value);
                links.Append("\n");
            }

            return links.ToString();
        }
    }
}