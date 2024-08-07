using System;
namespace ClassObj
{
	public class Kitap
	// Icerisinde alanlar, yapilandiricilar ve metodlar barindiran siniflardir.
	{
	//Sinif sablonlarinin olusumunu saglayan gerek parametreli gerek parametresiz metod ve degisken arasi ozelliktir.
		public Kitap()
		{
			DateTime tarih = DateTime.Now;
			_kayitTarihi = tarih.ToLongDateString();
		}
		public Kitap(string ad, string soyad, string kitapAdi, int sayfaSayisi, string yayinEviAdi)
		{
			_ad = ad;
			_soyAd = soyad;
			_kayitTarihi = DateTime.Now.ToLongDateString();
			_sayfaSayisi = sayfaSayisi;
			_yayinEviAdi = yayinEviAdi;
			_kitapAdi = kitapAdi;
			Console.WriteLine(ad + " " + soyad + "'dan " + kitapAdi + ". Sayfa sayisi= " + sayfaSayisi + "," + yayinEviAdi);

		}
	//Sinifin nesnelerinin sahip olabilecegi degiskenlerdir.
		public string _ad { get; set; }
		public string _soyAd { get; set; }
		public string _kitapAdi { get; set; }
		public string _kayitTarihi { get; set; }
		public int _sayfaSayisi { get; set; }
		public string _yayinEviAdi { get; set; }

		public void Ozet()
		{
            Console.WriteLine(_ad + " " + _soyAd + "'dan " + _kitapAdi + ". Sayfa sayisi=" + _sayfaSayisi + "," + _yayinEviAdi);
        }
	}
	
	
}

