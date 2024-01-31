using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_be_S1_D3_M4
{
    internal class ContoCorrente
    {
        // Creazione  variabili dei dati utili
        private string _nome;
        private string _cognome;
        private bool _aperturaConto = false;
        private int _saldo = 0;
        public string NomeCorrentista
        {
            get { return _nome; }
            set { _nome = value; }
        }
        public string Cognome
        {
            get { return _cognome; }
            set { _cognome = value; }
        }
        public bool aperturaConto
        {
            get { return _aperturaConto; }
            set { _aperturaConto = value; }
        }
        public int Saldo
        {
            get { return _saldo; }
            set { _saldo = value; }
        }

        // Creazione del menù per la scelta dell'opzione
        public void Menu()
        {
            Console.WriteLine("Buongiorno cosa vorrebbe fare ?:");
            Console.WriteLine("1. Apri conto corrente");
            Console.WriteLine("2. Fai un versamento");
            Console.WriteLine("3. Fai un prelievo");
            int selezione = int.Parse(Console.ReadLine()); // Converto !?!?

            switch (selezione)
            {
                case 1:
                    ApriContoCorrente();
                    break;

                case 2:
                    Versamento();
                    break;

                case 3:
                    Prelievo();
                    break;

                default:
                    Console.WriteLine("Scelta errata");
                    Menu();
                    break;
            }

        }
       
        private void Prelievo() // Procedura per prelievo
        {
            if (_aperturaConto == false)
            {
                Console.WriteLine("Nessun conto corrente trovato");
            }
            else
            {
                Console.WriteLine("Quanto vorresti ritirare ? ");
                int soldiUscenti = int.Parse(Console.ReadLine());
                if (soldiUscenti > _saldo)
                {
                    Console.WriteLine("Sei povero, non esagerare");
                }
                else
                {
                    Console.WriteLine("Denaro in uscita");
                    _saldo -= soldiUscenti;
                    Console.WriteLine($"Saldo attuale: {_saldo}");
                }
            }
            Menu();
        }
        private void Versamento() // Procedura per versamento
        {
            if (_aperturaConto == false)
            {
                Console.WriteLine("Nessun conto corrente trovato");
            }
            else
            {
                Console.WriteLine("Quanto vorresti depositare ? ");
                int soldiEntranti = int.Parse(Console.ReadLine());

                Console.WriteLine("Versamento effettuato");
                _saldo += soldiEntranti;
                Console.WriteLine($"Saldo attuale: {_saldo}");
            }
            Menu();
        }
        private void ApriContoCorrente() // Procedura per aprire conto corrente 
        {

            Console.WriteLine("Nome: ");
            string Nome = Console.ReadLine();
            Console.WriteLine("Cognome: ");
            string Cognome = Console.ReadLine();
            ContoCorrente c = new ContoCorrente();
            _nome = Nome;
            _cognome = Cognome;
            _saldo = 0;
            _aperturaConto = true;
            Console.WriteLine($"Conto aperto a: {_nome} {_cognome} con saldo {_saldo}");
            Menu();
        }


    }

}





