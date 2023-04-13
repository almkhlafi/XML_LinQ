namespace XML_LinQ
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCreateXML = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnShowXML = new System.Windows.Forms.Button();
            this.richTextBoxXML = new System.Windows.Forms.RichTextBox();
            this.btnAddXML = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreateXML
            // 
            this.btnCreateXML.Location = new System.Drawing.Point(18, 49);
            this.btnCreateXML.Name = "btnCreateXML";
            this.btnCreateXML.Size = new System.Drawing.Size(377, 51);
            this.btnCreateXML.TabIndex = 0;
            this.btnCreateXML.Text = "Create XML ";
            this.btnCreateXML.UseVisualStyleBackColor = true;
            this.btnCreateXML.Click += new System.EventHandler(this.btnCreateXML_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnAddXML);
            this.groupBox1.Controls.Add(this.richTextBoxXML);
            this.groupBox1.Controls.Add(this.btnShowXML);
            this.groupBox1.Controls.Add(this.btnCreateXML);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1075, 465);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "XML Linq Exercise";
            // 
            // btnShowXML
            // 
            this.btnShowXML.Location = new System.Drawing.Point(18, 126);
            this.btnShowXML.Name = "btnShowXML";
            this.btnShowXML.Size = new System.Drawing.Size(377, 51);
            this.btnShowXML.TabIndex = 1;
            this.btnShowXML.Text = "Display XML File";
            this.btnShowXML.UseVisualStyleBackColor = true;
            this.btnShowXML.Click += new System.EventHandler(this.btnShowXML_Click);
            // 
            // richTextBoxXML
            // 
            this.richTextBoxXML.Location = new System.Drawing.Point(567, 33);
            this.richTextBoxXML.Name = "richTextBoxXML";
            this.richTextBoxXML.Size = new System.Drawing.Size(480, 413);
            this.richTextBoxXML.TabIndex = 2;
            this.richTextBoxXML.Text = "";
            // 
            // btnAddXML
            // 
            this.btnAddXML.Location = new System.Drawing.Point(18, 206);
            this.btnAddXML.Name = "btnAddXML";
            this.btnAddXML.Size = new System.Drawing.Size(377, 51);
            this.btnAddXML.TabIndex = 3;
            this.btnAddXML.Text = "Add to XML File ";
            this.btnAddXML.UseVisualStyleBackColor = true;
            this.btnAddXML.Click += new System.EventHandler(this.btnAddXML_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(18, 290);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(377, 51);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete from XML File ";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(18, 374);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(377, 51);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update in XML File ";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 489);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreateXML;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox richTextBoxXML;
        private System.Windows.Forms.Button btnShowXML;
        private System.Windows.Forms.Button btnAddXML;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
    }
}

