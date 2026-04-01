namespace jurnalmodul5_103082400051;

// Class generic T sesuai instruksi modul [cite: 98]
public class SimpleDataBase<T> where T : notnull
{
    // Property storedData berupa List tipe generic T [cite: 112]
    private List<T> storedData;
    // Property inputDates berupa List DateTime untuk mencatat waktu input [cite: 113]
    private List<DateTime> inputDates;

    // Konstruktor untuk inisialisasi list kosong [cite: 118]
    public SimpleDataBase()
    {
        storedData = new List<T>();
        inputDates = new List<DateTime>();
    }

    // Method untuk menambah data dan mencatat waktu saat ini [cite: 119]
    public void AddNewData(T data)
    {
        storedData.Add(data);
        inputDates.Add(DateTime.Now);
    }

    // Method untuk mencetak semua data yang tersimpan [cite: 120]
    public void PrintAllData()
    {
        for (int i = 0; i < storedData.Count; i++)
        {
            // Format output sesuai contoh: Data [n] berisi: [isi], disimpan pada waktu: [waktu] [cite: 121]
            Console.WriteLine($"Data {i + 1} berisi: {storedData[i]}, yang disimpan pada waktu UTC: {inputDates[i]}");
        }
    }
}