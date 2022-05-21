using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_03
{
    class Helper
    {
        /// <summary>
        /// Метод возвращает строку в обратном порядке
        /// </summary>
        /// <param name="data">Исходная строка</param>
        /// <returns>Строка в обратном порядке</returns>
        public static string ReverseString(string data)
        {
            if (string.IsNullOrEmpty(data))
            {
                throw new Exception($"Empty string");
            }

            StringBuilder result = new StringBuilder();

            for (int i = data.Length - 1; i >= 0; i--)
            {
                result.Append(data[i]);
            }

            return result.ToString();
        }

        /// <summary>
        /// Метод поиска e-mail адреса в строке формата "<ФИО> <Разделитель> <e-mail>"
        /// </summary>
        /// <param name="incomingData">входная строка, в которой нужно найти e-mail адрес. В результате будет содержать e-mail или null</param>
        /// <param name="splitChar">разделитель между данными</param>
        public static void SearchMail(ref string incomingData, char splitChar)
        {
            if (string.IsNullOrEmpty(incomingData) == false)
            {
                string[] userData = incomingData.Split(splitChar);

                if (userData.Length == 2)
                {
                    if (userData[1].Contains('@'))
                    {
                        incomingData = userData[1].Trim();
                    }
                    else
                    {
                        incomingData = null;
                    }
                }
                else
                {
                    incomingData = null;
                }
            }
        }
    }
}
