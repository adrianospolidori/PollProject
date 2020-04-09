namespace Model
{
    public class PollOption : BaseModel
    {
        public int PollId { get; set; }
        public string Description { get; set; }
        public int Votes { get; set; }
    }
}
