
namespace Task_11_01
{
    internal class Program
    {
        /// <summary>
        /// меняет числа местами
        /// </summary>
        /// <param name="x"> Первое число </param>
        /// <param name="y"> Второе число </param>
        static void Main(string[] args)
        {

            Console.Write("Введите число x");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число y");
            int y = Convert.ToInt32(Console.ReadLine());
            SwapNums (x, y);
            Console.WriteLine($"после вызова метода : x ={x} , y = {y}");

            
        }

        public static void SwapNums(int x, int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
    }
}
