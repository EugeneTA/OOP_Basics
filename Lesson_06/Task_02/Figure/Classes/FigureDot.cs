using Lesson_06_Task_02.Interfaces;
using Lesson_06_Task_02.PrintInfo;
using System;


namespace Lesson_06_Task_02
{
    /// <summary>
    /// Figure Dot class
    /// </summary>
    public class FigureDot : Figure , IMove 
    {
        /// <summary>
        /// coordinates of a point on the x and y axis
        /// </summary>
        private Coordinate _position = new Coordinate();

        public Coordinate Position
        {
            set
            {
                if (value == null)
                {
                    _position.CoordinateX = 0;
                    _position.CoordinateY = 0;
                }
                else
                {
                    _position.CoordinateX = value.CoordinateX;
                    _position.CoordinateY = value.CoordinateY;
                }

            }
            get
            {
                return _position;
            }
        }

        public FigureDot(): this(new Coordinate(), Console.ForegroundColor, true)
        {
        }

        public FigureDot(Coordinate coordinate, ConsoleColor figureColor, bool figiureIsVisible)
        {
            Position = coordinate;
            Color = figureColor;
            IsVisible = figiureIsVisible;
        }

        /// <summary>
        /// offset of a point along the X axis by a defined amount
        /// </summary>
        /// <param name="offset">offset amount</param>
        /// <returns></returns>
        public Figure XMove(long offset)
        {
            Position.CoordinateX += offset;
            return this;
        }

        /// <summary>
        /// offset of a point along the Y axis by a defined amount
        /// </summary>
        /// <param name="offset">offset amount</param>
        /// <returns></returns>
        public Figure YMove(long offset)
        {
            Position.CoordinateY += offset;
            return this;
        }

        /// <summary>
        /// Execute PrintInfo method implemented by printInfo
        /// </summary>
        /// <param name="offset">instance of the class implementing the interface IPrintInfo</param>
        /// <returns></returns>
        public override void PrintFigureInfo(IPrintInfo printInfo)
        {
            if (printInfo != null)
            {
                printInfo.PrintInfo(this);
            }
        }
    }
}
