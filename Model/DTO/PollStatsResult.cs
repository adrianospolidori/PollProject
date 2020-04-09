using Newtonsoft.Json;

namespace Model.DTO
{
    public class PollStatsResult
    {
        [JsonProperty("views")]
        public int Views { get; set; }

        [JsonProperty("votes")]
        public PollStatsVotesResult[] Votes { get; set; }

        public class PollStatsVotesResult
        {
            [JsonProperty("option_id")]
            public int OptionId { get; set; }

            [JsonProperty("qty")]
            public int Quantity { get; set; }
        }
    }
}
