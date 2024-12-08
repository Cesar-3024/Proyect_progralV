using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Programacios_lV_Grupo6.Modelo
{
    //Clase que nos permite recibir y dar los atributos agregados
    //Si deben agregar mas, deberan añadirlos a las demas llamadas
    public class Persona
    {
        public int id { get; set; }
        public string Nombre { get; set; }
        public string Primer_Apellido { get; set; }
        public string Segundo_Apellido { get; set; }
        public string Celular { get; set; }
        public string Correo_Electronico { get; set; }

        public Persona(int id, String Nombre, string Primer_Apellido, String Segundo_Apellido, String Celular, String Correo_Electronico)
        {
            this.id = id;
            this.Nombre = Nombre;
            this.Primer_Apellido = Primer_Apellido;
            this.Segundo_Apellido = Segundo_Apellido;
            this.Celular = Celular;
            this.Correo_Electronico = Correo_Electronico;
        }

        public Persona()
        {
        }
       
    }
}
