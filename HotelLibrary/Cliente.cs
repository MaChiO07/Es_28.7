namespace HotelLibrary
{
    public class Cliente
    {
        public string CodiceFiscale { get; set; }
        public string Cognome { get; set; }
        public string Nome { get; set; }
        public string Citta { get; set; }
        public string Provincia { get; set; }
        public string Email { get; set; }
        public int NumeroTelefono { get; set; }


        public Cliente(string codiceFiscale, string cognome, string nome, string citta, string provincia, string email, int numeroTelefono)
        {
            CodiceFiscale = codiceFiscale;
            Cognome = cognome;
            Nome = nome;
            Citta = citta;
            Provincia = provincia;
            Email = email;
            NumeroTelefono = numeroTelefono;
        }

        public override string ToString()
        {
            return $"{Cognome} {Nome} {CodiceFiscale}";
        }
    }
}
