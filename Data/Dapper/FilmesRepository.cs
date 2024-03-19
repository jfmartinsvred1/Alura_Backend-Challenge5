using Alura_Backend_Challenge5.Models;
using Dapper;
using MySql.Data.MySqlClient;
using System.Data;

namespace Alura_Backend_Challenge5.Data.Dapper
{
    public class FilmesRepository : IFilmesRepository
    {
        private IConfiguration _configuration;
        private IDbConnection _connection;

        public FilmesRepository(IConfiguration configuration, IDbConnection connection)
        {
            _configuration = configuration;
            _connection = new MySqlConnection(_configuration.GetConnectionString("DefaultConn"));
        }


        public async Task<List<Filmes>> GetFilmes()
        {
            var config = _configuration.GetConnectionString("");

            List<Filmes> filmes = (await _connection.QueryAsync<Filmes>("Select * from tb_filmes")).ToList();
            return filmes;
        }

    }
}
