namespace Task_03_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите произвольный текст.");

            int count = 0;  // счетчик введенных строк
            while (true)
            {
                count++;
                Console.Clear();

                string text = Console.ReadLine();

                // прекращение считывания с консоли 
                if (text == "exit" || text == "")
                {
                    count -= text == "" ? 1 : 0;  // если текст пустой не считать его за введенный 

                    Console.WriteLine($"Вы ввели {count} строк текста!");
                    break;
                }
            }
        }
    }
}