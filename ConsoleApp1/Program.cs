//#define TEST
//#define EXERCISE_1
//#define EXERCISE_2
//#define EXERCISE_3
#define EXERCISE_4

using System;
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
#if TEST
            System.Console.WriteLine("Привет, мир");//способы вывода на экран
            Console.WriteLine("Hello, World!");//2ой способ вывода на экран

            string name; //переменная
            name = Console.ReadLine();//ввод переменной с консоли
            System.Console.WriteLine("Привет,"+name);//вывод на экран текст + переменная
#endif

#if EXERCISE_1
           
            Console.WriteLine("Введите число от 1 до 100:");
            String numberStr = Console.ReadLine();
            int number = Convert.ToInt32(numberStr);
            if (number < 0 || number > 100)
            {
                Console.WriteLine("\nНеобходимо ввести число от 1 до 100!\n");
            }
            else if (number % 3 == 0 && number % 5 == 0) Console.WriteLine("Результат: FizzBuzz"); // проверяем на деление на  3 и 5 без остатка
            else if (number % 3 == 0) Console.WriteLine("Результат: Fizz"); // проверяем на деление на  3  без остатка
            else if (number % 5 == 0) Console.WriteLine("Результат: Buzz");// проверяем на деление на 5 без остатка
            else Console.WriteLine("Результат: " +number);// если число не делится на  3 и 5 без остатка
#endif
#if EXERCISE_2
            Console.WriteLine("Введите число для которого необходимо вычислить процент: ");
            double number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите процент от числа: ");
            sbyte percent = Convert.ToSByte(Console.ReadLine());
            double result = number * percent / 100; // находим % от числа , сохраняем в переменной "результат"
            Console.WriteLine(percent +"% от числа "+ number + " = " + result);
#endif
#if EXERCISE_3
            Console.WriteLine("Введите 4 цифры:");
            String number_1Str = Console.ReadLine();
            int number_1 = Convert.ToInt32(number_1Str);
            String number_2Str = Console.ReadLine();
            int number_2 = Convert.ToInt32(number_2Str);
            String number_3Str = Console.ReadLine();
            int number_3 = Convert.ToInt32(number_3Str);
            String number_4Str = Console.ReadLine();
            int number_4 = Convert.ToInt32(number_4Str);
            Console.WriteLine("Ваше число: "+ number_1+ number_2+ number_3+ number_4);


#endif
#if EXERCISE_4
            Console.WriteLine("Введите 6-ти значное число: ");
            String numberString = Console.ReadLine();
            Char[] numberChar = new char[6];
            numberChar = numberString.ToCharArray();
            if (numberChar.Length != 6) Console.Write(" Провертье ввод, число должно быть 6-ти значным");
            Console.WriteLine("Введите номер первой цифры для замены: ");
            sbyte firstDigit = Convert.ToSByte(Console.ReadLine());
            Console.WriteLine("Введите номер второй цифры для замены: ");
            sbyte secondDigit = Convert.ToSByte(Console.ReadLine());
            char buffer;
          ///пока не доделала



#endif

            Console.ReadKey();//ожидает ввода клавиши
        }
    }
}
