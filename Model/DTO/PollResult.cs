using Newtonsoft.Json;

namespace Model.DTO
{
    public class PollResult
    {
        [JsonProperty("poll_id")]
        public int Id { get; set; }

        [JsonProperty("poll_description")]
        public string Description { get; set; }

        [JsonProperty("options")]
        public PollOptionResult[] Options { get; set; }

        public class PollOptionResult
        {
            [JsonProperty("option_id")]
            public int Id { get; set; }

            [JsonProperty("option_description")]
            public string Description { get; set; }
        }
    }
}
