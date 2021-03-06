using System.Text.RegularExpressions;
using System.Threading.Tasks;

using TumblThree.Domain.Models;

namespace TumblThree.Applications.Parser
{
    public interface IGfycatParser
    {
        Regex GetGfycatUrlRegex();

        Task<string> RequestGfycatCajax(string gfyId);

        string ParseGfycatCajaxResponse(string result, GfycatTypes gfycatType);
    }
}
