namespace Task_11_06
{
     internal class Program
    {
        /// <summary>
        /// Метод, который принимает массив целых чисел и увеличивает каждый элемент на 1.
        /// </summary>
        /// <param name="numbers">Массив целых чисел.</param>
        static void IncrementArray(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] += 1; // Увеличиваем каждый элемент на 1
            }
        }

        static void Main(string[] args)
        {
            Random random = new Random();
            int size = 5; // Размер массива
            int[] originalArray = new int[size];

            // Заполнение массива случайными числами
            for (int i = 0; i < 0; i++)
            {
                originalArray[i] = random.Next(1, 101); // Случайные числа от 1 до 100
            }

            Console.WriteLine("Оригинальный массив:");
            Console.WriteLine(string.Join(", ", originalArray)); // Вывод оригинального массива

            // Вызов метода для изменения массива
            IncrementArray(originalArray);

            Console.WriteLine("Массив после изменения:");
            Console.WriteLine(string.Join(", ", originalArray)); // Вывод изменённого массива
        }
    }
}