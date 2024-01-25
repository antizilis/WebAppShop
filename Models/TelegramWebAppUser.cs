namespace WebApp.Models
{
    public class TelegramWebAppUser
    {
        public int id { get; set; } = 0;
        public bool is_bot { get; set; } = false;
        public string first_name { get; set; } = "";
        public string last_name { get; set; } = "";
        public string username { get; set; } = "";
        public string language_code { get; set; } = "";
    }
}
