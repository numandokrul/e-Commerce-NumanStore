using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Sepet
/// </summary>
public class Sepet
{
    string bkod;
    string email;
    bool durum;
    int adet;
    public Sepet()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public string Bkod { get => bkod; set => bkod = value; }
 public string Email { get => email; set => email = value; }
    public bool Durum { get => durum; set => durum = value; }
    public int Adet { get => adet; set => adet = value; }
   
}

