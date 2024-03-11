using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CsvHelper;
using System.IO;
using System.Globalization;

namespace Tyuiu.GurbanovYA.Task1.V12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonWrite_YA_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "CSV|*.csv", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (var sw = new StreamWriter(sfd.FileName))
                    {
                        var writer = new CsvWriter(sw, CultureInfo.InvariantCulture);
                        writer.WriteHeader(typeof(Student));
                        foreach (Student s in studentBindingSource.DataSource as List<Student>)
                        {
                            writer.WriteRecord(s);
                        }
                    }
                    MessageBox.Show("Ваши данные были успешно сохранены.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            studentBindingSource.DataSource = new List<Student>();
        }

        private void buttonRead_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog ofd = new OpenFileDialog() { Filter = "CSV|*.csv", ValidateNames = true })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    var sr = new StreamReader(new FileStream(ofd.FileName, FileMode.Open));
                    var csv = new CsvReader(sr, CultureInfo.InvariantCulture);
                    studentBindingSource.DataSource = csv.GetRecords<Student>().ToString();

                }
            }
        }
    }
}
    
