using System;
using System.Collections.Generic;

namespace PR2
{
    internal class ReadersCardDatabase
    {
        internal List<ReadersCard> Entry { get; private set; }
        public void Initialize()
        {
            Entry = new List<ReadersCard>()
            {
                new ReadersCard(new Reader("Name0", "Surname0", "Patrinymic0", "Phone0"), new Book("Title0", new Author("Name0", "Surname0"), "Annotation0", 2023), DateTime.Parse("01/01/2023"), DateTime.Parse("01/03/2023"), ReadersCard.Statuses.Возвращено),
                new ReadersCard(new Reader("Name1", "Surname1", "Patrinymic1", "Phone1"), new Book("Title1", new Author("Name1", "Surname1"), "Annotation1", 2017), DateTime.Parse("27/07/2022"), DateTime.Parse("27/09/2022"), ReadersCard.Statuses.Возвращено),
                new ReadersCard(new Reader("Name2", "Surname2", "Patrinymic2", "Phone2"), new Book("Title2", new Author("Name2", "Surname2"), "Annotation2", 2021), DateTime.Parse("09/11/2021"), DateTime.Parse("09/01/2022"), ReadersCard.Statuses.Невозвращено)
            };
        }
    }
}
