public abstract class Calisan
{
    public string Ad { get; set; }
    public string Soyad { get; set; }
    public string Departman { get; set; }

    public abstract void Gorev(); 
}

public class YazilimGelistirici : Calisan
{
    public override void Gorev()
    {
        Console.WriteLine("Yazılım geliştiriyorum.");
    }
}

public class ProjeYoneticisi : Calisan
{
    public override void Gorev()
    {
        Console.WriteLine("Proje yönetiyorum.");
    }
}

public class SatisTemsilcisi : Calisan
{
    public override void Gorev()
    {
        Console.WriteLine("Satış yapıyorum.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        YazilimGelistirici yazılımcı = new YazilimGelistirici();
        yazılımcı.Ad = "Ahmet";
        yazılımcı.Soyad = "Can";
        yazılımcı.Departman = "Bilgi İşlem";
        yazılımcı.Gorev();

        ProjeYoneticisi projeYoneticisi = new ProjeYoneticisi();
        projeYoneticisi.Ad = "Ayşe";
        projeYoneticisi.Soyad = "Yılmaz";
        projeYoneticisi.Departman = "Proje Yönetimi";
        projeYoneticisi.Gorev();
    }
}
