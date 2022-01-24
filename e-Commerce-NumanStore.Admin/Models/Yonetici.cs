using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace admin2
{
    public class Yonetici 
    {
        public Yonetici()
        {
            //
            // TODO: Add constructor logic here
            //
        }
        string email, kadi, sfr, resim,adsoyad;

       public string Adsoyad { get => adsoyad; set => adsoyad = value; }
        public string Email { get => email; set => email = value; }
        public string Kadi { get => kadi; set => kadi = value; }
        public string Sfr { get => sfr; set => sfr = value; }
        public string Resim { get => resim; set => resim = value; }
       
    }
}