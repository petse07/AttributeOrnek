// See https://aka.ms/new-console-template for more information
using AttributeOrnek;

Console.WriteLine("Hello, World!");

Ogrenci ogrenci = new Ogrenci();
ogrenci.Adi = "can";
ogrenci.Bolum = "EE";
if(!ZorunlulukKontrolu.Dogrula(ogrenci))
{
    Console.WriteLine("Öğrenci bilgileri doğrulamadan geçemedi");
}
else
{
    Console.WriteLine("Başarılı Form");
}
