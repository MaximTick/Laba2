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
    public partial class AuthorCreateForm : Form
    {
        BookForm book;

        public AuthorCreateForm()
        {
            InitializeComponent();
        }

        public AuthorCreateForm(BookForm f)
        {
            InitializeComponent();
            book = f;
        }

        private void AuthorCreateForm_Load(object sender, EventArgs e)
        {
            Program.Filler(CountryBox);
        }

        private void SaveAuthor_Click(object sender, EventArgs e)
        {
            try
            {
                if (NameBox.Text.CompareTo("") == 0 ||
                    CountryBox.Text.CompareTo("") == 0 ||
                    (!Man.Checked && !Woman.Checked))
                {
                    MessageBox.Show("Заполните поля!");
                }
                else
                {
                    BookForm.Author = new Author(NameBox.Text, CountryBox.Text, Man.Checked);
                    book.AuthorBox.Text = BookForm.Author.ToString();
                    Close();
                }
            }
            catch(Exception err)
            {
                MessageBox.Show("Проверьте правильность введенных данных!");
            }
        }

        private void NameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void NameBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
                return;
            else
                e.Handled = true;
        }

        private void NameBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(NameBox.Text))
            {
                errorProvider1.SetError(NameBox, "укажите автора");
            }
            else
                errorProvider1.Clear();
        }

        private void CountryBox_Click(object sender, EventArgs e)
        {

        }

        private void CountryBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar))
                return;
            else
                e.Handled = true;
        }
    }
}
