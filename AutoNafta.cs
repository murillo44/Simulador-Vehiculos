using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulador_Vehiculos
{
    public class AutoNafta : Vehiculo
    {
        public AutoNafta(string Marca, string Modelo, double CapacidadTanque, double ConsumoKmPorLitro) 
        {
            this.Marca = Marca;
            this.Modelo = Modelo;
            this.CapacidadTanque = CapacidadTanque;
            this.ConsumoKmPorLitro = ConsumoKmPorLitro;

            this.CapacidadActualTanque = CapacidadTanque;
        }

        public override string SimularViaje(double kmRecorridos)
        {
            double litrosConsumidos = kmRecorridos / this.ConsumoKmPorLitro;

            if (litrosConsumidos <= this.CapacidadActualTanque)
            {
                this.CapacidadActualTanque -= litrosConsumidos;
                this.KmRecorridos += kmRecorridos;

                return "Se ha realizado un viaje correctamente. Se recorrieron " + kmRecorridos + "KMS y el gasto de combustible fue de " + litrosConsumidos + " litros.";
            } 
            else
            {
                return "No te alcanza el combustible para realizar este viaje.";
            }
            
        }
        
        public override void CargarCombustible()
        {
            this.CapacidadActualTanque = this.CapacidadTanque;
        }
    }
}
