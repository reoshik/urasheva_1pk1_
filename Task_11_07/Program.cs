namespace Task_11_07
{
    internal class Program
    {
        /// <summary>
        /// Метод, который принимает массив целых чисел и увеличивает каждый элемент на 1.
        /// </summary>
        /// <param name="numbers">Массив целых чисел.</param>
        static void IncreaseArrayValues(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] += 1; // Увеличиваем каждый элемент на 1
            }
        }

        static void Main(string[] args)
        {
            Random random = new Random();
            int[] originalArray = new int[5];

            // Заполнение массива случайными числами
            for (int i = 0; i < originalArray.Length; i++)
            {
                originalArray[i] = random.Next(1, 10);
            }

            Console.WriteLine("Оригинальный массив: " + string.Join(", ", originalArray));

            // Создаем копию массива для передачи
            int[] arrayCopy = (int[])originalArray.Clone();

            // Увеличиваем элементы копии
            IncreaseArrayValues(arrayCopy);

            Console.WriteLine("Измененный массив (копия): " + string.Join(", ", arrayCopy));
            Console.WriteLine("Оригинальный массив после вызова метода: " + string.Join(", ", originalArray));
        }
    }
}
