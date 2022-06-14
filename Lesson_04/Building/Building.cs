using System;


namespace BuildingLibrary
{
    public class Building : BuildingBase
    {
        internal Building(int buildingHeight, int floorsNumber, int flatsNumber, int entarancesNumber, BuildingType buildingType) : base()
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
            return EntrancesNumber > 0 ? GetFlatsPerFloor() / EntrancesNumber : 0;
        }

        public override int GetFloorHieght()
        {
            return FloorsNumbers > 0 ? BuildingHeight / FloorsNumbers : 0;
        }

        public override string ToString()
        {
            return (
                $" Заданные значение:" + Environment.NewLine +
                $" Индекс: {BuildingIndex}" + Environment.NewLine +
                $" Высота: {BuildingHeight}" + Environment.NewLine +
                $" Кол-во этажей: {FloorsNumbers}" + Environment.NewLine +
                $" Кол-во квартир: {FlatsNumber}" + Environment.NewLine +
                $" Кол-во подъездов: {EntrancesNumber}" + Environment.NewLine + Environment.NewLine +
                " Рассчитанные значение" + Environment.NewLine +
                $" Кол-во квартир на этаже дома: {GetFlatsPerFloor()}" + Environment.NewLine +
                $" Кол-во квартир в подъезде: {GetFlatsPerEntrance()}" + Environment.NewLine +
                $" Кол-во квартир на этаже в подъезде: {GetFlatsPerFloorInEntrance()}" + Environment.NewLine +
                $" Высота этажа: {GetFloorHieght()}"
            );
        }

        public void PrintBuildingInfo()
        {
            Console.WriteLine(this.ToString());
        }

    }


}
