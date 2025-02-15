namespace Task_10_08
{
    internal class Program
    {
        /// <summary>
        /// Возвращает индекс искомого элемента в массиве
        /// </summary>
        /// <param name="number"> массив чисел </param>
        /// <param name="num"> искомое число </param>
        /// <returns> индекс искомого числа </returns>
         static void Main(string[] args)
        {
            Console.Write("Введите число элементов массива");
            int n = Convert.ToInt32(Console.ReadLine());        //Число элемемтов массива

            Console.Write("Введите искомое число в диопазоне от 0 до 9 включительно: ");
            int num = Convert.ToInt32(Console.ReadLine());      //Искомое число

            Random rnd = new Random();
            int[] number = new int[n];    // Массив чисел

            Console.WriteLine("\nМассив:");
            //Заполнение и вывод
            for (int i = 0; i < n; i++)
            {
                number[i] = rnd.Next(0, 10);
                Console.Write($"{number[i]}");
            }

            Console.WriteLine($"Индекс искомого значения: {GetValSearchInd(number, num)}");
        }

        
        public static int GetValSearchInd(int[] number, int num)
        {
            for (int i = 0; i < number.Length; i++)
                if (number[i] == num)
                    return i;

            return -1;
        }
    }
}