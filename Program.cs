// See https://aka.ms/new-console-template for more information
public class PemrosesData
{
    public T DapatkanNilaiTerbesar<T>(T a, T b, T c)
    {
        dynamic temp1= (dynamic)a;
        dynamic temp2 = (dynamic)b;
        dynamic temp3 = (dynamic)c;


        dynamic largest = temp1;

        if(temp2 > largest)
        {
            largest = temp2;
        } 
        if( temp3 > largest)
        {
            largest = temp3;
        }
        return largest;
    }

    
} 


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

        PemrosesData pemrosesData = new PemrosesData();

        SimpleDataBase<int> db = new SimpleDataBase<int>();
        db.AddNewData(30);
        db.AddNewData(1);
        db.AddNewData(6);
        db.printAllData();


    }
}