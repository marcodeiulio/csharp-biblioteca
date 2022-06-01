using System;
using System.IO;
namespace csharp_biblioteca // Note: actual namespace depends on the project name.
{
    internal class Program
    {

        

        static void Main(string[] args)
        {

            // Definisco le librerie ed i Dizionari

            Dictionary<string, Dvd> Dictdvd = new Dictionary<string, Dvd>();
            Dictionary<string, Libro> Dictlibri = new Dictionary<string, Libro>();
            Dictionary<string, Utente> Dictutenti = new Dictionary<string, Utente>();
            List<Prestito> listPrestiti = new List<Prestito>();


            Biblioteca b = new Biblioteca("Civica", Dictlibri, Dictdvd, Dictutenti, listPrestiti);

           
            // Qui sto leggendo i dati dal file e ripopolando gli utenti

            //if (File.Exists("biblioteca.txt"))
            //    b.RestoreUtenti("biblioteca.txt");
            //else
            //    Console.WriteLine("Il file non esiste");

            

            Utente u1 = new Utente("Nome 1", "Cognome 1", "342343", "Email 1", "Password 1");
            Utente u2 = new Utente("Nome 2", "Cognome 2", "786778", "Email 2", "Password 2");
            Utente u3 = new Utente("Nome 3", "Cognome 3", "467976", "Email 3", "Password 3");

            Libro l1 = new Libro("Harry Potter", 2000, "Scaffale A", "KJ Rowling", "3478974gggjjd", "Fantasy", 345);
            Dvd dvd1 = new Dvd("Queen", 1987, "Scaffale A", "Queen", "7689", "Rock", 3.35);
            

            

            b.AggiungiUtente(u1);
            b.AggiungiUtente(u2);
            b.AggiungiUtente(u3);


            Console.WriteLine("========= Variabili di configurazione ========");

            Configurazione.ReadAllSettings();



            // GESTIONE FILE DI CONFIGURAZIONE
            string vPublic = Environment.GetEnvironmentVariable("PUBLIC");
            if (vPublic != null)
                Console.WriteLine("variabile d'ambiente {0}", vPublic);

            vPublic += "\\Biblioteca";
            string mioPath = @"C:\Users\Matteo\corso_net\csharp-biblioteca\bin\Debug\net6.0\biblioteca.txt";
            //Verifico se il file biblioteca esiste nella variabile d'ambiente, se non esiste creo la cartella Biblioteca


            if (!Directory.Exists(vPublic))
            {

                Console.WriteLine("Dove vuoi storare i file?");
                Console.WriteLine("Sul computer centrale (C3): premi 1");
                Console.WriteLine("Sul sul tuo computer: premi 2");

                string choise = Console.ReadLine();
                int chouseUser = Convert.ToInt32(choise);


                if (chouseUser == 1)
                {
                    Directory.CreateDirectory(vPublic);
                    Console.WriteLine("Ho creato la cartella");
                    
                    //CREO LA CARTELLA BIBLIOTECA NEL PC REMOTO E SCRIVO I FILE
                    string pathCompleto = vPublic + @"\biblioteca.txt";
                    b.SaveUtenti(pathCompleto);



                    //CREO IL FILE biblioteca.txt NELLA CARTELLA BIN DOVE MI SEGNO IL PATH DELLA CARTELLA DEL COMPUTER REMOTO
                    StreamWriter sr = new StreamWriter("biblioteca.txt");
                    sr.WriteLine(pathCompleto);

                    sr.Close();

                }
                else if (chouseUser == 2)
                {
                    //CREO IL FILE NEL MIO COMPUTER E LO USO COME DATABASE PER SCRIVERE I DATI 
                    b.SaveUtenti("biblioteca.txt");

                }
                else
                { 
                    Environment.Exit(0);
                }
                
            }
            else
            {
                
                Console.WriteLine("la directory esiste");
                if (File.Exists(vPublic + @"\biblioteca.txt"))
                {
                    //QUI LEGGERO I DATI DAL FILE e mi estrapolo il percorso per andare a leggere i file
                    string pathCompleto = vPublic + @"\biblioteca.txt";
                    b.RestoreUtenti(pathCompleto);
                }
                else if (File.Exists(mioPath))
                {
                    b.RestoreUtenti(mioPath);
                }
                else 
                { 
                    Environment.Exit(0);         
                }


            }

            b.AggiungiDvd(dvd1);
            b.AggiungiLibro(l1);
           
            
            //b.AggiungiPrestito(u1, l1);
            
            
            
            //foreach (Prestito doc in listPrestiti)
            //{
            //    Console.WriteLine("=========== Prestito =============");
            //    Console.WriteLine(doc.ToString());
                
            //}
            

            //Console.WriteLine("\n\nSearchPrestiti: Nome 1, Cognome 1\n\n");
            //List<Prestito> prestiti = b.SearchPrestiti("Nome 1", "Cognome 1");
            //foreach (Prestito p in prestiti)
            //{
            //    Console.WriteLine(p.ToString());
            //    Console.WriteLine("--------------------------");
            //}
        }
    }
}