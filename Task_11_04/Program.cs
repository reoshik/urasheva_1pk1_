namespace Task_11_04
{

    /// <summary>
    /// Метод для вычисления среднего значения переданных чисел.
    /// Использует ключевое слово params для принятия переменного количества аргументов.
    /// </summary>
    /// <param name="numbers">Массив чисел для вычисления среднего значения.</param>
    /// <returns>Среднее значение чисел.</returns>
    class Program
    {
        static void Main(string[] args)
        {
            //Вызов метода CalculateAverage с набором чисел
            double average = CalculateAverage(10, 20, 30, 40, 50);

            //Вывод сред. значения
            Console.WriteLine("Среднее значение: " + average);
        }

        static double CalculateAverage(params double[] numbers)
        {
            //Проверка на пустой массив
            if (numbers.Length == 0)
            {
                throw new ArgumentException("Должен быть передан хотя бы один элемент для вычисления среднего.");
            }

            //Переменная для хранения суммы чисел
            double sum = 0;

            
            foreach (double number in numbers)
            {
                sum += number;
            }

            //Вычисление среднего значения
            double average = sum / numbers.Length;

            //Возвращение сред. значения
            return average;
        }
    }
}