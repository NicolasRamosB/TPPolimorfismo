using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPPolimorfismo.Avion;

namespace TPPolimorfismo.Aviones
{
    public class AvionComercial : AvionBase
    {
        

        public AvionComercial(string piloto, string copiloto, string azafata, string capacidad, string lineaAerea) : base(piloto, copiloto, azafata)
        {
            Capacidad = capacidad;
            LineaAerea = lineaAerea;
        }

        public string Capacidad { get; set; }

        public string LineaAerea { get; set; }

        public override string Aterrizar()
        {
            return "Aterrizar en la pista 5";
        }

        public override string Despega()
        {
            return "Despega por pista 1";
        }

        public override string ToString()
        {
            return base.Imprimir() + $"\nCapacidad {Capacidad}" +
                                     $"\nLinea Aerea: {LineaAerea}" ;
        }

    }
}
