using Lesson_06_Task_02.Interfaces;
using System;


namespace Lesson_06_Task_02
{
    class FigureRectangle : FigureDot, ISquare
    {
        /// <summary>
        /// side length on the X axis
        /// </summary>
        public long XWide { set; get; }
        
        /// <summary>
        /// side length on the Y axis
        /// </summary>
        public long YHeight { set; get; }

        public FigureRectangle() : this(null, 0,0, Console.ForegroundColor, false)
        {

        }
        public FigureRectangle(long xWide, long yHeight) : this (null, xWide, yHeight, Console.ForegroundColor, true)
        {

        }
        public FigureRectangle(
            Coordinate basePoint,
            long xWide,
            long yHeight,
            ConsoleColor colour,
            bool figiureIsVisible) :
            base(basePoint, colour, figiureIsVisible)
        {
            XWide = xWide;
            YHeight = yHeight;
        }

        /// <summary>
        /// Calculates rectangle square
        /// </summary>
        /// <returns></returns>
        public double Square()
        {
            return Math.Abs(XWide) * Math.Abs(YHeight);
        }
    }
}
