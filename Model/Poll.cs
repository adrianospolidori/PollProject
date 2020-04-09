
namespace Model
{
    public class Poll : BaseModel
    {
        public Poll()
        {
        }

        public string Description { get; set; }
        public int Views { get; set; }
    }
}
