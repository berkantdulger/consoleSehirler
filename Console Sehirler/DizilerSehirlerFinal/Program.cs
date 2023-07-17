using System;

namespace DizilerSehirlerFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sehirler = { "Kayıt Yok", "ADANA", "ADIYAMAN", "AFYONKARAHİSAR", "AĞRI", "AMASYA", "ANKARA", "ANTALYA", "ARTVİN", "AYDIN", "BALIKESİR", "BİLECİK", "BİNGÖL", "BİTLİS", "BOLU", "BURDUR", "BURSA", "ÇANAKKALE", "ÇANKIRI", "ÇORUM", "DENİZLİ", "DİYARBAKIR", "EDİRNE", "ELAZIĞ", "ERZİNCAN", "ERZURUM", "ESKİŞEHİR", "GAZİANTEP", "GİRESUN", "GÜMÜŞHANE", "HAKKARİ", "HATAY", "ISPARTA", "MERSİN", "İSTANBUL", "İZMİR", "KARS", "KASTAMONU", "KAYSERİ", "KIRKLARELİ", "KIRŞEHİR", "KOCAELİ", "KONYA", "KÜTAHYA", "MALATYA", "MANİSA", "KAHRAMANMARAŞ", "MARDİN", "MUĞLA", "MUŞ", "NEVŞEHİR", "NİĞDE", "ORDU", "RİZE", "SAKARYA", "SAMSUN", "SİİRT", "SİNOP", "SİVAS", "TEKİRDAĞ", "TOKAT", "TRABZON", "TUNCELİ", "ŞANLIURFA", "UŞAK", "VAN", "YOZGAT", "ZONGULDAK", "AKSARAY", "BAYBURT", "KARAMAN", "KIRIKKALE", "BATMAN", "ŞIRNAK", "BARTIN", "ARDAHAN", "IĞDIR", "YALOVA", "KARABÜK", "KİLİS", "OSMANİYE", "DÜZCE" };
            Console.WriteLine("plaka kodunu giriniz");
            int i = Convert.ToInt32(Console.ReadLine());

            if (i<0 || i>82)
            {
                Console.WriteLine(sehirler[0]);
            }else {
                Console.WriteLine("sehir= " + sehirler[i]);
                
            }
            Console.ReadLine();

        }
    }
}
