namespace Task_11_05
{
    class Program
    {
        /// <summary>
        /// Метод, который принимает два числа по ссылке и возвращает их сумму и произведение.
        /// </summary>
        /// <param name="a">Первое число, переданное по ссылке.</param>
        /// <param name="b">Второе число, переданное по ссылке.</param>
        /// <param name="sum">Сумма двух чисел, возвращаемая через выходной параметр.</param>
        /// <param name="product">Произведение двух чисел, возвращаемое через выходной параметр.</param>
        static void Calculate(ref int a, ref int b, out int sum, out int product)
        {
            // Вычисляем сумму
            sum = a + b;

            // Вычисляем произведение
            product = a * b;
        }

        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 10;

            // Вызов метода Calculate с использованием ref и out
            Calculate(ref num1, ref num2, out int resultSum, out int resultProduct);

            // Вывод результатов
            Console.WriteLine($"Сумма: {resultSum}");          // Вывод: Сумма: 15
            Console.WriteLine($"Произведение: {resultProduct}"); // Вывод: Произведение: 50
        }
    }

}
