using Model;
using System.Collections.Generic;

namespace Data.Interfaces
{
    public interface IPollOptionRepository : IRepositoryBase<PollOption>
    {
        PollOption Get(int id);

        IList<PollOption> GetOptions(int pollId);
    }
}
