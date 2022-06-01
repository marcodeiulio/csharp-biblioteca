using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Biblioteca
    {
        private string nome;
        public string Nome { get => nome; set => nome = value; }
        public Dictionary<string, Libro> Libri { get; set; }
        public Dictionary<string, Dvd> Dvd { get; set; }
        public List<Prestito> Prestiti { get; set; }
        public Dictionary<string, Utente> Utenti { get; set; }


        public Biblioteca(string Nome, Dictionary<string, Libro> libri, Dictionary<string, Dvd> dvd, Dictionary<string, Utente> utenti, List<Prestito> lsPrestiti)
        {
            this.Nome = Nome;
            this.Libri = libri;
            this.Dvd = dvd;
            this.Utenti = utenti;
            this.Prestiti = lsPrestiti;
        }



        public bool SaveUtenti(string filename)
        {
            StreamWriter sw = new StreamWriter(filename);
            foreach (KeyValuePair<string, Utente> entry in Utenti)
            {
                sw.WriteLine(entry.Value.Nome + ":" + entry.Value.Cognome + ":" + 
                    entry.Value.Cell + ":" + entry.Value.Email + ":" + entry.Value.Password);
               
            }
            sw.Close();
            return true;
        }


        public bool RestoreUtenti(string filename)
        {
            StreamReader sw = new StreamReader(filename);
            string sRiga;
            List<Utente> listU = new List<Utente>();
            while ((sRiga = sw.ReadLine()) != null)
            {

                string[] vett = sRiga.Split(":");
                string Nome = vett[0];
                string Cognome = vett[1];
                string Cell = vett[2];
                string Email = vett[3];
                string Password = vett[4];

                Utente utente = new Utente(Nome,Cognome,Cell,Email,Password);
                listU.Add(utente);  


            }
            foreach (Utente u in listU)
                Console.WriteLine(u.ToString());

            sw.Close();
            return true;
        }


        public void CercaLibro(string isbn)
        {
            if (Libri.ContainsKey(isbn))
            {
                Console.WriteLine("Il LIbro e presente nel sistema:");
                Libri[isbn].ToString();
            }
            else
            {
                Console.WriteLine("Libro non trovato");
            }

        }


        public void CercaDvd(string codice)
        {
            if (Dvd.ContainsKey(codice))
            {
                Console.WriteLine("Il Dvd e presente nel sistema:");
                Dvd[codice].ToString();
            }
            else
            {
                Console.WriteLine("Dvd non trovato");
            }

        }

        public void AggiungiUtente(Utente utente)
        { 
            string nome = utente.Nome;
            string cognome = utente.Cognome;
            string email = utente.Email;

            string key = nome + ";" + cognome + ";" + email;

            Utenti.Add(key, utente);
        }

        public void AggiungiLibro(Libro libro)
        {
            string key = libro.ISBN;

            if (Libri.ContainsKey(key))
            {
                Console.WriteLine("Libro gia presente nell'archivio");
            }
            else
            { 
                Libri.Add(key, libro);
            }
        }


        public void AggiungiDvd(Dvd dvd)
        {
            string key = dvd.Codice;

            if (Dvd.ContainsKey(key))
            {
                Console.WriteLine("Libro gia presente nell'archivio");
            }
            else
            {
                Dvd.Add(key, dvd);
            }
        }


        public void CercaUtente(Utente utente)
        {
            string key = utente.Nome + ";" + utente.Cognome + ";" + utente.Email;

            try
            {
                if (Utenti.ContainsKey(key))
                    Console.WriteLine("L'utente e presente nel sistema");
                else
                    Console.WriteLine("L'utente non e presente nel sistema");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

      


        public void AggiungiPrestito(Utente utente, Documento documento)
        { 
            DateTime inizioPrestito = DateTime.Now;
            DateTime finePrestito = inizioPrestito.AddMonths(1);

            string chiave = "";
            for (int i = 0; i < 6; i++)
            { 
                Random r = new Random();
                int num = r.Next(0,9);

                chiave += r;
            }


            Prestito prestito = new Prestito(chiave, inizioPrestito, finePrestito, utente, documento);
            Prestiti.Add(prestito);
            documento.Stato = "In prestito";

            //if(prestito.Contains(prestito.Numero))
            //Prestiti.Add(prestito);
            
        }


        //public List<Prestito> CercaPrestito(Prestito p)
        //{
        //    if (Prestiti.Contains(p))
        //    {
        //        Prestiti.Where(p => Prestiti.Contains(p)).ToString();
        //    }
        //    else
        //    { 
        //        Console.WriteLine("Non ci sono prestiti ")
        //    }
        //}
    }
}
