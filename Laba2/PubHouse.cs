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
    public partial class PubHouse : Form
    {
        BookForm book;

        public PubHouse()
        {
            InitializeComponent();
        }

        public PubHouse(BookForm f)
        {
            InitializeComponent();
            book = f;
        }

        private void SavePub_Click(object sender, EventArgs e)
        {
            try
            {
                if (NameBox.Text.CompareTo("") == 0 ||
                    CountryBox.Text.CompareTo("") == 0 ||
                    CityBox.Text.CompareTo("") == 0 || (!isPublic.Checked && !isPrivate.Checked))
                {
                    MessageBox.Show("Заполните все поля!");
                }
                else { 
                BookForm.House = new PublishingHouse(NameBox.Text, CountryBox.Text,
                    CityBox.Text, (int)YearBox.Value, isPublic.Checked);
                book.PubHouseBox.Text = BookForm.House.ToString();
                Close();
                    }
            }
            catch(Exception err)
            {
                MessageBox.Show("Проверьте правильность введенных данных!");
            }
        }

        private void PubHouse_Load(object sender, EventArgs e)
        {
            Program.Filler(CountryBox);
        }

        private void NameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void NameBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(NameBox.Text))
            {
                errorProvider1.SetError(NameBox, "заполните строку");
            }
            else
                errorProvider1.Clear();
        }

        private void CityBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar))
                return;
            else
                e.Handled = true;
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
