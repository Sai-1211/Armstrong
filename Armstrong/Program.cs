using Armstrong;

class Program
{
    public static void Main()
    {
        //Armstrong number check

        Console.WriteLine("-----------------");
        Console.WriteLine("Armstrong Example");
        Console.WriteLine("-----------------");

        int n,r,temp,sum=0; //n= number, r= remainder
        Console.WriteLine("Enter the n Value:");
        n = Convert.ToInt32(Console.ReadLine());
        temp = n;
        while(n > 0)
        {
            r = n % 10;
            sum = (int)(sum + Math.Pow(r,3));
            n = n / 10;
        }
        if(temp == sum)
        {
            Console.WriteLine("Number is Armstrong");
        }
        else
        {
            Console.WriteLine("Number is not Armstrong");
        }

        // Armstrong Series
        Console.WriteLine("-----------------");
        Console.WriteLine("Armstrong Series Example");
        Console.WriteLine("-----------------");

        Armstrongseries obj = new Armstrongseries();
        obj.Arm();

        //Fibanacci Series
        Console.WriteLine("----------------");
        Console.WriteLine("Fibanacci Series");
        Console.WriteLine("----------------");
        FibanacciSeries obj1 = new FibanacciSeries();
        obj1.Fibanacci();
    }
}