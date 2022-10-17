
new Homework().Task_1();

class Homework
{
    public void Task_1()
    {
        int a = 9; //целочисленный
        Console.WriteLine(a);

        double b = 4.2; // значение с точкой 
        Console.WriteLine(b);

        char c = 'v'; //символьный
        Console.WriteLine(c);

        bool c1 = false; //логический
        bool c2 = true;
        Console.WriteLine(c1);
        Console.WriteLine(c2);

        string text = "Миру мир!"; // ссылочный
        Console.WriteLine(text);
    }

    public void Task_2()
    {
        int a = 18;
        int b = 18;
        bool c = a == b;
        Console.WriteLine(c);
        var d = a.Equals(b);
        Console.WriteLine(d);

        object a1 = 19;
        object b1 = 19;
        var c1 = a1 == b1;
        Console.WriteLine(c1);
        var c2 = a1.Equals(b1);
        Console.WriteLine(c2);

    }

    public void Task_3()
    {
        Console.Write("Введите ваше имя и нажмите клавишу Enter: ");
        string name = Console.ReadLine();
        Console.Write("Введите вашу фамилию и нажмите клавишу Enter: ");
        string surname = Console.ReadLine();
        Console.Write("Введите ваш возраст и нажмите клавишу Enter: ");
        string age = Console.ReadLine();
        Console.WriteLine($" \"How old are you\", - policemen asked. \n \"{age}\", - {name} {surname} answered");
    }

    public void Task_4()
    {
        string a = "Never";
        string b = "say";
        string c = "never";
        string d = "!";
        string abcd = string.Join(" ", a, b, c, d);
        Console.WriteLine(abcd);

        string a2 = "Never";
        string b2 = "say";
        string c2 = "never";
        string d2 = "!";
        Console.WriteLine(string.Concat(a2, b2, c2, d2));
    }

    public void Task_5()
    {
        string a = "mothkhfjkdshfdskjfhsdkjfhsker";
        string b = a.Substring(2, a.Length - 2);
        string c = a.Substring(0, 2);
        string cb = string.Join("", b, c);
        Console.WriteLine(cb);

    }

    public void Task_6()
    {
        string poem = "Love is the worst feeling in the world!";
        string newadj = "best";
        string newpoem = poem.Replace("worst", newadj);
        Console.WriteLine(newpoem);
    }

    public void Task_7()
    {
        string string1 = Console.ReadLine();
        string upperString = string1.ToUpper();
        Console.Write(upperString);

    }

}