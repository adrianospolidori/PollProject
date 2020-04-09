using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApp.Controllers
{
    [Route("api/[controller]")]
    public class PollController : Controller
    {
        private readonly IPollBusiness _pollBusiness;

        public PollController(IPollBusiness pollBusiness)
        {
            _pollBusiness = pollBusiness;
        }

        [HttpGet]
        [Route("{id}")]
        public ActionResult<Model.DTO.PollResult> Get(int id)
        {
            var result = _pollBusiness.Get(id);

            if (result == null)
                return NotFound();

            return Ok(result);

        }
        
        [HttpPost]
        public ActionResult<Model.DTO.PollRequestResult> Post([FromBody]Model.DTO.PollRequest request)
        {
            var result = _pollBusiness.Create(request);

            return Ok(result);
        }

        [HttpPut("{id}/vote")]
        public ActionResult Put(int id)
        {
            var option = _pollBusiness.Vote(id);

            if (option == null)
                return NotFound();

            //neste exemplo, foi simplificado e criado um objeto anônimo para o retorno, sem criar uma classe
            var result = new
            {
                option_id = option.Id
            };

            return Ok(result);
        }

        [HttpGet]
        [Route("{id}/stats")]
        public ActionResult<Model.DTO.PollStatsResult> GetStats(int id)
        {
            var result = _pollBusiness.GetStats(id);

            if (result == null)
                return NotFound();

            return Ok(result);

        }
    }
}
