using System;

namespace Lesson_04
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1.Реализовать класс для описания здания(уникальный номер здания, высота, этажность, количество квартир, подъездов).
            // Поля сделать закрытыми, предусмотреть методы для заполнения полей и получения значений полей для печати.
            // Добавить методы вычисления высоты этажа, количества квартир в подъезде, количества квартир на этаже и т.д.
            // Предусмотреть возможность, чтобы уникальный номер здания генерировался программно.
            // Для этого в классе предусмотреть статическое поле, которое бы хранило последний использованный номер здания,
            // и предусмотреть метод, который увеличивал бы значение этого поля.

            Building concreteBuilding = new ConcreteBuilding(50, 20, 120, 2);
            Building brickBuilding = new BrickBuilding(20, 5, 40, 4);
            Building woodenBuilding3 = new WoodenBuilding(12, 3, 6, 1);

            // Выводим информацию по созданным зданиям

            concreteBuilding.PrintBuildingInfo();
            brickBuilding.PrintBuildingInfo();
            woodenBuilding3.PrintBuildingInfo();

            // Выводим значение глобального индекса зданий
            Console.WriteLine(GlobalBuildingIndex.ToString());

            Console.WriteLine();
            Console.WriteLine(" Нажмите любую клавишу для завершения работы ...");
            Console.ReadKey();
        }
    }
}
