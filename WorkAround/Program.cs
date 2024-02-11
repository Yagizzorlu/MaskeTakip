using Business.Concrete;
using Entities.Concrete;
namespace WorkAround
{
    public class Program
    {
        static void Main(string[] args)
        {
            Vatandas vatandas1 = new Vatandas();

            //Degiskenler();
            SelamVer("Yağız");   //Çalışınca merhaba yazdıracak.Void methodlar,sadece işi yaparlar.
            SelamVer();   //Merhaba isimsiz diyecek çünkü içi boş olursa isimsiz yazdırsın şeklinde kodladık.
            int sonuc = Topla(3,5);  //Topla methodu int döndüğü için sonuc değişkenine atayabiliyoruz.

            string ogrenci1 = "Yağız";
            string ogrenci2 = "Metehan";
            string ogrenci3 = "Ali";

            Console.WriteLine(ogrenci1);
            Console.WriteLine(ogrenci2);
            Console.WriteLine(ogrenci3);

            string[] ogrenciler = new string[3];
            ogrenciler[0] = "Yağız";
            ogrenciler[1] = "Metehan";
            ogrenciler[2] = "Ali";
            //ogrenciler[3] eklersek hata alırız biz 3 elemanlık olarak oluşturduk diziyi.

            ogrenciler = new string[4];
            ogrenciler[3] = "İlker";    //Artık sadece İlker yazdırır çünkü biz 4 elemanlı yeni bir dizi oluşturduk ve bunun adresi farklı.
                                        //Diziler referans tiptir ve hepsi farklı bir adrese bağlıdır.

            for (int i = 0; i < ogrenciler.Length; i++)
            {
                Console.WriteLine("Öğrenci İsmi:" + ogrenciler[i]);
            }

            string[] sehirler1 = new string[] { "Ankara", "İstanbul", "İzmir" };
            string[] sehirler2 = new string[] { "Balıkesir", "Antalya", "Bursa" };
            sehirler2 = sehirler1;   //sehirler2 ye sehirler1 i atadık.
            sehirler1[0] = "Adana";   //sehirler1 in ilk elemanını Ankara'dan Adana'ya çevirdik.
            Console.WriteLine(sehirler2[0]);   //sehirler2 de sehirler1 de aynı adrese bakıyor artık.O yüzden bunun ilk değeri de Adana olur.

            int sayi1 = 10;
            int sayi2 = 20;
            sayi2 = sayi1;
            sayi1 = 30;
            Console.WriteLine(sayi2);    //int,double gibi değişkenler değer tiptir. Sayi2 ye sayi1 i atadıktan sonra sayi1 ile bir ilişkimiz kalmıyor.
                                         //O yüzden sayi2, 10 a eşittir. Sayi1 in 30 olarak değiştirilmesi onu ilgilendirmez artık.

            Person person1 = new Person();
            person1.FirstName = "YAĞIZ";
            person1.LastName = "ZORLU";
            person1.DateOfBirthYear = 2002;
            person1.NationalIdentity = 123456789;

            Person person2 = new Person();
            person2.FirstName = "Sinem";


            foreach (var sehir in sehirler1)
            {
                Console.WriteLine(sehir);
            }

            List<string> yeniSehirler1 = new List<string> { "Ankara 1 ", "İstanbul 1 ", "İzmir 1 " };   //collections konusudur bu.
            yeniSehirler1.Add("Adana 1 ");
            foreach (var sehir in yeniSehirler1)
            {
                Console.WriteLine(sehir);
            }

            PttManager pttManager = new PttManager(new PersonManager());  //PttManager,Interface'a bağımlı o yüzden içi boş kalamaz.ForeignerManager ve PersonManager classları Interface ile implement edildiğinden dolayı onlardan biri new'lenmeli.
            pttManager.GiveMask(person1);

        }


        static void SelamVer(string isim = "isimsiz")
        {
            Console.WriteLine("Merhaba" + isim);
        }

        static int Topla(int sayi1,int sayi2)   //sayi1 = 5,sayi2 = 10 desek mesela o zaman mainde Topla() şeklinde yazarsak 5 ve 10 olarak alır.
                                                 //Topla(50) alırsak ilk sayıyı 50 alır ikinci sayıyı default verilen 10 alır.
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Toplam" + sonuc);
            return sonuc;
        }

        private static void Degiskenler()
        {
            string mesaj = "Merhaba";
            double tutar = 100000.5;
            int sayi = 100;
            bool girisYapmisMi = false;

            string adi = "Yağız";
            string soyadi = "Zorlu";
            int dogumYili = 2002;
            long tcNo = 1234567890;

            Console.WriteLine(mesaj);
            Console.WriteLine(mesaj);
            Console.WriteLine(tutar * 1.18);
            Console.WriteLine(mesaj);
            Console.WriteLine(mesaj);  //Tekrar tekrar içindeki mesajı değiştirmek yerine mesaj değişkeninde 1 kere tanımlıyoruz.
            Console.WriteLine(mesaj);
            Console.WriteLine(mesaj);
            Console.WriteLine(mesaj);
        }
    }

    public class Vatandas
    {
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public int DogumYili { get; set; }
        public long TcNo { get; set; }

        //public string Adi = "Yağız";
        //public string Soyadi = "Zorlu";   Bunun yerine getter setter ile prop olarak yazmak,değişkenleri yönetmemiz için.
        //public int DogumYili = 2002;
        //public long TcNo = 1234567890;
    }
}
