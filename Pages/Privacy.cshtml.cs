using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApp.Models;

namespace WebAppShop.Pages
{
    public class PrivacyModel : PageModel
    {
        public TelegramWebAppInitData _webAppInitData;
        private readonly ILogger<PrivacyModel> _logger;

        public PrivacyModel(ILogger<PrivacyModel> logger)
        {
            _logger = logger;
        }

        public void OnGet(TelegramWebAppInitData webAppInitData)
        {
            _webAppInitData = webAppInitData;
        }
    }

}
