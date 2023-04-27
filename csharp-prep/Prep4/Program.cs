using System;

class Program
{
    static void Main(string[] args)
    {
        int stopnumber = 0;
        int number = -1;
        
        List<int> numbers = new List<int>();

        while(number != stopnumber)
        {
            Console.Write("Enter a number or Enter 0 to stop: ");
            number = int.Parse(Console.ReadLine()); 
            numbers.Add(number);
        }
        int lenght1 = numbers.Count;
        numbers.RemoveAt(lenght1-1);
        int sum = 0;
        int avarage;
        int big = -1;

        foreach (int number1 in numbers)
        {
            sum += number1;
            if(number1 > big)
            {
                big = number1;
            }

        }
         
        Console.WriteLine($"The sum is: {sum}");
        avarage = sum / numbers.Count;
        Console.WriteLine($"The Avarage is: {avarage}");
        Console.WriteLine($"The largest number is {big}");
        Console.WriteLine($"Lenght of the list is: {lenght1}");
        
        // Console.WriteLine
      
        // Console.WriteLine("Hello Prep4 World!");
    }
}