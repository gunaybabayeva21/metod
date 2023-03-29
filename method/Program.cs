using System.Reflection.Metadata.Ecma335;
using System.Text.RegularExpressions;

internal class Program
{
    private static void Main(string[] args)
    {
        Sum(10, 100);
        value(2345);
        SumFirst(11);
        Second(1,3,4,6,7);
        Query(10, 100);
        Deyer(10, 100);
        
    }
    static int Sum(int num1, int num2)
    {

        int sum = 0;
        for (int i = num1; i <= num2; i++) 
        { 

            if (i % 3 == 0 & i % 7 == 0)
            {
                sum += i;
            }
            
        }
        Console.WriteLine("bolunen " + sum);
        return sum;


}

    static int value(int num1)
    {
        int num =0;
        if (num/100==4)
        {
          return num;
        }
        return num;

    }
  
    static bool SumFirst( int eded)
    { 
        if(eded == 2) 
        { return true;}

        for(int i = 2; i < eded; i++) 
        { 
         if (eded%i == 0)
            {
                return false;
            
            }
       
        }return true;
    }


    static int Second( params int[] reqem)
    {
        
        int sum= 0;
       for (int i = 0; i < reqem.Length; i++)
        {
           sum+= reqem[i];

        }
       return sum;
    } 
    
    static int Query ( params int[] select)
    {
       int  max = 0;

        for (int i = 0; i < select.Length; i++)
        {
            if (select[i] > max)
            {

                max = select[i];
            }
        }
        return max;

    }

      static int Deyer(int deyisen1, int deyisen2 )
    {
        int result = deyisen1 + deyisen2;
        return result;  

    }


    
    

}