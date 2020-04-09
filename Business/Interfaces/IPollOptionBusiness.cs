using Model;
using System.Collections.Generic;

namespace Business.Interfaces
{
    public interface IPollOptionBusiness
    {
        PollOption Get(int id);
        IList<PollOption> GetOptions(int pollId);
        void Create(int pollId, string[] Options);
        PollOption Vote(int id);
    }
}
