namespace Peliculas.DTOs
{
    public class ComentarioDTO
    {
        public int Id { get; set; }
        public string usuario { get; set; }
        public string Contenido { get; set; }
        public int MeGustaCantidad { get; set; }
    }
}