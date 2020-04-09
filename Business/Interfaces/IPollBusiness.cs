using Model;
using Model.DTO;

namespace Business.Interfaces
{
    public interface IPollBusiness
    {
        PollResult Get(int id);
        PollRequestResult Create(PollRequest request);
        PollOption Vote(int optionId);
        PollStatsResult GetStats(int id);
    }
}
