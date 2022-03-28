using System;

namespace Lesson_02
{
    class Program
    {
        static void Main(string[] args)
        {

            // (*) Добавить в класс счет в банке два метода: снять со счета и положить на счет.
            // Метод снять со счета проверяет, возможно ли снять запрашиваемую сумму, и в случае положительного результата изменяет баланс.

            AccountTask05 account = new AccountTask05(AccountType.Current, 300);

            Console.WriteLine();
            Console.WriteLine($" Номер счета: {account.Number}");
            Console.WriteLine($" Тип счета: {account.Type}");
            Console.WriteLine($" Баланс счета: {account.Balance}");


            Decimal money = 100;
            Console.WriteLine();
            Console.WriteLine($" Положить на счет {money}.");
            account.PutMoney(money);
            Console.WriteLine($" Вы положили на счет {money}. Баланс счета: {account.Balance}");

            money = 200;
            Console.WriteLine();
            Console.WriteLine($" Снять со счета {money}.");
            account.WithdrawMoney(money);
            Console.WriteLine($" Вы сняли со счета {money}. Баланс счета: {account.Balance}");


            money = 500;
            Console.WriteLine();
            Console.WriteLine($" Снять со счета {money}.");
            try
            {
                account.WithdrawMoney(money);
                Console.WriteLine($" Вы сняли со счета {money}. Баланс счета: {account.Balance}");
            }
            catch (Exception e)
            {
                Console.WriteLine($" Ошибка снятия со счета. {e.Message}");
            }

            Console.Write($"{Environment.NewLine} Нажмите любую клавишу для завершения работы ...");
            Console.ReadKey();
        }
    }
}
