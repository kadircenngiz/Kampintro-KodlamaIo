using Metotlar;

Urun urun1 = new Urun();
urun1.Adi = "Karpuz";
urun1.Fiyati = 100;
urun1.Aciklama = "Bal gibi karpuz";

Urun urun2 = new Urun();
urun2.Adi = "Kiraz";
urun2.Fiyati = 200;
urun2.Aciklama = "bilecik kirazi";

Urun[] urunler = new Urun[] {urun1, urun2};

foreach (Urun urun in urunler)
{
    Console.WriteLine(urun.Adi);
    Console.WriteLine(urun.Fiyati);
    Console.WriteLine(urun.Aciklama);
    Console.WriteLine("---------------");

}
SepetManager sepet = new SepetManager();
sepet.Ekle(urun1);
sepet.Ekle(urun2);


sepet.Ekle2("armut", "bal gibi armut", 12);
sepet.Ekle2("Erik", "Sert Erik", 15);
sepet.Ekle2("Şeftali", "Muq Şeftali", 16);