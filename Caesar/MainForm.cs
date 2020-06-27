using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encryption
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        private Alphabet GenerationAlphabet()
        {
            Alphabet Alphabet = (elem_RU.Checked) ? Alphabet.Cyrillic : Alphabet.Latin;
            List<Char> Chars = Caesar.GetAlphabet(Alphabet);

            elem_alphabet.Text = Chars.Select(i => i.ToString()).Aggregate((result, item) => result + " " + item) + "\n";

            for (int i = (Chars.Count - (int)elem_key.Value); i < Chars.Count; i++)
            {
                elem_alphabet.Text += Chars[i].ToString() + " ";
            }

            for (int i = 0; i < (Chars.Count - (int)elem_key.Value); i++)
            {
                elem_alphabet.Text += Chars[i].ToString() + " ";
            }

            elem_alphabet.Text = elem_alphabet.Text.Remove(elem_alphabet.Text.Length - 1, 1);

            return Alphabet;
        }

        /// <summary>
        /// Загрузка формы
        /// </summary>
        private void MainForm_Load(Object sender, EventArgs e)
        {
            GenerationAlphabet();
        }

        /// <summary>
        /// Шифровка даннных
        /// </summary>
        private void elem_encrypt_Click(Object sender, EventArgs e)
        {
            GenerationAlphabet();
            elem_cipherText.Text = Caesar.Encrypt(elem_sourceText.Text, (int)elem_key.Value);
        }

        /// <summary>
        /// Очистка данных
        /// </summary>
        private void elem_clear_Click(Object sender, EventArgs e)
        {
            elem_cipherText.Clear();
            elem_sourceText.Clear();
            elem_key.Value = 0;

            elem_sourceText.Focus();
        }

        /// <summary>
        /// Зарпет ввода букв в зависимости от выбранного языка
        /// </summary>
        private void elem_sourceText_KeyPress(Object sender, KeyPressEventArgs e)
        {
            if (elem_RU.Checked)
            {
                if (e.KeyChar >= 'A' && e.KeyChar <= 'Z' || e.KeyChar >= 'a' && e.KeyChar <= 'z')
                    e.Handled = true;
            }
            else
            {
                if (e.KeyChar >= 'А' && e.KeyChar <= 'Я' || e.KeyChar >= 'а' && e.KeyChar <= 'я')
                    e.Handled = true;
            }
        }

        private void elem_sourceText_KeyUp(Object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                elem_encrypt_Click(sender, e);
            }
        }

        private void elem_key_ValueChanged(Object sender, EventArgs e)
        {
            GenerationAlphabet();
        }

        private void elem_key_KeyUp(Object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                elem_encrypt_Click(sender, e);
            }
        }

        private void elem_RU_CheckedChanged(Object sender, EventArgs e)
        {
            elem_key.Maximum = 32;
            GenerationAlphabet();

            elem_cipherText.Clear();
            elem_sourceText.Clear();
            elem_sourceText.Focus();
        }

        private void elem_EN_CheckedChanged(Object sender, EventArgs e)
        {
            elem_key.Maximum = 25;
            GenerationAlphabet();

            elem_cipherText.Clear();
            elem_sourceText.Clear();
            elem_sourceText.Focus();
        }
    }
}
