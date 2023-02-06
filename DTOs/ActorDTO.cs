using Microsoft.AspNetCore.Components.Web;

namespace Peliculas.DTOs
{
    public class ActorDTO
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string PaisOrigen { get; set; }
        public bool EsPrincipal { get; set; }
    }
}