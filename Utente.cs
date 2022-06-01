using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Utente : Persona
    {
        
        private string email;
        public string Email { get => email; set => email = value; }

        private string password;
        public string Password { get => password; set => password = value; }

        public Utente(string Nome, string Cognome, string Cell,string email, string password) : base(Nome,Cognome,Cell)
        { 
            Email = email;
            Password = password;

        }



        public void CercaUtente(Utente utente, Dictionary<string, Utente> listaUtenti)
        {
            string key = utente.Nome + ";" + utente.Cognome + ";" + utente.Email;

            try 
            {
                if (listaUtenti.ContainsKey(key))
                    Console.WriteLine("L'utente e presente nel sistema");
                else
                    Console.WriteLine("L'utente non e presente nel sistema");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }



        public void CercaLibro(string isbn, Dictionary<string, Libro> listaLibro)
        {
            if (listaLibro.ContainsKey(isbn))
            {
                Console.WriteLine("Il LIbro e presente nel sistema:");
                listaLibro[isbn].ToString();
            }
            else
            {
                Console.WriteLine("Libro non trovato");
            }

        }

        public void CercaDvd(string codice, Dictionary<string, Dvd> listaDvd)
        {
            if (listaDvd.ContainsKey(codice))
            {
                Console.WriteLine("Il Dvd e presente nel sistema:");
                listaDvd[codice].ToString();
            }
            else
            {
                Console.WriteLine("Dvd non trovato");
            }

        }


        public override string ToString()
        {
            return string.Format("Nome:{0}\n Cognome:{1}\n Cell:{2}\n Email:{3}\n Password",
                this.Nome,
                this.Cognome,
                this.Cell,
                this.Email,
                this.Password);
        }
    }
}
