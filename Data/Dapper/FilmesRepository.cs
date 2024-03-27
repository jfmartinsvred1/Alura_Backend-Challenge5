using Alura_Backend_Challenge5.Models;
using Dapper;
using MySql.Data.MySqlClient;

namespace Alura_Backend_Challenge5.Data.Dapper
{
    public class FilmesRepository : IFilmesRepository
    {
        private IConfiguration _configuration;

        public FilmesRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public FIlme GetFIlme(int id)
        {
            var connetctionString = _configuration.GetConnectionString("Default");

            var sql = @"Select * from filmes where FilmeId= @Id";

            using (var a = new MySqlConnection(connetctionString))
            {
                FIlme filme = (a.QueryFirstOrDefault<FIlme>(sql,new {Id =id}));
                return filme;
            }
        }

        public List<FIlme> GetFilmes()
        {
            var connetctionString = _configuration.GetConnectionString("Default");

            var sql = @"Select * from filmes";

            using (var a = new MySqlConnection(connetctionString))
            {
                List<FIlme> filmes = (a.Query<FIlme>(sql)).ToList();
                return filmes;
            }

        }

    }
}
