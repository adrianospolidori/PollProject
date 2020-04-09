using Business.Interfaces;
using Data.Interfaces;
using Model;
using Model.DTO;
using System.Linq;

namespace Business
{
    public class PollBusiness : Interfaces.IPollBusiness
    {
        private readonly IPollRepository _repository;
        private readonly IPollOptionBusiness _pollOptionBusiness;

        public PollBusiness(IPollRepository repository, IPollOptionBusiness pollOptionBusiness)
        {
            _repository = repository;
            _pollOptionBusiness = pollOptionBusiness;
        }

        public PollResult Get(int id)
        {
            var poll = _repository.GetById(id);

            if (poll == null)
                return null;

            IncrementPollView(poll);

            var pollOptions = _pollOptionBusiness.GetOptions(id);

            return new PollResult()
            {
                Id = poll.Id,
                Description = poll.Description,
                Options = pollOptions.Select(s => new PollResult.PollOptionResult
                {
                    Id = s.Id,
                    Description = s.Description
                }).ToArray()
            };
        }

        public PollRequestResult Create(PollRequest request)
        {
            var poll = new Model.Poll()
            {
                Description = request.PollDescription,
                Views = 0
            };

            _repository.Insert(poll);

            _pollOptionBusiness.Create(poll.Id, request.Options);

            return new PollRequestResult()
            {
                PollId = poll.Id
            };
        }

        public PollOption Vote(int optionId)
        {
            return _pollOptionBusiness.Vote(optionId);
        }

        public PollStatsResult GetStats(int id)
        {
            var poll = _repository.GetById(id);

            if (poll == null)
                return null;

            IncrementPollView(poll);

            var options = _pollOptionBusiness.GetOptions(id);

            return new PollStatsResult()
            {
                Views = poll.Views,
                Votes = options.Select(s => new PollStatsResult.PollStatsVotesResult()
                {
                    OptionId = s.Id,
                    Quantity = s.Votes
                }).ToArray()
            };
        }

        void IncrementPollView(Poll poll)
        {
            poll.Views++;
            _repository.Update(poll);
        }
    }
}
