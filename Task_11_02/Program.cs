namespace Task_11_02
{
    internal class Program
    {
        /// <summary>
        /// Метод, который меняет местами два целых числа.
        /// </summary>
        /// <param name="x">Первое целое число.</param>
        /// <param name="y">Второе целое число.</param>
        static void Main(string[] args)
        {
            Console.Write("Введите число x");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("И число y");
            int y = Convert.ToInt32(Console.ReadLine());

            SwapNums(ref x, ref y, x, y);
            Console.WriteLine($" Значениия после метода x = {x}; b = {y}");
        }

        public static void SwapNums(ref int , ref int, int x = 0, int y = 0)
        {
            int temp = x;
            x = y;
            y = temp;
        }
    }
}
