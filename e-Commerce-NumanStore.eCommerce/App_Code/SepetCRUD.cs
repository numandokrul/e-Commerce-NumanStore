using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for SepetCRUD
/// </summary>
public class SepetCRUD
{

    Db db = new Db();//vt için db nesnesi oluşturur
    public SepetCRUD()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public bool kaydet(Sepet ysepet)
    {   //TblAdmin tablosuna kayıt ekler
        bool sonuc = true;
        //vt kayıt işlemleri

        db.ac();//db için yol açar

        SqlCommand komut = new SqlCommand("insert into TblSepet values(@a,@b,@c,@d)", db.baglanti);//baglanti ile açılan db üzerinde 
                                                                                                   //belirtilen tabloya insert ile gelen parametre nesnesini ekliyoruz
        komut.Parameters.AddWithValue("@a", ysepet.Bkod);
        komut.Parameters.AddWithValue("@b", ysepet.Adet);
        komut.Parameters.AddWithValue("@c", ysepet.Email);
        komut.Parameters.AddWithValue("@d", ysepet.Durum);

        int etkilenen = komut.ExecuteNonQuery();//komutu çalıştırır,eğer kayıt ekleme başarılı ise 1 değilse 0 döndürür
        if (etkilenen == 0)
        {
            sonuc = false;
        }
        db.kapat();//db için yolu kapatır

        return sonuc;
    }

    public DataTable liste(string email)
    {
        db.ac();
        DataTable listem = new DataTable();
        SqlCommand komut = new SqlCommand("select * from urunler,TblSepet where urunler.barkodkodu=TblSepet.Barkod and TblSepet.email=@q", db.baglanti);//tablodaki kayıtları çeker
        komut.Parameters.AddWithValue("@q", email);
        SqlDataAdapter adp = new SqlDataAdapter();// adp aracılığı ile gelen kayıtları listeleme aktarılıyor
        adp.SelectCommand = komut;
        adp.Fill(listem);
        db.kapat();
        return listem;


    }

    public bool adetazalt(string bkod, string email)
    {
        bool sonuc = true;
        db.ac();
        SqlCommand komut = new SqlCommand("update TblSepet set adet=adet-1 where Barkod=@a and Email=@b", db.baglanti);
        komut.Parameters.AddWithValue("@a", bkod);
        komut.Parameters.AddWithValue("@b", email);
        int cevap = komut.ExecuteNonQuery();
        if (cevap == 0)
        {
            sonuc = false;
        }
        db.kapat();
        return sonuc;
    }

    public bool adetartir(string bkod, string email)
    {
        bool sonuc = true;
        db.ac();
        SqlCommand komut = new SqlCommand("update TblSepet set adet=adet+1 where Barkod=@a and Email=@b", db.baglanti);
        komut.Parameters.AddWithValue("@a", bkod);
        komut.Parameters.AddWithValue("@b", email);
        int cevap = komut.ExecuteNonQuery();
        if (cevap == 0)
        {
            sonuc = false;
        }
        db.kapat();
        return sonuc;
    }

    public bool varmi(string email, string bkod)
    {
        bool sonuc = true;
        db.ac();
        SqlCommand komut = new SqlCommand("select count (Barkod) from TblSepet where Barkod=@a and Email=@b", db.baglanti);
        komut.Parameters.AddWithValue("a", bkod);
        komut.Parameters.AddWithValue("b", email);
        int adet = Convert.ToInt16(komut.ExecuteScalar());
        if (adet == 0)
        {
            sonuc = false;

        }
        db.kapat();
        return sonuc;

    }

    public bool sil(string bkod, string email)
    {
        bool cevap = true;
        int kay;
        db.ac();
        SqlCommand komut = new SqlCommand("delete from TblSepet where email=@a and Barkod=@b", db.baglanti);
        komut.Parameters.AddWithValue("@a", email);
        komut.Parameters.AddWithValue("@b", bkod);
        kay = komut.ExecuteNonQuery();
        if (kay == 0)
        {
            cevap = false;
        }
        db.kapat();
        return cevap;

    }
    public int urunadet(string email)
    {
        db.ac();

        SqlCommand komut = new SqlCommand("select count(*) from TblSepet where email=@a", db.baglanti);//tablodaki kayıtları çeker
        komut.Parameters.AddWithValue("@a", email);
        int adet = Convert.ToInt16(komut.ExecuteScalar());

        db.kapat();
        return adet;


    }


}