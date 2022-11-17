using CSharpException;
using System;
/* ex 1*/

try
{
    Triangle triangle = new Triangle();
    Console.WriteLine("Enter lenght of first side");
    triangle.FirstSide = int.Parse(Console.ReadLine());

    Console.WriteLine("Enter lenght of second side");
    triangle.SecondSide = int.Parse(Console.ReadLine());

    Console.WriteLine("Enter lenght of third side");
    triangle.ThirdSide = int.Parse(Console.ReadLine());

}


catch (InvalidSideLenght ex)
{
    Console.WriteLine(ex);
}

catch (SideCanNotBeZeroException ex)
{
    Console.WriteLine(ex);
}

catch (Exception ex)
{
    Console.WriteLine(ex);
}

/* ex 2*/

Triangle triangle = new Triangle();
Console.WriteLine("Enter lenght of first side:");

while (true)
{
    try
    {
        triangle.FirstSide = int.Parse(Console.ReadLine());
        break;
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.ToString());
        Console.WriteLine("Exception occured. Please try again.");

    }
}

Console.WriteLine("Enter lenght of second side:");

while (true)
{
    try
    {
        triangle.SecondSide = int.Parse(Console.ReadLine());
        break;
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.ToString());
        Console.WriteLine("Exception occured. Please try again.");

    }
}

Console.WriteLine("Enter lenght of third side:");

while (true)
{
    try
    {
        triangle.ThirdSide = int.Parse(Console.ReadLine());
        break;
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.ToString());
        Console.WriteLine("Exception occured. Please try again.");

    }
}







