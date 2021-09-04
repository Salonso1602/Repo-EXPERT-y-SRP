using System;

namespace SRP
{
    public class Libro
    {

        public string Titulo { get ; }
        public string Autor { get ; }
        public string Codigo { get ;  }
        //los dos proximos atributos deberían separarse de esta clase a una nueva que lleve la responsabilidad de almacenar los libros
        public string SectorBiblioteca { get ; set; }
        public string EstanteBiblioteca { get ; set; }

        public Libro(String titulo, String autor, String codigo)
        {
            this.Titulo = titulo;
            this.Autor = autor;
            this.Codigo = codigo;
        }

        public void AlmacenarLibro(String sector, String estante) 
        //la clase libro debería tener solo la responsabilidad de conocer los libros y su información
        // el almacenamiento de lo mismos debería recaer en otra clase con sus metodos y atributos propios.
        {
            this.SectorBiblioteca = sector;
            this.EstanteBiblioteca = estante;
        }

    }
}
