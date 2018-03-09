using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2
{
    public class Book
    {
        string title;
        byte ukk;
        int numberPages;
        PublishingHouse publishingHouse;
        int year;
        bool isCD;
        bool isDVD;
        Author author;
        DateTime date;
        #region Properties
        public string Title { get => title; set => title = value; }
        public byte Ukk { get => ukk; set => ukk = value; }
        public int NumberPages { get => numberPages; set => numberPages = value; }
        public int Year { get => year; set => year = value; }
        public bool IsCD { get => isCD; set => isCD = value; }
        public bool IsDVD { get => isDVD; set => isDVD = value; }
        public DateTime Date { get => date; set => date = value; }
        public PublishingHouse PublishingHouse { get => publishingHouse; set => publishingHouse = value; }
        public Author Author { get => author; set => author = value; }
        #endregion

        public Book() { }

        public Book(string title, byte ukk, int numberPages, PublishingHouse publishingHouse, int year, bool isCD, bool isDVD, Author listAuthor, DateTime date)
        {
            this.title = title;
            this.ukk = ukk;
            this.numberPages = numberPages;
            this.publishingHouse = publishingHouse;
            this.year = year;
            this.isCD = isCD;
            this.isDVD = isDVD;
            this.author = listAuthor;
            this.date = date;
        }

        public override string ToString()
        {
            StringBuilder a = new StringBuilder();
            a = new StringBuilder($"\'{Title}\'\nУДК:{Ukk}\n{NumberPages} стр\n" +
                $"Издательство: {publishingHouse.ToString()}\nГод издания: {Year}\nCD: ");
            if (IsCD)
                a.Append("Да;");
            else
                a.Append("Нет;");
            a.Append("\nDVD: ");
            if (IsDVD)
                a.Append("Да;");
            else
                a.Append("Нет;");
            a.Append($"\nАвтор: {Author.ToString()}\nДата написания: {Date.ToString("dd.MM.yyyy")}");

            return a.ToString();
        }
    }
}
