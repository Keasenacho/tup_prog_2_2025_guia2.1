using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia2._1
{
    public class Registro
    {
        string Patente { get; set; }
        string Serie { get;  set; }
        public Persona Propietario { get; set; }
    
    public void RegistroVehiculo(string patente, string serie, Persona propietario)
        {

            this.Patente = patente;
            this.Serie = serie;
            this.Propietario = propietario;
        }
        public string VerDetalle()
        {
            return $"Patente {Patente} - Serie {Serie}-Nombre{Propietario.nombre}-Dni{Propietario.Dni}";

         }
    }
}
