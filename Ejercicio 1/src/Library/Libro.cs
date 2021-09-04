using System;

namespace SRP
{
    public class Libro
    {

        public string Titulo { get ; }
        public string Autor { get ; }
        public string Codigo { get ;  }

        public Libro(String titulo, String autor, String codigo)
        {
            this.Titulo = titulo;
            this.Autor = autor;
            this.Codigo = codigo;
        }

     
    }

    public class Biblioteca //creo una clase biblioteca cuyas instancias pueden representar las diferentes bibliotecas
    //en este estado se les pueden añadir libro sin discriminación si un lugar esta libre o existe, pero estas precauciones no
    //se especificaron en la letra por lo que no las desarrollé.
    {
        public string NombreBiblioteca { get; set;}
        public string SectorBiblioteca { get ; set; }
        public string EstanteBiblioteca { get ; set; }
        public Libro LibroGuardado{ get ; set; }

        public Biblioteca(string nombre)
        {
            this.NombreBiblioteca = nombre;
        }

        public void AlmacenarLibro(Libro libro, String sector, String estante) 
        {
            this.SectorBiblioteca = sector;
            this.EstanteBiblioteca = estante;
            this.LibroGuardado = libro;
        }
    }
}

// de esta manera las responsabilidades de conocer los datos del libro, y la de almacenarlos, estan separadas en cada clase.