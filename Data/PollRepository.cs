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
    }
}
