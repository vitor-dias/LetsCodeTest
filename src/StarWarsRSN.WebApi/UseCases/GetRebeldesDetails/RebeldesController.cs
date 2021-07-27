
    using StarWarsRSN.Application.Queries;
    using StarWarsRSN.Application.Results;
    using Microsoft.AspNetCore.Mvc;
    using System;
    using System.Threading.Tasks;
    using StarWarsRSN.WebApi.Model;
    using System.Collections.Generic;

namespace StarWarsRSN.WebApi.UseCases.GetRebeldeDetails
{
    [Route("api/[controller]")]
    public sealed class RebeldesController : Controller
    {
        private readonly IRebeldesQueries RebeldesQueries;

        public RebeldesController(IRebeldesQueries RebeldesQueries)
        {
            this.RebeldesQueries = RebeldesQueries;
        }

        /// <summary>
        /// Get a Rebelde details 
        /// </summary>
        [HttpGet("{RebeldeId}", Name = "GetRebelde")]
        public async Task<IActionResult> GetRebelde(int RebeldeId)
        {
            RebeldeResult Rebelde = await RebeldesQueries.GetRebelde(RebeldeId);

            if (Rebelde == null)
            {
                return new NoContentResult();
            }

            return new ObjectResult(Rebelde);
        }

        /// <summary>
        /// Get a Rebeldes details 
        /// </summary>
        [HttpGet("GetRebeldes")]
        public async Task<IActionResult> GetRebeldes()
        {
            var rebeldes = await RebeldesQueries.GetRebeldes();
            var models = new List<RebeldeDetailsModel>();

            if (rebeldes == null)
            {
                return new NoContentResult();
            }

            return new ObjectResult(rebeldes);
        }
    }
}
