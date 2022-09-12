using System.Collections;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] ogrenciler = new string[3]
            {
            "Eyüp", "Behlül", " Akılbek"
            };
            ArrayList students = new ArrayList();// bütün türleri değiştiryor.
            students.Add("Eyyübi");
            students.Add("Mevlüd");
            students.Add("cptnprice");
            foreach (string ogrenci in students)
                Console.WriteLine(ogrenci);


            List<string> StudentList = new List<string>();// verilen tipleri tutar
            StudentList.Add("Ali");
            StudentList.Add("MAhmut");

            List<string> sehirListesi = new List<string>()
            {
                "İstanbul",
                "Ankara"
            };
            sehirListesi.Add("İzmir");
            foreach (string sehir in sehirListesi)
            {
                Console.WriteLine(sehir);
            }
            Console.WriteLine(sehirListesi[1]);



            Sehir city = new Sehir()// newleyerek yeni bir şehir ekledik
            {
                Id = 1,
                Adi = "Antalya"
            };
            List<Sehir> cityList = new List<Sehir>();
            cityList.Add(city);
            cityList.Add(new Sehir() { Id = 2, Adi = "Malatya " });// buda newlemenin ikinci yolu


            for (int i = 0; i < cityList.Count; i++)
            {
                Console.WriteLine(cityList[i].Id + " - " + cityList[i].Adi);

            }
            foreach (var sehir in cityList)
            {
                Console.WriteLine(sehir.Id + " - " + sehir.Adi);
            }

            int count = cityList.Count;//2 malatya izmit
            Sehir[] yeniSehir = new Sehir[2]
            {
                new Sehir()
                {
                    Id=3,
                    Adi= "Trabzon"
                },
                new Sehir()
                {
                    Id=4,
                    Adi= "Samsun"
                }
            };

            // foreach (sehir yeniSehir in yeniSehirler)
            cityList.AddRange(yeniSehir);
               
            
        }
    }
    class Sehir
    {
        public int Id { get; set; }
        public string Adi { get; set; }
    }

    class Urun
    {
        //tod0
    }
}

