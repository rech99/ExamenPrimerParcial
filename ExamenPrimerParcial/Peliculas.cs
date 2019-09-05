using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPrimerParcial
{
    class Peliculas
    {

        public string Nombre { get; set; }
        public string Director { get; set; }
        private int _año;
        public int Año
        {
            get { return _año; }
            set
            {
                if (_año >= 1800 || _año <= 2019)
                {
                    _año = value;
                }
                else
                {
                    throw new Exception("La pelicula debe de estar entre el año de 1800 a 2019");
                }
            }
        }
        public  string Genero { get; set; }
        public string Pais { get; set; }
        private int _duracion;
        public int Duracion
        {
            get { return _duracion; }
            set
            {
                if (_duracion >= 0)
                {
                    _duracion = value;
                }
                else
                {
                    throw new Exception("La pelicula debe de tener una duracion minima de un minuto");
                }
            }
        }
        private double _rating;
        public double Rating
        {
            get { return _rating; }
            set
            {
                if (_rating <= 10 || _rating >= 0)
                {
                    _rating = value;
                }
                else
                {
                    throw new Exception("El rating tiene que ir del 0 al 10");
                }
            }
        }
        public string Sinopsis { get; set; }

        public Peliculas()
        {
            Nombre = "No se encuentra";
            Director = "No se encuentra";
            Año = 0;
            Genero = "No se encuentra";
            Pais = "No se encuentra";
            Duracion = 0;
            Rating = 0;
            Sinopsis = "No se encuentra";
        }

        public Peliculas(string nombre, string director, int año, string genero, string pais, int duracion, double rating, string sinopsis)
            {
                Nombre = nombre;
                Director = director;
                Año = año;
                Genero = genero;
                Pais = pais;
                Duracion = duracion;
                Rating = rating;
                Sinopsis = sinopsis;
            }
        
    }
}
