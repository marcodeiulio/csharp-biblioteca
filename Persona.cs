using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Persona
    {
        private string nome;
        public string Nome { get => nome; set => nome = value; }

        private string cognome;
        public string Cognome { get => cognome; set => cognome = value; }

        private string cell;
        public string Cell { get => cell; set => cell = value; }


        public Persona(string nome, string cognome, string cell)
        { 
            Nome = nome;
            Cognome = cognome;
            Cell = cell;
        
        }
    }
}
