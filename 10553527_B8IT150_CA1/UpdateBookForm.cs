using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace _10553527_B8IT150_CA1
{
    public partial class UpdateBookForm : Form
    {

        public UpdateBookForm()
        {
            InitializeComponent();
        }

        private void UpdateBookForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDBDataSet.Book' table. You can move, or remove it, as needed.
            this.bookTableAdapter.Fill(this.libraryDBDataSet.Book);
        }

        private void newDataValidating(object sender, CancelEventArgs e)
        {
            int columnIndex = bookGridView.CurrentCell.ColumnIndex;
            string columnName = bookGridView.Columns[columnIndex].HeaderText;

            string newValue = newValueTxt.Text;

            if (string.IsNullOrWhiteSpace(newValueTxt.Text))
            {
                e.Cancel = true;
                valueErrorProvider.SetError(newValueTxt, "Not Null");
                newValueTxt.Focus();
            }

            if (columnName == "IBSN")
            {
                e.Cancel = true;
                valueErrorProvider.SetError(newValueTxt, "Can't Edit IBSN");
                newValueTxt.Focus();
            }
            else if (columnName == "PublicationYear")
            {
                bool validYear = IsValidYear(newValue);

                if (!validYear)
                {
                    e.Cancel = true;
                    valueErrorProvider.SetError(newValueTxt, "Year in YYYY and < " + (DateTime.Now.Year + 1));
                    newValueTxt.Focus();
                }
            }
        }

        private void newDataValidated(object sender, EventArgs e)
        {
            valueErrorProvider.SetError(newValueTxt, string.Empty);
            newValueTxt.Text = newValueTxt.Text.Trim();
            valueErrorProvider.Clear();
        }

        private void editValueBtn_Click(object sender, EventArgs e)
        {
            bool success = this.ValidateChildren();

            if (success)
            {               
                string newValue = newValueTxt.Text;
                string ibsn = bookGridView.CurrentRow.Cells[0].Value.ToString();
                string title = bookGridView.CurrentRow.Cells[1].Value.ToString();
                string author = bookGridView.CurrentRow.Cells[2].Value.ToString();
                string year = bookGridView.CurrentRow.Cells[3].Value.ToString();

                int columnIndex = bookGridView.CurrentCell.ColumnIndex;
                string columnName = bookGridView.Columns[columnIndex].HeaderText;

                BusinessLogic.EditValue(columnName, int.Parse(ibsn), title, author, int.Parse(year), newValue);
            }
            else
            {
                MessageBox.Show("Validation Failed.");
            }

            this.bookTableAdapter.Fill(this.libraryDBDataSet.Book);
        }

        public static bool IsValidIBSN(string ibsn)
        {
            bool status = true;

            if (ibsn != "")
            {
                try
                {
                    Regex engine = new Regex(@"^\b\d{10}\b$");
                    Match match = engine.Match(ibsn);

                    if (!match.Success)
                    {
                        status = false;
                    }
                }
                catch
                {
                    status = false;
                }
            }
            else
            {
                status = false;
            }

            return status;
        }

        public static bool IsValidYear(string year)
        {
            bool status = true;

            if (year != "")
            {
                try
                {
                    Regex engine = new Regex(@"\b\d{4}\b");
                    Match match = engine.Match(year);

                    if (!match.Success)
                    {
                        status = false;
                    }
                }
                catch
                {
                    status = false;
                }

                try
                {
                    int pubYear = int.Parse(year);

                    if (pubYear > DateTime.Now.Year)
                    {
                        status = false;
                    }
                }
                catch
                {
                    status = false;
                }
            }
            else
            {
                status = false;
            }

            return status;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }
    }
}
