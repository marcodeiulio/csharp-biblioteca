using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Prestito
    {
        public string Numero { get; set; }
        public DateTime Inizio { get; set; }
        public DateTime Fine { get; set; }
        public Utente Utente { get; set; }
        public Documento Documento { get; set; }

       
        public Prestito(string Numero, DateTime inizio, DateTime fine, Utente Utente, Documento Documento)
        {
            this.Numero = Numero;
            this.Inizio = inizio;
            this.Fine = fine;
            this.Utente = Utente;
            this.Documento = Documento;
            
        }

        public override string ToString()
        {
            return string.Format("Numero:{0}\nDal:{1}\nAl:{2}\nStato:{3}\nUtente:\n{4}\nDocumento:\n{5}",
                this.Numero,
                this.Inizio,
                this.Fine,
                this.Documento.Stato,
                this.Utente.ToString(),
                this.Documento.ToString());
        }
    }
}
