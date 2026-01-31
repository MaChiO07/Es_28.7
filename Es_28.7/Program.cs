internal class Program
{
    public static void Main(string[] args)
    {
        bool start = true;

        Console.WriteLine("== GRAN HOTEL ==");

        while (start)
        {
            int scelta = -1;
            do
            {
                Console.WriteLine();
                Console.WriteLine("Inserisci: ");
                Console.WriteLine("1) Carica una nuova prenotazione");
                Console.WriteLine("2) Cerca prenotazione per Numero/Anno");
                Console.WriteLine("3) Cerca prenotazione per Nome/Cognome del cliente");
                Console.WriteLine("4) Cerca prenotazione per la Data");
                Console.WriteLine("0) Finire programma");

                int.TryParse(Console.ReadLine(), out scelta);
                if (!int.TryParse(Console.ReadLine(), out scelta))
                    Console.WriteLine("Inserire un numero corretto! 0-4");
            } while (scelta == -1);


        }
    }
}
