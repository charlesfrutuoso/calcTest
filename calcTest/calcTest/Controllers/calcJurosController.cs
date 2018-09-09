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
        public ActionResult<decimal> Get()
        {
            return Models.CalcJuros.valorFinal;
        }

        // POST api/values
        [HttpPost]
        public void Post(decimal valorInicial, int tempoMeses)
        {
            try
            {
                Models.CalcJuros.valorInicial = valorInicial;
                Models.CalcJuros.tempoMeses = tempoMeses;

                if (valorInicial == 0 && tempoMeses == 0)
                    /* Valor Final -1 indica que parametros são inválidos */
                    Models.CalcJuros.valorFinal = -1;
                else
                    /* Valor Final = Valor Inicial * (1 + juros) ^ Tempo */
                    Models.CalcJuros.valorFinal = (Decimal)Math.Pow(Convert.ToDouble(Models.CalcJuros.valorInicial * (1 + (Models.CalcJuros.valorJuros / 100))), Convert.ToDouble(Models.CalcJuros.tempoMeses));

            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }


    }
}
