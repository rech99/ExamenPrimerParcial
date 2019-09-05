using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPrimerParcial
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Playlist> playlists = new List<Playlist>();

            Playlist Pl1 = new Playlist();
            Playlist Pl2 = new Playlist();


            playlists.Add(Pl1);
            playlists.Add(Pl2);

            Pl1.Nombre = "Oldies";
            Pl1.Descripcion = "Peliculas de antaño para disfrutar\n";






            Peliculas Resplandor = new Peliculas("El Resplandor", "Stanley Kubrick", 1975, "Terror Psicologico", "Estados Unidos", 187, 8.7, "Jack Torrance no sabe lo que el Overlook le depara..." );
            Peliculas Taxi = new Peliculas("Taxi Driver", "Martin Scorsese", 1973, "Thriller Psicologico", "Estados Unidos", 195, 9.2, "Un veterano regresa a casa a Nueva York, y este es el inicio de sus problemas");
            Peliculas FMJ = new Peliculas("Full Metal Jacket", "Stanley Kubrick", 1979, "Drama, Antibelico", "Estados Unidos", 193, 8.6, "Despues de Vietnam, nada fue lo mismo...");
            Peliculas Goodfellas = new Peliculas("Goodfellas", "Martin Scorsese", 1976, "Drama, Gangsters", "Estados Unidos", 157, 8.4, "¿Quieres ser un gangster?, atente a las consecuencias");
            Peliculas DLN = new Peliculas("Dont Look Now", "Nicolas Roeg", 1972, "Terror Psicologico", "Estados Unidos/Italia", 120 , 10, "Amor, Tragedia, Familia, Muerte, y Psiquicos, esta pelicula lo tiene todo");
            Peliculas TMWFFE = new Peliculas("The Man Who Fell From Earth", "Nicolas Roeg", 1975, "Drama, Ciencia Ficcion", "Estados Unidos", 115, 8.1, "Un aliengina cae en nuestra Tierra, esta es su historia");
            Peliculas Padrino = new Peliculas("The GodFather", "Francis Ford Coppola", 1977, "Drama, Gangsters", "Estados Unidos", 187, 9.7, "Esta pelicula empezo la nueva era de cine en Hollywoood, ¿necesitas algo mas?");

            Pl1.Lista.Add(Resplandor);
            Pl1.Lista.Add(Taxi);
            Pl1.Lista.Add(FMJ);
            Pl1.Lista.Add(Goodfellas);
            Pl1.Lista.Add(DLN);
            Pl1.Lista.Add(TMWFFE);
            Pl1.Lista.Add(Padrino);

          



            



            Pl2.Nombre = "Modernas";
            Pl2.Descripcion = "Peliculas de actualidad\n";
            Console.WriteLine("");


            Peliculas Avengers = new Peliculas("Avengers: Endgame", "Los Hermanos Russo", 2019, "Terror Psicologico", "Estados Unidos", 187, 8.7, "Despues de perderlo todo, los avengers se embarcan en una busqueda deseperada");
            Peliculas Capitan = new Peliculas("Capitan America", "Joe Russo", 2013, "Thriller Psicologico", "Estados Unidos", 120, 9.2, "El primer Vengador");
            Peliculas It = new Peliculas("It", "Andy Muscietti", 2019, "Drama, Antibelico", "Estados Unidos", 140, 8.6, "Un payaso se levanta cada 27 años a sembrar el terror en Derry");
            Peliculas Spiderman = new Peliculas("Spiderman", "Sam Raimi", 2006, "Drama, Gangsters", "Estados Unidos", 127, 8.4, "La adaptcion original de este superheroe");
            Peliculas YWNRH = new Peliculas("You Were Never Really Here", "Lynne Rmasay", 2019, "Terror Psicologico", "Estados Unidos/Italia", 120, 10, "Un veterano de Irak inteta rescatar a una niña");
            Peliculas TOTDY = new Peliculas("Too Old To Die Young", "Nicolas Winding Refn", 2019, "Drama, Ciencia Ficcion", "Estados Unidos", 600, 8.1, "Gangsters, sectas, narcos y videntes conviven en este largometraje");
            Peliculas Drive = new Peliculas("Drive", "Nicolas Winding Refn", 2011, "Drama, Gangsters", "Estados Unidos", 125, 9.7, "Un conducotr de asaltos encuentra su proposito");

            Pl2.Lista.Add(Avengers);
            Pl2.Lista.Add(Capitan);
            Pl2.Lista.Add(It);
            Pl2.Lista.Add(Spiderman);
            Pl2.Lista.Add(YWNRH);
            Pl2.Lista.Add(TOTDY);
            Pl2.Lista.Add(Drive);

            foreach (Playlist playlist in playlists)
            {
                Console.WriteLine("PLAYLIST: " + playlist.Nombre);
                Console.WriteLine("Descripcion: " + playlist.Descripcion);

                foreach (Peliculas peliculas in playlist.Lista)
                {
                    Console.WriteLine("Nombre: " + peliculas.Nombre);
                    
                    Console.WriteLine("Año: " + peliculas.Año);
                    
                    Console.WriteLine("");
                }

            }

            



            Console.Read();
        }
    }
}
