namespace WebAppShop.Models
{
    public class TelegramParametrs
    {
        public string query_id { get; set; }
        public User user { get; set; }
        public string auth_date { get; set; }
        public string hash { get; set; }
    }

    public class User
    {
        public int id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string username { get; set; }
        public string language_code { get; set; }
        public bool allows_write_to_pm { get; set; }
    }

}
