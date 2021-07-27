namespace StarWarsRSN.WebApi.UseCases.UpdateLocalizacao
{
    using Microsoft.AspNetCore.Mvc;
    using System.Threading.Tasks;
    using StarWarsRSN.Application.Commands.UpdateLocalizacao;
    using StarWarsRSN.WebApi.Model;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using StarWarsRSN.WebApi.UseCases.Register;

    [Route("api/[controller]")]
    public sealed class RebeldesController : Controller
    {
        private readonly IUpdateLocalizacaoUseCase RegisterService;

        public RebeldesController(IUpdateLocalizacaoUseCase registerService)
        {
            this.RegisterService = registerService;
        }

        [HttpPut]
        public async Task<IActionResult> Post([FromBody]UpdateLocalizacaoRequest request)
        {
            var a = Newtonsoft.Json.JsonConvert.SerializeObject(request);
            //\\JsonSerializer.Create().Serialize(.Serialize(request);
            UpdateLocalizacaoResult result = await RegisterService.Execute(request.PersonalNumber,request.Localizacao);

            LocalizacaoModel model = new LocalizacaoModel(result.localizacaoResult.PersonalNumber, result.localizacaoResult.Localizacao);

            return CreatedAtRoute("Post", new { rebelde = model.PersonalNumber}, model);
        }
    }
}
