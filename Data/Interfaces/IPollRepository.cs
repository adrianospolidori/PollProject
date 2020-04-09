using Model;

namespace Data.Interfaces
{
    public interface IPollRepository : IRepositoryBase<Poll>
    {
        Poll Get(int id);
    }
}
