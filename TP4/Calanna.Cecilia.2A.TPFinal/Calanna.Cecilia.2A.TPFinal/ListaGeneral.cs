using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calanna.Cecilia._2A.TPFinal
{
    public class ListaGeneral<T> where T : Universo
    {
        public List<T> listaGeneral;

        public ListaGeneral(int cantidad)
        {
            listaGeneral = new List<T>(cantidad);     
        }
        public ListaGeneral() :this(100)
        {
            listaGeneral = new List<T>();
        }

        

        public ListaGeneral<T> GetDeLaLista
        {
            get; 
        
        }

    }
}
