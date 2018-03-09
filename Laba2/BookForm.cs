using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba2
{
    public partial class BookForm : Form
    {
        static PublishingHouse house;
        static Author author;
        public MainForm main;

        internal static PublishingHouse House { get => house; set => house = value; }
        internal static Author Author { get => author; set => author = value; }

        public BookForm()
        {
            InitializeComponent();
        }

        public BookForm(MainForm f)
        {
            InitializeComponent();
            main = f;
        }

        private void BookForm_Load(object sender, EventArgs e)
        {
            UKKValue.Text = UKKBar.Value.ToString();
        }

        private void Va(object sender, EventArgs e)
        {
            UKKValue.Text = UKKBar.Value.ToString();
        }

        private void CreatePubHouse_Click(object sender, EventArgs e)
        {
            PubHouse house = new PubHouse(this);
            house.Show();
        }

        private void CreateAuthor_Click(object sender, EventArgs e)
        {
            AuthorCreateForm author = new AuthorCreateForm(this);
            author.Show();
        }

        private void SaveBook_Click(object sender, EventArgs e)
        {
            if (TitleBox.Text.CompareTo("") == 0 || PubHouseBox.Text.CompareTo("") == 0 ||
                AuthorBox.Text.CompareTo("") == 0)
            {
                MessageBox.Show("Заполните все поля!");
            }
            else
            {
                DateTime date = new DateTime();
                date = Convert.ToDateTime(dateTimePicker1.Value);
                Book book = new Book(TitleBox.Text, Convert.ToByte(UKKValue.Text),
                    (int)NumberBox.Value, House, (int)YearBox.Value, isCDBox.Checked, isDVDBox.Checked,
                    Author, date);
                main.Library.list.Add(book);
            }
        }

        private void TitleBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(TitleBox.Text))
            {
                errorProvider1.SetError(TitleBox, "название книги должно быть обязательно");
            }
            else
                errorProvider1.Clear();
        }

        private void UKKBar_Scroll(object sender, EventArgs e)
        {

        }
    }
}
