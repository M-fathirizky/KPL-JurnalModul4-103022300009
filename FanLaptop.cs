using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mod4
{
    class FanLaptop
    {
        public enum StateKeys { Quiet, Balanced, Performace, Quit }
        public enum StateKunci { Turbo, Balanced };

        public static void Run()
        {
            StateKeys defaults = StateKeys.Balanced;
            String Command = "terbuka";
            while (defaults != StateKeys.Performace)
            {
                switch (defaults)
                {
                    case StateKeys.Quiet:
                        Console.WriteLine("Fan Laptop Mode Quiet");
                        break;
                    case StateKeys.Balanced:
                        Console.WriteLine("Fan Laptop Mode Balanced");
                        break;
                    case StateKeys.Performace:
                        Console.WriteLine("Fan Laptop Mode Performace");
                        break;
                }

                Console.WriteLine("Masukkan perintah : ");
                Command = Console.ReadLine() ?? string.Empty;

                if (Command == "Quiet" || Command == "buka")
                {
                    if (defaults == StateKeys.Balanced)
                    {
                        defaults = StateKeys.Quiet;
                    }
                    else
                    {
                        Console.WriteLine("“Fan Quiet berubah menjadi Turbo");
                    }
                }
                else if (Command == "Balanced" || Command == "kunci")
                {
                    if (defaults == StateKeys.Quiet)
                    {
                        defaults = StateKeys.Balanced;
                    }
                    else
                    {
                        Console.WriteLine("Pintu terkunci");
                    }
                }
                else if (Command == "Performace" || Command == "Performace")
                {
                    if (defaults == StateKeys.Quiet)
                    {
                        defaults = StateKeys.Performace;
                    }
                    else
                    {
                        Console.WriteLine("Pintu terkunci");
                    }
                }
                else if (Command == "Quit" || Command == "Quit")
                {
                    defaults = StateKeys.Quit;
                }
                else
                {
                    Console.WriteLine("Perintah tidak dikenal");
                }
            }
        }
    }
}
