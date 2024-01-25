using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
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

            _telegramParametrs = JsonConvert.DeserializeObject<TelegramParametrs>(_param);
        }
    }

}
