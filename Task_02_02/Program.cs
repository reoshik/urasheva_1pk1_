namespace Task_02_02
{
    internal class Program
    {
        private static double part_2_2;

        /* Найти значение выражения , при a = 8, b = 14, c = π/4
*/
        static void Main(string[] args)
        {
            double a = 8;
            double b = 14;
            double c = Math.PI / 4;

            // найдём числитель
            double part_1_1 = Math.Pow(a - 1, 1.0 / 3);
            double part_1_2 = Math.Pow(b + part_1_1, 0.25);
            // найдём знаменатель
            double part2_1 = Math.Abs(a - b);
            double part2_2 = part2_1 * (Math.Pow(Math.Sin(c), 2) + Math.Tan(c));

            double res = part_1_2 / part_2_2;

            Console.WriteLine(res);
        }
    }
}
