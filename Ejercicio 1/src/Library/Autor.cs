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
                if(this.Nombre != null && this.Apellido != null){
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
            if(this.NombreCompleto != null){
                return this.NombreCompleto;
            } else if(this.Seudonimo != null){
                return this.Seudonimo;
            } else {
                return "Anónimo";
            }
        }
    }
}
