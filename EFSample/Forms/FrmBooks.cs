using EFSample.Models.ORM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFSample.Forms
{
    public partial class FrmBooks : Form
    {
        public FrmBooks()
        {
            InitializeComponent();
        }

        private void FrmBooks_Load(object sender, EventArgs e)
        {
            AkademiLibraryContext db = new AkademiLibraryContext();


            List<Book> books = db.Books.ToList();
            dataGridView1.DataSource = books;

            //kitaplari ada gore sirala
            //List<Book> books = db.Books.OrderBy(x => x.Name).ToList();
            //dataGridView1.DataSource = books;

            //kitaplari ada gore tersten sirala
            //List<Book> books = db.Books.OrderByDescending(x => x.Name).ToList();
            //dataGridView1.DataSource = books;

            //icerisinde a harfi gecen kitaplari getir
            // select * from books where name like '%a%'

            //List<Book> books = db.Books.Where(x => x.Name.Contains('a')).ToList();


            //Kitap fiyati 100 den buyuk olan kitaplari getir
            //List<Book> books2 = db.Books.Where(x => x.UnitPrice > 100).ToList();

            //Kitap fiyati 50 den buyuk 100 den kucuk olan kitaplari getir
            //List<Book> books3 = db.Books.Where(x => x.UnitPrice > 50 && x.UnitPrice < 100).ToList();


        }

        private void btnOrderByName_Click(object sender, EventArgs e)
        {
            AkademiLibraryContext db = new AkademiLibraryContext();
            List<Book> books = db.Books.OrderBy(x => x.Name).ToList();
            dataGridView1.DataSource = books;
        }

        private void btnOrderByDescName_Click(object sender, EventArgs e)
        {
            AkademiLibraryContext db = new AkademiLibraryContext();
            List<Book> books = db.Books.OrderByDescending(x => x.Name).ToList();
            dataGridView1.DataSource = books;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string search = txtSearch.Text.Trim();
            AkademiLibraryContext db = new AkademiLibraryContext();
            //List<Book> books = db.Books.Where(x => x.Name.Contains(search)).ToList();
            List<Book> books = db.Books.Where(x => x.Name.StartsWith(search)).ToList();

            dataGridView1.DataSource = books;
        }

        private void btnSearchByPrice_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtMinPrice.Text) || string.IsNullOrEmpty(txtMaxPrice.Text))
            {
                MessageBox.Show("Please enter min and max price");
                return;
            }   

            //decimal minPrice = Convert.ToDecimal(txtMinPrice.Text);
            //decimal maxPrice = Convert.ToDecimal(txtMaxPrice.Text);
            decimal minPrice = decimal.TryParse(txtMinPrice.Text, out decimal min) ? min : 0;
            decimal maxPrice = decimal.TryParse(txtMaxPrice.Text, out decimal max) ? max : 0;


            AkademiLibraryContext db = new AkademiLibraryContext();
            List<Book> books = db.Books.Where(x => x.UnitPrice >= minPrice && x.UnitPrice <= maxPrice).ToList();

            dataGridView1.DataSource = books;
        }
    }
}
