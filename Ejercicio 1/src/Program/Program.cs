using System;

namespace SRP
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Libro libro1 = new Libro("Design Patterns","Erich Gamma & Others","001-034");
            Libro libro2 = new Libro("Pro C#","Troelsen","001-035");
            Biblioteca BibliotecaUCU = new Biblioteca("Biblioteca de la UCU");
            BibliotecaUCU.AlmacenarLibro(libro1,"A","7");
            BibliotecaUCU.AlmacenarLibro(libro2,"B","3");

        }
    }
}
