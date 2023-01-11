using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPPolimorfismo.Avion
{
    internal class AvionCarga : AvionBase
    {
        public AvionCarga(string piloto, string copiloto, string azafata, string peso, string tipoMercaderia) : base(piloto, copiloto, azafata)
        {
            Peso = peso;
            TipoMercaderia = tipoMercaderia;
        }

        public string Peso { get; set; }

        public string TipoMercaderia { get; set;}

        public override string Aterrizar()
        {
            return "Aterrizar en la pista 10";
        }

        public override string Despega()
        {
            return "Despega por pista 2";
        }

        public override string ToString()
        {
            return base.Imprimir() + $"\nPeso: {Peso}" +
                $"\nTipo de Mercaderia: {TipoMercaderia}";
        }

    }
}
