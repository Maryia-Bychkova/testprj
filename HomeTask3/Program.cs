var task = new MyHomework();
//task.RunTask2();

while (task.RunTask1())
{

}

while (task.RunTask2())
{

}

while (task.RunTask3())
{

}

public class MyHomework
{

    public bool RunTask1()
    {
        Console.WriteLine("Enter the number:");
        var numberFromConsole = Console.ReadLine();

        if (numberFromConsole.ToLower() == "exit")
        {
            return false;
        }


        CheckNumber(int.Parse(numberFromConsole));

        return true;
    }

    public bool RunTask2()
    {
        Console.WriteLine("Enter 2 numbers:");
        var firstnumberFromConsole = Console.ReadLine();
        var secondnumberFromConsole = Console.ReadLine();
        if (firstnumberFromConsole.ToLower() == "exit" || secondnumberFromConsole.ToLower() == "exit")
        {
            return false;
        }

        int Firstnumber = int.Parse(firstnumberFromConsole);
        int Secondnumber = int.Parse(secondnumberFromConsole);

        for (var i = Firstnumber; i <= Secondnumber; i++)
        {
            CheckNumber(i);
        }

        return true;

    }

    public bool RunTask3()
    {
        Console.WriteLine("Enter 2 numbers:");
        var FirstnumberFromConsole = Console.ReadLine();
        var SecondnumberFromConsole = Console.ReadLine();
        if (FirstnumberFromConsole.ToLower() == "exit" || SecondnumberFromConsole.ToLower() == "exit")
        {
            return false;
        }
        int Firstnumber = int.Parse(FirstnumberFromConsole);
        int Secondnumber = int.Parse(SecondnumberFromConsole);

        if (Firstnumber < Secondnumber)
        {
            for (var i = Firstnumber; i <= Secondnumber; i++)
            {
                CheckNumber(i);
            }

        }
        else
        {
            for (var i = Secondnumber; i <= Firstnumber; i++)
            {
                CheckNumber(i);
            }
        }

        return true;
    }


    protected void CheckNumber(int number)
    {
        bool isDividedByTwo = IsDividedByTwo(number);
        bool isDividedByFive = IsDividedByFive(number);

        if (isDividedByTwo && isDividedByFive)
        {
            Console.WriteLine("tuttu-frutti");
        }
        else if (isDividedByTwo)
        {
            Console.WriteLine("tutti");
        }
        else if (isDividedByFive)
        {
            Console.WriteLine("frutti");
        }
        else
        {
            Console.WriteLine($"Number {number} can’t be divided on 2 or 5");
        }
        
    }



    protected bool IsDividedByTwo(int number)
    {
        return number % 2 == 0;
    }

    protected bool IsDividedByFive(int number)
    {
        return number % 5 == 0;
    }
}