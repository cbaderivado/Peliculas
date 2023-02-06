namespace Peliculas.DTOs
{
    public class CineDTO
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Cadena { get; set; }
        public DireccionDTO Direccion { get; set; }
        public List<SalaDTO> Salas { get; set; }
        //public List<PeliculaDTO> Peliculas { get; set; }
    }
}