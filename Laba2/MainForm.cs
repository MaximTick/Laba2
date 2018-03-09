using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;

namespace Laba2
{
    public partial class MainForm : Form
    {
        Library library;

        internal Library Library { get => library; set => library = value; }

        public MainForm()
        {
            InitializeComponent();
            Library = new Library();
        }


        private void CreateBook_Click(object sender, EventArgs e)
        {
            BookForm book = new BookForm(this);
            book.Show();
        }

        private void SaveInFileMeth(object sender, EventArgs e)
        {
            XmlSerializer ser = new XmlSerializer(typeof(Library));

            using(FileStream file = new FileStream("Library.xml", FileMode.Create))
            {
                ser.Serialize(file, Library);
            }
        }

        private void ReadFromFileMet(object sender, EventArgs e)
        {
            XmlSerializer deser = new XmlSerializer(typeof(Library));
            Library a;

            using(FileStream file = new FileStream("Library.xml", FileMode.Open))
            {
                a = (Library)deser.Deserialize(file);
            }
            foreach (var b in a.list)
                MessageBox.Show(b.ToString());
        }

       
    }
}
