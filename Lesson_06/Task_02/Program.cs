using Lesson_06_Task_02.PrintInfo;
using System;

namespace Lesson_06_Task_02
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задание 2.
            // Создать класс Figure для работы с геометрическими фигурами.
            // В качестве полей класса задаются цвет фигуры, состояние «видимое/невидимое».
            // Реализовать операции: передвижение геометрической фигуры по горизонтали, по вертикали, изменение цвета, опрос состояния (видимый/невидимый).
            // Метод вывода на экран должен выводить состояние всех полей объекта.
            // Создать класс Point (точка) как потомок геометрической фигуры.
            // Создать класс FigureCircle (окружность) как потомок точки.
            // В класс FigureCircle добавить метод, который вычисляет площадь окружности.
            // Создать класс Rectangle (прямоугольник) как потомок точки, реализовать метод вычисления площади прямоугольника.
            // Точка, окружность, прямоугольник должны поддерживать методы передвижения по горизонтали и вертикали, изменения цвета.

            FigureDot dot = new FigureDot();
            FigureCircle circle = new FigureCircle(10);
            FigureRectangle rectangle = new FigureRectangle(20,10);

            IMove[] figures = new IMove[] { dot, circle, rectangle };

            PrintInfoFigureDotToConsole printInfoFigureDot = new PrintInfoFigureDotToConsole();
            PrintInfoFigureCircleToConsole printInfoFigureCircle = new PrintInfoFigureCircleToConsole();
            PrintInfoFigureRectangleToConsole printInfoFigureRectangle = new PrintInfoFigureRectangleToConsole();

            dot.PrintFigureInfo(printInfoFigureDot);
            Console.WriteLine();
            circle.PrintFigureInfo(printInfoFigureCircle);
            Console.WriteLine();
            rectangle.PrintFigureInfo(printInfoFigureRectangle);
            Console.WriteLine();

            foreach (var item in figures)
            {
                item.XMove(10);
                item.YMove(-10);
            }

            dot.Color = ConsoleColor.Yellow;
            circle.Color = ConsoleColor.Cyan;
            rectangle.Color = ConsoleColor.Magenta;

            dot.PrintFigureInfo(printInfoFigureDot);
            Console.WriteLine();
            circle.PrintFigureInfo(printInfoFigureCircle);
            Console.WriteLine();
            rectangle.PrintFigureInfo(printInfoFigureRectangle);
            Console.WriteLine();

        }
    }
}
