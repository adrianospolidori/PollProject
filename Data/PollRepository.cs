using Model;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Model.DTO;

namespace Data
{
    public class PollRepository : RepositoryBase<Poll>, Interfaces.IPollRepository
    {
        protected PollContext _context;

        public PollRepository(PollContext context) : base(context)
        {
            _context = context;
        }

        public Poll Get(int id)
        {
            return (from poll in _context.Set<Poll>().AsNoTracking()
                        where
                            poll.Id == id
                        select poll).FirstOrDefault();
        }

        //public PollStatsResult GetStats(int id)
        //{
        //    return (from poll in _context.Set<Poll>().AsNoTracking()
        //            join option in _context.Set<PollOption>().AsNoTracking() on poll.Id equals option.Id
        //            select new PollStatsResult()
        //            {
                        
        //            }

        //            )            
        //}
    }
}
