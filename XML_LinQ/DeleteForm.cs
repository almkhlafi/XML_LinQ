using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace XML_LinQ
{
    public partial class DeleteForm : Form
    {
        public DeleteForm()
        {
            InitializeComponent();
        }

        private void DeleteForm_Load(object sender, EventArgs e)
        {

        }

        private bool checkIfEmpty(String value)
        {

            bool control = true;

            if (value.Length < 1)
                control = true;

            else
                control = false;


            return control;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {

                String isbn = this.txtISBN.Text;

                if (!checkIfEmpty(isbn))
                {
                    var books = XDocument.Load(@"../../books.xml");

                    DialogResult dialogResult = MessageBox.Show("Do you want to remove ISBN number : " +isbn, "Do you want to delete permanently?", MessageBoxButtons.YesNo);

                    if (dialogResult == DialogResult.Yes) {

                        books.Descendants("book").Where(x => (string)x.Element("isbn") == isbn).Remove();

                        books.Save(@"../../books.xml");

                        MessageBox.Show("Existing record (if it exists) is deleted");
                    }
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show($"XML File reading Error : {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
