using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Guia2._1
{
  public class Persona
    {
        string Dni { get; set; }
        string Nombre { get; set; }
        
    
    public Persona(string dni, string nombre)
        {
            this.Dni = dni;
            this.Nombre = nombre;
        }
        public string VerDatos()
        {
            return $"{Nombre}(dni: {Dni}";
        }
    }


}
