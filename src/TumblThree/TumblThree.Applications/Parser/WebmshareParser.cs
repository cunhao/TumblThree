using System;
using System.Text.RegularExpressions;

using TumblThree.Domain.Models;

namespace TumblThree.Applications.Parser
{
    public class WebmshareParser : IWebmshareParser
    {
        public Regex GetWebmshareUrlRegex()
        {
            return new Regex("(http[A-Za-z0-9_/:.]*webmshare.com/([A-Za-z0-9_]*))");
        }

        public string CreateWebmshareUrl(string webshareId, string detectedUrl, WebmshareTypes webmshareType)
        {
            var url = "";
            switch (webmshareType)
            {
                case WebmshareTypes.Mp4:
                    url = @"https://s1.webmshare.com/f/" + webshareId + ".mp4";
                    break;
                case WebmshareTypes.Webm:
                    url = @"https://s1.webmshare.com/" + webshareId + ".webm";
                    break;
                case WebmshareTypes.Any:
                    url = detectedUrl;

                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            return url;
        }
    }
}
