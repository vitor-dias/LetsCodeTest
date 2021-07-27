namespace StarWarsRSN.WebApi.UseCases.Register
{
    using Microsoft.AspNetCore.Mvc;
    using System.Threading.Tasks;
    using StarWarsRSN.Application.Commands.UpdateLocalizacao;
    using StarWarsRSN.WebApi.Model;
    using System.Collections.Generic;
    using Newtonsoft.Json;

    [Route("api/[controller]")]
    public sealed class RebeldesController : Controller
    {
        private readonly IRegisterUseCase registerService;

        public RebeldesController(IRegisterUseCase registerService)
        {
            this.registerService = registerService;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody]AddRebeldeRequest request)
        {
            RegisterResult result = await registerService.Execute(request.PersonalNumber, request.Nome, request.Idade, request.Genero, request.Localizacao, request.Inventario);

            RebeldeModel model = new RebeldeModel(result.Rebelde.PersonalNumber, result.Rebelde.Nome, result.Rebelde.Idade, result.Rebelde.Genero, result.Rebelde.Localizacao, result.Rebelde.Inventario);

            return CreatedAtRoute("GetRebelde", new { rebelde = model.PersonalNumber}, model);
        }


    
    }
}
