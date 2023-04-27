using System;

namespace PR2
{
    internal class ReadersCard//не билет вообще, а запись так-то
    {
        public enum Statuses
        {
            Возвращено,
            Невозвращено
        }

        private Reader reader;
        private Book book;
        private DateTime issueDate;
        private DateTime returnDate;
        private Statuses status;
        public string ReaderName
        {
            get
            {
                return Reader != null ? $"{Reader.Name} {Reader.Surname}" : "";
            }
        }
        public string BookTitle
        {
            get
            {
                return Book != null ? Book.Title : "";
            }
        }
        private Reader Reader { get => reader; }
        private Book Book { get => book; }
        public DateTime IssueDate { get => issueDate; }
        public DateTime ReturnDate { get => returnDate; }
        public Statuses Status { get => status; }
        public ReadersCard(Reader reader, Book book, DateTime issueDate, DateTime returnDate, Statuses status)
        {
            this.reader = reader;
            this.book = book;
            this.issueDate = issueDate;
            this.returnDate = returnDate;
            this.status = status;
        }
    }
}
