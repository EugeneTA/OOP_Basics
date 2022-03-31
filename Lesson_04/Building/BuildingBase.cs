using System;


namespace BuildingLibrary
{

    /// <summary>
    /// Абстрактный класс здания
    /// </summary>
    abstract public class BuildingBase
    {
        protected int _buildingIndex;          // уникальный индекс здания
        protected int _buildingHeight;          // высота здания
        protected int _floorsNumber;            // количество этажей
        protected int _flatsNumber;             // количество квартир  
        protected int _entrancesNumber;         // количество подъездов
        protected BuildingType _buildingType;   // тип дома (кирпичный, ж/бетонный, деревянный)

        protected BuildingBase()
        {
            _buildingIndex = 0;
            _buildingHeight = 0;
            _floorsNumber = 0;
            _flatsNumber = 0;
            _entrancesNumber = 0;
            _buildingType = BuildingType.Undefined;
        }

        /// <summary>
        /// Получение количества квартир на одном этаже в доме, не в подъезде.
        /// </summary>
        /// <returns>Количество квартир на этаже</returns>
        public abstract int GetFlatsPerFloor();

        /// <summary>
        /// Получение количества квартир в подъезде
        /// </summary>
        /// <returns>Количество этажей в подъезде</returns>
        public abstract int GetFlatsPerEntrance();

        /// <summary>
        /// Получение количества квартир на одном этаже в подъезде
        /// </summary>
        /// <returns>Количество квартир на одном этаже в подъезде</returns>
        public abstract int GetFlatsPerFloorInEntrance();

        /// <summary>
        /// Получение высоты одного этажа в доме
        /// </summary>
        /// <returns>Высота одного этажа в доме</returns>
        public abstract int GetFloorHieght();

    }
}
