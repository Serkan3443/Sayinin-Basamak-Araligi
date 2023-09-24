namespace SAYİNİN_RAKAMLARİNİN_BASAMAK_DEGERLERİNİ_BULMAK
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("3 basamaklı bir sayı giriniz:");
            int sayi = Convert.ToInt32(Console.ReadLine());

            int yuzeayir;
            yuzeayir = sayi / 100;

            Console.WriteLine("yüzler basamağındaki sayı: " + yuzeayir);


            int onayir;
            sayi = sayi - (yuzeayir * 100);
            onayir = sayi / 10;

            Console.WriteLine("onlar basamağındaki sayı: " + onayir);

            int bireayir;
            sayi = sayi - (onayir * 10);
            bireayir = sayi;

            Console.WriteLine("birler basamağındaki sayı: " + bireayir);


            Console.Read();
        }
    }
}