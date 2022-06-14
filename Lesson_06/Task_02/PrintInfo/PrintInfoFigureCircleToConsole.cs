using System;
using Lesson_06_Task_02.Interfaces;


namespace Lesson_06_Task_02.PrintInfo
{
    /// <summary>
    /// Print information about figure circle to the console
    /// </summary>
    public class PrintInfoFigureCircleToConsole : IPrintInfo
    {
        public void PrintInfo(Figure figure)
        {
            if (figure != null && figure is FigureCircle)
            {
                FigureCircle figureCircle = (FigureCircle)figure;

                ConsoleColor defaultColour = Console.ForegroundColor;
                Console.ForegroundColor = figureCircle.Color;

                Console.WriteLine($" Фигура 'Круг':");
                Console.WriteLine($"  1. Координаты центра окружности: X:{figureCircle.Position.CoordinateX}, Y:{figureCircle.Position.CoordinateY}");
                Console.WriteLine($"  2. Радиус: {figureCircle.Radius}");
                Console.WriteLine($"  3. Площадь: {figureCircle.Square():F2}");
                Console.WriteLine($"  4. Цвет фигуры: {figureCircle.Color}");
                if (figureCircle.IsVisible) Console.WriteLine($"  5. Круг виден");
                else Console.WriteLine($"  5. Круг не виден");

                Console.ForegroundColor = defaultColour;
            }
        }
    }
}
