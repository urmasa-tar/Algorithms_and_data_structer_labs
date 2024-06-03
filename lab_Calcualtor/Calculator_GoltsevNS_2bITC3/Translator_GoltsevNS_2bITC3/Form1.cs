using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Translator_GoltsevNS_2bITC3
{
    public partial class Form1 : Form
    {

        private void SetItem(List<string> colmns)
        {
            cmbBoxFrom.DataSource = colmns;
            cmbBoxTo.DataSource = colmns;
        }

        IEnumerable<string> lines;
        public Form1()
        {
            InitializeComponent();
            // SetItem();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnNewDict_Click(object sender, EventArgs e)
        {
            OpenFileDialog inpReaderDiolog = new OpenFileDialog
            {
                Title = "Open CSV File",
                Filter = "csv file (.csv)|*.csv",
                CheckFileExists = true,
                CheckPathExists = true
            };

            if(inpReaderDiolog.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(inpReaderDiolog.FileName);
                IEnumerable<string> lines = File.ReadLines(inpReaderDiolog.FileName);
                SetItem();
            }
        }
    }
}
