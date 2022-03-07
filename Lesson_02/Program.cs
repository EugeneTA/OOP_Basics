using System;

namespace Lesson_02
{
    class Program
    {
        static void Main(string[] args)
        {

            // Изменить класс счет в банке из упражнения таким образом,
            // чтобы номер счета генерировался сам и был уникальным.
            // Для этого надо создать в классе статическую переменную и метод, который увеличивает значение этого переменной.


            AccountTask02 accountTask01 = new AccountTask02();
            AccountTask02 accountTask02 = new AccountTask02();
            AccountTask02 accountTask03 = new AccountTask02();

            accountTask01.CreateAccount();
            accountTask01.SetAccountType(AccountType.Current);
            accountTask01.PutTheMoney(200);

            accountTask02.CreateAccount();
            accountTask02.SetAccountType(AccountType.Credit);
            accountTask02.PutTheMoney(60000);

            accountTask03.CreateAccount();
            accountTask03.SetAccountType(AccountType.Deposit);
            accountTask03.PutTheMoney(45000);

            Console.WriteLine();
            Console.WriteLine($" Номер счета: {accountTask01.GetAccountNumber()}");
            Console.WriteLine($" Тип счета: {accountTask01.GetAccountType()}");
            Console.WriteLine($" Баланс счета: {accountTask01.GetAccountAmount()}");

            Console.WriteLine();
            Console.WriteLine($" Номер счета: {accountTask02.GetAccountNumber()}");
            Console.WriteLine($" Тип счета: {accountTask02.GetAccountType()}");
            Console.WriteLine($" Баланс счета: {accountTask02.GetAccountAmount()}");

            Console.WriteLine();
            Console.WriteLine($" Номер счета: {accountTask03.GetAccountNumber()}");
            Console.WriteLine($" Тип счета: {accountTask03.GetAccountType()}");
            Console.WriteLine($" Баланс счета: {accountTask03.GetAccountAmount()}");

            Console.Write($"{Environment.NewLine} Нажмите любую клавишу для завершения работы ...");
            Console.ReadKey();
        }
    }
}
