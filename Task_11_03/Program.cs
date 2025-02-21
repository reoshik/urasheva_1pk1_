
namespace Task_11_03
{
    internal class Program
    { /*Выходной параметр (out): Напишите метод, который принимает строку и возвращает через
       выходной параметр количество гласных и согласных букв в этой строке*/

        /// <summary>
        /// Метод, который принимает строку и считает количество гласных и согласных букв
        /// </summary>
        /// <param name="input">Строка, в которой будет произведен подсчет букв.</param>
        /// <param name="vowelCount">Выходной параметр, который содержит количество гласных букв</param>
        /// <param name="consonantCount">Выходной параметр, который содержит количество согласных букв</param>
        public static void Main(string[] args)
        {
            // Пример использования метода
            string input = "Пример строки!";
            CountVowelsAndConsonants(input, out int vowels, out int consonants);

            // Вывод результата
            Console.WriteLine($"Количество гласных: {vowels}");
            Console.WriteLine($"Количество согласных: {consonants}");
        }
         static public void CountVowelsAndConsonants(string input, out int vowelCount, out int consonantCount)
        {
            // Инициализируем 
            vowelCount = 0;
            consonantCount = 0;

            input = input.ToLower();

            // Строка для хранения 
            string vowels = "aeiou";

            // Перебираем каждый символ в строке
            foreach (char c in input)
            {
                // Проверяем, является ли символ буквой
                if (char.IsLetter(c))
                {
                    // Проверяем, является ли буква гласной
                    if (vowels.Contains(c))
                    {
                        vowelCount++; 
                    }
                    else
                    {
                        consonantCount++; 
                    }
                }
            }
        }

        

    }
}
