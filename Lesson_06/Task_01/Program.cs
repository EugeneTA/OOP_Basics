using System;
using System.IO;
using System.Text;

namespace Lesson_06_Task_01
{
    class Program
    {
        static void Main(string[] args)
        {

            // Задание 1.
            // Для класса банковский счет переопределить операторы == и != для сравнения информации в двух счетах.
            // Переопределить метод Equals аналогично оператору ==, не забыть переопределить метод GetHashCode().
            // Переопределить методToString() для печати информации о счете.
            // Протестировать функционирование переопределенных методов и операторов на простом примере.


            Account creditAccount = new Account(AccountType.Current, 300);
            Account depositAccount = new Account(AccountType.Deposit, 500);
            Account nullAccount = null;
            Account copyCreditAccount = null;

            Console.WriteLine(creditAccount);
            Console.WriteLine(depositAccount);

            Console.WriteLine();
            Console.WriteLine($" Account 1 == Account 2: {creditAccount == depositAccount}");
            Console.WriteLine($" Account 1 != Account 2: {creditAccount != depositAccount}");

            Console.WriteLine();
            Console.WriteLine($" Account 1 == null: {creditAccount == null}");
            Console.WriteLine($" Account 1 != null: {creditAccount != null}");

            Console.WriteLine();
            Console.WriteLine($" nullAccount == null: {nullAccount == null}");
            Console.WriteLine($" nullAccount != null: {nullAccount != null}");

            copyCreditAccount = creditAccount;

            Console.WriteLine();
            Console.WriteLine($" creditAccount == copyCreditAccount: {creditAccount == copyCreditAccount}");
            Console.WriteLine($" creditAccount != copyCreditAccount: {creditAccount != copyCreditAccount}");

            Console.Write($"{Environment.NewLine} Нажмите любую клавишу для завершения работы ...");
            Console.ReadKey();
        }
    }
}
