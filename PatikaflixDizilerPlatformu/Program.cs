using PatikaflixDizilerPlatformu;

//degisken tanımlama
string name, type, director, platform, choice;
int productionYear, publishYear;

//liste tanımlama
List<Series> dizi = new List<Series>();

while (true)
{
    Console.Write("Lütfen dizinin adını giriniz: ");
    name = Console.ReadLine().ToLower();

    //burada hata yakalayıp kullanıcı doğru girene kadar kullanıcıdan değer istiyoruz.
    while (true)
    {
        try
        {
            Console.Write("Lütfen dizinin yapım yılını giriniz: ");
            productionYear = Convert.ToInt32(Console.ReadLine());
            break;
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Maalesef doğru bir giriş yapmadınız sadece yapım yılını giriniz.");
        }
    }

    Console.Write("Lütfen dizinin türünü giriniz: ");
    type = Console.ReadLine().ToLower();

    //burada hata yakalayıp kullanıcı doğru girene kadar kullanıcıdan değer istiyoruz.
    while (true)
    {
        try
        {
            Console.Write("Lütfen dizinin yayımlanma yılını giriniz: ");
            publishYear = Convert.ToInt32(Console.ReadLine());
            break;
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Maalesef doğru bir giriş yapmadınız yayımlanma yapım yılını giriniz.");
        }
    }
    
    Console.Write("Lütfen dizinin yönetmenini giriniz: ");
    director = Console.ReadLine().ToLower();

    Console.Write("Lütfen dizinin yayımlandığı platformu giriniz: ");
    platform = Console.ReadLine().ToLower();

    //burada girilen bilgiler ile diziye eklemesini yapıyoruz.
    dizi.Add(new Series(name,productionYear,type,publishYear,director,platform));


    //burada yeni dizi ekleyip eklemek istemediğini soruyoruz.
    choice:  Console.WriteLine("Yeni bir dizi eklemek ister misiniz ? ( e / h )");
    choice = Console.ReadLine().ToLower();
    if (choice.ToLower() == "h")
    {
        Console.WriteLine("------- Girilen bütün diziler -------");
        
        var seriesAll = dizi.OrderBy(item => item.Name).ThenBy(item => item.Director).ToList();
        foreach (var item  in seriesAll)
        {
            Console.WriteLine($"Dizi adı: {item.Name}, Yapım yılı: {item.ProductionYear}, Türü: {item.Type},yayımlanma yılı:{item.PublishYear}, yönetmen: {item.Director}, yayımlanan platform: {item.Platform}");
        }


        Console.WriteLine("------- Girilen komedi dizileri -------");
        List<Comedy> comedyList = dizi.Where(item => item.Type.Contains("komedi"))
        .Select(item => new Comedy(item.Name, item.Type, item.Director))
        .OrderBy(item => item.Name)
        .ThenBy(item => item.Director)
        .ToList();

        var comedySeries = comedyList.OrderBy(item => item.Name).ThenBy(item => item.Director).ToList();
        foreach (var item in comedyList)
        {
            Console.WriteLine($"Dizi adı: {item.Name}, Türü: {item.Type}, yönetmen: {item.Director}");
        }


        Console.WriteLine("İyi günler dileriz");
        break;
    }
    else if (choice.ToLower() == "e")
    {
        continue;
    }
    else
    {
        Console.WriteLine("Yanlış değer girdiniz.");
        goto choice;
    }
}