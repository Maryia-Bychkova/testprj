
using CSharpOOP;

#region Task_1


Console.WriteLine("*********************** Задание 1 **********************");
Console.WriteLine("Введите количество товара:");
var quantity = int.Parse(Console.ReadLine());
Console.WriteLine("Введите цену товара:");
var price = double.Parse(Console.ReadLine());
Console.WriteLine("Введите скидку:");
var discount = double.Parse(Console.ReadLine());

var task1 = new Homework_1();
Console.WriteLine("Итоговая сумма = " + String.Format("0:C", task1.GetPriceWithDiscount(price, discount, quantity)));


#endregion

#region Task_2

Console.WriteLine("*********************** Задание 2 **********************");

Console.WriteLine("Введите количество товаров:");
int itemCounts = int.Parse(Console.ReadLine());

var productArray = new List<Product>();

for (int i = 0; i < itemCounts; ++i)
{
    var product = new Product();

    var productNumber = i + 1;

    Console.WriteLine($"Введите название товара номер {productNumber}:");
    product.Name = Console.ReadLine();
    Console.WriteLine($"Введите количество товара номер {productNumber}:");
    product.Quantity = int.Parse(Console.ReadLine());
    Console.WriteLine($"Введите цену товара номер {productNumber}:");
    product.Price = double.Parse(Console.ReadLine());

    productArray.Add(product);
}

Console.WriteLine($"Введите cкидку:");
var discount2 = double.Parse(Console.ReadLine());

Console.WriteLine("******************* CHECK *******************");


double totalPrice = 0;
foreach (var product in productArray)
{
    var price2 = task1.GetPriceWithDiscount(product.Price, discount, product.Quantity);
    totalPrice = totalPrice + price;

    Console.WriteLine(task1.FormatPriceWithDiscount(product.Name, product.Quantity, product.Price, discount));
}
Console.WriteLine("----------------------------------------------");
Console.WriteLine(String.Format("Всего    {0:C}", totalPrice));


#endregion

#region Task_3

Console.WriteLine("*********************** Задание 3 **********************");


var hn1 = new Homework_1();
hn1.GetPriceWithDiscount(12, 1);
hn1.GetPriceWithDiscount(12, 1, 55);

#endregion

#region Task_4

Console.WriteLine("*********************** Задание 4 **********************");

var task4 = new Homework_1();

Console.WriteLine("Введите навание фигуры:");
var figure = Console.ReadLine();
if (figure == "треугольник")
{
    var sideA = double.Parse(Console.ReadLine());
    var sideB = double.Parse(Console.ReadLine());
    var sideC = double.Parse(Console.ReadLine());

    Console.WriteLine(task4.GetPerimetr(sideA, sideB, sideC));

}

if (figure == "четырехугольник")
{
    var sideA = double.Parse(Console.ReadLine());
    var sideB = double.Parse(Console.ReadLine());
    var sideC = double.Parse(Console.ReadLine());
    var sideD = double.Parse(Console.ReadLine());

    Console.WriteLine(task4.GetPerimetr(sideA, sideB, sideC, sideD));

}

else if (figure == "пятиугольник")
{
    var sideA = double.Parse(Console.ReadLine());
    var sideB = double.Parse(Console.ReadLine());
    var sideC = double.Parse(Console.ReadLine());
    var sideD = double.Parse(Console.ReadLine());
    var sideE = double.Parse(Console.ReadLine());

    Console.WriteLine(task4.GetPerimetr(sideA, sideB, sideC, sideD, sideE));

}

else
{
    Console.WriteLine("error");
}

#endregion







/*19. Создать отдельным файлом в проекте статический класс-помощник,
который будет например выводить на консоль значения полей
созданного ранее класса. Ваша фантазия в этом задании не ограничена!
Методов должно быть не менее 3х, они все должны чем-то отличаться,
либо возвращаемым типом, либо количеством передаваемых значений,
либо необязательным параметром. В один из методов требуется
передать экземпляр класса, пример показан далее.
Пример для лошади:
public class HorseManipulator
{
public static void RepaintHorse(Horse horse, string newColor = “White”)
{
horse.Color = newColor;
}
}
Пояснение примера: данный метод принимает в себя экземпляр лошади
и меняет цвет именно у этого определенного экземпляра.

*/

