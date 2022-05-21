using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_05
{
    public class RationalNumber
    {
        private long _numerator;
        private long _denominator;

        public RationalNumber(long numerator, long denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
        }

        public long Numerator
        {
            set { _numerator = value; }
            get { return _numerator; }
        }

        public long Denominator
        {
            set
            {
                if (value > 0)
                {
                    _denominator = value;
                }
                else
                {
                    throw new Exception($"Not valid denominator. Should be grater then 0");
                }
            }
            get { return _denominator; }
        }


        // Определение операторов

        public static RationalNumber operator +(RationalNumber operand1, RationalNumber operand2)
        {
            if (operand1 == null)
            {
                if (operand2 == null)
                {
                    return null;
                }
                else
                {
                    return operand2;
                }
            }
            else
            {
                if (operand2 == null)
                {
                    return operand1;
                }
                else
                {
                    long scm = SCM(operand1.Denominator, operand2.Denominator);

                    return new RationalNumber(
                        operand1.Numerator * (scm / operand1.Denominator) + operand2.Numerator * (scm / operand2.Denominator),
                        operand1.Denominator * (scm / operand1.Denominator)
                        );
                }
            }
        }


        public static RationalNumber operator -(RationalNumber operand1, RationalNumber operand2)
        {
            if (operand1 == null)
            {
                if (operand2 == null)
                {
                    return null;
                }
                else
                {
                    return operand2;
                }
            }
            else
            {
                if (operand2 == null)
                {
                    return operand1;
                }
                else
                {
                    long scm = SCM(operand1.Denominator, operand2.Denominator);

                    return new RationalNumber(
                        operand1.Numerator * (scm / operand1.Denominator) - operand2.Numerator * (scm / operand2.Denominator),
                        operand1.Denominator * (scm / operand1.Denominator)
                        );
                }
            }
        }

        public static RationalNumber operator ++(RationalNumber rationalNumber)
        {
            if (rationalNumber != null)
            {
                rationalNumber.Numerator++;
            }
            return rationalNumber;
        }

        public static RationalNumber operator --(RationalNumber rationalNumber)
        {
            if (rationalNumber != null)
            {
                rationalNumber.Numerator--;
            }
            return rationalNumber;
        }

        public static RationalNumber operator *(RationalNumber operand1, RationalNumber operand2)
        {
            if (operand1 == null)
            {
                return operand2;
            }

            if (operand2 == null)
            {
                return operand1;
            }
            
            return new RationalNumber(operand1.Numerator*operand2.Numerator, operand1.Denominator*operand2.Denominator);
        }


        public static RationalNumber operator /(RationalNumber operand1, RationalNumber operand2)
        {
            if (operand2.Numerator < 0)
            {
                return operand1 * new RationalNumber(-operand2.Denominator, -operand2.Numerator);
            }
            else if (operand2.Numerator == 0)
            {
                return operand1 * new RationalNumber(0, operand2.Numerator);
            }
            else
            {
                return operand1 * new RationalNumber(operand2.Denominator, operand2.Numerator);
            }

        }

        
        public static bool operator < (RationalNumber operand1, RationalNumber operand2)
        {
            if (operand1 != null && operand2 != null)
            {
                long scm = SCM(operand1.Denominator, operand2.Denominator);

                if (operand1.Numerator * (scm / operand1.Denominator) < operand2.Numerator * (scm / operand2.Denominator)) return true;
           
            }

            return false;
        }
        
        public static bool operator >(RationalNumber operand1, RationalNumber operand2)
        {
            if (operand1 != null && operand2 != null)
            {
                long scm = SCM(operand1.Denominator, operand2.Denominator);

                if (operand1.Numerator * (scm / operand1.Denominator) > operand2.Numerator * (scm / operand2.Denominator)) return true;

            }

            return false;
        }
        
        public static bool operator <=(RationalNumber operand1, RationalNumber operand2)
        {
            if (operand1 != null && operand2 != null)
            {
                long scm = SCM(operand1.Denominator, operand2.Denominator);

                if (operand1.Numerator * (scm / operand1.Denominator) <= operand2.Numerator * (scm / operand2.Denominator)) return true;

            }

            return false;
        }
        
        public static bool operator >=(RationalNumber operand1, RationalNumber operand2)
        {
            if (operand1 != null && operand2 != null)
            {
                long scm = SCM(operand1.Denominator, operand2.Denominator);

                if (operand1.Numerator * (scm / operand1.Denominator) >= operand2.Numerator * (scm / operand2.Denominator)) return true;

            }

            return false;
        }
        
        public static bool operator ==(RationalNumber operand1, RationalNumber operand2)
        {
            if ((object) operand1 == null || (object) operand2 == null)
            {
                return (object)operand1 == (object)operand2;
            }

            return operand1.Equals(operand2);
        }
        
        public static bool operator !=(RationalNumber operand1, RationalNumber operand2)
        {
            return !(operand1 == operand2);

        }


        // Преобразования типов

        public static implicit operator float(RationalNumber rationalNumber)
        {
            return (float)rationalNumber.Numerator / (float)rationalNumber.Denominator;
        }

        public static implicit operator int(RationalNumber rationalNumber)
        {
            return (int)(rationalNumber.Numerator / rationalNumber.Denominator);
        }

        public static implicit operator long(RationalNumber rationalNumber)
        {
            return (long)(rationalNumber.Numerator / rationalNumber.Denominator);
        }

        public static implicit operator RationalNumber(int number)
        {
            return new RationalNumber(number, 1);
        }

        public static implicit operator RationalNumber(long number)
        {
            return new RationalNumber(number, 1);
        }

        public static implicit operator RationalNumber(float number)
        {
            long integerPart = (long)Math.Truncate(number);

            int totalDigit = number.ToString().Where(x => x != '-' && x != '.' && x != ',').Count();
            int integerPartDigits = integerPart.ToString().Where(x => x != '-' && x != '.' && x != ',').Count();
            int fractionPartDigits = totalDigit - integerPartDigits;
            long denominator = (long)Math.Pow(10, fractionPartDigits);


            return new RationalNumber((long)(number * denominator), denominator);
        }


        /// <summary>
        /// Метод вычисления наибольшего общего делителя 
        /// </summary>
        /// <param name="argA">Аргумент 1</param>
        /// <param name="argB">Аргумент 2</param>
        /// <returns></returns>
        public static long GCD(long argA, long argB)
        {
            //наибольший_общий_делитель(a, b) {
            //    если a делится на b без остатка то -верни b;
            //    если b делится на a без остатка то -верни a;

            //    если a > b - то верни наибольший_общий_делитель(a % b, b);
            //    иначе верни наибольший_общий_делитель(a, b % a);
            //}

            long a = Math.Abs(argA);
            long b = Math.Abs(argB);

            if (a % b == 0) return b;
            if (b % a == 0) return a;

            if (a > b) return GCD(a % b, b);
            else return GCD(a, b % a);

        }

        /// <summary>
        /// Метод вычисления наименьшего общего кратного для двух чисел
        /// </summary>
        /// <param name="a">Аргумент 1</param>
        /// <param name="b">Аргумент 2</param>
        /// <returns></returns>
        public static long SCM(long a, long b)
        {
            //наименьшее_общее_кратное(a, b) {
            //    верни(A * B) / наибольший_общий_делитель(a, b);
            //}

            return (Math.Abs(a) * Math.Abs(b)) / GCD(Math.Abs(a), Math.Abs(b));
        }


        /// <summary>
        /// Сокращает дробь
        /// </summary>

        public RationalNumber Reduce()
        {
            // Вычисляем наибольший общий делитель для числителя и знаменателя
            long gcd = GCD(this.Numerator, this.Denominator);

            Numerator /= gcd;
            Denominator /= gcd;

            return this;
        }

        public override string ToString()
        {
            if (Numerator == 0) return "0";
            if (Numerator == Denominator) return "1";

            return ($"{Numerator}/{Denominator}");
        }

        public override bool Equals(object obj)
        {
            if (obj != null && obj is RationalNumber number)
            {
                if (_numerator == number._numerator && _denominator == number._denominator)
                {
                    return true;
                } 

            }

            return false;

        }

        public override int GetHashCode()
        {
            // Вычисляем наибольший общий делитель для числителя и знаменателя
            long gcd = GCD(this.Numerator, this.Denominator);

            // Вычисляем HashCode с учетом вычисленного наибольшего общего делителя
            // Если просто посчтитать HashCode для дроби 1/2 и 2/4, то получим разные значения
            // а по сути дроби одинаковые, если сократить 2/4 до 1/2. Если сократим, то получим одинаковый HashCode.
            // Именно для этого сокращаем дробь перед подсчетом HashCode-а
            return HashCode.Combine(this.Numerator/ gcd, this.Denominator/ gcd);
        }
    }
}
