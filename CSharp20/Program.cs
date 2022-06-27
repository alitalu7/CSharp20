
Ogrenci ogr1 = new Ogrenci();
ogr1.Ad = "Ali";
ogr1.SoyAd = "Talu";
ogr1.Yas = -30;
ogr1.EkranaYaz();

class Ogrenci
{
    private string? ad;
    private string? soyAd;
    private int yas;

    public string Ad { get => ad; set => ad = value; }
    public string SoyAd { get => soyAd; set => soyAd = value; }
    public int Yas 
    { 
        get { return yas; } 
        set 
        { 
            if (value < 0)
            {
                yas = Math.Abs(value);
            }
            else
            {
                yas = value;
            }
        } 
    }
    public void EkranaYaz()
    {
        Console.WriteLine("Öğrenci Adı: {0}", Ad);
        Console.WriteLine("Öğrenci SoyAdı: {0}", SoyAd);
        Console.WriteLine("Öğrenci Yaşı: {0}", Yas);
    }
}
