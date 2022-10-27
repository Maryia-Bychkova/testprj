//Console.WriteLine("Hello, World!");
//Console.ReadLine();

new Homework().Task_1();
new Homework_2().Task_1();

class Homework
{
    public void Task_1()
    {
        //int a = 9; //целочисленный
        //Console.WriteLine(a);

        //double b = 4.2 ; // значение с точкой 
        //Console.WriteLine(b);

        //char c = 'v'; //символьный
        //Console.WriteLine(c);

        //bool c1 = false; //логический
        //bool c2 = true;
        //Console.WriteLine(c1);
        //Console.WriteLine(c2);

        //string text = "Миру мир!"; // ссылочный
        //Console.WriteLine(text);
    }

    public void Task_2()
    {
        //int a = 18;
        //int b = 18;
        //bool c = a == b;
        //Console.WriteLine(c);
        //var d = a.Equals(b);
        //Console.WriteLine(d);

        //object a1 = 19;
        //object b1 = 19;
        //var c1 = a1 == b1;
        //Console.WriteLine(c1);
        //var c2 = a1.Equals(b1);
        //Console.WriteLine(c2);

    }

    public void Task_3()
    {
        //Console.Write("Введите ваше имя и нажмите клавишу Enter: ");
        //string name = Console.ReadLine();
        //Console.Write("Введите вашу фамилию и нажмите клавишу Enter: ");
        //string surname = Console.ReadLine();
        //Console.Write("Введите ваш возраст и нажмите клавишу Enter: ");
        //string age = Console.ReadLine();
        //Console.WriteLine($" \"How old are you\", - policemen asked. \n \"{age}\", - {name} {surname} answered");
    }

    public void Task_4()
    {
        //string a = "Never";
        //string b = "say";
        //string c = "never";
        //string d = "!";
        //string[] values = new string[] { a, b, c, d };
        //string abcd = string.Join(" ", values);
        //Console.WriteLine(abcd);

        //string a2 = "Never";
        //string b2 = "say";
        //string c2 = "never";
        //string d2 = "!";
        //string abcd = a2+ " " + b2 + " "+ c2 +" "+d2;
        //string a2d2 = string.Concat(abcd); 
        //Console.WriteLine(a2d2);
    }

    public void Task_5()
    {
        string a = "mother";
        string b = a.Substring(3, 6);
        string c = a.Substring(1,3 );
        string cb = string.Join(" ", b, c);
        string[] values = new string[] { b, c };
        Console.WriteLine(cb);

    }

    public void Task_6()
    {
        //string poem = "Love is the worst feeling in the world!";
        //string newadj = "best";
        //string newpoem = poem.Replace("worst", newadj);
        //Console.WriteLine(newpoem);
    }

    public void Task_7()
    {
        //string string1 = Console.ReadLine();
        //string upperString = string1.ToUpper();
        //Console.Write(upperString);

    }

}


class Homework_2
{
    public void Task_1()
    {
        Console.WriteLine("Enter the number:");
        var numberToString = Console.ReadLine();
        var numberToInt = Convert.ToInt32(numberToString);
        Console.WriteLine(numberToInt);

        Console.WriteLine("Enter the number:");
        var numberToDouble = Console.ReadLine();
        var number1ToInt = Convert.ToDouble(numberToDouble);
        Console.WriteLine(number1ToInt);

        Console.WriteLine("Enter the number:");
        var numberToByte = Console.ReadLine();
        var number2ToInt = Convert.ToDecimal(numberToByte);
        Console.WriteLine(number2ToInt);

        Console.WriteLine("Enter the number:");
        var numberToChar = Console.ReadLine();
        var number3ToInt = Convert.ToUInt64(numberToChar);
        Console.WriteLine(number3ToInt);

    }
    public void Task_2()
    {
        Console.WriteLine("Enter the number:"); 
        var numberToString = Console.ReadLine();
        var numberToint = int.Parse(numberToString);
        Console.WriteLine(numberToint);

        Console.WriteLine("Enter the number:");
        var numberToDouble = Console.ReadLine();
        var number1Toint = double.Parse(numberToDouble);
        Console.WriteLine(number1Toint);
    }
    public void Task_3()
    {
        Console.WriteLine("Введите значение:");
        string? input = Console.ReadLine();

        bool result = int.TryParse(input, out var number);
        if (result == true)
            Console.WriteLine($"Преобразование прошло успешно. Число: {number}");
        else Console.WriteLine($"Преобразование завершилось неудачно");

    }
    public void Task_4()
    {
        int a = 3;
        int b = a * 3;
        int c = a + b;
        Console.WriteLine($"Первая перемнная равна {a}.\nВторая переменная равна {b}.\nТретья переменная равна {c}.");

    }

    public void Task_5()
    {
        var quantity = 2;
        var jeans = 50 * quantity;
        var dress = 75 * quantity;
        var blouse = 45 * quantity;
        var shorts = 30 * quantity;
        var shoes = 83 * quantity;
        var sum = jeans + dress + blouse + shorts;
        var discount = sum / 100 * 15;
        var sum2 = sum - discount;
        Console.WriteLine($"Стоимость товаров без скидки:{sum}.\nВаша скидка:{discount}.\nСтоимость товаров со скидкой:{sum2}.");
    }
    public void Task_6()
    {
        double a = 2;
        double b = 3;
        double c = a++ + b / 1;
        Console.WriteLine(c);
        //1) b / 2 = 3 / 1 = 3
        // 2) a + b / 1 = 2 + 3 = 5
        // 3) a++ = 5

        double a1 = 2;
        double b2 = 3;
        double d = --a1 - b2 * 2;
        Console.WriteLine(d);
        // 1) --a = 2-1 = 1
        // 2) b*2 = 3*2 = 6
        // 2) --a - b/2= 1-6 = 0
    }
    public void Task_7()
    {
        int a = 5;
        int b = 5;
        bool d = a == b;
        Console.WriteLine(d);

        int a = 6;
        int b = 5;
        bool d = a == b;
        Console.WriteLine(d);

        bool a = true;
        bool b = true;
        bool c = true;
        bool e = a && b == c;
        Console.WriteLine(e);

        bool a = true;
        bool b = true;
        bool c = false;
        bool e = a && b == c;
        Console.WriteLine(e);

        int a = 2;
        int b = 3;
        bool m = a != b;
        Console.WriteLine(m);

        int a = 3;
        int b = 3;
        bool m = a != b;
        Console.WriteLine(m);

        int a = 2;
        int b = 3;
        bool s = a <= b;
        Console.WriteLine(s);

        int a = 4;
        int b = 3;
        bool s = a <= b;
        Console.WriteLine(s);

        int a = 7;
        int b = 8;
        int c = 9;
        bool h = a + b > c;
        Console.WriteLine(h);

        int a = 2;
        int b = 8;
        int c = 9;
        int d = 10;
        bool h = d / a > b + c;
        Console.WriteLine(h);
    }
    public void Task_8()
        {
        int i = 123; // упаковка
        object o = i;

        o = 123;
        i = (int)o;  // распаковка
    }


        public void Task_9()
        {
        
            double a = 48.76; // явное  
            int b;
            b = (int)a;

            int x = 5; // неявное
            double y = 15.3;
            y = x;
        }



}
