using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulador_Vehiculos
{
    public abstract class Vehiculo
    {
        private string modelo;
        private string marca;
        private double capacidadTanque;
        private double capacidadActualTanque;
        private double consumoKmPorLitro;
        private double kmRecorridos;

        public string Modelo { get => modelo; set => modelo = value; }
        public string Marca { get => marca; set => marca = value; }
        public double CapacidadTanque { get => capacidadTanque; set => capacidadTanque = value; }
        public double CapacidadActualTanque { get => capacidadActualTanque; set => capacidadActualTanque = value; }
        public double ConsumoKmPorLitro { get => consumoKmPorLitro; set => consumoKmPorLitro = value; }
        public double KmRecorridos { get => kmRecorridos; set => kmRecorridos = value; }

        public abstract string SimularViaje(double kmRecorridos);

        public abstract void CargarCombustible();
    }
}
