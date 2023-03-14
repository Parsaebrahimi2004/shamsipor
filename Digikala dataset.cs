using System.Drawing;
using System.Net;
using System.Net.Http.Headers;
using System.Text.RegularExpressions;
using System;
// Parsa Ebrahimi Shamsipoor

        string Folder = @"D:\digikala dataset\";
        Directory.CreateDirectory(Folder);
 void downloading()
{
    string Dfile = "http://alihafezi.com/fa/wp-content/uploads/2023/03/orders.csv";
    string Flocation = @"D:\digikala dataset\orders.csv";

    using (WebClient client = new WebClient())
    {
        try
        {
            client.DownloadFile(Dfile, Flocation);
            Console.WriteLine("File downloaded");
        }
        catch (Exception error)
        {
            Console.WriteLine("Something went wrong : " + error.Message);
        }
    }
}



    string address1 = @"D:\digikala dataset\orders.csv";

    string address2 = @"D:\digikala dataset\Tehran.csv";
    
    string address3 = @"D:\digikala dataset\Esfahan.csv";
    
    string address4 = @"D:\digikala dataset\Karaj.csv";
    
    string address5 = @"D:\digikala dataset\Mashhad.csv";
    
    string address6 = @"D:\digikala dataset\Qom.csv";
    
    string address7 = @"D:\digikala dataset\MahmodAbad.csv";
    
    string address8 = @"D:\digikala dataset\Khordam Dare.csv";
    
    string address9 = @"D:\digikala dataset\Qarchak.csv";
    
    string address10 = @"D:\digikala dataset\Rasht.csv";
    
    string address11 = @"D:\digikala dataset\KhoramShahr.csv";
    
    string address12 = @"D:\digikala dataset\Lali.csv";
    
    string address13 = @"D:\digikala dataset\ToneKabon.csv";
    
    string address14 = @"D:\digikala dataset\Ahvaz.csv";
    
    string address15 = @"D:\digikala dataset\ShahinShahr.csv";
    
    string address16 = @"D:\digikala dataset\Zanjan.csv";
    
    string address17 = @"D:\digikala dataset\Saari.csv";
    
    string address18 = @"D:\digikala dataset\Kelor.csv";
    
    string address19 = @"D:\digikala dataset\Hachirud.csv";
    
    string address20 = @"D:\digikala dataset\Mobarake.csv";
    
    string address21 = @"D:\digikala dataset\Abadan.csv";
    
    string address22 = @"D:\digikala dataset\Kish.csv";
    
    string address23 = @"D:\digikala dataset\BandarAnzali.csv";
    
    string address24 = @"D:\digikala dataset\Borojerd.csv";
    
    string address25 = @"D:\digikala dataset\GhaemShahr.csv";
    
    string address26 = @"D:\digikala dataset\AstaneAshrafie.csv";
    
    string address27 = @"D:\digikala dataset\Shiraz.csv";
    
    string address28 = @"D:\digikala dataset\Amol.csv";
    
    string address29 = @"D:\digikala dataset\Kermanshah.csv";
    
    string address30 = @"D:\digikala dataset\Boshehr.csv";
    
    string address31 = @"D:\digikala dataset\Qazvin.csv";
    
    string address32 = @"D:\digikala dataset\BandarAbas.csv";
    
    string address33 = @"D:\digikala dataset\Neyshabor.csv";
    
    string address34 = @"D:\digikala dataset\Tabriz.csv";
    
    string address35  = @"D:\digikala dataset\Arak.csv";
    
    string address36 = @"D:\digikala dataset\Ilam.csv";
    
    string address37 = @"D:\digikala dataset\Lahijan.csv";
    
    string address38 = @"D:\digikala dataset\Aliabad.csv";
    
    string address39 = @"D:\digikala dataset\Yazd.csv";
    
    string address40 = @"D:\digikala dataset\Zabol.csv";
    
    string address41 = @"D:\digikala dataset\Shahrkord.csv";
    
    string address42 = @"D:\digikala dataset\Roider.csv";
    
    string address43 = @"D:\digikala dataset\KabodarAhang.csv";
    
    string address44 = @"D:\digikala dataset\Takestan.csv";
    
    string address45 = @"D:\digikala dataset\Hashtgerd.csv";
    
    string address46 = @"D:\digikala dataset\Gorgan.csv";
    
    string address47 = @"D:\digikala dataset\Khomam.csv";
    
    string address48 = @"D:\digikala dataset\Gonbadkavos.csv";
    
    string address49 = @"D:\digikala dataset\Hamedan.csv";
    
    string address50 = @"D:\digikala dataset\zarand.csv";
    
    string address51 = @"D:\digikala dataset\Noshahr.csv";
    
    string address52 = @"D:\digikala dataset\2014.csv";
    
    string address53 = @"D:\digikala dataset\2015.csv";
    
    string address54 = @"D:\digikala dataset\2016.csv";
    
    string address55 = @"D:\digikala dataset\2017.csv";
    
    string address56 = @"D:\digikala dataset\2018.csv";
    



    StreamReader digikala = new StreamReader(address1);

    StreamWriter digikalatehran = new StreamWriter(address2);

    StreamWriter digikalaesfahan = new StreamWriter(address3);

    StreamWriter digikalakaraj = new StreamWriter(address4);

    StreamWriter digikalamashhad = new StreamWriter(address5);

    StreamWriter digikalaqom = new StreamWriter(address6);

    StreamWriter digikalamahmodabad = new StreamWriter(address7);

    StreamWriter digikalakhoramdare = new StreamWriter(address8);

    StreamWriter digikalaqarchak = new StreamWriter(address9);

    StreamWriter digikalarasht = new StreamWriter(address10);

    StreamWriter digikalakhoramshahr = new StreamWriter(address11);

    StreamWriter digikalalali = new StreamWriter(address12);

    StreamWriter digikalatonekabon = new StreamWriter(address13);

    StreamWriter digikalaahvaz = new StreamWriter(address14);

    StreamWriter digikalashahinshahr = new StreamWriter(address15);

    StreamWriter digikalazanjan = new StreamWriter(address16);

    StreamWriter digikalasaari = new StreamWriter(address17);

    StreamWriter digikalakelor = new StreamWriter(address18);

    StreamWriter digikalahachirud = new StreamWriter(address19);

    StreamWriter digikalamobarake = new StreamWriter(address20);

    StreamWriter digikalaabadan = new StreamWriter(address21);

    StreamWriter digikalakish = new StreamWriter(address22);

    StreamWriter digikalabandaranzali = new StreamWriter(address23);

    StreamWriter digikalaborojerd = new StreamWriter(address24);

    StreamWriter digikalaghaemshahr = new StreamWriter(address25);

    StreamWriter digikalaastaneashrafie = new StreamWriter(address26);

    StreamWriter digikalashiraz = new StreamWriter(address27);

    StreamWriter digikalaamol = new StreamWriter(address28);

    StreamWriter digikalakermanshah = new StreamWriter(address29);

    StreamWriter digikalaboshehr = new StreamWriter(address30);

    StreamWriter digikalaqazvin = new StreamWriter(address31);

    StreamWriter digikalabandarabas = new StreamWriter(address32);

    StreamWriter digikalaneyshabor = new StreamWriter(address33);

    StreamWriter digikalatabriz = new StreamWriter(address34);

    StreamWriter digikalaarak = new StreamWriter(address35);

    StreamWriter digikalailam = new StreamWriter(address36);

    StreamWriter digikalalahijan = new StreamWriter(address37);

    StreamWriter digikalaaliabad = new StreamWriter(address38);

    StreamWriter digikalayazd = new StreamWriter(address39);

    StreamWriter digikalazabol = new StreamWriter(address40);

    StreamWriter digikalashahrkord = new StreamWriter(address41);

    StreamWriter digikalaroider = new StreamWriter(address42);

    StreamWriter digikalakabodarahang = new StreamWriter(address43);

    StreamWriter digikalatakestan = new StreamWriter(address44);

    StreamWriter digikalahashtgerd = new StreamWriter(address45);

    StreamWriter digikalagorgan = new StreamWriter(address46);

    StreamWriter digikalakhomam = new StreamWriter(address47);

    StreamWriter digikalagonbadkavos = new StreamWriter(address48);

    StreamWriter digikalahamedan = new StreamWriter(address49);

    StreamWriter digikalazarand = new StreamWriter(address50);

    StreamWriter digikalanoshahr = new StreamWriter(address51);

    StreamWriter digikala2014 = new StreamWriter(address52);

    StreamWriter digikala2015 = new StreamWriter(address53);
    
    StreamWriter digikala2016 = new StreamWriter(address54);

    StreamWriter digikala2017 = new StreamWriter(address55);

    StreamWriter digikala2018 = new StreamWriter(address56);






