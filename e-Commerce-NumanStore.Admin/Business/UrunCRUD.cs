using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace admin2
{
    public class UrunCRUD
    {
        public UrunCRUD()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        Db db = new Db();//vt için db nesnesi oluşturur
        public bool kaydet(Urun purun)
        {   //TblAdmin tablosuna kayıt ekler
            bool sonuc = true;
            //vt kayıt işlemleri

            db.ac();//db için yol açar

            SqlCommand komut = new SqlCommand("insert into urunler values(@a,@b,@c,@d,@e,@f,@g,@h,@i,@j,@k,@l,@m)", db.baglanti);//baglanti ile açılan db üzerinde 
                                                                                                                                 //belirtilen tabloya insert ile gelen parametre nesnesini ekliyoruz
            komut.Parameters.AddWithValue("@a", purun.Kat);
            komut.Parameters.AddWithValue("@b", purun.Marka);
            komut.Parameters.AddWithValue("@c", purun.Urunad);
            komut.Parameters.AddWithValue("@d", purun.Fiyat);
            komut.Parameters.AddWithValue("@e", purun.Kdv);
            komut.Parameters.AddWithValue("@f", purun.Pbirim);
            komut.Parameters.AddWithValue("@g", purun.Stkodu);
            komut.Parameters.AddWithValue("@h", purun.Barkod);
            komut.Parameters.AddWithValue("@i", purun.Stadet);
            komut.Parameters.AddWithValue("@j", purun.Kagirlik);
            komut.Parameters.AddWithValue("@k", purun.Resim);
            komut.Parameters.AddWithValue("@l", purun.Tarih);
            komut.Parameters.AddWithValue("@m", purun.Detay);



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
            SqlCommand komut = new SqlCommand("select*from urunler", db.baglanti);//tablodaki kayıtları çeker
            SqlDataAdapter adp = new SqlDataAdapter();// adp aracılığı ile gelen kayıtları listeleme aktarılıyor
            adp.SelectCommand = komut;
            adp.Fill(listem);
            db.kapat();
            return listem;
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

        public bool Sil(string gbarkodkodu)
        {
            bool cevap = true;
            int kay;
            db.ac();
            SqlCommand komut = new SqlCommand("delete from urunler where barkodkodu=@a", db.baglanti);
            komut.Parameters.AddWithValue("@a", gbarkodkodu);
            kay = komut.ExecuteNonQuery();
            if (kay == 0)
            {
                cevap = false;
            }
            db.kapat();
            return cevap;

        }

        public bool guncelleme(string bkod, Urun gurun)
        {
            bool cevap;
            db.ac();
            SqlCommand komut = new SqlCommand("update urunler set kategoriler=@a, marka=@b,urunadi=@c, fiyat=@d,parabirimi=@e,stokkodu=@f,stokadedi=@g, kargoagirlik=@h,resim=@i,tarih=@j,detay=@k where barkodkodu=@x", db.baglanti);
            komut.Parameters.AddWithValue("@a", gurun.Kat);
            komut.Parameters.AddWithValue("@b", gurun.Marka);
            komut.Parameters.AddWithValue("@c", gurun.Urunad);
            komut.Parameters.AddWithValue("@d", gurun.Fiyat);
            komut.Parameters.AddWithValue("@e", gurun.Pbirim);
            komut.Parameters.AddWithValue("@f", gurun.Stkodu);
            komut.Parameters.AddWithValue("@g", gurun.Stadet);
            komut.Parameters.AddWithValue("@h", gurun.Kagirlik);
            komut.Parameters.AddWithValue("@i", gurun.Resim);
            komut.Parameters.AddWithValue("@j", gurun.Tarih);
            komut.Parameters.AddWithValue("@k", gurun.Detay);
            komut.Parameters.AddWithValue("@x", bkod);

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

        public Urun getir(string bkod)
        {
            Urun urunum = new Urun();
            db.ac();//db için yol açar

            SqlCommand komut = new SqlCommand(" select*from urunler where barkodkodu=@a", db.baglanti);//baglanti ile açılan db üzerinde 
            komut.Parameters.AddWithValue("@a", bkod);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                urunum.Kat = dr[0].ToString();
                urunum.Marka = dr[1].ToString();
                urunum.Urunad = dr[2].ToString();
                urunum.Fiyat = Convert.ToInt32(dr[3]);
                urunum.Kdv = dr[4].ToString();
                urunum.Pbirim = dr[5].ToString();
                urunum.Stkodu = dr[6].ToString();
                urunum.Barkod = dr[7].ToString();
                urunum.Stadet = dr[8].ToString();
                urunum.Kagirlik = dr[9].ToString();
                urunum.Resim = dr[10].ToString();
                urunum.Tarih = dr[11].ToString();
                urunum.Detay = dr[12].ToString();




            }
            db.kapat();
            return urunum;



        }









    }
}

