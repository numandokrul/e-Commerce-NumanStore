using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace admin2
{
    public class Musteri
    {
        string adsoyad, tcno, meslek, tel, adres, sehir, mail, ulke;

        public string Adsoyad { get => adsoyad; set => adsoyad = value; }
        public string Tcno { get => tcno; set => tcno = value; }
        public string Meslek { get => meslek; set => meslek = value; }
        public string Tel { get => tel; set => tel = value; }
        public string Adres { get => adres; set => adres = value; }
        public string Sehir { get => sehir; set => sehir = value; }
        public string Mail { get => mail; set => mail = value; }
        public string Ulke { get => ulke; set => ulke = value; }
    }
}