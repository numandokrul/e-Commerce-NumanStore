using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for UrunCRUD
/// </summary>
public class UrunCRUD
{
    public UrunCRUD()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    Db db = new Db();
    public DataTable tumliste()
    {
        db.ac();
        DataTable dt = new DataTable();
        SqlCommand komut = new SqlCommand("select * from urunler", db.baglanti);

        SqlDataAdapter adp = new SqlDataAdapter(komut);
        adp.Fill(dt);

        db.kapat();

        return dt;
    }


    public DataTable katliste(string gkat)
    {
        db.ac();
        DataTable dt = new DataTable();
        SqlCommand komut = new SqlCommand("select * from urunler  where kategoriler=@a", db.baglanti);
        komut.Parameters.AddWithValue("@a", gkat);

        SqlDataAdapter adp = new SqlDataAdapter(komut);
        adp.Fill(dt);

        db.kapat();

        return dt;
    }




    public DataTable ilk4liste()
    {
        db.ac();
        DataTable dt = new DataTable();
        SqlCommand komut = new SqlCommand("select top 4 * from urunler order by barkodkodu desc", db.baglanti);

        SqlDataAdapter adp = new SqlDataAdapter(komut);
        adp.Fill(dt);
        db.kapat();


        return dt;
    }
    public Urun tekurun(string gbkod)
    {
        Urun burun = new Urun();
        db.ac();
        SqlCommand komut = new SqlCommand("select * from urunler where barkodkodu=@a", db.baglanti);
        komut.Parameters.AddWithValue("@a", gbkod);
        SqlDataReader rd = komut.ExecuteReader();
        while (rd.Read())
        {
            burun.Kat = rd[0].ToString();
            burun.Marka = rd[1].ToString();
            burun.Urunad = rd[2].ToString();
            burun.Fiyat = Convert.ToInt32(rd[3]);
            burun.Kdv = rd[4].ToString();
            burun.Pbirim = rd[5].ToString();
            burun.Stkodu = rd[6].ToString();
            burun.Barkod = rd[7].ToString();
            burun.Stadet = rd[8].ToString();
            burun.Kagirlik = rd[9].ToString();
            burun.Resim = rd[10].ToString();
            burun.Detay = rd[12].ToString();

        }
        db.kapat();
        return burun;
    }
    public DataTable kategorilericekme()
    {

        DataTable kat = new DataTable();
        SqlCommand komut = new SqlCommand("select distinct(kategoriler) from urunler", db.baglanti);
        SqlDataAdapter adp = new SqlDataAdapter(komut);
        adp.SelectCommand = komut;
        adp.Fill(kat);

        db.kapat();

        return kat;

    }
    public DataTable kategoriyeuruncek(string kategoriadi)
    {
        db.ac();

        DataTable kat = new DataTable();
        SqlCommand komut = new SqlCommand("select * from  urunler where kategoriler like '%" + kategoriadi + "%'", db.baglanti);
        //komut.Parameters.AddWithValue("@a", kategoriadi);


        SqlDataAdapter adp = new SqlDataAdapter(komut);
        adp.SelectCommand = komut;
        adp.Fill(kat);

        db.kapat();

        return kat;

    }

    public DataTable yenigelenler(string yenigelen)
    {
        db.ac();

        DataTable dz = new DataTable();
        SqlCommand komut = new SqlCommand("select* from  urunler where kategoriler=@a", db.baglanti);
        komut.Parameters.AddWithValue("@a", yenigelen);
        SqlDataAdapter adp = new SqlDataAdapter(komut);
        adp.SelectCommand = komut;
        adp.Fill(dz);

        db.kapat();

        return dz;

    }
    public DataTable AramaSonuclariListe(string aramakriteri)
    {
        db.ac();
        DataTable listem = new DataTable();
        SqlCommand komut = new SqlCommand("select * from urunler where urunadi like '%" + aramakriteri + "%'", db.baglanti);//tablodaki kayıtları çeker
        SqlDataAdapter adp = new SqlDataAdapter();// adp aracılığı ile gelen kayıtları listeleme aktarılıyor
        adp.SelectCommand = komut;
        adp.Fill(listem);
        db.kapat();
        return listem;
    }


}