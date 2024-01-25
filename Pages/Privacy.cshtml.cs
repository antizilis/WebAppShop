using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppShop.Models;

namespace WebAppShop.Pages
{
    public class PrivacyModel : PageModel
    {
        public TelegramParametrs _telegramParametrs;
        private readonly ILogger<PrivacyModel> _logger;

        public PrivacyModel(ILogger<PrivacyModel> logger)
        {
            _logger = logger;
        }

        public void OnGet(TelegramParametrs telegramParametrs)
        {
            _telegramParametrs = telegramParametrs;
        }
    }

}
