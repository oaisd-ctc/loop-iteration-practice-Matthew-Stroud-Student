public class Program
{
    public static void Main(string[] args)
    {
        Write1ThroughN_While(5);
        Write1ThroughN_For(5);
        WriteNThrough1_While(5);
        WriteNThrough1_For(5);
        WriteEvensThrough100();
        FindSum(5);
        FindSumOfEvenNumbers(10);
        FindSumOfOddNumbers(10);
        OutputRightTriangle(5);
    }

    public static void Write1ThroughN_While(int n)
    {
        if (n < 1)
        {
            OutOfRangeMessage(n);
        }
        else
        {
            int counter = 1;
            while (counter <= n)
            {
                Console.WriteLine($"{counter}");
                counter++;
            }
        }
    }

    public static void Write1ThroughN_For(int n)
    {
        if (n < 1)
        {
            OutOfRangeMessage(n);
        }
        else
        {
            for (int counter = 1; counter <= n; counter++)
            {
                Console.WriteLine($"{counter}");
            }
        }
    }

    public static void WriteNThrough1_While(int n)
    {
        if (n < 1)
        {
            OutOfRangeMessage(n);
        }
        else
        {
            int counter = 1;
            while (counter <= n)
            {
                Console.WriteLine($"{n}");
                n--;
            }
        }
    }

    public static void WriteNThrough1_For(int n)
    {
        if (n < 1)
        {
            OutOfRangeMessage(n);
        }
        else
        {
            for (int counter = 1; counter <= n; n--)
            {
                Console.WriteLine($"{n}");
            }
        }
    }

    public static void WriteEvensThrough100()
    {
        for (int counter = 1; counter <= 100; counter++)
        {
            if (counter % 2 == 0)
            {
            Console.WriteLine($"{counter}");
            }
        }
    }

    public static void FindSum(int n)
    {
        int sum = 0;
        for (int counter = n; counter >= 0; counter--)
        {
            sum = sum + counter;
        }
        Console.WriteLine($"{sum}");
    }

    public static void FindSumOfEvenNumbers(int n)
    {
        int sum = 0;
        for (int counter = n; counter >= 0; counter--)
        {
            if (counter % 2 == 0)
            {
            sum = sum + counter;
            }
        }
        Console.WriteLine($"{sum}");
    }

    public static void FindSumOfOddNumbers(int n)
    {
        int sum = 0;
        for (int counter = n; counter >= 0; counter--)
        {
            if (counter % 2 != 0)
            {
            sum = sum + counter;
            }
        }
        Console.WriteLine($"{sum}");
    }

    public static void OutputRightTriangle(int _base)
    {
        if (_base == 0)
        {
            OutOfRangeMessage(_base);
        }
        else if (_base > 0)
        {
            for (int counter = 0; counter <= _base; counter++)
            {
                for (int iteration = 0; iteration < counter; iteration++)
                {
                    Console.Write("*");
                }
                if (counter <= _base)
                {
                Console.WriteLine();
                }
            }
        }
        else
        {
            for (int counter = _base; counter <= 0; counter++)
            {
                for (int iteration = counter; iteration < 0; iteration++)
                {
                    Console.Write("*");
                }
                if (counter < 0)
                {
                Console.WriteLine();
                }
            }
        }
    }

    public static void OutOfRangeMessage(int n)
    {
        Console.WriteLine($"{n} is out of range.");
    }
}