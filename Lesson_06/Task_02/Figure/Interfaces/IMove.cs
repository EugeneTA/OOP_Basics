namespace Lesson_06_Task_02
{
    public interface IMove
    {
        /// <summary>
        /// Moving along the x-axis
        /// </summary>
        /// <param name="offset">the amount of displacement</param>
        /// <returns></returns>
        public Figure XMove(long offset);

        /// <summary>
        /// Moving along the y-axis
        /// </summary>
        /// <param name="offset">the amount of displacement</param>
        /// <returns></returns>
        public Figure YMove(long offset);
    }
}
