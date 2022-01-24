using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace admin2
{
    public class YoneticiCRUD
    {

        public YoneticiCRUD()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        Db db = new Db();//vt için db nesnesi oluşturur
        public bool kaydet(Yonetici pyonetici)
        {   //TblAdmin tablosuna kayıt ekler
            bool sonuc = true;
            //vt kayıt işlemleri

            db.ac();//db için yol açar

            SqlCommand komut = new SqlCommand("insert into TabloAdminn values(@a,@b,@c,@d,@e)", db.baglanti);//baglanti ile açılan db üzerinde 
                                                                                                             //belirtilen tabloya insert ile gelen parametre nesnesini ekliyoruz
            komut.Parameters.AddWithValue("@a", pyonetici.Adsoyad);
            komut.Parameters.AddWithValue("@b", pyonetici.Email);
            komut.Parameters.AddWithValue("@c", pyonetici.Kadi);
            komut.Parameters.AddWithValue("@d", pyonetici.Sfr);
            komut.Parameters.AddWithValue("@e", pyonetici.Resim);
            int etkilenen = komut.ExecuteNonQuery();//komutu çalıştırır,eğer kayıt ekleme başarılı ise 1 değilse 0 döndürür
            if (etkilenen == 0)
            {
                sonuc = false;
            }
            db.kapat();//db için yolu kapatır

            return sonuc;
        }

        public DataTable tumliste()
        {
            db.ac();
            DataTable listem = new DataTable();
            SqlCommand komut = new SqlCommand("select*from TabloAdminn", db.baglanti);//tablodaki kayıtları çeker
            SqlDataAdapter adp = new SqlDataAdapter();// adp aracılığı ile gelen kayıtları listeleme aktarılıyor
            adp.SelectCommand = komut;
            adp.Fill(listem);
            db.kapat();
            return listem;


        }
        public bool sil(string gemail)
        {
            bool cevap = true;
            int kay;
            db.ac();
            SqlCommand komut = new SqlCommand("delete from TabloAdminn where email=@a", db.baglanti);
            komut.Parameters.AddWithValue("@a", gemail);
            kay = komut.ExecuteNonQuery();
            if (kay == 0)
            {
                cevap = false;
            }
            db.kapat();
            return cevap;

        }

        public bool guncelleme(string email, Yonetici gyonetici)
        {
            bool cevap;
            db.ac();
            SqlCommand komut = new SqlCommand("update TabloAdminn set adsoyad=@a, kadi=@b,sfr=@c, resim=@d where email=@z", db.baglanti);
            komut.Parameters.AddWithValue("@a", gyonetici.Adsoyad);
            komut.Parameters.AddWithValue("@b", gyonetici.Kadi);
            komut.Parameters.AddWithValue("@c", gyonetici.Sfr);
            komut.Parameters.AddWithValue("@d", gyonetici.Resim);
            komut.Parameters.AddWithValue("@z", email);

            int durum = komut.ExecuteNonQuery();
            if (durum == 0)
            {
                cevap = false;
            }

            else
            {
                cevap = true;
            }
            db.kapat();
            return cevap;



        }

        public Yonetici getir(string email)
        {
            Yonetici yoneticim = new Yonetici();
            db.ac();//db için yol açar

            SqlCommand komut = new SqlCommand(" select*from TabloAdminn where email=@a", db.baglanti);//baglanti ile açılan db üzerinde 
            komut.Parameters.AddWithValue("@a", email);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                yoneticim.Adsoyad = dr[0].ToString();
                yoneticim.Email = dr[1].ToString();
                yoneticim.Kadi = dr[2].ToString();
                yoneticim.Sfr = dr[3].ToString();
                yoneticim.Resim = dr[4].ToString();
            }
            db.kapat();
            return yoneticim;



        }


        public Yonetici KullaniciGirisKontrol(string Email, string Sifre)
        {
            DataTable dt = new DataTable();
            db.ac();//db için yol açar

            SqlCommand komut = new SqlCommand(" select * from TabloAdminn where email=@email and sfr=@sfr", db.baglanti);//baglanti ile açılan db üzerinde 
            komut.Parameters.AddWithValue("@email", Email);
            komut.Parameters.AddWithValue("@sfr", Sifre);
            SqlDataAdapter adp = new SqlDataAdapter();// adp aracılığı ile gelen kayıtları listeleme aktarılıyor
            adp.SelectCommand = komut;
            adp.Fill(dt);
            db.kapat();

            if (dt.Rows.Count == 1)
            {
                Yonetici yonetici = new Yonetici()
                {
                    Adsoyad = dt.Rows[0]["adsoyad"].ToString(),
                    Email = dt.Rows[0]["email"].ToString(),
                    Kadi = dt.Rows[0]["kadi"].ToString(),
                    Sfr = dt.Rows[0]["sfr"].ToString(),
                    Resim = dt.Rows[0]["resim"].ToString()
                };
                
                return yonetici;
            }
            return null;
        }
        public bool yenikullanici(Yonetici yonetici)
        {   //TblAdmin tablosuna kayıt ekler
            bool sonuc = true;
            //vt kayıt işlemleri

            db.ac();//db için yol açar

            SqlCommand komut = new SqlCommand("insert into TabloAdminn values(@a,@b,@c,@d,@e)", db.baglanti);//baglanti ile açılan db üzerinde 
                                                                                                             //belirtilen tabloya insert ile gelen parametre nesnesini ekliyoruz
            komut.Parameters.AddWithValue("@a", yonetici.Adsoyad);
            komut.Parameters.AddWithValue("@b", yonetici.Email);
            komut.Parameters.AddWithValue("@c", yonetici.Kadi);
            komut.Parameters.AddWithValue("@d", yonetici.Sfr);
            komut.Parameters.AddWithValue("@e", string.Empty);
            int etkilenen = komut.ExecuteNonQuery();//komutu çalıştırır,eğer kayıt ekleme başarılı ise 1 değilse 0 döndürür
            if (etkilenen == 0)
            {
                sonuc = false;
            }
            db.kapat();//db için yolu kapatır

            return sonuc;
        }



    }
}