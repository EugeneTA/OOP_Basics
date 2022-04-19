using System;
using System.Text;
using Lesson_07.Interfaces;

namespace Lesson_07.Classes
{
    /// <summary>
    ///  Класс шифрует строку посредством сдвига каждого символа на одну «алфавитную» позицию выше.
    ///  В результате такого сдвига буква А становится буквой Б.
    /// </summary>
    public class ACoder : ICoder
    {
        public string Decode(string message)
        {
            // 1025 - Ё
            // 1105 - ё

            // 1045 - Е
            // 1077 - е

            // 1046 - Ж
            // 1078 - ж

            if (string.IsNullOrWhiteSpace(message) == false)
            {
                StringBuilder result = new StringBuilder(); // Result. Will contain the encoded string
                int symbolCode;
                int codedSymbol;

                foreach (var symbol in message)
                {
                    symbolCode = (int)symbol;
                    codedSymbol = symbolCode;

                    if ((65 <= symbolCode && symbolCode <= 90) || (97 <= symbolCode && symbolCode <= 122)) // English Symbols
                    {
                        switch (symbolCode)
                        {
                            case (90): // Z -> A
                                {
                                    codedSymbol = 65;
                                }
                                break;
                            case (122): // z -> a
                                {
                                    codedSymbol = 97;
                                }
                                break;
                            default:
                                {
                                    codedSymbol = ++symbolCode;
                                }
                                break;
                        }
                    }
                    else if (1040 <= symbolCode && symbolCode <= 1103) // Сyrillic symbols
                    {
                        switch (symbolCode)
                        {
                            case (1045): // Е -> Ё
                                {
                                    codedSymbol = 1025;
                                }
                                break;
                            case (1077): // е -> ё
                                {
                                    codedSymbol = 1105;
                                }
                                break;
                            case (1071): // Я -> А
                                {
                                    codedSymbol = 1040;
                                }
                                break;
                            case (1103): // я -> а
                                {
                                    codedSymbol = 1072;
                                }
                                break;
                            default:
                                {
                                    codedSymbol = ++symbolCode;
                                }
                                break;
                        }
                    }
                    else if (symbolCode == 1025) // Ё -> Ж
                    {
                        codedSymbol = 1046;
                    }

                    else if (symbolCode == 1105) // ё -> ж
                    {
                        codedSymbol = 1078;
                    }

                    result.Append((char)codedSymbol);
                }

                return result.ToString();
            }
            return message;
        }

        public string Encode(string message)
        {
            // 1025 - Ё
            // 1105 - ё

            // 1045 - Е
            // 1077 - е

            // 1046 - Ж
            // 1078 - ж

            if (string.IsNullOrWhiteSpace(message) == false)
            {
                StringBuilder result = new StringBuilder();  // Result. Will contain the encoded string
                int symbolCode;
                int encodedSymbol;

                foreach (var symbol in message)
                {
                    symbolCode = (int)symbol;
                    encodedSymbol = symbolCode;

                    if ((65 <= symbolCode && symbolCode <= 90) || (97 <= symbolCode && symbolCode <= 122)) // English symbols
                    {
                        switch (symbolCode)
                        {
                            case (65): // A -> Z
                                {
                                    encodedSymbol = 90;
                                }
                                break;
                            case (97): // a- > z
                                {
                                    encodedSymbol = 122;
                                }
                                break;
                            default:
                                {
                                    encodedSymbol = --symbolCode;
                                }
                                break;
                        }
                    }
                    else if (1040 <= symbolCode && symbolCode <= 1103) // // Сyrillic symbols
                    {
                        switch (symbolCode)
                        {
                            case (1046): // Ж -> Ё
                                {
                                    encodedSymbol = 1025;
                                }
                                break;
                            case (1078): // ж -> ё
                                {
                                    encodedSymbol = 1105;
                                }
                                break;
                            case (1040): // A -> Я
                                {
                                    encodedSymbol = 1071;
                                }
                                break;
                            case (1072): // а -> я
                                {
                                    encodedSymbol = 1103;
                                }
                                break;
                            default:
                                {
                                    encodedSymbol = --symbolCode;
                                }
                                break;
                        }
                    }
                    else if (symbolCode == 1025) // Ё -> Е 
                    {
                        encodedSymbol = 1045;
                    }
                    else if (symbolCode == 1105) // ё -> е
                    {
                        encodedSymbol = 1077;
                    }

                    result.Append((char)encodedSymbol);
                }
                return result.ToString();
            }
            return message;
        }

    }
}
