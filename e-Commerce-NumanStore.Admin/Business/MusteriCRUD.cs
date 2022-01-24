using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace admin2
{
    public class MusteriCRUD
    {

        public MusteriCRUD()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        DbMusteri dbmusteri = new DbMusteri();//vt için db nesnesi oluşturur
        public bool kaydet(Musteri pmusteri)
        {   //TblAdmin tablosuna kayıt ekler
            bool sonuc = false;
            //vt kayıt işlemleri

            dbmusteri.ac();//db için yol açar

            SqlCommand komut = new SqlCommand("insert into TabloMusteri values(@a,@b,@c,@d,@e,@f,@g,@h)", dbmusteri.baglanti);//baglanti ile açılan db üzerinde 
                                                                                                                              //belirtilen tabloya insert ile gelen parametre nesnesini ekliyoruz
            komut.Parameters.AddWithValue("@a", pmusteri.Adsoyad);
            komut.Parameters.AddWithValue("@b", pmusteri.Tcno);
            komut.Parameters.AddWithValue("@c", pmusteri.Meslek);
            komut.Parameters.AddWithValue("@d", pmusteri.Tel);
            komut.Parameters.AddWithValue("@e", pmusteri.Adres);
            komut.Parameters.AddWithValue("@f", pmusteri.Sehir);
            komut.Parameters.AddWithValue("@g", pmusteri.Mail);
            komut.Parameters.AddWithValue("@h", pmusteri.Ulke);
            int etkilenen = 0;
            try
            {
                etkilenen = komut.ExecuteNonQuery();//komutu çalıştırır,eğer kayıt ekleme başarılı ise 1 değilse 0 döndürür
            }
            catch (Exception)
            {

            }
            if (etkilenen > 0)
            {
                sonuc = true;
            }
            dbmusteri.kapat();//db için yolu kapatır

            return sonuc;
        }

        public DataTable tumlistemm()
        {
            dbmusteri.ac();
            DataTable listemmus = new DataTable();
            SqlCommand komut = new SqlCommand("select*from TabloMusteri", dbmusteri.baglanti);//tablodaki kayıtları çeker
            SqlDataAdapter adp = new SqlDataAdapter();// adp aracılığı ile gelen kayıtları listeleme aktarılıyor
            adp.SelectCommand = komut;
            adp.Fill(listemmus);
            dbmusteri.kapat();
            return listemmus;


        }

        public bool sil(string tcno)
        {
            bool cevap = true;
            int kay;
            dbmusteri.ac();
            SqlCommand komut = new SqlCommand("delete from TabloMusteri where tcno=@a", dbmusteri.baglanti);
            komut.Parameters.AddWithValue("@a", tcno);
            kay = komut.ExecuteNonQuery();
            if (kay == 0)
            {
                cevap = false;
            }
            dbmusteri.kapat();
            return cevap;

        }

        public bool guncelleme(string tcno, Musteri gmusteri)
        {
            bool cevap;
            dbmusteri.ac();
            SqlCommand komut = new SqlCommand("update TabloMusteri set adsoyad=@a, mail=@b,  meslek=@c, tel=@d, adres=@e ,sehir=@f,ulke=@g where tcno=@y", dbmusteri.baglanti);
            komut.Parameters.AddWithValue("@a", gmusteri.Adsoyad);
            komut.Parameters.AddWithValue("@b", gmusteri.Mail);
            komut.Parameters.AddWithValue("@c", gmusteri.Meslek);
            komut.Parameters.AddWithValue("@d", gmusteri.Tel);
            komut.Parameters.AddWithValue("@e", gmusteri.Adres);
            komut.Parameters.AddWithValue("@f", gmusteri.Sehir);
            komut.Parameters.AddWithValue("@g", gmusteri.Ulke);
            komut.Parameters.AddWithValue("@y", tcno);

            int durum = komut.ExecuteNonQuery();
            if (durum == 0)
            {
                cevap = false;
            }

            else
            {
                cevap = true;
            }
            dbmusteri.kapat();
            return cevap;



        }




        public Musteri getir(string tcno)
        {
            Musteri musterim = new Musteri();
            dbmusteri.ac();//db için yol açar

            SqlCommand komut = new SqlCommand(" select*from TabloMusteri where tcno=@a", dbmusteri.baglanti);//baglanti ile açılan db üzerinde 
            komut.Parameters.AddWithValue("@a", tcno);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                musterim.Adsoyad = dr[0].ToString();
                musterim.Tcno = dr[1].ToString();
                musterim.Meslek = dr[2].ToString();
                musterim.Tel = dr[3].ToString();
                musterim.Adres = dr[4].ToString();
                musterim.Sehir = dr[5].ToString();
                musterim.Mail = dr[6].ToString();
                musterim.Ulke = dr[7].ToString();





            }
            dbmusteri.kapat();
            return musterim;


        }



    }

}



