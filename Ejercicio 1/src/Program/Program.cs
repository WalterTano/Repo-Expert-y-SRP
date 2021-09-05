using System;

namespace SRP
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Biblioteca biblioteca1 = new Biblioteca();
            Autor autor1 = new Autor("Erich Gamma & Others");
            Autor autor2 = new Autor("Troelsen");
            Libro libro1 = new Libro("Design Patterns", autor1 ,"001-034");
            Libro libro2 = new Libro("Pro C#", autor2, "001-035");
            biblioteca1.AlmacenarLibro(libro1, "A", "7");
            biblioteca1.AlmacenarLibro(libro2, "B", "3");
            
            System.Console.WriteLine(biblioteca1.EncontrarLibroConTitulo("Pro C#").Codigo);
        }
    }
}
