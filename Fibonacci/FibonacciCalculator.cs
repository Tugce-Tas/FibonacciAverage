namespace Fibonacci;

public class FibonacciCalculator
{
    public void Example()
    {
        int n, total = 0, a = 0, b = 1, count = 0;
        double sum = 0, average;
      
        Console.Write("Sayı giriniz: ");
        n = Convert.ToInt16(Console.ReadLine());

        for (int i = 1; i<n; i++)
        {   
            total = a+b;
            a = b;
            b = total;
            sum += total;
            count++;
            
        }
        
        average = (sum + 1) / (count + 1);
        Console.WriteLine(average);
    }}
    
