using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPrimerParcial
{
    class Playlist
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public List<Peliculas> Lista { get; set; }
        
        public Playlist(string nombre, string descripcion)
        {
            Nombre = "No se encuentra";
            Descripcion = "No se encuentra";
        }

        public Playlist()
        {
           Lista = new List<Peliculas>();
        
        }

    }
}
