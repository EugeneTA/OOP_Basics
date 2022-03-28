using System;

namespace Lesson_02
{
    class Program
    {
        static void Main(string[] args)
        {

            //В классе все методы для заполнения и получения значений полей заменить на свойства.
            //Написать тестовый пример.


            AccountTask04 account01 = new AccountTask04();
            AccountTask04 account02 = new AccountTask04(AccountType.Current);
            AccountTask04 account03 = new AccountTask04(700);
            AccountTask04 account04 = new AccountTask04(AccountType.Deposit, 1000);


            Console.WriteLine();
            Console.WriteLine($" Номер счета: {account01.Number}");
            Console.WriteLine($" Тип счета: {account01.Type}");
            Console.WriteLine($" Баланс счета: {account01.Balance}");

            Console.WriteLine();
            Console.WriteLine($" Номер счета: {account02.Number}");
            Console.WriteLine($" Тип счета: {account02.Type}");
            Console.WriteLine($" Баланс счета: {account02.Balance}");

            Console.WriteLine();
            Console.WriteLine($" Номер счета: {account03.Number}");
            Console.WriteLine($" Тип счета: {account03.Type}");
            Console.WriteLine($" Баланс счета: {account03.Balance}");

            Console.WriteLine();
            Console.WriteLine($" Номер счета: {account04.Number}");
            Console.WriteLine($" Тип счета: {account04.Type}");
            Console.WriteLine($" Баланс счета: {account04.Balance}");

            Console.Write($"{Environment.NewLine} Нажмите любую клавишу для завершения работы ...");
            Console.ReadKey();
        }
    }
}
