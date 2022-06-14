using System;
using Lesson_06_Task_02.Interfaces;

namespace Lesson_06_Task_02.PrintInfo
{
    /// <summary>
    /// Print information about figure rectangle to the console
    /// </summary>
    public class PrintInfoFigureRectangleToConsole : IPrintInfo
    {
        public void PrintInfo(Figure figure)
        {
            if (figure != null && figure is FigureRectangle)
            {
                FigureRectangle figureRectangle = (FigureRectangle)figure;

                ConsoleColor defaultColour = Console.ForegroundColor;
                Console.ForegroundColor = figureRectangle.Color;

                Console.WriteLine($" Фигура 'Прямоугольник':");
                Console.WriteLine($"  1. Координаты базовой точки: X:{figureRectangle.Position.CoordinateX}, Y:{figureRectangle.Position.CoordinateY}");
                Console.WriteLine($"  2. Ширина прямоуголника: {figureRectangle.XWide}");
                Console.WriteLine($"  3. Высота прямоуголника: {figureRectangle.YHeight}");
                Console.WriteLine($"  4. Площадь: {figureRectangle.Square()}");
                Console.WriteLine($"  5. Цвет фигуры: {figureRectangle.Color}");
                if (figureRectangle.IsVisible) Console.WriteLine($"  6. Прямоугольник виден");
                else Console.WriteLine($"  6. Прямоугольник не виден");

                Console.ForegroundColor = defaultColour;
            }
        }
    }
}
