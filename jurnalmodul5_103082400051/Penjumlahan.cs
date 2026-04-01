namespace jurnalmodul5_103082400051;

public class Penjumlahan
{
    // Menambahkan constraint 'where T : notnull' untuk menghilangkan warning nullable
    public void JumlahTigaAngka<T>(T angka1, T angka2, T angka3) where T : notnull
    {
        // Menggunakan dynamic untuk memungkinkan operasi penjumlahan sesuai petunjuk 
        dynamic a = angka1;
        dynamic b = angka2;
        dynamic c = angka3;
        
        Console.WriteLine(a + b + c);
    }
}