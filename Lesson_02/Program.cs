using System;

namespace Lesson_02
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создать класс счет в банке с закрытыми полями: номер счета, баланс, тип банковского счета (использовать перечислимый тип).
            // Предусмотреть методы для доступа к данным – заполнения и чтения.
            // Создать объект класса, заполнить его поля и вывести информацию об объекте класса на печать


            AccountTask01 accountTask01 = new AccountTask01();

            accountTask01.CreateAccount(345);

            accountTask01.SetAccountType(AccountType.Current);

            accountTask01.PutTheMoney(200);


            Console.WriteLine();
            Console.WriteLine($" Номер счета: {accountTask01.GetAccountNumber()}");
            Console.WriteLine($" Тип счета: {accountTask01.GetAccountType()}");
            Console.WriteLine($" Баланс счета: {accountTask01.GetAccountAmount()}");

            Console.Write($"{Environment.NewLine} Нажмите любую клавишу для завершения работы ...");
            Console.ReadKey();
        }
    }
}
