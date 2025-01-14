using Inheritance2;

Ogrenci ogrenci = new Ogrenci
{
    Ad = "James",
    Soyad="Bond",
    OgrenciNo=777,

};
ogrenci.AdSoyad();
ogrenci.OgrenciNumber();


Ogretmen ogretmen = new Ogretmen
{
    Ad="Jason",
    Soyad="Bourne",
    MaasBilgisi=1000,
};
ogretmen.AdSoyad();
ogretmen.OgretmenMaas();
