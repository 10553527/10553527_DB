using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10553527_B8IT150_CA1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void addBookBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateBookForm createForm = new CreateBookForm();
            createForm.Show();
        }

        private void readBookBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReadBookForm readForm = new ReadBookForm();
            readForm.Show();
        }

        private void updateBookBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpdateBookForm updateForm = new UpdateBookForm();
            updateForm.Show();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
