using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class ListaDocumenti
    {
        private Dictionary<string, Documento> listaDoc;
        public Dictionary<string, Documento> ListaDoc { get; set; }


        public ListaDocumenti()
        { 
            this.ListaDoc = new Dictionary<string, Documento>();
        }

    }
}
