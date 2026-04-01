// See https://aka.ms/new-console-template for more information

namespace jurnalmodul5_103082400051;

class Program
{
    static void Main(string[] args)
    {
        Penjumlahan p = new Penjumlahan();
        
        // Karena NIM akhiran 1, gunakan tipe data float 
        // 2-digit NIM awal biasanya diambil dari depan, misal 10, 30, dan 82
        p.JumlahTigaAngka<float>(10.0f, 30.0f, 82.0f);
    }
}