using System;
using System.Collections.Generic;


namespace BuildingLibrary
{
    public static class BuildingFactory
    {
        private static Dictionary<int, Building> buildingsDatabase = new Dictionary<int, Building>();

        private static Building CreateBuilding(int buildingHeight, int floorsNumber, int flatsNumber, int entarancesNumber, BuildingType buildingType)
        {
            Building building = null;

            if (buildingHeight > 0 && floorsNumber > 0 && flatsNumber > 0 && entarancesNumber > 0)
            {
                // считаем, что количество квартир на этаже величина постоянная
                if ((double)(flatsNumber % entarancesNumber) == 0)
                {
                    if ((double)((double)(flatsNumber / entarancesNumber) % (floorsNumber)) == 0)
                    {
                        building = new Building(buildingHeight, floorsNumber, flatsNumber, entarancesNumber, buildingType);
                    }
                }
            }

            if (building != null)
            {
                buildingsDatabase.Add(building.BuildingIndex, building);
            }

            return building;
        }

        public static Building CreateConcreteBuilding(int buildingHeight, int floorsNumber, int flatsNumber, int entarancesNumber)
        {
            return CreateBuilding(buildingHeight, floorsNumber, flatsNumber, entarancesNumber, BuildingType.Concrete);
        }

        public static Building CreateBrickBuilding(int buildingHeight, int floorsNumber, int flatsNumber, int entarancesNumber)
        {
            return CreateBuilding(buildingHeight, floorsNumber, flatsNumber, entarancesNumber, BuildingType.Bric);
        }

        public static Building CreateWodenBuilding(int buildingHeight, int floorsNumber, int flatsNumber, int entarancesNumber)
        {
            return CreateBuilding(buildingHeight, floorsNumber, flatsNumber, entarancesNumber, BuildingType.Wooden);
        }

        public static bool DeleteBuildingFromDatabase(Building buildingToDelete)
        {
            bool result = false;

            if (buildingToDelete != null)
            {
                if (buildingsDatabase.ContainsKey(buildingToDelete.BuildingIndex))
                {
                    buildingsDatabase.Remove(buildingToDelete.BuildingIndex);
                    result = true;
                }
            }

            return result;
        }

        public static void PrintBuildingsDatabase()
        {
            foreach (var item in buildingsDatabase)
            {
                if (item.Value != null)
                {
                    Console.WriteLine("*********************");
                    item.Value.PrintBuildingInfo();
                    Console.WriteLine("*********************");
                }
            }
        }
    }

}
