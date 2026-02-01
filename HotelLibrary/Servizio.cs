namespace HotelLibrary;

public class Servizio
{
    public DateTime Data { get; set; }
    public string Descrizione { get; set; }
    public int Quantita { get; set; }
    public double PrezzoUnitario { get; set; }


    public double PrezzoTotale()
    {
        return Quantita * PrezzoUnitario;
    }

    public override string ToString()
    {
        return $"{Descrizione} {PrezzoUnitario}";
    }
}