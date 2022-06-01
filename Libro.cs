using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Libro : Documento
    {
        private string isbn;
        public string ISBN { get => isbn; set => isbn = value; }

        private string settore;

        public string Settore { get => settore; set => settore = value; }

        private int pagine;

        public int Pagine { get => pagine; set => pagine = value; }



        public Libro(string titolo, int anno, string scaff, string author, string isbn, string settore, int pagine) : base(titolo, anno, scaff, author)
        {
            this.ISBN = isbn;
            this.Settore = settore;
            this.Pagine = pagine;
        }


        public override string ToString()
        {
            return string.Format("{0}\n ISBN:{1}\n Settore: {2}\n Pagine: {3}",
                base.ToString(), this.ISBN, this.Settore, this.Pagine);
        }



    }
}
