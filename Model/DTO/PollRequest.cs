using Newtonsoft.Json;
using System.Collections.Generic;

namespace Model.DTO
{
    public class PollRequest
    {
        [JsonProperty("poll_description")]
        public string PollDescription { get; set; }

        [JsonProperty("options")]
        public string[] Options { get; set; }
    }

    public class PollRequestResult
    {
        [JsonProperty("poll_id")]
        public int PollId { get; set; }
    }
}
