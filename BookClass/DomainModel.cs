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
    public class BookDeteil
    {
        /// <summary>
        /// Книга
        /// </summary>
        public List<BookDetails> Book { get; set; }
    }
    /// <summary>
    /// Информация о книге
    /// </summary>
    public class BookDetails
    {
        /// <summary>
        /// Название книги
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Автор книги
        /// </summary>
        public Genre Genre {get;set;}
        /// <summary>
        /// Количество страниц
        /// </summary>
        public int PagesNumber { get; set; }
        /// <summary>
        /// Цена
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// Возрастное ограничение
        /// </summary>
        public AgeLimit AgeLimit { get; set; }
        /// <summary>
        /// Наличие
        /// </summary>
        public bool Presence { get; set; }
    }
    

    public enum Genre
    {
        Detective,
        Fantasy,
        Fiction,
        Adventures,
        Horror,
        RomanceNovel,
        Tale,
        Comics,
        Biography
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
