using HotelLibrary;
internal class Program
{
    static void NuovaPrenotazione()
    {
        Prenotazione p = new Prenotazione();
        p.DataPrenotazione = DateTime.Now;

        bool repeat = false;
        do
        {
            Console.Write("Numero prenotazione: ");
            int numeroPrenotazione;
            if (!int.TryParse(Console.ReadLine(), out numeroPrenotazione))
            {
                Console.WriteLine("Inserisci un numero corretto!");
                repeat = true;
            }
            else if (numeroPrenotazione < 0)
            {
                Console.WriteLine("Numero di prenotazione deve essere positivo!");
                repeat = true;
            }
            else
            {
                p.NumeroPrenotazione = numeroPrenotazione;
                repeat = false;
            }
        } while (repeat);

        do
        {
            Console.Write("Anno: ");
            int anno;
            if (!int.TryParse(Console.ReadLine(), out anno))
            {
                Console.WriteLine("Inserisci un numero corretto!");
                repeat = true;
            }
            else if (anno < 0)
            {
                Console.WriteLine("L`anno non puo essere negativo!");
                repeat = true;
            }
            else
            {
                p.Anno = anno;
                repeat = false;
            }
        } while (repeat);

        do
        {
            Console.Write("Check In (gg/mm/aaaa): ");
            DateTime checkIn;
            if (!DateTime.TryParse(Console.ReadLine(), out checkIn))
            {
                Console.WriteLine("Inserisci la data correta!");
                repeat = true;
            }
            else if (checkIn.Year < 0 || checkIn.Month < 0 || checkIn.Day < 0)
            {
                Console.WriteLine("La data non puo essere negativa!");
                repeat = true;
            }
            else
            {
                p.CheckIn = checkIn;
                repeat = false;
            }
        } while (repeat);


        do
        {
            Console.Write("Check Out (gg/mm/aaaa): ");
            DateTime checkOut;
            if (!DateTime.TryParse(Console.ReadLine(), out checkOut))
            {
                Console.WriteLine("Inserisci la data correta!");
                repeat = true;
            }
            else if (checkOut.Year < 0 || checkOut.Month < 0 || checkOut.Day < 0)
            {
                Console.WriteLine("La data non puo essere negativa!");
                repeat = true;
            }
            else
            {
                p.CheckOut = checkOut;
                repeat = false;
            }
        } while (repeat);

        do
        {
            Console.Write("Tariffa giornaliera: ");
            double tariffaGiornaliera;
            if (!double.TryParse(Console.ReadLine(), out tariffaGiornaliera))
            {
                Console.WriteLine("Inserisci un numero corretto!");
                repeat = true;
            }
            else if (tariffaGiornaliera < 0)
            {
                Console.WriteLine("Tarriffa non puo essere inferiore di 0!");
                repeat = true;
            }
            else
            {
                p.TariffaGiornaliera = tariffaGiornaliera;
                repeat = false;
            }
        } while (repeat);

        do
        {
            Console.Write("Caparra: ");
            double caparra;
            if (!double.TryParse(Console.ReadLine(), out caparra))
            {
                Console.WriteLine("Inserisci un numero corretto!");
                repeat = true;
            }
            else if (caparra < 0)
            {
                Console.WriteLine("Caparra non puo essere inferiore di 0!");
                repeat = true;
            }
            else
            {
                p.Caparra = caparra;
                repeat = false;
            }
        } while (repeat);


        

        p.Cliente = new Cliente();
        Console.Write("Cognome cliente: ");
        p.Cliente.Cognome = Console.ReadLine();
        Console.Write("Nome cliente: ");
        p.Cliente.Nome = Console.ReadLine();

        prenotazioni.Add(p);
        Console.WriteLine("Prenotazione inserita!");
    }

    static void RicercaNumeroAnno()
    {
        Console.Write("Numero: ");
        int num = int.Parse(Console.ReadLine());

        Console.Write("Anno: ");
        int anno = int.Parse(Console.ReadLine());

        Prenotazione trovata = null;

        foreach (Prenotazione p in prenotazioni)
        {
            if (p.NumeroPrenotazione == num && p.Anno == anno)
            {
                trovata = p;
                break;
            }
        }

        if (trovata != null)
        {
            StampaCosti(trovata);
        }
        else
        {
            Console.WriteLine("Prenotazione non trovata");
        }
    }

    static void RicercaPerCliente()
    {
        Console.Write("Cognome (invio per saltare): ");
        string cognome = Console.ReadLine().ToLower();

        Console.Write("Nome (invio per saltare): ");
        string nome = Console.ReadLine().ToLower();

        bool trovata = false;

        foreach (Prenotazione p in prenotazioni)
        {
            bool okCognome = true;
            bool okNome = true;

            if (cognome != "")
                okCognome = p.Cliente.Cognome.ToLower() == cognome;

            if (nome != "")
                okNome = p.Cliente.Nome.ToLower() == nome;

            if (okCognome && okNome)
            {
                StampaCosti(p);
                trovata = true;
            }
        }

        if (!trovata)
        {
            Console.WriteLine("Nessuna prenotazione e stata trovata per il cliente indicato!");
        }
    }


    static void RicercaPerData()
    {
        Console.Write("Inserisci la data (gg/mm/aaaa): ");
        DateTime dataRicerca = DateTime.Parse(Console.ReadLine());

        bool trovata = false;

        foreach (Prenotazione p in prenotazioni)
        {
            if (p.DataPrenotazione.Date == dataRicerca.Date)
            {
                StampaCosti(p);
                trovata = true;
            }
        }

        if (!trovata)
        {
            Console.WriteLine("Nessuna prenotazione e stata trovata per la data indicata!");
        }
    }

    static void StampaCosti(Prenotazione p)
    {
        Console.WriteLine("\n--- RIEPILOGO COSTI ---");
        Console.WriteLine($"Cliente: {p.Cliente.Cognome} {p.Cliente.Nome}");
        Console.WriteLine($"Totale camera: {p.CalcolaPrezzoTotaleCamera()}");
        Console.WriteLine($"Totale servizi: {p.CalcolaPrezzoTotaleServizi()}");
        Console.WriteLine($"Totale: {p.CalcolaPrezzoTotalePrenotazione()}");
        Console.WriteLine($"Caparra: {p.Caparra}");
        Console.WriteLine($"Saldo da pagare: {p.CalcolaSaldo()}");
    }



    static List<Prenotazione> prenotazioni = new List<Prenotazione>();
    public static void Main(string[] args)
    {
        int scelta;
        do
        {
            Console.WriteLine("\n--- GESTIONE PRENOTAZIONI HOTEL ---");
            Console.WriteLine("1. Nuova prenotazione");
            Console.WriteLine("2. Ricerca per numero e anno");
            Console.WriteLine("3. Ricerca per cognome/nome");
            Console.WriteLine("4. Ricerca per data prenotazione");
            Console.WriteLine("0. Esci");
            scelta = int.Parse(Console.ReadLine());

            switch (scelta)
            {
                case 1: NuovaPrenotazione(); break;
                case 2: RicercaNumeroAnno(); break;
                case 3: RicercaPerCliente(); break;
                case 4: RicercaPerData(); break;
            }

        } while (scelta != 0);
    }
}
