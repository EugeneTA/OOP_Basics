using System;
using Lesson_07.Classes;
using Lesson_07.Interfaces;

namespace Lesson_07
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Определить интерфейс IСoder, который полагает методы поддержки шифрования строк.
            // В интерфейсе объявляются два метода Encode() и Decode(), используемые для шифрования и дешифрования строк.
            //
            // Создать класс ACoder, реализующий интерфейс ICoder.
            // Класс шифрует строку посредством сдвига каждого символа на одну «алфавитную» позицию выше.
            // (В результате такого сдвига буква А становится буквой Б).
            //
            // Создать класс BCoder, реализующий интерфейс ICoder.
            // Класс шифрует строку, выполняя замену каждой буквы, стоящей в алфавите на i-й позиции,
            // на букву того же регистра, расположенную в алфавите на i-й позиции с конца алфавита.
            // (Например, буква В заменяется на букву Э. Написать программу, демонстрирующую функционирование классов).


            string text1 = "123АаБбВвГгДдЕеЁёЖжЗзИиЙйКкЛлМмНнОо**Пп**РрСсТтУуФфХхЦцЧчШшЩщЪъЫыЬьЭэЮюЯя321";
            string text2 = "?!AaBbCcDdEeFfGgHhIiJjKkLlMm**NnOoPpQqRrSsTtUuVvWwXxYyZz12345";

            ICoder aCoder = new ACoder();
            ICoder bCoder = new BCoder();

            PrintResult(text1, aCoder);
            PrintResult(text1, bCoder);

            PrintResult(text2, aCoder);
            PrintResult(text2, bCoder);


            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу для завершения работы ...");
            Console.ReadKey();

        }

        static void PrintResult(string message, ICoder coder)
        {
            Console.WriteLine();
            Console.WriteLine($"Кодирование методом {coder}");
            Console.WriteLine($"Исходный текст      : {message}");
            Console.WriteLine($"Кодированный текст  : {coder.Decode(message)}");
            Console.WriteLine($"Декодированный текст: {coder.Encode(coder.Decode(message))}");
            Console.WriteLine($"Равен ли результат исходному тексту после операций?: {(string.Compare(message, coder.Encode(coder.Decode(message))) == 0 ? "Да" : "Нет")}");
            Console.WriteLine();
        }
    }
}
