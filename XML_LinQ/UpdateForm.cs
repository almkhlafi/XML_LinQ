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
    public partial class UpdateForm : Form
    {
        public UpdateForm()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtISBN.Clear();
            txtAuthor.Clear();
            txtTitle.Clear();
            comboYear.SelectedIndex = 0;
        }

        private void brnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            String isbn = this.txtISBN.Text;
            String author = this.txtAuthor.Text;
            String title = this.txtTitle.Text;
            String yearStr = this.comboYear.SelectedItem.ToString();

            try
            {
                var books = XDocument.Load(@"../../books.xml");
                String updateID = isbn;

                var items = from item in books.Descendants("book")
                            where item.Element("isbn").Value == updateID
                            select item;

                foreach (XElement itemElement in items) {

                    itemElement.SetElementValue("author", author);
                    itemElement.SetElementValue("title", title);
                    itemElement.SetElementValue("year", yearStr);
                }

                books.Save(@"../../books.xml");

                MessageBox.Show("Update completed");



            }
            catch (Exception ex)
            {

                MessageBox.Show($"XML File reading : {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void UpdateForm_Load(object sender, EventArgs e)
        {
            comboYear.DropDownStyle = ComboBoxStyle.DropDown;

            for (int i = 1900; i <= 2021; i++)
                comboYear.Items.Add(i);
        }
    }
}
