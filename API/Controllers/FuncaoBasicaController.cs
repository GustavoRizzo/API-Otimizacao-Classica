using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OtimizacaoClassicaLib;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FuncaoBasicaController : ControllerBase
    {
        // GET api/FuncaoBasica
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get([FromQuery] string str_func, [FromQuery] double coordenada)
        {            
            // Dado que a pessoa não passou uma coordenada geramos uma aleatória
            //Random random = new Random();
            //double coordenada = random.NextDouble();

            // Verificamos o retorno da função naquela coordenada
            double val_na_coordenada = OtimizacaoClassicaLib.Otimizador.declaraFuncao(str_func, coordenada);
            
            return new string[] { $"f(x) = {str_func}" , $"f({coordenada}) = {val_na_coordenada}" , $"x = {coordenada}" };
        }
    }
}