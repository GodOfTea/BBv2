using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackBooks
{
    /// <summary>
    /// Информация о заказе
    /// </summary>
    public class BookRequestDto
    {
        /// <summary>
        /// Дата заполнения
        /// </summary>
        public DateTime Filled { get; set; }
        /// <summary>
        /// Дата доставки
        /// </summary>
        public DateTime Delivery { get; set; }
        /// <summary>
        /// ФИО заказчика
        /// </summary>
        public string FullName { get; set; }
        /// <summary>
        /// Названия книг
        /// </summary>
        public List<BookTitle> BookTitles { get; set; }
        public List<BookAuthor> BookAuthors { get; set; }
        public List<BookGener> BookGeneres { get; set; }
        public List<BookPrice> BookPrices { get; set; }
        public List<BookPresence> BookPresences { get; set; }
        /// <summary>
        /// Адрес
        /// </summary>
        public string Addres { get; set; }
        /// <summary>
        /// Стоимость
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        /// Валюта
        /// </summary>
        public Currency Currency { get; set; }
    }
    /// <summary>
    /// Информация о названиях
    /// </summary>
    public class BookTitle
    {
        /// <summary>
        /// Название книги
        /// </summary>
        public string Title { get; set; }
    }
    /// <summary>
    /// Информация о авторах
    /// </summary>
    public class BookAuthor
    {
        /// <summary>
        /// Автор книги
        /// </summary>
        public string Author { get; set; }
    }
    /// <summary>
    /// Информация о жанрах
    /// </summary>
    public class BookGener
    {
        /// <summary>
        /// Жанр
        /// </summary>
        public Genre Genre { get; set; }
    }
    /// <summary>
    /// Информация о ценах
    /// </summary>
    public class BookPrice
    {
        /// <summary>
        /// Цена
        /// </summary>
        public double Price { get; set; }
    }
    /// <summary>
    /// Информация о наличии
    /// </summary>
    public class BookPresence
    {
        /// <summary>
        /// Наличие
        /// </summary>
        public bool Presence { get; set; }
    }
    

    public enum Genre
    {
        BusinessBook,
        ClassicalLiterature,
        ForeignLiterature,
        RussianLiterature,
        ChildrenBook,
        Detective,
        Fantasy,
        Fiction,
        ModernProse,
        Adventures,
        Horror,
        JournalisticLiterature,
        RomanceNovel,
        Militant,
        Psychology,
        Tale,
        Poetry,
        Science,
        Leisure,
        Comics,
        Esotericist,
        Culture,
        HumorousLiterature,
        Religion,
        Dictionary
    }

    public enum AgeLimit
    {
        zeroAndOlder,
        sixAndOlder,
        twelveAndOlder,
        sixteenAndOlder,
        eighteenAndOlder
    }

    public enum Currency
    {
        Rubles,
        Dollars,
        Euro,
        Bitcoins,
        BonusPoints
    }
}
