using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Simulador_Vehiculos
{
    internal class AutoHibrido : Vehiculo
    {
        private double bateriaActual;
        private double consumoBateriaPorKm;

        public double BateriaActual { get => bateriaActual; set => bateriaActual = value; }
        public double ConsumoBateriaPorKm { get => consumoBateriaPorKm; set => consumoBateriaPorKm = value; }

        public AutoHibrido(string Marca, string Modelo, double CapacidadTanque, double ConsumoKmPorLitro, double ConsumoBateriaPorKm)
        {
            this.Marca = Marca;
            this.Modelo = Modelo;
            this.CapacidadTanque = CapacidadTanque;
            this.ConsumoKmPorLitro = ConsumoKmPorLitro;
            this.ConsumoBateriaPorKm = ConsumoBateriaPorKm;

            this.CapacidadActualTanque = CapacidadTanque;
            this.BateriaActual = 100;
        }

        public void CargarBateria()
        {
            this.BateriaActual = 100;
        }

        public override void CargarCombustible()
        {
            this.CapacidadActualTanque = this.CapacidadTanque;
        }

        public override string SimularViaje(double kmRecorridos)
        {
            double bateriaAConsumirViaje = kmRecorridos * this.ConsumoBateriaPorKm;
            double litrosConsumidos = kmRecorridos / this.ConsumoKmPorLitro;

            if (bateriaAConsumirViaje >= this.BateriaActual)
            {
                this.BateriaActual -= bateriaAConsumirViaje;
                this.KmRecorridos += kmRecorridos;

                return "Se ha realizado el viaje correctamente. Se recorrieron " + kmRecorridos + "kms utilizando carga eléctrica. Te queda " + this.BateriaActual + "% de carga.";
            }
            else if (litrosConsumidos <= this.CapacidadActualTanque)
            {
                this.CapacidadActualTanque -= litrosConsumidos;
                this.KmRecorridos += kmRecorridos;

                return "Se ha realizado el viaje correctamente. Se recorrieron " + kmRecorridos + "KMS y el gasto de combustible fue de " + litrosConsumidos + " litros.";
            }
            else
            {
                return "No te alcanza el combustible o carga eléctrica para realizar este viaje.";
            }
        }


    }
}