string Orders;

while (!digikala.EndOfStream)
{
    Orders = digikala.ReadLine();
    if (Orders.Contains("تهران"))
    {
        digikalatehran.WriteLine(Orders);
    }
    if (Orders.Contains("اصفهان"))
    {
        digikalaesfahan.WriteLine(Orders);
    }
    if (Orders.Contains("کرج"))
    {
        digikalakaraj.WriteLine(Orders);
    }
    if (Orders.Contains("مشهد"))
    {
        digikalamashhad.WriteLine(Orders);
    }
    if (Orders.Contains("قم"))
    {
        digikalaqom.WriteLine(Orders);
    }
    if (Orders.Contains("محمود آباد"))
    {
        digikalamahmodabad.WriteLine(Orders);
    }
    if (Orders.Contains("خرمدره"))
    {
        digikalakhoramdare.WriteLine(Orders);
    }
    if (Orders.Contains("قرچک"))
    {
        digikalaqarchak.WriteLine(Orders);
    }
    if (Orders.Contains("رشت"))
    {
        digikalarasht.WriteLine(Orders);
    }
    if (Orders.Contains("خرمشهر"))
    {
        digikalakhoramshahr.WriteLine(Orders);
    }
    if (Orders.Contains("لالی"))
    {
        digikalalali.WriteLine(Orders);
    }
    if (Orders.Contains("تنکابن"))
    {
        digikalatonekabon.WriteLine(Orders);
    }
    if (Orders.Contains("اهواز"))
    {
        digikalaahvaz.WriteLine(Orders);
    }
    if (Orders.Contains("شاهین شهر"))
    {
        digikalashahinshahr.WriteLine(Orders);
    }
    if (Orders.Contains("زنجان"))
    {
        digikalazanjan.WriteLine(Orders);
    }
    if (Orders.Contains("ساری"))
    {
        digikalasaari.WriteLine(Orders);
    }
    if (Orders.Contains("کلور"))
    {
        digikalakelor.WriteLine(Orders);
    }
    if (Orders.Contains("هچیرود"))
    {
        digikalahachirud.WriteLine(Orders);
    }
    if (Orders.Contains("مبارکه"))
    {
        digikalamobarake.WriteLine(Orders);
    }
    if (Orders.Contains("آبادان"))
    {
        digikalaabadan.WriteLine(Orders);
    }
    if (Orders.Contains("کیش"))
    {
        digikalakish.WriteLine(Orders);
    }
    if (Orders.Contains("بندر انزلی"))
    {
        digikalabandaranzali.WriteLine(Orders);
    }
    if (Orders.Contains("بروجرد"))
    {
        digikalaborojerd.WriteLine(Orders);
    }
    if (Orders.Contains("قائم شهر"))
    {
        digikalaghaemshahr.WriteLine(Orders);
    }
    if (Orders.Contains("آستانه اشرفیه"))
    {
        digikalaastaneashrafie.WriteLine(Orders);
    }
    if (Orders.Contains("شیراز"))
    {
        digikalashiraz.WriteLine(Orders);
    }
    if (Orders.Contains("آمل"))
    {
        digikalaamol.WriteLine(Orders);
    }
    if (Orders.Contains("کرمانشاه"))
    {
        digikalakermanshah.WriteLine(Orders);
    }
    if (Orders.Contains("بوشهر"))
    {
        digikalaboshehr.WriteLine(Orders);
    }
    if (Orders.Contains("قزوین"))
    {
        digikalaqazvin.WriteLine(Orders);
    }
    if (Orders.Contains("بندر عباس"))
    {
        digikalabandarabas.WriteLine(Orders);
    }
    if (Orders.Contains("نیشابور"))
    {
        digikalaneyshabor.WriteLine(Orders);
    }
    if (Orders.Contains("تبریز"))
    {
        digikalatabriz.WriteLine(Orders);
    }
    if (Orders.Contains("اراک"))
    {
        digikalaarak.WriteLine(Orders);
    }
    if (Orders.Contains("ایلام"))
    {
        digikalailam.WriteLine(Orders);
    }
    if (Orders.Contains("لاهیجان"))
    {
        digikalalahijan.WriteLine(Orders);
    }
    if (Orders.Contains("علی آباد"))
    {
        digikalaaliabad.WriteLine(Orders);
    }
    if (Orders.Contains("یزد"))
    {
        digikalayazd.WriteLine(Orders);
    }
    if (Orders.Contains("زابل"))
    {
        digikalazabol.WriteLine(Orders);
    }
    if (Orders.Contains("شهرکرد"))
    {
        digikalashahrkord.WriteLine(Orders);
    }
    if (Orders.Contains("رویدر"))
    {
        digikalaroider.WriteLine(Orders);
    }
    if (Orders.Contains("کبودرآهنگ"))
    {
        digikalakabodarahang.WriteLine(Orders);
    }
    if (Orders.Contains("تاکستان"))
    {
        digikalatakestan.WriteLine(Orders);
    }
    if (Orders.Contains("هشتگرد"))
    {
        digikalahashtgerd.WriteLine(Orders);
    }
    if (Orders.Contains("گرگان"))
    {
        digikalagorgan.WriteLine(Orders);
    }
    if (Orders.Contains("خمام"))
    {
        digikalakhomam.WriteLine(Orders);
    }
    if (Orders.Contains("گنبدکاووس"))
    {
        digikalagonbadkavos.WriteLine(Orders);
    }
    if (Orders.Contains("همدان"))
    {
        digikalahamedan.WriteLine(Orders);
    }
    if (Orders.Contains("زرند"))
    {
        digikalazarand.WriteLine(Orders);
    }
    if (Orders.Contains("نوشهر"))
    {
        digikalanoshahr.WriteLine(Orders);
    }
    if (Orders.Contains("2014"))
    {
        digikala2014.WriteLine(Orders);
    }
    if (Orders.Contains("2015"))
    {
        digikala2015.WriteLine(Orders);
    }
    if (Orders.Contains("2016"))
    {
        digikala2016.WriteLine(Orders);
    }
    if (Orders.Contains("2017"))
    {
        digikala2017.WriteLine(Orders);
    }
    if (Orders.Contains("2018"))
    {
        digikala2018.WriteLine(Orders);
    }
}