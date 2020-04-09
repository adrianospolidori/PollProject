using Data.Interfaces;
using Model;
using System.Collections.Generic;

namespace Business
{
    public class PollOptionBusiness : Interfaces.IPollOptionBusiness
    {
        private readonly IPollOptionRepository _repository;

        public PollOptionBusiness(IPollOptionRepository repository)
        {
            _repository = repository;
        }

        public PollOption Get(int id)
        {
            return _repository.Get(id);
        }

        public IList<PollOption> GetOptions(int pollId)
        {
            return _repository.GetOptions(pollId);
        }

        public void Create(int pollId, string[] Options)
        {
            foreach (var option in Options)
            {
                var pollOption = new PollOption()
                {
                    PollId = pollId,
                    Description = option,
                    Votes = 0
                };

                _repository.Insert(pollOption);
            }
        }

        public PollOption Vote(int id)
        {
            var option = _repository.Get(id);

            if (option == null)
                return null;

            option.Votes++;

            _repository.Update(option);

            return option;
        }
    }
}
