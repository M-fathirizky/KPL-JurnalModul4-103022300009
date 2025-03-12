// See https://aka.ms/new-console-template for more information

using mod4;

namespace mod4
{
    class Program
    {
        static void Main(string[] args)
        {
            KodeProduk kodeProduk = new KodeProduk();
            Console.WriteLine(kodeProduk.GetKodeProduk("laptop"));
            Console.WriteLine(kodeProduk.GetKodeProduk("smartphone"));
            Console.WriteLine(kodeProduk.GetKodeProduk("tablet"));
            Console.WriteLine(kodeProduk.GetKodeProduk("Headset"));
            Console.WriteLine(kodeProduk.GetKodeProduk("Keyboard"));
            Console.WriteLine(kodeProduk.GetKodeProduk("Mouse"));
            Console.WriteLine(kodeProduk.GetKodeProduk("Printer"));
            Console.WriteLine(kodeProduk.GetKodeProduk("Monitor"));
            Console.WriteLine(kodeProduk.GetKodeProduk("Smartwatch"));
            Console.WriteLine(kodeProduk.GetKodeProduk("Kamera"));
            Console.WriteLine(kodeProduk.GetKodeProduk("Speaker"));
            

        }
    }
}


