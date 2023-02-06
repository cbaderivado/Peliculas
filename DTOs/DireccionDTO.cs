using Microsoft.Extensions.Primitives;

using System.Reflection.Metadata.Ecma335;

namespace Peliculas.DTOs
{
    public class DireccionDTO
    {
        public int Id { get; set; }
        public string Pais { get; set; }
        public string Provincia { get; set; }
        public string Ciudad { get; set; }
        public string Cp { get; set; }
        public string Calle { get; set; }
        public int Numero { get; set; }


    }
}