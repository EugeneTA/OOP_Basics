using System;
using System.Text;
using Lesson_07.Interfaces;

namespace Lesson_07.Classes
{
    /// <summary>
    /// Класс шифрует строку, выполняя замену каждой буквы, стоящей в алфавите на i-й позиции,
    /// на букву того же регистра, расположенную в алфавите на i-й позиции с конца алфавита.
    /// Например, буква В заменяется на букву Э. Написать программу, демонстрирующую функционирование классов.
    /// </summary>
    public class BCoder : ICoder
    {
        public string Decode(string message)
        {
            return Code(message);
        }

        public string Encode(string message)
        {
            return Code(message);
        }

        private string Code(string message)
        {
            // 1025 - Ё
            // 1105 - ё

            // 1045 - Е
            // 1077 - е

            // 1046 - Ж
            // 1078 - ж

            if (string.IsNullOrWhiteSpace(message) == false)
            {
                StringBuilder result = new StringBuilder();
                short symbolCode;
                int codedSymbol;

                foreach (var symbol in message)
                {
                    symbolCode = (short)symbol;
                    codedSymbol = symbolCode;

                    if (65 <= symbolCode && symbolCode <= 90) // English Uppercase letters
                    {
                        codedSymbol = (90 - symbolCode) + 65;
                    }
                    else if (97 <= symbolCode && symbolCode <= 122) // English lowercase letters
                    {
                        codedSymbol = (122 - symbolCode) + 97;
                    }
                    else if (symbolCode == 1025) // Ё -> Щ
                    {
                        codedSymbol = 1065;
                    }
                    else if (symbolCode == 1105) // ё -> щ
                    {
                        codedSymbol = 1097;
                    }
                    else if (symbolCode == 1065) // Щ -> Ё
                    {
                        codedSymbol = 1025;
                    }
                    else if (symbolCode == 1097) // щ -> ё
                    {
                        codedSymbol = 1105;
                    }
                    else if (1040 <= symbolCode && symbolCode <= 1071) // Cyrrilic  Uppercase letters
                    {
                        codedSymbol = (1071 - symbolCode) + 1040;

                        // shift by 1 due to Ё
                        if (1046 <= symbolCode && symbolCode < 1065)
                        {
                            --codedSymbol;
                        }
                    }
                    else if (1072 <= symbolCode && symbolCode <= 1103) // Cyrrilic  lowercase letters
                    {
                        codedSymbol = (1103 - symbolCode) + 1072;

                        // shift by 1 due to ё
                        if (1078 <= symbolCode && symbolCode < 1097)
                        {
                            --codedSymbol;
                        }
                    }


                    result.Append((char)codedSymbol);

                }

                return result.ToString();
            }

            return message;
        }
    }
}
