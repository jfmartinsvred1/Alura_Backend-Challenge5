using System.ComponentModel.DataAnnotations;

namespace Alura_Backend_Challenge5.Models
{
    public class Filmes
    {
        public int filmeId { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public string Url { get; set; }
    }
}
