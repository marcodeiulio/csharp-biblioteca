using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Dvd : Documento
    {
        private string codice;
        public string Codice { get => codice; set => codice = value; }

        private string genere;
        public string Genere { get => genere; set => genere = value; }

        private double durata;
        public double Durata { get => durata; set => durata = value; }



        public Dvd(string titolo, int anno, string scaff, string author, string codice, string genere, double durata) : base(titolo, anno, scaff, author)
        {
            this.Codice = codice;
            this.Genere = genere;
            this.Durata = durata;
        }


        public override string ToString()
        {
            return string.Format("{0}\nDurata:{1}\n Genere: {2}\n Codice: {3}", 
                base.ToString(), this.Durata, this.Genere, this.Codice);
        }

    }
}
