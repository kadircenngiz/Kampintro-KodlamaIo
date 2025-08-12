Kurs kurs1 = new Kurs();
kurs1.KursAdi = "c#";
kurs1.Egitmen = "Engin Demirog";
kurs1.izlenmeOrani = 93;

Kurs kurs2 = new Kurs();
kurs2.KursAdi = "java#";
kurs2.Egitmen = "Kemal Can";
kurs2.izlenmeOrani = 63;


Kurs kurs3 = new Kurs();
kurs3.KursAdi = "Futboll";
kurs3.Egitmen = "Leo Messi";
kurs3.izlenmeOrani = 165;

Kurs[] kurslar =new Kurs[] {kurs1,kurs2,kurs3};

foreach (var kurs in kurslar)
{
    Console.WriteLine(kurs.KursAdi+ ":" + kurs.Egitmen);
}
public class Kurs
{
    public string KursAdi { get; set; }
    public string Egitmen { get; set; }
    public int izlenmeOrani { get; set; }



}