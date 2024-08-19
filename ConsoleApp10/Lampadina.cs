using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class Lampadina
    {
    public int PotenzaInWatt { get; set; } = 0;
        public int Durata {  get; set; }
        public string Statolampadina { get; set; } = string.Empty;
        public int nled;
        public string indirizzoIP;
        public string NomeLampadina;
         public string NumClienti;
        public Lampadina(int potenzainwatt, int durata)
        {
            PotenzaInWatt = potenzainwatt;
            Durata = durata;    
        }

    public Lampadina()
    {
        indirizzoIP = string.Empty;
        nled = 0;
        NomeLampadina = string.Empty;
        NumClienti = string.Empty;
    }

    public void Accendi(string statolampadina)
        {
        Statolampadina = statolampadina;

        }
         public void MostraLampadina()
    {
        Console.WriteLine("Lampadina:" + Statolampadina);
    }
        public void Spegni()
        {
           Console.WriteLine("Lampadina" + Statolampadina +"all'indirizzo" + indirizzoIP);
        }
    }

