using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR2
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow());

            Reader reader3 = new Reader("Name3", "Surname3", "Patronymic3", "Phone3");
            Reader reader4 = new Reader("Name4", "Surname4", "Patronymic4", "Phone4");
            Reader reader5 = new Reader("Name5", "Surname5", "Patronymic5", "Phone5");
            Reader reader6 = new Reader("Name6", "Surname6", "Patronymic6", "Phone6");
            Reader reader7 = new Reader("Name7", "Surname7", "Patronymic7", "Phone7");
            Author author3 = new Author("Name3", "Surname3");
            Author author4 = new Author("Name4", "Surname4");
            Author author5 = new Author("Name5", "Surname5");
            Author author6 = new Author("Name6", "Surname6");
            Author author7 = new Author("Name7", "Surname7");
            Book book3 = new Book("Title3", author3, "Annotation3", 2020);
            Book book4 = new Book("Title4", author4, "Annotation4", 2000);
            Book book5 = new Book("Title5", author5, "Annotation5", 1994);
            Book book6 = new Book("Title6", author6, "Annotation6", 2021);
            Book book7 = new Book("Title7", author7, "Annotation7", 2016);
        }
    }
}
