namespace Task_11_06
{ /// <summary>
  /// Метод, который принимает массив целых чисел и увеличивает каждый элемент на 1.
  /// Поскольку массив в C# передаётся по ссылке, изменения внутри метода будут
  /// видимы вне его. Однако, если заменить массив на новый, то оригинальный массив не изменится.
  /// </summary>
  /// <param name="numbers">Массив целых чисел для изменения.</param>

    internal class Program
    {
        static void IncreaseArrayElements(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                //Увеличиваем каждый элемент на 1
                numbers[i] += 1;
            }
        }

        static void Main()
        {
            //Создаём массив
            int[] originalArray = { 1, 2, 3, 4, 5 };

            //Выводим оригинальный метод
            Console.WriteLine("Оригинальный массив до изменения: " + string.Join(", ", originalArray));

            //Вызываем метод,изменяющий элементы
            IncreaseArrayElements(originalArray);
            //Выводим массив после вызова метода
             Console.WriteLine("Оригинальный массив после изменения: " + string.Join(", ", originalArray));
        }
    }
}
