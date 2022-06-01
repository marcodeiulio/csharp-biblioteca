using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Documento
    {
        private string titolo;
        public string Titolo { get => titolo; set => titolo = value; }

        private int anno;
        public int Anno { get => anno; set => anno = value; }

        private string stato;
        public string Stato { get => stato; set => stato = value; }

        private string scaffale;
        public string Scaffale { get => scaffale; set => scaffale = value; }

        private string autori;

        public string Autori { get => autori; set => autori = value; }



        public Documento(string titolo, int anno, string scaff, string author )
        { 
            this.Titolo = titolo;
            this.Anno = anno;
            this.scaffale = scaff;
            this.Autori = author;
            this.Stato = "Disponibile";

        }

        public void ImpostaInPrestito()
        {
            this.Stato = "In Prestito";
        }

        public void ImpostaDisponibile()
        {
            this.Stato = "Disponibile";
        }


        //public override string ToString()
        //{
        //    return string.Format("Codice:{0}\nTitolo:{1}\nSettore:{2}\nStato:{3}\nScaffale numero:{4}\n Stato:{5}",

        //        this.Titolo,
        //        this.Anno,
        //        this.Scaffale,
        //        this.Autori,
        //        this.Stato);
        //}


    }
}
