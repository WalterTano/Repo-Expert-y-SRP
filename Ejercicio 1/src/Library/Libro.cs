using System;

namespace SRP
{
    public class Libro
    {

        public string Titulo { get ; }

        public string Autor { get ; }
        /*
        Autor debería ser su propia clase.
        No es responsabilidad de un libro tener toda la información sobre su autor.
        Además, es posible querer cambiar la información del autor que se puede tener,
        ya que actualmente solo se tendría el nombre. Por ejemplo, incluyendo la fecha
        de nacimiento del autor, podrían buscarse libros de autores que vivieron en inicios
        del siglo XX.
        */
        public string Codigo { get ;  }

        public string SectorBiblioteca { get ; set; }
        public string EstanteBiblioteca { get ; set; }
        /*
        Biblioteca (o estante/sector) debería ser una clase que contenga una lista de libros.
        La clase libro podría tener razones para cambiar relacionadas a la biblioteca y no solo
        a los libros.
        */

        public Libro(String titulo, String autor, String codigo)
        {
            this.Titulo = titulo;
            this.Autor = autor;
            this.Codigo = codigo;
        }

        // La responsabilidad de almacenar un libro sería de una biblioteca, no del libro mismo.
        public void AlmacenarLibro(String sector, String estante)
        {
            this.SectorBiblioteca = sector;
            this.EstanteBiblioteca = estante;
        }

    }
}
