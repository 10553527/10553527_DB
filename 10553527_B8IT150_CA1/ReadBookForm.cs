using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace _10553527_B8IT150_CA1
{
    public partial class ReadBookForm : Form
    {
        List<Book> books = new List<Book>();

        public ReadBookForm()
        {
            InitializeComponent();
            UpdateBinding();
        }

        private void UpdateBinding()
        {
            readBookListbox.DataSource = books;
            readBookListbox.DisplayMember = "Title";
        }

        private void titleValidating(object sender, CancelEventArgs e)
        {
            e.Cancel = false;

            if (string.IsNullOrWhiteSpace(titleTxt.Text))
            {
                e.Cancel = true;
                nullErrorProvider.SetError(titleTxt, "Title Required");
            }
        }

        private void titleValidated(object sender, EventArgs e)
        {
            nullErrorProvider.SetError(titleTxt, string.Empty);
            titleTxt.Text = titleTxt.Text.Trim();
            nullErrorProvider.Clear();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            books = BusinessLayer.BusinessLogic.GetBook(titleTxt.Text);
            UpdateBinding();
        }

        private void showAllBtn_Click(object sender, EventArgs e)
        {
            books = BusinessLayer.BusinessLogic.GetBooks();
            UpdateBinding();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            string title = readBookListbox.GetItemText(readBookListbox.SelectedItem);
            BusinessLayer.BusinessLogic.DeleteBook(title);
            UpdateBinding();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }
    }
}
