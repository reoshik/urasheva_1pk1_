namespace Task_03_06
{
    internal class Program
    {
        //  Написать программу , котторая выводит таблицу значений функции: y=|x|:\n y\tx");
        static void Main(string[] args)
        {
            double y = 0; // значение функции

            Console.WriteLine("Таблица значений функции y=|x|:\n y\tx");
            for (double i = -4; i <= 4; i += 0.5)
            {
                y = Math.Abs(i);

                Console.WriteLine($" {y}\t{i}");
            }
        }
    }
}