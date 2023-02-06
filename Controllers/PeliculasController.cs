using Microsoft.AspNetCore.Mvc;

using Peliculas.DTOs;
using Peliculas.Models;

using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;

using static System.Net.WebRequestMethods;

namespace Peliculas.Controllers
{
    public class PeliculasController : Controller
    {
        private readonly ILogger<PeliculasController> _logger;

        public PeliculasController ( ILogger<PeliculasController> logger )
        {
            _logger = logger;
        }

        [HttpGet]
        
        public IActionResult Index ()
        {
            var PeliculasEstreno = GetPeliculasEstreno ();
            return View (PeliculasEstreno);
        }
        [HttpGet]
        [Route("{resumen}/{id}")]
        public IActionResult Resumen ( int id)
        {
            PeliculaDTO resumenpelicula = GetPeliculasEstrenoporId (id);

            return View ( resumenpelicula );
        }

        private PeliculaDTO GetPeliculasEstrenoporId (int id)
        {
            PeliculaDTO pelicula = GetPeliculasEstreno ().Where ( x => x.Id == id ).FirstOrDefault ();
            return pelicula;
        }

        private List<PeliculaDTO> GetPeliculasEstreno ()
        {
            var Peliculas = new List<PeliculaDTO> ();


            #region Comentarios
            ComentarioDTO jpcomentario1 = new ComentarioDTO { Id = 1, Contenido = "Excelente accion y ciencia ficcion", usuario="pepito",MeGustaCantidad=30 };
            ComentarioDTO jpcomentario2 = new ComentarioDTO { Id = 1, Contenido = "Imposible obtener ADN de dinosurios asi, horrible", usuario = "juanpe", MeGustaCantidad = 20 };
            List<ComentarioDTO> jpcomentarios = new List<ComentarioDTO> ();
            jpcomentarios.Add ( jpcomentario1 );
            jpcomentarios.Add ( jpcomentario2 );
            ComentarioDTO ttcomentario1 = new ComentarioDTO { Id = 1, Contenido = "obra maestra", usuario = "elisass", MeGustaCantidad = 9 };
            ComentarioDTO ttcomentario2 = new ComentarioDTO { Id = 1, Contenido = "Rose podria haber dejado que suba Leo...", usuario = "pelimirador", MeGustaCantidad = 50 };
            List<ComentarioDTO> ttcomentarios = new List<ComentarioDTO> ();
            ttcomentarios.Add ( ttcomentario1 );
            ttcomentarios.Add ( ttcomentario2 );
            ComentarioDTO smcomentario1 = new ComentarioDTO { Id = 1, Contenido = "Buena parodia sobre un mercado saturado", usuario = "pantallista", MeGustaCantidad = 15 };
            ComentarioDTO smcomentario2 = new ComentarioDTO { Id = 1, Contenido = "No puede insultar de esa manera al mejor genero", usuario = "Tres2De", MeGustaCantidad = 90 };
            List<ComentarioDTO> smcomentarios = new List<ComentarioDTO> ();
            smcomentarios.Add ( smcomentario1 );
            smcomentarios.Add ( smcomentario2 );
            ComentarioDTO gfcomentario1 = new ComentarioDTO { Id = 1, Contenido = "Lo que deben estudiar en la escuela de direccion de cine", usuario = "opinadorSerial", MeGustaCantidad = 180 };
            ComentarioDTO gfcomentario2 = new ComentarioDTO { Id = 1, Contenido = "Me quede dormido a los 20 minutos.", usuario = "multigusto", MeGustaCantidad = 1 };
            List<ComentarioDTO> gfcomentarios = new List<ComentarioDTO> ();
            gfcomentarios.Add ( gfcomentario1 );
            gfcomentarios.Add ( gfcomentario2 );
            #endregion
            
            #region Actores
            ActorDTO leo = new ActorDTO
            {
                Id = 1,
                Nombre = "Leo",
                Edad = 50,
                PaisOrigen = "EEUU",
                EsPrincipal = true
            };

            ActorDTO rose = new ActorDTO
            {
                Id = 1,
                Nombre = "Rose",
                Edad = 50,
                PaisOrigen = "EEUU",
                EsPrincipal = true
            };
            List<ActorDTO> jpactores = new List<ActorDTO> ();
            jpactores.Add ( leo );
            jpactores.Add ( rose );


            ActorDTO Andy = new ActorDTO
            {
                Id = 1,
                Nombre = "Andy Garcia",
                Edad = 80,
                PaisOrigen = "EEUU",
                EsPrincipal = true
            };
            ActorDTO Alpa = new ActorDTO
            {
                Id = 1,
                Nombre = "Al Paccino",
                Edad = 80,
                PaisOrigen = "EEUU",
                EsPrincipal = true
            };
            List<ActorDTO> ttactores = new List<ActorDTO> ();
            ttactores.Add ( Andy );
            ttactores.Add ( Alpa );

            ActorDTO Sidney = new ActorDTO
            {
                Id = 1,
                Nombre = "Berta",
                Edad = 40,
                PaisOrigen = "EEUU",
                EsPrincipal = true
            };
            ActorDTO Golum = new ActorDTO
            {
                Id = 1,
                Nombre = "jeff",
                Edad = 65,
                PaisOrigen = "EEUU",
                EsPrincipal = true
            };
            List<ActorDTO> smactores = new List<ActorDTO> ();
            smactores.Add ( Sidney );
            smactores.Add ( Golum );
            ActorDTO BobD = new ActorDTO
            {
                Id = 1,
                Nombre = "Robert Deniro",
                Edad = 90,
                PaisOrigen = "EEUU",
                EsPrincipal = true
            };
            ActorDTO Samuel = new ActorDTO
            {
                Id = 1,
                Nombre = "Samuel LJ",
                Edad = 60,
                PaisOrigen = "EEUU",
                EsPrincipal = true
            };
            List<ActorDTO> gfactores = new List<ActorDTO> ();
            gfactores.Add ( BobD );
            gfactores.Add ( Samuel );
            #endregion

            #region Generos
            GeneroDTO scifi = new GeneroDTO { Nombre = "Ciencia ficcion" };
            GeneroDTO epica = new GeneroDTO { Nombre = "Epica" };
            GeneroDTO comedia = new GeneroDTO { Nombre = "Comedia" };
            GeneroDTO drama = new GeneroDTO { Nombre = "Drama" };
            #endregion

            #region Direcciones
            DireccionDTO DirHoyts = new DireccionDTO
            {
                Id = 1,
                Pais = "ARG",
                Provincia = "STAFE",
                Ciudad = "Rosario",
                Cp = "2000",
                Calle = "Nazcar",
                Numero = 450
            };
            DireccionDTO DirCinePolis = new DireccionDTO
            {
                Id = 1,
                Pais = "ARG",
                Provincia = "STAFE",
                Ciudad = "Rosario",
                Cp = "2000",
                Calle = "Eva Peron",
                Numero = 8500
            };
            #endregion

            #region Tipos de salas
            TipoDTO dosd = new TipoDTO { Id = 1, Nombre = "2D" };
            TipoDTO tresd = new TipoDTO { Id = 1, Nombre = "2D" }; 
            #endregion
            
            #region Salas
            SalaDTO Sala2dHoyts = new SalaDTO
            {
                Id = 1,
                Nombre = "Sala 2D",
                Tipo = dosd
            };
            SalaDTO Sala3dHoyts = new SalaDTO
            {
                Id = 2,
                Nombre = "Sala 3D",
                Tipo = tresd
            };
            List<SalaDTO> SalasHoyst = new List<SalaDTO>();
            SalasHoyst.Add ( Sala2dHoyts );
            SalasHoyst.Add ( Sala3dHoyts );



            SalaDTO Sala2dCinepolis = new SalaDTO
            {
                Id = 1,
                Nombre = "Sala 2D",
                Tipo = dosd
            };
            SalaDTO Sala3dCinepolis = new SalaDTO
            {
                Id = 2,
                Nombre = "Sala 3D",
                Tipo = tresd
            };
            List<SalaDTO> SalasCinepolis = new List<SalaDTO> ();
            SalasHoyst.Add ( Sala2dCinepolis );
            SalasHoyst.Add ( Sala3dCinepolis );

            #endregion

            #region Cines
            CineDTO Hoyts = new CineDTO
            {
                Id = 1,
                Nombre = "Hoyts",
                Cadena = "Halmark",
                Direccion = DirHoyts,
                Salas = SalasHoyst
            };
            CineDTO Cinepolis = new CineDTO
            {
                Id = 1,
                Nombre = "Cinepolis",
                Cadena = "MexiCine",
                Direccion = DirCinePolis,
                Salas = SalasCinepolis
            };
            List<CineDTO> Cines = new List<CineDTO> ();
            Cines.Add ( Hoyts );
            Cines.Add(Cinepolis);
            #endregion

            #region Criticas
            List<CriticaDTO> CriticasJp = new List<CriticaDTO> ();
            CriticaDTO CriticaJp1 = new CriticaDTO
            {
                Id = 1,
                Contenido = "Buena critica",
                Autor = "Don criticon"
            };
            CriticasJp.Add ( CriticaJp1 );
            CriticaDTO CriticaJp2 = new CriticaDTO
            {
                Id = 1,
                Contenido = "mediocre critica",
                Autor = "Don DirectorFrustrado"
            };
            CriticasJp.Add ( CriticaJp2 );
            CriticaDTO CriticaJp3 = new CriticaDTO
            {
                Id = 1,
                Contenido = "mala critica",
                Autor = "Don MequedeDormido"
            };
            CriticasJp.Add ( CriticaJp3 );

            List<CriticaDTO> CriticasTt = new List<CriticaDTO> ();
            CriticaDTO CriticaTt1 = new CriticaDTO
            {
                Id = 1,
                Contenido = "Buena critica",
                Autor = "Don criticon"
            };
            CriticasTt.Add ( CriticaTt1 );
            CriticaDTO CriticaTt2 = new CriticaDTO
            {
                Id = 1,
                Contenido = "mediocre critica",
                Autor = "Don DirectorFrustrado"
            };
            CriticasTt.Add ( CriticaTt2 );
            CriticaDTO CriticaTt3 = new CriticaDTO
            {
                Id = 1,
                Contenido = "mala critica",
                Autor = "Don MequedeDormido"
            };
            CriticasTt.Add ( CriticaTt3 );

            List<CriticaDTO> CriticasSm = new List<CriticaDTO> ();
            CriticaDTO CriticaSm1 = new CriticaDTO
            {
                Id = 1,
                Contenido = "Buena critica",
                Autor = "Don criticon"
            };
            CriticasSm.Add ( CriticaSm1 );
            CriticaDTO CriticaSm2 = new CriticaDTO
            {
                Id = 1,
                Contenido = "mediocre critica",
                Autor = "Don DirectorFrustrado"
            };
            CriticasSm.Add ( CriticaSm2 );
            CriticaDTO CriticaSm3 = new CriticaDTO
            {
                Id = 1,
                Contenido = "mala critica",
                Autor = "Don MequedeDormido"
            };
            CriticasSm.Add ( CriticaSm3 );

            List<CriticaDTO> CriticasGf = new List<CriticaDTO> ();
            CriticaDTO CriticaGf1 = new CriticaDTO
            {
                Id = 1,
                Contenido = "Buena critica",
                Autor = "Don criticon"
            };
            CriticasGf.Add ( CriticaGf1 );
            CriticaDTO CriticaGf2 = new CriticaDTO
            {
                Id = 1,
                Contenido = "mediocre critica",
                Autor = "Don DirectorFrustrado"
            };
            CriticasGf.Add ( CriticaGf2 );
            CriticaDTO CriticaGf3 = new CriticaDTO
            {
                Id = 1,
                Contenido = "mala critica",
                Autor = "Don MequedeDormido"
            };
            CriticasGf.Add ( CriticaGf3 ); 
            #endregion

            #region Peliculas
            PeliculaDTO JurasicPark = new PeliculaDTO
            {

                Id = 1,
                PaisOrigen = "EEUU",
                Nombre = "Jurasic Park",
                Resumen = "Viejo loco revive dinosaurios ",
                FechaEstreno = new DateTime ( 1992, 06, 15 ),
                Director = "Spilbergo",
                Comentarios = jpcomentarios,
                Actores = jpactores,
                Genero = scifi,
                PosterLink = "poster_001.jpeg",
                Cines = Cines,
                TrailerLink= "https://www.youtube.com/embed/dLDkNge_AhE",
                Criticas=CriticasJp

            };
            Peliculas.Add ( JurasicPark );
            PeliculaDTO Titanic = new PeliculaDTO
            {

                Id = 2,
                PaisOrigen = "EEUU",
                Nombre = "Titanic",
                Resumen = "Nunca vieron el iceberg",
                FechaEstreno = new DateTime ( 1995, 06, 15 ),
                Director = "Spilbergo",
                Comentarios = ttcomentarios,
                Actores = ttactores,
                Genero = scifi,
                PosterLink = "poster_002.png",
                Cines = Cines,
                TrailerLink = "https://www.youtube.com/embed/tA_qMdzvCvk",
                Criticas = CriticasTt

            };
            Peliculas.Add ( Titanic );

            PeliculaDTO ScaryMovie = new PeliculaDTO
            {
                Id = 3,
                PaisOrigen = "EEUU",
                Nombre = "Scary movie",
                Resumen = "Y donde esta el susto?",
                FechaEstreno = new DateTime ( 1998, 06, 15 ),
                Director = "Los hermanos",
                Comentarios = smcomentarios,
                Actores = smactores,
                Genero = scifi,
                PosterLink = "poster_003.jpeg",
                Cines = Cines,
                TrailerLink= "https://www.youtube.com/embed/HTLPULt0eJ4",
                Criticas = CriticasSm

            };
            Peliculas.Add ( ScaryMovie );

            PeliculaDTO ElPadrino = new PeliculaDTO
            {
                Id = 4,
                PaisOrigen = "EEUU",
                Nombre = "El padrino",
                Resumen = "Mafiosos  adiestra y siniestra",
                FechaEstreno = new DateTime ( 1970, 06, 15 ),
                Director = "Scorsese",
                Comentarios = gfcomentarios,
                Actores = gfactores,
                Genero = drama,
                PosterLink = "poster_004.jpeg",
                Cines = Cines,
                TrailerLink= "https://www.youtube.com/embed/gCVj1LeYnsc",
                Criticas = CriticasGf

            };
            Peliculas.Add ( ElPadrino ); 
            #endregion

            return Peliculas;
        }

        public IActionResult Privacy ()
        {
            return View ();
        }

        [ResponseCache ( Duration = 0, Location = ResponseCacheLocation.None, NoStore = true )]
        public IActionResult Error ()
        {
            return View ( new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier } );
        }
    }
}
