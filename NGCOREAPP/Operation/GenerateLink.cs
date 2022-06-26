using NGCOREAPP.Models;
using NGCOREAPP.Models.List;
using NGCOREAPP.Extensions;

namespace NGCOREAPP.Operation
{
    public class GenerateLink
    {
        public string Generate()
        {
            string url = "";
            
            Random random = new Random();
            Repeat:
            url = random.NextString() + random.Next(999) + random.NextString();
            
            if (Links.LinkList.Any(x => x.ShortUrl == url))
            {
                goto Repeat;
            }

            return url;
        }
    }
}
