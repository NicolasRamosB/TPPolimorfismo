using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPPolimorfismo.Avion
{
    public abstract class AvionBase
    {
        protected AvionBase(string piloto, string copiloto, string azafata)
        {
            Piloto = piloto;
            Copiloto = copiloto;
            Azafata = azafata;
        }

        public string Piloto { get; set; }
        public string Copiloto { get; set; }
        public string Azafata { get; set; }


        public abstract string Aterrizar();
        public abstract string Despega();

        public virtual string Imprimir()
        {
            return $"\nNombre Piloto: {Piloto}" +
                   $"\nNombre Copiloto: {Copiloto}" +
                   $"\nNombre Azafata: {Azafata}";
        }



    }
}
