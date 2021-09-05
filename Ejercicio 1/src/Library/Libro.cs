using System;

namespace SRP
{
    public class Libro
    {

        public string Titulo { get ; }

        public Autor Autor { get ; }

        public string Codigo { get ;  }

        public string SectorBiblioteca { get ; set; }

        public string EstanteBiblioteca { get ; set; }

        public Libro(String titulo, Autor autor, String codigo)
        {
            this.Titulo = titulo;
            this.Autor = autor;
            this.Codigo = codigo;
        }
    }
}
