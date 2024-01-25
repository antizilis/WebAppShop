using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppShop.Models;

namespace WebAppShop.Pages
{
    public class PrivacyModel : PageModel
    {
        public TelegramParametrs _telegramParametrs;
        public string _param;

        public void OnGet(string param)
        {
            _param = param;
        }
    }

}
