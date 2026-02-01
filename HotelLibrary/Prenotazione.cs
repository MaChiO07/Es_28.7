using System.Security.AccessControl;

namespace HotelLibrary;

public class Prenotazione
{
    public int NumeroPrenotazione { get; set; }
    public int Anno { get; set; }
    public DateTime DataPrenotazione { get; set; }
    public DateTime CheckIn { get; set; }
    public DateTime CheckOut { get; set; }
    public double Caparra { get; set; }
    public double TariffaGiornaliera { get; set; }
    public Cliente Cliente { get; set; }
    public Camera Camera { get; set; }
    public List<Servizio> Servizi { get; set; } = new List<Servizio>();



    public int CalcolaGiorniSoggiorno()
    {
        return (CheckOut - CheckIn).Days;
    }



    public double CalcolaPrezzoTotaleCamera()
    {
        return CalcolaGiorniSoggiorno() * TariffaGiornaliera;
    }



    public double CalcolaPrezzoTotaleServizi()
    {
        double totale = 0;
        foreach (var s in Servizi)
            totale += s.PrezzoTotale();
        return totale;
    }



    public double CalcolaPrezzoTotalePrenotazione()
    {
        return CalcolaPrezzoTotaleCamera() + CalcolaPrezzoTotaleServizi();
    }



    public double CalcolaSaldo()
    {
        return CalcolaPrezzoTotalePrenotazione() - Caparra;
    }





    public override string ToString()
    {
        return $"{Camera} \n {DataPrenotazione} \n {NumeroPrenotazione}";
    }

}