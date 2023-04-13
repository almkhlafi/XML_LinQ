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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Name = "Form1";
        }

        private void btnCreateXML_Click(object sender, EventArgs e)
        {
            try
            {
                XDocument doc = new XDocument(
                    new XDeclaration("1.0", "utf-8", "yes"),
                    new XComment("books xml"),
                        new XElement("listofbooks",

                                new XElement("book",
                                new XElement("isbn", "111"),
                                new XElement("title", "Introduction to C#"),
                                new XElement("author", "Abdulrahman Almkhlafi"),
                                new XElement("year", "2021")),

                                new XElement("book",
                                new XElement("isbn", "222"),
                                new XElement("title", "Fellowship of the Ring"),
                                new XElement("author", "J.R.R. Tolkien"),
                                new XElement("year", "1954"))
                       ));

                doc.Save(@"../../books.xml");

                MessageBox.Show("XML File Created");
            }
            catch (Exception ex) {

                MessageBox.Show($"XML File saving error: {ex.Message}","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);

            }


            

        }

        private void btnShowXML_Click(object sender, EventArgs e)
        {
            try
            {
                XElement books = XElement.Load(@"../../books.xml");
                richTextBoxXML.Text = books.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show($"XML File reading : {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnAddXML_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm();
            addForm.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteForm deleteForm = new DeleteForm();
            deleteForm.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateForm updateForm = new UpdateForm();
            updateForm.Show();
        }
    }
}
