using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia2._1
{
    public class RegistroVehiculo
    {
        public string Patente { get; set; }
        public string Serie { get; set; }
        public Persona Propietario { get; set; }
        public RegistroVehiculo() { }
        public int CantidadRegistros { get; set; }
        public void RegistroVehicul(string patente, string serie, Persona propietario)
        {
            this.Patente = patente;
            this.Serie = serie;
            this.Propietario = propietario;
        }
        public string VerDetalle()
        {
            return $"Patente {Patente} - Serie {Serie} - Nombre {Propietario.nombre} - Dni {Propietario.dni}";
        }
    }
    public class DepartamentoVehicular
    {
        private List<RegistroVehiculo> registros = new List<RegistroVehiculo>();
        private int CantidadRegistros = 0;
        private Random rnd = new Random();
        public RegistroVehiculo RegistrarVehiculo(Persona elPropietario)
        {
            CantidadRegistros++;
            string nuevaSerie = CantidadRegistros.ToString();
            while (nuevaSerie.Length < 9)
                nuevaSerie = "0" + nuevaSerie;
            string nuevaPatente = GenerarPatente();
            RegistroVehiculo unRegistro = new RegistroVehiculo();
            unRegistro.RegistroVehicul(nuevaPatente, nuevaSerie, elPropietario);
            registros.Add(unRegistro);

            return unRegistro;
        }
        private string GenerarPatente()
        {
            string letras = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string resultado = "";
            for (int i = 0; i < 2; i++)
                resultado += letras[rnd.Next(letras.Length)];

            string numeros = CantidadRegistros.ToString();
            while (numeros.Length < 3)
                numeros = "0" + numeros;

            return resultado + numeros;
        }
        public RegistroVehiculo VerRegistro(int indice)
        {
            if (indice >= 0 && indice < registros.Count)
                return registros[indice];
            return null;
        }

    }
}







