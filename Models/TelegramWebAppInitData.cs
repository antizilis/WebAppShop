namespace WebApp.Models
{
    public class TelegramWebAppInitData
    {
        public string query_id { get; set; }
        public TelegramWebAppUser user { get; set; }
        public TelegramWebAppUser receiver { get; set; }
        public TelegramWebAppChat chat { get; set; }
        public string chat_type { get; set; }
        public string chat_instance { get; set; }
        public int auth_date { get; set; }
        public string hash { get; set; }
    }
}
