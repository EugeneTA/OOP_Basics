using System;

namespace Lesson_02
{
    class Program
    {
        static void Main(string[] args)
        {

            // В классе банковский счет, удалить методы заполнения полей.
            // Вместо этих методов создать конструкторы.
            // Переопределить конструктор по умолчанию,
            // создать конструктор для заполнения поля баланс,
            // конструктор для заполнения поля тип банковского счета,
            // конструктор для заполнения баланса и типа банковского счета.
            // Каждый конструктор должен вызывать метод, генерирующий номер счета.


            AccountTask03 accountTask01 = new AccountTask03();
            AccountTask03 accountTask02 = new AccountTask03(AccountType.Current);
            AccountTask03 accountTask03 = new AccountTask03(700);
            AccountTask03 accountTask04 = new AccountTask03(AccountType.Deposit, 1000);


            Console.WriteLine();
            Console.WriteLine($" Номер счета: {accountTask01.GetAccountNumber()}");
            Console.WriteLine($" Тип счета: {accountTask01.GetAccountType()}");
            Console.WriteLine($" Баланс счета: {accountTask01.GetBalance()}");

            Console.WriteLine();
            Console.WriteLine($" Номер счета: {accountTask02.GetAccountNumber()}");
            Console.WriteLine($" Тип счета: {accountTask02.GetAccountType()}");
            Console.WriteLine($" Баланс счета: {accountTask02.GetBalance()}");

            Console.WriteLine();
            Console.WriteLine($" Номер счета: {accountTask03.GetAccountNumber()}");
            Console.WriteLine($" Тип счета: {accountTask03.GetAccountType()}");
            Console.WriteLine($" Баланс счета: {accountTask03.GetBalance()}");

            Console.WriteLine();
            Console.WriteLine($" Номер счета: {accountTask04.GetAccountNumber()}");
            Console.WriteLine($" Тип счета: {accountTask04.GetAccountType()}");
            Console.WriteLine($" Баланс счета: {accountTask04.GetBalance()}");

            Console.Write($"{Environment.NewLine} Нажмите любую клавишу для завершения работы ...");
            Console.ReadKey();
        }
    }
}
