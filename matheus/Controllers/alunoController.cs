using matheus.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace matheus.Controllers
{
       
    [ApiController]
    public class alunoController : ControllerBase
    {
        public List<int> numeros = [1,2,3,4,5,6,7,8,9,0];

        public static List<Pessoa> pessoas = new List<Pessoa>();
        [HttpPost]
        [Route("Registro Pessoas")]
        public IActionResult RegistroAluno([FromBody] Pessoa pessoa)
        {
            pessoas.Add(pessoa);

            const string numeros = "0123456789";

           if (pessoa.RA.StartsWith("RA")) {

                for (int i = 2; i < pessoa.RA.Length; i++)
                    if (numeros.IndexOf(pessoa.RA[i]) < 0) return BadRequest("RA Invalido");
                return Ok("Usuario registrado");
            }
            return BadRequest("RA Invalido");
            }
        }
    }

