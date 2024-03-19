using Alura_Backend_Challenge5.Models;
using Dapper;
using MySql.Data.MySqlClient;
using System.Text.Json;

namespace Alura_Backend_Challenge5.Data.Dapper
{
    public class FilmesRepository : IFilmesRepository
    {
        private IConfiguration _configuration;
        private string _connection;

        public FilmesRepository(IConfiguration configuration, string connection)
        {
            _configuration = configuration;
            _connection = _configuration.GetConnectionString("Default");
        }


        public List<Filmes> GetFilmes()
        {
            using (var a = new MySqlConnection(_connection))
            {
                List<Filmes> filmes = (a.Query<Filmes>("Select * from filmes")).ToList();
                return filmes;
            }

        }

    }
}
