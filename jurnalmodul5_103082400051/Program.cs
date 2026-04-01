// See https://aka.ms/new-console-template for more information
namespace jurnalmodul5_103082400051;

class Program
{
    static void Main(string[] args)
    {
        // Bagian 4: Penjumlahan
        Penjumlahan p = new Penjumlahan();
        p.JumlahTigaAngka<float>(10.0f, 30.0f, 82.0f);

        Console.WriteLine(); // Baris baru agar rapi

        // Bagian 6: SimpleDataBase [cite: 122]
        SimpleDataBase<float> db = new SimpleDataBase<float>();
        
        // Menambahkan tiga data (menggunakan 2-digit NIM seperti sebelumnya) [cite: 122]
        db.AddNewData(10.0f);
        db.AddNewData(30.0f);
        db.AddNewData(82.0f);
        
        // Menampilkan hasil [cite: 122]
        db.PrintAllData();
    }
}