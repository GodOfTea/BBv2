using BlackBooks;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderForma
{
    public partial class BookDeteilsForm : Form
    {
        public BookGener bg { get; set; }
        public BookPrice bp { get; set; }
        public BookPresence bpre { get; set; }
        public BookAuthor ba { get; set; }
        public BookTitle bt { get; set; }
        public BookDeteilsForm(BookTitle bt, BookAuthor ba, BookGener bg, BookPrice bp, BookPresence bpre)
        {
            this.bt = bt;
            this.ba = ba;
            this.bg = bg;
            this.bp = bp;
            this.bpre = bpre;
            InitializeComponent();
            GenreBox.DataSource = Enum.GetValues(typeof(Genre));
        }

        private void TitleBox_TextChanged(object sender, EventArgs e)
        {
            if (String.Equals(TitleBox.Text, ""))
                button1.Enabled = false;
            else
            {
                foreach (var c in TitleBox.Text)
                {
                    if (!Char.IsLetter(c))
                    {
                        button1.Enabled = false;
                    }
                    else button1.Enabled = true;
                }
            }
        }

        private void GenereBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            GenreBox.SelectedItem.ToString();
            bg.Genre = (Genre)GenreBox.SelectedItem;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bt.Title = TitleBox.Text;
            ba.Author = textBox1.Text;
            bp.Price = (double)PriceNumericUpDown.Value;       
        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            bpre.Presence = CheckBox.Checked;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (String.Equals(textBox1.Text, ""))
                button1.Enabled = false;
            else
            {
                foreach (var c in textBox1.Text)
                {
                    if (!Char.IsLetter(c))
                    {
                        button1.Enabled = false;
                    }
                    else button1.Enabled = true;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ////////////////////////////////////////////////
        }
    }
}

