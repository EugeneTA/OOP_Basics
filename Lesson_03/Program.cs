using System;
using System.IO;
using System.Text;

namespace Lesson_03
{
    class Program
    {
        static void Main(string[] args)
        {

            // Задание 1.
            // В класс банковский счет, созданный в упражнениях добавить метод, который
            // переводит деньги с одного счета на другой.У метода два параметра: ссылка на
            // объект класса банковский счет откуда снимаются деньги, второй параметр –
            // сумма.


            Account creditAccount = new Account(AccountType.Current, 300);
            Account debitAccount = new Account(AccountType.Current, 500);

            Console.WriteLine(" Начальный баланс:");
            creditAccount.PrintBalanceToConsole();
            debitAccount.PrintBalanceToConsole();
            Console.WriteLine();

            try
            {
                Console.WriteLine($" Переводим 300 со счета {debitAccount.Number} на счет {creditAccount.Number}");
                creditAccount.TransferMoney(debitAccount, 300);
            }
            catch (Exception e)
            {
                Console.WriteLine($" Ошибка перевода денег со счета {debitAccount.Number} на счет {creditAccount.Number}. {e.Message}");
            }

            creditAccount.PrintBalanceToConsole();
            debitAccount.PrintBalanceToConsole();
            Console.WriteLine();

            try
            {
                Console.WriteLine($" Переводим 200 со счета {debitAccount.Number} на счет {creditAccount.Number}");
                creditAccount.TransferMoney(debitAccount, 200);
            }
            catch (Exception e)
            {
                Console.WriteLine($" Ошибка перевода денег со счета {debitAccount.Number} на счет {creditAccount.Number}. {e.Message}");
            }

            creditAccount.PrintBalanceToConsole();
            debitAccount.PrintBalanceToConsole();
            Console.WriteLine();

            try
            {
                Console.WriteLine($" Переводим 500 со счета {debitAccount.Number} на счет {creditAccount.Number}");
                creditAccount.TransferMoney(debitAccount, 500);
            }
            catch (Exception e)
            {
                Console.WriteLine($" Ошибка перевода денег со счета {debitAccount.Number} на счет {creditAccount.Number}. {e.Message}");
            }

            creditAccount.PrintBalanceToConsole();
            debitAccount.PrintBalanceToConsole();
            Console.WriteLine();


            // Задание 2.
            // Реализовать метод, который в качестве входного параметра принимает строку
            // string, возвращает строку типа string, буквы в которой идут в обратном порядке.
            // Протестировать метод.


            string someString = "0123456789";
            string reverseString = "9876543210";

            Console.WriteLine($" Исходная строка: {someString}");
            Console.WriteLine($" Перевернутая строка: {Helper.ReverseString(someString)}");
            Console.WriteLine($" Результат: {Helper.ReverseString(someString) == reverseString}");



            //Задание 3.
            // (*) Работа со строками.Дан текстовый файл, содержащий ФИО и e-mail адрес.
            // Разделителем между ФИО и адресом электронной почты является символ &:
            // Кучма Андрей Витальевич & Kuchma@mail.ru Мизинцев Павел Николаевич &
            // Pasha@mail.ru Сформировать новый файл, содержащий список адресов
            // электронной почты. Предусмотреть метод, выделяющий из строки адрес почты.
            // Методу в качестве параметра передается символьная строка s, e-mail
            // возвращается в той же строке s: public void SearchMail(ref string s).


            string fileName = "PersonalData.txt";  // имя файла с данными 
            string outputFileName = "emails.txt";  // имя файла для сохранения e-mail адресов

            try
            {
                // Открываем файловый поток на перезапись, если файл существует
                using (StreamWriter writer = new StreamWriter(outputFileName, false))
                {
                    // открываем файловый поток на чтение
                    using (StreamReader reader = new StreamReader(fileName))
                    {
                        string fileReadLine = reader.ReadLine();  // читаем первую строку из файла

                        // Проверяем, что не достигли конца файла
                        while (fileReadLine != null)
                        {
                            // Выделяем e-mail из считанной строки
                            Helper.SearchMail(ref fileReadLine, '&');

                            // Если получили не пустую строку, то записываем полученный e-mail в файл.
                            if (string.IsNullOrEmpty(fileReadLine) == false)
                            {
                                writer.WriteLine(fileReadLine);
                            }

                            // читаем слудующую строку
                            fileReadLine = reader.ReadLine();
                        } 

                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($" Ошибка чтения или записи в файл. {e.Message}");
            }



            Console.Write($"{Environment.NewLine} Нажмите любую клавишу для завершения работы ...");
            Console.ReadKey();
        }
    }
}
