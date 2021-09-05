using System;
using System.Collections;
using System.Collections.Generic;

namespace SRP
{
    public class Biblioteca
    {
        
        public ArrayList Libros {get; set;}

        public Biblioteca(ArrayList libros)
        {
            this.Libros = libros;
        }

        public Biblioteca(){
            this.Libros = new ArrayList();
        }

        public void AlmacenarLibro(Libro libro, String sector, String estante){
            libro.SectorBiblioteca = sector;
            libro.EstanteBiblioteca = estante;
            this.Libros.Add(libro);
        }

        public Libro EncontrarLibroConTitulo(String titulo)
        {
            foreach(Libro libroEnBiblioteca in this.Libros)
            {
                if(libroEnBiblioteca.Titulo.Equals(titulo))
                {
                    return libroEnBiblioteca;
                }
            }
            return null;
        }
    }
}
