using System;

class Program
{
    static void Main(string[] args)
    {

            List<int> numbers = new List<int>();
            int numberUser = -3;
            while (numberUser!= 0)
        {
            Console.Write("What is your number (0 to stop):");

            string userInput  = Console.ReadLine();
            numberUser = int.Parse(userInput);
            if (numberUser != 0)
            {
                numbers.Add(numberUser);
            }

        }
        // getting the sum
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The total is : {sum}");

         // getting the average.
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is : {average}");

        // getting the max.
        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
         }
        Console.WriteLine($"The maximum  number is:{max}");
            
    }
}