namespace Task_11_08
{
    internal class Program
    {
        /// <summary>
        /// Метод для вычисления суммы и максимального значения из переменного количества целых чисел.
        /// </summary>
        /// <param name="numbers">Переменное количество целых чисел.</param>
        /// <param name="sum">Сумма переданных чисел.</param>
        /// <param name="max">Максимальное значение среди переданных чисел.</param>
        public static void CalculateSumAndMax(out int sum, out int max, params int[] numbers)
        {
            sum = 0; // Инициализация суммы
            max = int.MinValue; // Инициализация максимального значения

            foreach (var number in numbers)
            {
                sum += number; // Суммируем числа
                if (number > max) // Проверяем, является ли текущее число максимальным
                {
                    max = number;
                }
            }
        }

        static void Main(string[] args)
        {
            // Пример использования метода
            CalculateSumAndMax(out int totalSum, out int maximumValue, 5, 10, 3, 8, 15);

            Console.WriteLine($"Сумма: {totalSum}"); // Вывод суммы
            Console.WriteLine($"Максимальное значение: {maximumValue}"); // Вывод максимального значения
        }
    }
}
