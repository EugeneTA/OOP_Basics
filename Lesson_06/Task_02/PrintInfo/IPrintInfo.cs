using System.Collections.Generic;

namespace Lesson_06_Task_02.Interfaces
{
    public interface IPrintInfo
    {
        /// <summary>
        /// Print information about figure
        /// </summary>
        /// <param name="figure">the object to print information about</param>
        /// <returns></returns>
        public void PrintInfo(Figure figure);
    }
}
