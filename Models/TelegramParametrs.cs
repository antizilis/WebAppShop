using Newtonsoft.Json;
using System.Text.Json;

namespace WebAppShop.Models
{
    public class TelegramParametrs
    {
        [JsonProperty("query_id")]
        public string QueryId { get; set; }

        [JsonProperty("user")]
        public User User { get; set; }

        [JsonProperty("auth_date")]
        public long AuthDate { get; set; }

        [JsonProperty("hash")]
        public string Hash { get; set; }
    }

    public class User
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("language_code")]
        public string LanguageCode { get; set; }

        [JsonProperty("allows_write_to_pm")]
        public bool AllowsWriteToPm { get; set; }
    }

}
