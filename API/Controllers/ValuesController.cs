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
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {            
            // Dado que a pessoa não passou uma coordenada geramos uma aleatória
            Random random = new Random();
            double coordenada = random.NextDouble();

            // Verificamos o retorno da função naquela coordenada
            double val_na_coordenada = OtimizacaoClassicaLib.Otimizador.declaraFuncao("f(x) = 0.65 - (0.75 / (1 + x^2)) - 0.65 * x * atan(1/x)",coordenada);
            
            return new string[] { $"f(x) = {val_na_coordenada}" , $"x = {coordenada}" };
        }

        // GET api/values/x+1/5
        [HttpGet("{cript_func}")]
        public ActionResult<IEnumerable<string>> Get(string cript_func)
        {
            //Descriptografa função
            //regredescriptografia: 'div'->'/'
            string func = cript_func.Replace("div","/");

            // Dado que a pessoa não passou uma coordenada geramos uma aleatória
            Random random = new Random();
            double coordenada = random.NextDouble();
            
            // Verificamos o retorno da função naquela coordenada
            double val_na_coordenada = OtimizacaoClassicaLib.Otimizador.declaraFuncao(func,coordenada);
            
            return new string[] { $"f(x) = {val_na_coordenada}" , $"x = {coordenada}" };            
        }

        // GET api/values/x+1/5
        [HttpGet("{cript_func}/{coordenada}")]
        public ActionResult<IEnumerable<string>> Get(string cript_func, double coordenada)
        {
            //Descriptografa função
            //regredescriptografia: 'div'->'/'
            string func = cript_func.Replace("div","/");
            
            // Verificamos o retorno da função naquela coordenada
            double val_na_coordenada = OtimizacaoClassicaLib.Otimizador.declaraFuncao(func,coordenada);
            
            return new string[] { $"f(x) = {val_na_coordenada}" , $"x = {coordenada}" };            
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
