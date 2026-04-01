namespace jurnalmodul5_103082400051;

class Program
{
    static void Main(string[] args)
    {
        // --- Bagian 4: Penjumlahan ---
        Penjumlahan p = new Penjumlahan();
        // NIM kamu berakhiran 1, jadi pakai float [cite: 81]
        p.JumlahTigaAngka<float>(10.0f, 30.0f, 82.0f); 

        Console.WriteLine(); // Jeda baris agar rapi saat demo

        // --- Bagian 6: SimpleDataBase ---
        SimpleDataBase<float> db = new SimpleDataBase<float>();
        db.AddNewData(10.0f);
        db.AddNewData(30.0f);
        db.AddNewData(82.0f);
        db.PrintAllData();
    }
}