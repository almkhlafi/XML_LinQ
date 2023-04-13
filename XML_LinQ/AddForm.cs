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
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        private void AddForm_Load(object sender, EventArgs e)
        {
            comboYear.DropDownStyle = ComboBoxStyle.DropDown;

            for (int i = 1900; i <= 2021; i++)
                comboYear.Items.Add(i);
        }

        private void brnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtISBN.Clear();
            txtAuthor.Clear();
            txtTitle.Clear();
            comboYear.SelectedIndex = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            try
            {

                String isbn = this.txtISBN.Text;
                String author = this.txtAuthor.Text;
                String title = this.txtTitle.Text;
                String yearStr = this.comboYear.SelectedItem.ToString();

                if ((!checkIfEmpty(isbn)) && (!checkIfEmpty(author)) && (!checkIfEmpty(title)))
                {
                    var books = XDocument.Load(@"../../books.xml");

                    var newElement = new XElement("book",
                                new XElement("isbn", isbn),
                                new XElement("title", title),
                                new XElement("author", author),
                                new XElement("year", yearStr));

                    books.Element("listofbooks").Add(newElement);

                    books.Save(@"../../books.xml");

                    MessageBox.Show("New Record is added");

                    /*close the form automatically and refresh the first form*/
                }
                else
                    MessageBox.Show("Please fill all of the fields", "You left fields empty", 
                        MessageBoxButtons.OK,MessageBoxIcon.Warning);


            }
            catch (Exception ex)
            {

                MessageBox.Show($"XML File reading : {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }


        private bool checkIfEmpty(String value) {

            bool control = true;

            if (value.Length < 1)
                control = true;
           
            else
                control = false;


            return control;
        }

      
    }
}
