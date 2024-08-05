//assistant v1.5+
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Assistant
{
    static void Main(string[] args)
    {
        //функции
        Console.WriteLine("1 - calculator");
        Console.WriteLine("2 - shop calculator");
        Console.WriteLine("3 - credit calculator");
        Console.WriteLine("4 - tax calculator");
        Console.WriteLine("5 - random number");



        //выбор функции
        int function = Convert.ToInt32(Console.ReadLine());
        switch (function)
        {
            /*калькулятор*/
            case 1:
                Console.WriteLine("1 Number - Enter - Sign - Enter - 2 Number - Enter");

                //переменные
                double a_1 = Convert.ToDouble(Console.ReadLine());
                char sign_1 = Convert.ToChar(Console.ReadLine());
                double b_1 = Convert.ToDouble(Console.ReadLine());

                //выбор нужного метода
                switch (sign_1)
                {
                    //умножение
                    case '*':
                        Multimate(a_1, b_1);
                        break;
                    //деление
                    case '/':
                        Divide(a_1, b_1);
                        break;
                    //сложение
                    case '+':
                        Plus(a_1, b_1);
                        break;
                    //вычитание
                    case '-':
                        Minus(a_1, b_1);
                        break;
                }
                break;

            /*магазинный калькулятор*/
            case 2:
                Console.WriteLine("Amount - Enter - Price - Enter - TaxPercent - Enter");

                //переменные
                double amount = Convert.ToDouble(Console.ReadLine());
                double price = Convert.ToDouble(Console.ReadLine());
                double taxP_1 = Convert.ToDouble(Console.ReadLine());

                Shop(amount, price, taxP_1);
                break;

            /*кредитный калькулятор*/
            case 3:
                Console.WriteLine("Sum - Enter - Percent - Enter - Month - Enter");

                double sum = Convert.ToDouble(Console.ReadLine());
                double percent = Convert.ToDouble(Console.ReadLine());
                double month = Convert.ToDouble(Console.ReadLine());
                Credit(sum, percent, month);
                break;

            /*налоговый калькулятор*/
            case 4:
                Console.WriteLine("Money - Enter - TaxPercent - Enter");

                double money = Convert.ToDouble(Console.ReadLine());
                double taxP_2 = Convert.ToDouble(Console.ReadLine());
                Tax(money, taxP_2);
                break;

            /*рандомное число*/
            case 5:
               Console.WriteLine("Minimum - Enter - Maximum - Enter");

               int m_1 = Convert.ToInt32(Console.ReadLine());
               int m_2 = Convert.ToInt32(Console.ReadLine());
               Random(m_1, m_2);
               break;

        }
        Console.ReadKey();

    }

    /*калькулятор(методы)*/
    public static void Multimate(double a_1, double b_1)
    {
        //умножение
        Console.WriteLine(a_1 * b_1);
    }

    public static void Divide(double a_1, double b_1)
    {
        //деление
        Console.WriteLine(a_1 / b_1);
    }

    public static void Plus(double a_1, double b_1)
    {
        //сложение
        Console.WriteLine(a_1 + b_1);
    }

    public static void Minus(double a_1, double b_1)
    {
        //вычитание
        Console.WriteLine(a_1 - b_1);
    }

    /*магазинный калькулятор(метод)*/
    public static void Shop(double amount, double price, double taxP_1)
    {
        Console.WriteLine("Sum without tax: " + amount * price);
        Console.WriteLine("Sum with tax: " + ((amount * price) + (amount * price * taxP_1 / 100)));
        Console.WriteLine("Tax: " + (amount * price * taxP_1 / 100));
    }

    /*кредитный калькулятор(метод)*/
    public static void Credit(double sum, double percent, double month)
    {
        Console.WriteLine("You must pay for month: " + ((sum + (sum * percent / 100)) / month));
        Console.WriteLine("You overpay: " + sum * percent / 100);
        Console.WriteLine("All you pay: " + (sum + (sum * percent / 100)));
    }

    /*налоговый калькулятор(метод)*/
    public static void Tax(double money, double taxP_2)
    {
        Console.WriteLine("Tax: " + (money * taxP_2 / 100));
    }

    /*рандомное число(метод)*/
    public static void Random(int m_1,int m_2)
    {
        Random r = new Random();
        int x = r.Next(m_1, m_2);
        Console.WriteLine(x);
    }
}
