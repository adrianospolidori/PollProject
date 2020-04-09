using Microsoft.EntityFrameworkCore;
using Model;
using System.Collections.Generic;
using System.Linq;

namespace Data
{
    public class PollOptionRepository : RepositoryBase<PollOption>, Interfaces.IPollOptionRepository
    {
        protected PollContext _context;

        public PollOptionRepository(PollContext context) : base(context)
        {
            _context = context;
        }

        public PollOption Get(int id)
        {
            return (from po in _context.Set<PollOption>().AsNoTracking()
                        where
                            po.Id == id
                        select po).FirstOrDefault();
        }

        public IList<PollOption> GetOptions(int pollId)
        {
            return (from po in _context.Set<PollOption>().AsNoTracking()
                    where
                        po.PollId == pollId
                    select po).ToList();
        }
    }
}
