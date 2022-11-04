using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP
{
    public class Homework_1
    {

        /// <summary>
        /// площадь круга
        /// </summary>
        /// <param name="radius"></param>
        /// <returns></returns>
        public double GetArea(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        /// <summary>
        /// площадь треуглльника
        /// </summary>
        /// <param name="heightT"></param>
        /// <param name="sideT"></param>
        /// <returns></returns>
        public double GetArea(double heightT, double sideT)
        {
            return ((0.5 * sideT) * heightT);
        }


        public double GetPerimetr(params double[] lengths)
        {
            return lengths.Sum();
        }

        public string FormatPriceWithDiscount(string productName, int quantity, double price, double discount)
        {
            var priceWithDiscount = GetPriceWithDiscount(price, discount, quantity);
            return $"{productName} ------ {priceWithDiscount:C}";
        }



        public double GetPriceWithDiscount(double price, double discount, int quantity=2)
        {
            return (quantity * price) * (100 - discount) / 100;
        }
        /*В предыдущем методе сделайте количество предметов необязательным параметром.
Исправьте вызов во втором region и в 3м region продемонстрируйте пример вызова метода
        как с необязательным параметром так и без него.
*/
   

    }
}
