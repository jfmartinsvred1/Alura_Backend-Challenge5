using Alura_Backend_Challenge5.Data;
using Alura_Backend_Challenge5.Data.Dapper;
using Alura_Backend_Challenge5.Models;
using Microsoft.AspNetCore.Mvc;

namespace Alura_Backend_Challenge5.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FilmeController : ControllerBase
    {
        private IFilmesRepository _filmesRepository;

        public FilmeController(IFilmesRepository filmesRepository)
        {
            _filmesRepository = filmesRepository;
        }
        [HttpGet]
        public IActionResult GetFilmes()
        {

            var filmes = _filmesRepository.GetFilmes();
            return Ok(filmes);
        }
    }
}
