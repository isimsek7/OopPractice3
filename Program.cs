using ClassObj;
string isim = "Mihail";
string soyIsim = "Bulgakov";
string kitapIsmi = "Usta ile Margarita";
int sayfa = 608;
string yayinEviAdi = "Ithaki Yayinlari";
//New anahtar kelimesi, siniftan instans almamizi saglar.
Kitap kitap1 = new Kitap(isim, soyIsim, kitapIsmi, sayfa, yayinEviAdi);

Kitap kitap2 = new Kitap();
kitap2._ad = "Oscar";
kitap2._soyAd = "Wilde";
kitap2._kitapAdi = "Dorian Gray'in Portresi";
kitap2._sayfaSayisi = 272;
kitap2._yayinEviAdi = "Can Yayinevi";
kitap2.Ozet();