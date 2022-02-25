using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Data.SqlClient;
using BusinessLayer;
using Model;
using System.Text.RegularExpressions;

namespace _10553527_B8IT150_CA1
{
    public partial class CreateBookForm : Form
    {
        public CreateBookForm()
        {
            InitializeComponent();
        }

        private void ibsnValidating(object sender, CancelEventArgs e)
        {
            e.Cancel = false;

            if (string.IsNullOrWhiteSpace(ibsnTxt.Text))
            {
                e.Cancel = true;
                nullErrorProvider.SetError(ibsnTxt, "IBSN Required");
            }
            else
            {
                bool success = IsValidIBSN(ibsnTxt.Text);

                if (!success)
                {
                    e.Cancel = true;
                    digitErrorProvider.SetError(ibsnTxt, "IBSN as 10 Digits");
                }
            }
        }

        private void ibsnValidated(object sender, EventArgs e)
        {
            nullErrorProvider.SetError(ibsnTxt, string.Empty);
            ibsnTxt.Text = ibsnTxt.Text.Trim();
            nullErrorProvider.Clear();

            digitErrorProvider.SetError(ibsnTxt, string.Empty);
            ibsnTxt.Text = ibsnTxt.Text.Trim();
            digitErrorProvider.Clear();
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

        private void authorValidating(object sender, CancelEventArgs e)
        {
            e.Cancel = false;

            if (string.IsNullOrWhiteSpace(authorTxt.Text))
            {
                e.Cancel = true;
                nullErrorProvider.SetError(authorTxt, "Author Required");
            }           
        }

        private void authorValidated(object sender, EventArgs e)
        {
            nullErrorProvider.SetError(authorTxt, string.Empty);
            authorTxt.Text = authorTxt.Text.Trim();
            nullErrorProvider.Clear();
        }

        private void pubYearValidating(object sender, CancelEventArgs e)
        {
            e.Cancel = false;

            if (string.IsNullOrWhiteSpace(yearTxt.Text))
            {
                e.Cancel = true;                
                nullErrorProvider.SetError(yearTxt, "Year Required");
            }
            else
            {
                bool success = IsValidYear(yearTxt.Text);

                if (!success)
                {
                    e.Cancel = true;
                    dateErrorProvider.SetError(yearTxt, "Year in YYYY and < " + (DateTime.Now.Year + 1));
                }
            }
        }

        private void pubYearValidated(object sender, EventArgs e)
        {
            nullErrorProvider.SetError(yearTxt, string.Empty);
            yearTxt.Text = yearTxt.Text.Trim();
            nullErrorProvider.Clear();

            dateErrorProvider.SetError(yearTxt, "");
            yearTxt.Text = yearTxt.Text.Trim();
            dateErrorProvider.Clear();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            bool success = this.ValidateChildren();

            if (success)
            {
                BusinessLogic.CreateBook(int.Parse(ibsnTxt.Text), titleTxt.Text, authorTxt.Text, int.Parse(yearTxt.Text));
            }
            else
            {
                MessageBox.Show("Validation Failed.");
            }
        }

        public static bool IsValidIBSN (string ibsn)
        {
            bool status = true;

            if(ibsn != "")
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
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Close();
        }
    }        
}
