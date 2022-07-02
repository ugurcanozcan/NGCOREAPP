using Microsoft.AspNetCore.Mvc;
using NGCOREAPP.Models;
using NGCOREAPP.Models.List;

namespace NGCOREAPP.Controllers
{
    public class DController : Controller
    {
        public IActionResult I(string I)
        {



            Link link = Links.LinkList.Where(x => x.ShortUrl == I).First();
            link.ClickCount++;
            if (link.ClickCount <= link.ClickLimit)
            {
              
                Response.Redirect(link.LongUrl);
            }

            
            return View();
        }
    }
}
