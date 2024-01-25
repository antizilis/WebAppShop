namespace WebApp.Models
{
    public class TelegramWebAppInitData
    {
        public string query_id { get; set; } = "";
        public TelegramWebAppUser user { get; set; } = new TelegramWebAppUser();
        public TelegramWebAppUser receiver { get; set; } = new TelegramWebAppUser();
        public TelegramWebAppChat chat { get; set; } = new TelegramWebAppChat();
        public string chat_type { get; set; } = "";
        public string chat_instance { get; set; } = "";
        public int auth_date { get; set; } = 0;
        public string hash { get; set; } = "";
    }
}
