using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patikfy_Muzik_Platformu
{
    public class Patikafy
    {
        public string Ad { get; set; }
        public string Tur { get; set; }
        public int Yil { get; set; }
        public int Satis { get; set; }

        public Patikafy(string ad, string tur, int yil, int satis)
        {
            Ad = ad;
            Tur = tur;
            Yil = yil;
            Satis = satis;
        }

    }
}
