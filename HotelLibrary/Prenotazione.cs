using System.Security.AccessControl;

namespace HotelLibrary;

public class Prenotazione
{
    public Camera Camera { get; set; }
    public DateTime Data { get; set; }
    public int NumeroPrenotazione { get; set; }
    public int Anno { get; set; }
    public DateTime CheckIn { get; set; }
    public DateTime CheckOut { get; set; }
    public int CaparraConfermatoria { get; set; }
    public int Tariffa { get; set; }
    public string Trattamento { get; set; }
    public bool ServiziAggiuntivi { get; set; }

    
    

    
    
    public override string ToString()
    {
        return $"{Camera} \n {Data} \n {NumeroPrenotazione}";
    }
}