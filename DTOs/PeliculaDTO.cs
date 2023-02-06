using System.Runtime.InteropServices;

namespace Peliculas.DTOs
{
    public class PeliculaDTO
    {
        public int Id { get; set; }
        public string PaisOrigen { get; set; }
        public string Nombre { get; set; }
        public string Resumen { get; set; }
        public DateTime FechaEstreno { get; set; }
        public string Director { get; set; }

        public List<ComentarioDTO> Comentarios   { get; set; }

        public List<ActorDTO> Actores { get; set; }
        public GeneroDTO Genero { get; set; }

        public string PosterLink { get; set; }
        public string TrailerLink { get; set; }
        public List<CineDTO> Cines { get; set; }
        public List<CriticaDTO> Criticas { get; set; }



    }
}
