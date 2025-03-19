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

class Program
{
    public static void Main(string[] args)
    {
        PemrosesData pemrosesData = new PemrosesData();
        Console.WriteLine(pemrosesData.DapatkanNilaiTerbesar<int>(30, 1, 6));
    }
}