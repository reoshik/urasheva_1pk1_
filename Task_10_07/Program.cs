namespace Task_10_07;

class Program
{
    /// <summary>
    /// Метод для генерации двумерного массива символов русского алфавита
    /// </summary>
    /// <param name="rows">Количество строк в массиве</param>
    /// <param name="columns">Количество столбцов в массиве</param>
    /// <returns>Двумерный массив символов.</returns>
    static char[,] GenerateCharArray(int rows, int columns)
    {
        // Определяем массив букв русского алфавита
        char[] russianAlphabet = new char[]
        {
            'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З', 'И', 'Й',
            'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С', 'Т', 'У', 'Ф',
            'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ъ', 'Ы', 'Ь', 'Э', 'Ю', 'Я',
            'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й',
            'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф',
            'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я'
        };

        // Создание двумерного массива
        char[,] charArray = new char[rows, columns];
        Random random = new Random();

        // Заполнение массива рандомными буквами русского алфавита
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                // Генерация случайного индекса для выбора буквы
                int index = random.Next(russianAlphabet.Length);
                charArray[i, j] = russianAlphabet[index];
            }
        }
        return charArray;
    }

    static void PrintCharArray(char[,] charArray)
    {
        int rows = charArray.GetLength(0); // Получаем количество строк
        int columns = charArray.GetLength(1); // Получаем количество столбцов

        // Проход по двумерному массиву для его отображения
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(charArray[i, j] + " "); // Выводим символ и пробел
            }
            Console.WriteLine(); // Переход на новую строку после каждой строки массива
        }
    }

   public static void GenerateCharArray(string[] args)
    {
        // Определяем размеры массива
        int rows = 5; // количество строк
        int columns = 10; // количество столбцов

        // Генерируем двумерный массив символов
        char[,] charArray = GenerateCharArray(rows, columns);

        // Выводим массив на консоль
        PrintCharArray(charArray);
    }
}