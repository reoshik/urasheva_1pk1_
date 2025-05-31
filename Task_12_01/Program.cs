namespace Task_12_01
{



    namespace ClassesDemo
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                Book book1 = new Book();
                var book2 = new Book();
                var book3 = new Book() { title = "Автостопом по галактике", autor = "Дуглас Адамс" };
                Book book4 = new Book() { title = "Хоббит", autor = "Джон Толкин" };


                book1.autor = "Рей Бредберри";
                book1.title = "Марсианские хроники";
                book1.GetInfo();    //Рей Бредберри : Марсианские хроники

                book2.autor = "Джона Роулинг";
                book2.title = "Гарри Поттер и философский камень";
                book2.GetInfo();    //Джона Роулинг : Гарри Поттер и философский камень

                //выдача книги
                book2.GetBoot(); // книга выдана на неделю

                //попытка выдать уже занятую книгу
                book2.GetBoot(); // книга Гарри Поттер и философский камень в данный момент выдана другому читателю
            }
        }
    }

    public class Journal
    {
        public DateTime PublicationDate { get; set; }
        public string Subject { get; set; }
        public string Title { get; set; }
        public int PageCount { get; set; }
        public decimal Price { get; set; }

        /// <summary>
        /// Метод для покупки журнала.
        /// </summary>
        public void Buy()
        {
            Console.WriteLine($"Вы купили журнал '{Title}' за {Price} рублей.");
        }

        /// <summary>
        /// Метод для просмотра содержания журнала.
        /// </summary>
        public void ViewContents()
        {
            Console.WriteLine($"Содержание журнала '{Title}': [Содержание журнала здесь]");
        }
    }

    /// <summary>
    /// Класс, представляющий газету.
    /// </summary>
    public class Newspaper
    {
        public DateTime PublicationDate { get; set; }
        public string Title { get; set; }
        public string MainHeadline { get; set; }
        public int PageCount { get; set; }
        public decimal Price { get; set; }

        /// <summary>
        /// Метод для покупки газеты.
        /// </summary>
        public void Buy()
        {
            Console.WriteLine($"Вы купили газету '{Title}' за {Price} рублей.");
        }

        /// <summary>
        /// Метод для просмотра главной статьи газеты.
        /// </summary>
        public void ViewMainHeadline()
        {
            Console.WriteLine($"Главная статья газеты '{Title}': {MainHeadline}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Создание экземпляров класса Journal
            Journal journal1 = new Journal()
            {
                PublicationDate = DateTime.Now,
                Subject = "Наука",
                Title = "Научный мир",
                PageCount = 100,
                Price = 250.50m
            };

            // Использование методов класса Journal
            journal1.Buy();
            journal1.ViewContents();

            // Создание экземпляров класса Newspaper
            Newspaper newspaper1 = new Newspaper()
            {
                PublicationDate = DateTime.Now,
                Title = "Утренние новости",
                MainHeadline = "События дня",
                PageCount = 20,
                Price = 50.00m
            };

            // Использование методов класса Newspaper
            newspaper1.Buy();
            newspaper1.ViewMainHeadline();
        }
    }
}   
