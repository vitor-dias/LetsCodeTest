namespace StarWarsRSN.WebApi.Filters
{
    using StarWarsRSN.Application;
    using StarWarsRSN.Domain;
    using StarWarsRSN.Infrastructure;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Filters;
    using Newtonsoft.Json;
    using System.Net;
    
    public sealed class DomainExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            var domainException = context.Exception;
            if (domainException != null)
            {
                string json = JsonConvert.SerializeObject(domainException.Message);

                context.Result = new BadRequestObjectResult(json);
                context.HttpContext.Response.StatusCode = (int)HttpStatusCode.BadRequest;
            }

            ApplicationException applicationException = context.Exception as ApplicationException;
            if (applicationException != null)
            {
                string json = JsonConvert.SerializeObject(applicationException.Message);

                context.Result = new BadRequestObjectResult(json);
                context.HttpContext.Response.StatusCode = (int)HttpStatusCode.BadRequest;
            }

            InfrastructureException infrastructureException = context.Exception as InfrastructureException;
            if (infrastructureException != null)
            {
                string json = JsonConvert.SerializeObject(infrastructureException.Message);

                context.Result = new BadRequestObjectResult(json);
                context.HttpContext.Response.StatusCode = (int)HttpStatusCode.BadRequest;
            }
        }
    }
}
