using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aspose.Cells;
using Slovar.Clases;
using Slovar.MyForms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Slovar
{
    public partial class Form1 : Form
    {
        MyDictionary myDictionary;
        string path;
        TextInput textInput = new TextInput();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            setDictionary();
            this.Activate();
        }

        private void setDictionary() //Иницилизация словаря
        {
            MessageBox.Show("Выберите путь к словарю");
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                path = openFileDialog1.FileName; //Запись пути к файлу словаря
                myDictionary = new MyDictionary(path); //Создание словаря
                myDictionary.InitializeDictionary();
                UpdateItems();
                comboBox1.SelectedIndex = 0;
                comboBox2.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("Отмена операции");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (path == null || path == "")
            {
                MessageBox.Show("Выберите словарь");
                setDictionary();
                return;
            }
            textBox2.Text = myDictionary.Translate(comboBox1.Text, comboBox2.Text, textBox1.Text.Trim().ToLower());
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            myDictionary.Save();
        }

        private void AddLanguageItemClick(object sender, EventArgs e)
        {
            string language = textInput.GetText();
            myDictionary.AddLanguage(language);
            UpdateItems();
        }

        private void AddWordItemClick(object sender, EventArgs e)
        {
            AddWordForm addWord = new AddWordForm(myDictionary);
            addWord.ShowDialog();
        }

        private void ChangeDictionaryItemClick(object sender, EventArgs e)
        {
            setDictionary();
        }
        private void UpdateItems()
        {
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            comboBox1.Items.AddRange(myDictionary.GetLanguages());
            comboBox2.Items.AddRange(myDictionary.GetLanguages());
        }

        private void добавитьПереводToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddTranslationForm addTranslation = new AddTranslationForm(myDictionary);
            addTranslation.ShowDialog();
        }

        private void MakeNewDictionaryStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Введите имя для словаря");
            myDictionary = new MyDictionary(Environment.CurrentDirectory + textInput.GetText() + ".xlsx");
            UpdateItems();
            comboBox1.Text = "Добавьте языки";
            comboBox2.Text = "Добавьте языки";
        }
    }
}
