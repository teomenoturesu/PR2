using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace PR2
{
    public partial class MainWindow : Form
    {
        private ReadersCardDatabase readersCard;
        public MainWindow()
        {
            InitializeComponent();
            readersCard = new ReadersCardDatabase();
            readersCard.Initialize();
            entries.DataSource = readersCard.Entry.ToList();

        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            entries.DataSource = readersCard.Entry.Where(i => i.ReaderName.ToLower().Contains(search.Text.ToLower())).ToList();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    entries.DataSource = readersCard.Entry.Where(i => i.Status == ReadersCard.Statuses.Возвращено).ToList();
                    break;
                case 1:
                    entries.DataSource = readersCard.Entry.Where(i => i.Status == ReadersCard.Statuses.Невозвращено).ToList();
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            entries.DataSource = readersCard.Entry.OrderByDescending(i => i.BookTitle).ToList();
        }
    }
}
