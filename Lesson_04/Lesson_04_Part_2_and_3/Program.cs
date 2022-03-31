using System;
using BuildingLibrary;

namespace Lesson_04
{
    class Program
    {
        static void Main(string[] args)
        {

            // 2. * Для реализованного класса создать новый класс Creator, который будет являться фабрикой объектов класса здания.
            // Для этого изменить модификатор доступа к конструкторам класса,
            // в новый созданный класс добавить перегруженные фабричные методы CreateBuild для создания объектов класса здания.
            // В классе Creator все методы сделать статическими, конструктор класса сделать закрытым.
            // Для хранения объектов класса здания в классе Creator использовать хеш-таблицу.
            // Предусмотреть возможность удаления объекта здания по его уникальному номеру из хеш-таблицы.
            // Создать тестовый пример, работающий с созданными классами.

            // 3. * Разбить созданные классы(здания, фабричный класс) и тестовый пример в разные исходные файлы.
            // Разместить классы в одном пространстве имен. Создать сборку(DLL), включающие эти классы.
            // Подключить сборку к проекту и откомпилировать тестовый пример со сборкой.
            // Получить исполняемый файл, проверить с помощью утилиты ILDASM, что тестовый пример ссылается на сборку и не содержит в себе классов здания и Creator.

            Building concreteBuilding = BuildingFactory.CreateConcreteBuilding(50, 20, 120, 2);
            Building brickBuilding = BuildingFactory.CreateBrickBuilding(20, 5, 40, 4);
            Building woodenBuilding3 = BuildingFactory.CreateWodenBuilding(12, 3, 6, 1);

            // Выводим информацию по зданиям из базы
            BuildingFactory.PrintBuildingsDatabase();

            // Удаляем один из домов из базы
            Console.WriteLine();
            Console.WriteLine($" Удаляем здание с индексом: {brickBuilding.BuildingIndex}");
            BuildingFactory.DeleteBuildingFromDatabase(brickBuilding);
            Console.WriteLine();


            // Выводим информацию по зданиям в базе еще раз
            Console.WriteLine();
            Console.WriteLine(" В базе остались следующие здания:");
            Console.WriteLine();
            BuildingFactory.PrintBuildingsDatabase();


            Console.WriteLine();
            Console.WriteLine(" Нажмите любую клавишу для завершения работы ...");
            Console.ReadKey();
        }
    }
}
