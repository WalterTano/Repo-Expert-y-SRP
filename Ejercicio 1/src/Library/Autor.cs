using System;

namespace SRP
{
    public class Autor
    {
        public string Seudonimo { get; }

        public string Nombre { get; }

        public string Apellido { get; }

        public string NombreCompleto {
            get{
                if(!String.IsNullOrEmpty(this.Nombre) && !String.IsNullOrEmpty(this.Apellido)){
                    return $"{this.Nombre} {this.Apellido}";
                }
                return null;
            }
        }

        public Autor(String nombre, String apellido, String seudonimo){
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Seudonimo = seudonimo;
        }

        public Autor(String nombre, String apellido)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
        }

        public Autor(String seudonimo){
            this.Seudonimo = seudonimo;
        }

        public string ObtenerNombre(){
            if(!String.IsNullOrEmpty(this.NombreCompleto)){
                return this.NombreCompleto;
            } else if(!String.IsNullOrEmpty(this.Seudonimo)){
                return this.Seudonimo;
            } else {
                return "Anónimo";
            }
        }
    }
}
