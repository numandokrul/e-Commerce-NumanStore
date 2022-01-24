using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Urun
/// </summary>
public class Urun
{
	public Urun()
	{
		//
		// TODO: Add constructor logic here
		//
	}
	string kat, marka, urunad, pbirim, stkodu, barkod, stadet, kdv, resim, detay,kagirlik;
	int fiyat;

    public string Kat { get => kat; set => kat = value; }
    public string Marka { get => marka; set => marka = value; }
    public string Urunad { get => urunad; set => urunad = value; }
    public string Pbirim { get => pbirim; set => pbirim = value; }
    public string Stkodu { get => stkodu; set => stkodu = value; }
    public string Barkod { get => barkod; set => barkod = value; }
    public string Stadet { get => stadet; set => stadet = value; }
    public string Kdv { get => kdv; set => kdv = value; }
    public string Resim { get => resim; set => resim = value; }
    public string Detay { get => detay; set => detay = value; }
    public string Kagirlik { get => kagirlik; set => kagirlik = value; }
    public int Fiyat { get => fiyat; set => fiyat = value; }
}