using Lesson_06_Task_02.Interfaces;
using System;

namespace Lesson_06_Task_02
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class Figure
    {
        /// <summary>
        /// Figure color
        /// </summary>
        public ConsoleColor Color { set; get; }
        
        /// <summary>
        /// Figure visible status
        /// </summary>
        public bool IsVisible { set; get; }
        
        /// <summary>
        /// Print figure info. How to print and where printInfo is defined.
        /// </summary>
        /// <param name="printInfo">instance of the class implementing the interface IPrintInfo</param>
        public abstract void PrintFigureInfo(IPrintInfo printInfo);
    }
}
