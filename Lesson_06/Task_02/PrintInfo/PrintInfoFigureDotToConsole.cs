using Lesson_06_Task_02.Interfaces;
using System;

namespace Lesson_06_Task_02.PrintInfo
{
    /// <summary>
    /// Print information about figure dot to the console
    /// </summary>
    public class PrintInfoFigureDotToConsole : IPrintInfo
    {
        public void PrintInfo(Figure figure)
        {
            if (figure != null && figure is FigureDot)
            {
                FigureDot figureDot = (FigureDot)figure;

                ConsoleColor defaultColour = Console.ForegroundColor;
                Console.ForegroundColor = figureDot.Color;

                Console.WriteLine($" Фигура 'Точка':");
                Console.WriteLine($"  1. Координаты базовой точки: X:{figureDot.Position.CoordinateX}, Y:{figureDot.Position.CoordinateY}");
                Console.WriteLine($"  2. Цвет фигуры: {figureDot.Color}");
                if (figureDot.IsVisible) Console.WriteLine($"  3. Точка видна");
                else Console.WriteLine($"  3. Точка не видна");

                Console.ForegroundColor = defaultColour;
            }
        }
    }
}
