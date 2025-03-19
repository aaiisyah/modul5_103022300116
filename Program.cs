// See https://aka.ms/new-console-template for more information


class SimpleDataBase<T>
{
    private List<T> storedData;
    private List<DateTime> inputDates;

    public SimpleDataBase()
    {
        storedData = new List<T>();
        inputDates = new List<DateTime>();

    }

    public void AddNewData(T data)
    {
        storedData.Add(data);
        inputDates.Add(DateTime.Now);
    }

    public void printAllData()
    {
        for(int i = 0; i <storedData.Count; i++)
        {
            Console.WriteLine("Data " + (i+1) + " berisi: " + storedData[i] + ", yang disimpan pada waktu UTC: " + inputDates[i]);
        }
        
    }
    
    
}

class Program
{
    public static void Main(string[] args)
    {
        SimpleDataBase<int> db = new SimpleDataBase<int>();
        db.AddNewData(30);
        db.AddNewData(1);
        db.AddNewData(6);
        db.printAllData();


    }
}