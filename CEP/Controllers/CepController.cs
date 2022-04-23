using CEP.Models;
using CEP.Services;
using Microsoft.AspNetCore.Mvc;

namespace CEP.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CepController : ControllerBase
    {
        private ICepService _cepService;

        public CepController(ICepService cepService)
        {
            _cepService = cepService;
        }

        [HttpGet(Name = "Cep")]
        public Cep Get(string cep)
        {
           var cepRetorno =  _cepService.ConsultarCep(cep);
            return cepRetorno.Result;
        }
    };
}
