using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelLibrary
{

    public enum TipologiaCamera
    {
        Singola,
        Doppia
    }
    public class Camera
    {

        public int Numero { get; set; }
        public string Descrizione { get; set; }
        public TipologiaCamera Tipologia { get; set; }




        public override string ToString()
        {
            return $"{Numero} {Tipologia} {Descrizione}";
        }
    }
}
