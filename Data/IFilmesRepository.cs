using Alura_Backend_Challenge5.Models;

namespace Alura_Backend_Challenge5.Data
{
    public interface IFilmesRepository
    {
        Task<List<Filmes>> GetFilmes();
    }
}
