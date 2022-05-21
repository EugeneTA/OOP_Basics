using System;
using System.Linq;

namespace Lesson_05
{
    class Program
    {
        static void Main(string[] args)
        {
            RationalNumber rationalNumber1 = new RationalNumber(1, 2);
            RationalNumber rationalNumber2 = new RationalNumber(2, 4);
            RationalNumber rationalNumber3 = new RationalNumber(7, 15);

            
            Console.WriteLine($" Операторы отношения:");
            Console.WriteLine($" {rationalNumber1} >  {rationalNumber2}: {rationalNumber1 > rationalNumber2}");
            Console.WriteLine($" {rationalNumber1} >= {rationalNumber2}: {rationalNumber1 >= rationalNumber2}");
            Console.WriteLine($" {rationalNumber3} <  {rationalNumber2}: {rationalNumber3 < rationalNumber2}");
            Console.WriteLine($" {rationalNumber1} <= {rationalNumber2}: {rationalNumber1 <= rationalNumber2}");
            Console.WriteLine($" {rationalNumber1} == {rationalNumber2}: {rationalNumber1 == rationalNumber2}");
            Console.WriteLine($" {rationalNumber1} != {rationalNumber2.Reduce()}: {rationalNumber1 != rationalNumber2}");

            float fNumber = .5f;
            long lNumber = 2;

            Console.WriteLine();
            Console.WriteLine($" Арифметические действия:");
            Console.WriteLine($" {rationalNumber1} + {rationalNumber3}: {rationalNumber1 + rationalNumber3}");
            Console.WriteLine($" {rationalNumber1} + {fNumber}: {rationalNumber1 + fNumber}");
            Console.WriteLine($" {rationalNumber1} + {lNumber}: {rationalNumber1 + lNumber}");
            Console.WriteLine($" {rationalNumber1} - {rationalNumber3}: {rationalNumber1 - rationalNumber3}");
            Console.WriteLine($" {rationalNumber1} - {fNumber}: {rationalNumber1 - fNumber}");
            Console.WriteLine($" {rationalNumber1} - {lNumber}: {rationalNumber1 - lNumber}");
            Console.WriteLine($" {rationalNumber1} * {rationalNumber3}: {rationalNumber1 * rationalNumber3}");
            Console.WriteLine($" {rationalNumber1} * {fNumber}: {rationalNumber1 * fNumber}");
            Console.WriteLine($" {rationalNumber1} * {lNumber}: {rationalNumber1 * lNumber}");
            Console.WriteLine($" {rationalNumber1} / {rationalNumber3}: {rationalNumber1 / rationalNumber3}");
            Console.WriteLine($" {rationalNumber1} / {fNumber}: {rationalNumber1 / fNumber}");
            Console.WriteLine($" {rationalNumber1} / {lNumber}: {rationalNumber1 / lNumber}");

            fNumber = 1290.1234f;
            lNumber = 34780;

            Console.WriteLine();
            Console.WriteLine($" Преобразование типов:");
            Console.WriteLine($" float {fNumber} в RationalNumber: {(RationalNumber) fNumber}");
            Console.WriteLine($" long  {lNumber} в RationalNumber: {(RationalNumber) lNumber}");
            Console.WriteLine($" RationalNumber {rationalNumber1} во float: {(float) rationalNumber1}");
            Console.WriteLine($" RationalNumber {rationalNumber1} в long: {(long) rationalNumber1}");

            Console.WriteLine();
            Console.WriteLine(" Нажмите любую клавишу для завершения работы ...");
            Console.ReadKey();
        }
    }
}
