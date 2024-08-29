using Patikfy_Muzik_Platformu;
class Program
{
    public static void Main(string[] args)
    {
        List<Patikafy> sarkici = new List<Patikafy>();
        sarkici.Add(new Patikafy("Ajda Pekkan", "Pop", 1968, 20));
        sarkici.Add(new Patikafy("Sezen Aksu", "Türk Halk Müziği/ Pop", 1971, 10));
        sarkici.Add(new Patikafy("Funda Arar", "Pop", 1999, 3));
        sarkici.Add(new Patikafy("Sertab Erener", "Pop", 1994, 5));
        sarkici.Add(new Patikafy("Sıla", "Pop", 2009, 3));
        sarkici.Add(new Patikafy("Serdar Ortaç", "Pop", 1994, 10));
        sarkici.Add(new Patikafy("Tarkan", "Pop", 1992, 40));
        sarkici.Add(new Patikafy("Hande Yener", "Pop", 1999, 7));
        sarkici.Add(new Patikafy("Hadise", "Pop", 2005, 5));
        sarkici.Add(new Patikafy("Gülben Ergen", "Pop/ Türk Halk Müziği", 1997, 10));
        sarkici.Add(new Patikafy("Neşet Ertaş", "Türk Halk Müziği/ Türk Sanat Müziği", 1960, 2));

        //Adı "S" ile başlayan şarkıcılar.
        Console.WriteLine("Adı 'S' ile başlayan şarkıcılar:");
        var S = sarkici.Where(s => s.Ad.StartsWith("S"));
        foreach (var s in S) Console.WriteLine(s.Ad);

        // Albüm satışı 10 milyonun üzerinde olan 
        Console.WriteLine("\nAlbüm satışları 10 milyon'un üzerinde olan şarkıcılar:");
        var s10 = sarkici.Where(s => s.Satis > 10);
        foreach (var s in s10) Console.WriteLine(s.Ad + "-" + s.Satis +" milyon");

        //2000 yılı öncesi çıkış yapmış ve pop müzik yapan şarkıcılar. Alfabetik sıraya göre.
        Console.WriteLine("\n2000 yılı öncesi çıkış yapmış ve pop müzik yapan şarkıcılar");
        var pop = sarkici.Where(s => s.Yil < 2000 && s.Tur == "Pop")
                         .OrderBy(s => s.Yil)
                         .ThenBy(s => s.Ad);
        foreach (var s in pop) Console.WriteLine(s.Ad + ": " + s.Yil);

        //En çok albüm satan şarkıcı
        Console.WriteLine("\nEn çok albüm satan şarkıcı:");
        var max = sarkici.OrderByDescending(s => s.Satis).First();
        Console.WriteLine(max.Ad);

        //En yeni çıkış yapan şarkıcı ve en eski çıkış yapan şarkıcı
        Console.WriteLine("\nEn yeni çıkış yapan şarkıcı ve en eski çıkış yapan şarkıcı:");
        var ilk = sarkici.OrderByDescending(sarkici => sarkici.Yil).First();
        var son = sarkici.OrderBy(sarkici => sarkici.Yil).First();
        Console.WriteLine("En yeni: " + ilk.Ad);
        Console.WriteLine("En eski: " + son.Ad);

    }
}



