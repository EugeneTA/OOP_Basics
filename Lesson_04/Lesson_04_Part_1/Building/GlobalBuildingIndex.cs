namespace Lesson_04
{
    /// <summary>
    /// Класс уникальных индексов зданий
    /// </summary>
    internal static class GlobalBuildingIndex
    {
        private static int _buildingsIndex = 0;

        internal static int InitializeNewBuildingIndex()
        {
            return ++_buildingsIndex;
        }


        public static string ToString()
        {
            return $" Глобальный индекс зданий: {_buildingsIndex}";
        }

    }

}