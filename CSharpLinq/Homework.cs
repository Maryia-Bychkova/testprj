using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLinq
{
    internal class Homework
    {
        /*1. Обьявить коллекцию из 10и любых чисел. Выбрать из них те, что
делятся на 3. Вывести результирующую коллекцию на консоль.
Использовать синтаксис запросов.*/

        public void Task1()
        {
            Console.WriteLine("----------  ЗАДАНИЕ 1 -------------");

            var Numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            IEnumerable<int> numberQuery =
                                    from numbers in Numbers
                                    where (numbers % 3) == 0
                                    select numbers;

            foreach (var i in numberQuery)
            {
                Console.Write(i + " ");
            }
        }


            /* 2. Объявить коллекцию из 10и любых чисел от 7 до 15. Половину из них
    объявить отрицательными. Выбрать из них те, которые отрицательные
    и меньше 10и. Использовать синтаксис расширений. */

            public void Task2()
        {
            Console.WriteLine("----------  ЗАДАНИЕ 2 -------------");


            var Numbers = new List<int> { -7, -8, -9, -10, -11, 7, 12, 13, 14, 15 };
            IEnumerable<int> numQuery = Numbers.Where(num => num < 10 && num < 0);
            foreach (int i in numQuery)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine(System.Environment.NewLine);

        }



            /*3. Объявить коллекцию из 5и наименований. Это могут быть
            имена/животные/книги. Выбрать из них те, которые имеют в себе
            четное количество символов и отсортируйте коллекцию в алфавитном
            порядке. Использовать синтаксис запросов.*/
            public void Task3()
        {
            Console.WriteLine("----------  ЗАДАНИЕ 3 -------------");


            var Books = new List<string> { "Букварь", "Красная", "Синяя", "Чётвертая", "Пятая" };

            IEnumerable<string> bookQuery =
                from book in Books
                where book.Length % 2 == 0
                orderby book
                select book;

            foreach (var i in bookQuery)
            {
                Console.WriteLine(i);
            }
        }

        /*4. Объявите коллекцию из 6и городов. Выберите из них те, которые
начинаются и заканчиваются на определенные буквы. Букву начала и
конца выберите самостоятельно. Использовать синтаксис расширений.*/

        public void Task4()
        {
            Console.WriteLine("----------  ЗАДАНИЕ 4 -------------");


            // First/Last

            //using System;

            char firstChar = 'м';
            char lastChar = 'к';

            var cities = new List<string> { "Минск", "Львов", "Вилюнюс", "Батуми", "Киев" };



            IEnumerable<string> cityQuery = cities.Where(city => city.ToLower().Last() == lastChar
                        && city.ToLower().First() == firstChar);

            cityQuery.ToList().ForEach(x => Console.WriteLine(x));
        }

        public void Task5()
        {
            Console.WriteLine("----------  ЗАДАНИЕ 5 -------------");
            Console.WriteLine("Введите СТРОКУ, которая содержит в себе СЛОВА, написанные прописными и строчными БУКВАМИ.");
            string inputString = Console.ReadLine();

            string[] words = inputString
                                .Replace(",", string.Empty)
                                .Replace(".", string.Empty)
                                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            words.Where(x => x.ToUpper() == x).ToList().ForEach(x => Console.WriteLine(x));
        }

        /* 8. Объявите коллекцию из не менее 3х любых строк. Посчитайте с
        помощью linq сумму длин всех элементов коллекции. Если сумма
        больше 5и символов, то выведите на консоль первый и последний
        элементы. Используйте любой синтаксис.*/
        public void Task8()
        {
            Console.WriteLine("----------  ЗАДАНИЕ 8------------");

            IEnumerable<string> items = new List<string> { "yellow", "white", "pink", "black" };
            int count = items.Select(x => x.Length).Sum();

            if (count > 5)
            {
                Console.WriteLine(items.First());
                Console.WriteLine(items.Last());

            }
        }

        /*6. Объявите коллекцию из 10и чисел. 4 из них должны быть
повторяющими другие существующие числа. С помощью linq удалите
все дубликаты из коллекции и введите итог на консоль в обратном
порядке. Используйте любой синтаксис.*/

        public void Task6()
        {
            Console.WriteLine("----------  ЗАДАНИЕ 6   ---------");

            List<int> ages = new List<int> { 21, 55, 33, 46, 55, 17, 28, 55, 55, 27 };

            IEnumerable<int> distinctAges = ages.Distinct().OrderByDescending(n => n); ;


            foreach (int age in distinctAges)
            {
                Console.WriteLine(age);
            }

        }


            /*7. Объявите коллекцию из 10 чисел. Позвольте пользователю ввести
    любое число из консоли. Определите входит ли введенное число в
    коллекцию с помощью linq и выведите ответ пользователю в
    зависимости от наличия введенного числа в имеющейся коллекции.
    Используйте любой синтаксис*/
            public void Task7()
        {

            Console.WriteLine("----------  ЗАДАНИЕ 7   ---------");

            var Numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            string numberAsString = Console.ReadLine();
            var number = int.Parse(numberAsString);



            //Using Method Syntax
            var IsExistsMS = Numbers.Contains(number);
            //Using Query Syntax
            var IsExistsQS = (from num in Numbers
                              select num).Contains(number);
            Console.WriteLine(IsExistsMS ? "Yes" : "No");
            Console.ReadKey();

        }

        /*
        Внимательно посмотрите на классы объектов, созданных в заданиях на
        ооп. Выберите из них любой, например, выдру из домашки по 7му
        уроку. Выберите 1 свойство у объекта, например, цвет выдры. Создайте
        коллекцию из 3х значений этих полей, например bald, brown, yellow. С
        помощью оператора select и коллекции свойств создайте коллекцию из
        3х экземпляров класса. Используйте любой синтаксис
        */
        public void Task9()
        {
            var colors = new[] { "red", "yellow", "green" };

            var animals = colors.Select(x => new Horse
            {
                Color = x
            });
        }

        /* 10.Объявите коллекцию из 3х экземпляров класса, выбранного в 9м
        задании. Создайте новую коллекцию, которая будет содержать только
        значения свойств, выбранных в задании 9. Используйте оператор select.
        Используйте любой синтаксис.*/
        public void Task10()
        {

            var horses = new List<Horse>
            {
                new Horse { Color = "red" },
                new Horse { Color = "blue" },
                new Horse { Color = "white" },
                new Horse { Color = "brown" },
            };


            var horseColors = horses.Select(x => x.Color);
        }

    }
}
