using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppShop.Models;

namespace WebAppShop.Pages
{
    public class PrivacyModel : PageModel
    {
        public TelegramParametrs _telegramParametrs;

        public void OnGet(TelegramParametrs param)
        {
            _telegramParametrs = param;
        }
    }

}
