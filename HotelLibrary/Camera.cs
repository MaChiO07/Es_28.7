using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelLibrary
{
    public class Camera
    {

        public int Numero { get; set; }
        public string Descrizione { get; set; }
        public string Tipologia { get; set; }


        public Camera(int numero, string descrizione, string tipologia)
        {
            Numero = numero;
            Descrizione = descrizione;
            Tipologia = tipologia;
        }

        public override string ToString()
        {
            return $"{Numero} {Tipologia} {Descrizione}";
        }
    }
}
