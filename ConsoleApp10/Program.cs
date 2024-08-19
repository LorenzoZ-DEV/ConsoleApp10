class Program
{
    static void Main(string[] args)
    {
        Lampadina lampadina = new Lampadina();

        lampadina.nled = 50;
        lampadina.indirizzoIP = "127.168.102.3";
        lampadina.Statolampadina = "Accesa";
        lampadina.NomeLampadina = "Philips Hue";
        lampadina.PotenzaInWatt = 15;

        Console.WriteLine("Nome:" + lampadina.NomeLampadina);
        Console.WriteLine("Indirizzo IP" + lampadina.indirizzoIP);
        Console.WriteLine("Stato" + lampadina.Statolampadina);
        Console.WriteLine("Potenza" + lampadina.PotenzaInWatt + "W");
    }
}