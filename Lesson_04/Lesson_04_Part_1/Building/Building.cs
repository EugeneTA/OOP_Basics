using System;


namespace Lesson_04
{

    /// <summary>
    /// Класс здания
    /// </summary>
    public class Building: BuildingBase
    {
        public Building(int buildingHeight, int floorsNumber, int flatsNumber, int entarancesNumber, BuildingType buildingType) : base()
        {
            if (buildingHeight > 0 && floorsNumber > 0 && flatsNumber > 0 && entarancesNumber > 0)
            {
                // считаем, что количество квартир на этаже величина постоянная
                if ((double)(flatsNumber % entarancesNumber) == 0)
                {
                    if ((double)((double)(flatsNumber / entarancesNumber) % (floorsNumber)) == 0)
                    {
                        _buildingIndex = GlobalBuildingIndex.InitializeNewBuildingIndex();
                        _buildingHeight = buildingHeight;
                        _floorsNumber = floorsNumber;
                        _flatsNumber = flatsNumber;
                        _entrancesNumber = entarancesNumber;
                        _buildingType = buildingType;
                    }
                }
            }
        }

        public int BuildingIndex
        {
            private set { }
            get { return _buildingIndex; }
        }

        public int BuildingHeight
        {
            private set { }
            get { return _buildingHeight; }

        }

        public int FloorsNumbers
        {
            private set { }
            get { return _floorsNumber; }
        }

        public int FlatsNumber
        {
            private set { }
            get { return _flatsNumber; }
        }

        public int EntrancesNumber
        {
            private set { }
            get { return _entrancesNumber; }
        }


        public override int GetFlatsPerFloor()
        {
            return FloorsNumbers > 0 ? FlatsNumber / FloorsNumbers : 0;
        }

        public override int GetFlatsPerEntrance()
        {
            return EntrancesNumber > 0 ? FlatsNumber / EntrancesNumber : 0;
        }

        public override int GetFlatsPerFloorInEntrance()
        {
            return EntrancesNumber> 0 ? GetFlatsPerFloor() / EntrancesNumber : 0;
        }

        public override int GetFloorHieght()
        {
            return FloorsNumbers > 0 ? BuildingHeight / FloorsNumbers : 0;
        }

        public void PrintBuildingInfo()
        {
            Console.WriteLine(" Заданные значение: ");
            Console.WriteLine($" Индекс: {BuildingIndex}");
            Console.WriteLine($" Высота: {BuildingHeight}");
            Console.WriteLine($" Кол-во этажей: {FloorsNumbers}");
            Console.WriteLine($" Кол-во квартир: {FlatsNumber}");
            Console.WriteLine($" Кол-во подъездов: {EntrancesNumber}");

            Console.WriteLine(" Рассчитанные значение");
            Console.WriteLine($" Кол-во квартир на этаже дома: {GetFlatsPerFloor()}");
            Console.WriteLine($" Кол-во квартир в подъезде: {GetFlatsPerEntrance()}");
            Console.WriteLine($" Кол-во квартир на этаже в подъезде: {GetFlatsPerFloorInEntrance()}");
            Console.WriteLine($" Высота этажа: {GetFloorHieght()}");
            Console.WriteLine();
        }

    }

    /// <summary>
    /// Класс здания из бетона
    /// </summary>
    public class ConcreteBuilding : Building
    {
        public ConcreteBuilding(int buildingHeight, int floorsNumber, int flatsNumber, int entarancesNumber) : 
            base(buildingHeight, floorsNumber, flatsNumber, entarancesNumber, BuildingType.Concrete)
        {
        }
    }

    /// <summary>
    /// Класс здания из дерева
    /// </summary>
    public class WoodenBuilding : Building
    {
        public WoodenBuilding(int buildingHeight, int floorsNumber, int flatsNumber, int entarancesNumber):
            base(buildingHeight, floorsNumber, flatsNumber, entarancesNumber, BuildingType.Wooden)
        {
        }
    }


    /// <summary>
    /// Класс здания из кирпича
    /// </summary>
    public class BrickBuilding : Building
    {
        public BrickBuilding(int buildingHeight, int floorsNumber, int flatsNumber, int entarancesNumber) :
            base(buildingHeight, floorsNumber, flatsNumber, entarancesNumber, BuildingType.Bric)
        {
        }
    }

}