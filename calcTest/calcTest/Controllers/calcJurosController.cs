using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace calcTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalcJurosController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "Valor inicial:" + Models.CalcJuros.valorInicial.ToString(),
                                  "Valor final:" + Models.CalcJuros.valorFinal.ToString() };
        }

        // POST api/values
        [HttpPost]
        public void Post(decimal valorInicial, int tempoMeses)
        {
            try
            {
                Models.CalcJuros.valorInicial = valorInicial;
                Models.CalcJuros.tempoMeses = tempoMeses;

                /*  Valor Final = Valor Inicial * (1 + juros) ^ Tempo */
                Models.CalcJuros.valorFinal = (Decimal)Math.Pow(Convert.ToDouble(Models.CalcJuros.valorInicial * (1 + (Models.CalcJuros.valorJuros / 100))), Convert.ToDouble(Models.CalcJuros.tempoMeses));

            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }


    }
}
