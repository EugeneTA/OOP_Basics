using Lesson_06_Task_02.Interfaces;
using Lesson_06_Task_02.PrintInfo;
using System;

namespace Lesson_06_Task_02
{
    public class FigureCircle : FigureDot, ISquare
    {
        /// <summary>
        /// Circle radius
        /// </summary>
        public uint Radius { set; get; }

        public FigureCircle(): this (null, 0, Console.ForegroundColor, true)
        {
        }

        public FigureCircle(uint radius) : this(null, radius, Console.ForegroundColor, true)
        {

        }

        public FigureCircle(
            Coordinate basePoint,
            uint radius,
            ConsoleColor colour,
            bool figiureIsVisible
            ) :
            base (basePoint, colour, figiureIsVisible)
        {
            Radius = radius;
        }


        /// <summary>
        /// Calculates circle square
        /// </summary>
        /// <returns></returns>
        public double Square()
        {
            if (Radius == 0)
            {
                return 0;
            }

            return Math.PI * Math.Pow(Radius, 2);
        }

    }
}
