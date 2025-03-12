using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mod4
{
   

class KodeProduk
    {
        private Dictionary<string, string> kodeProduk = new Dictionary<string, string>()
        {
            {"laptop", "E100" },
            {"smartphone", "E101" },
            {"tablet", "E102" },
            {"Headset", "E103" },
            {"Keyboard", "E104" },
            {"Mouse", "E105" },
            {"Printer", "E106" },
            {"Monitor", "E107" },
            {"Smartwatch", "E108" },
            {"Kamera", "E109" }
        };

        public string GetKodeProduk(string namaProduk)
        {
            return kodeProduk.ContainsKey(namaProduk) ? kodeProduk[namaProduk] : "Produk tidak ditemukan";

        }

    }
}
