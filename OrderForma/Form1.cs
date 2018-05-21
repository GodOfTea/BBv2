using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BlackBooks;

namespace OrderForma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        BookRequestDto GetModelFromUI()
        {
            return new BookRequestDto()
            {
                Filled = FilledData.Value,
                Price = PriceNumericUpDown.Value,
                Delivery = DeliveryData.Value,
                FullName = FullNameBox.Text,
                Addres = AdressBox.Text,
                BookTitles = listBox1.Items.OfType<BookTitle>().ToList(),
                BookAuthors = listBox2.Items.OfType<BookAuthor>().ToList(),
                BookGeneres = listBox3.Items.OfType<BookGener>().ToList(),
                BookPrices = listBox4.Items.OfType<BookPrice>().ToList(),
                BookPresences = listBox5.Items.OfType<BookPresence>().ToList(),
            };
        }

        private void SetModelToUI (BookRequestDto dto)
        {
            FilledData.Value = dto.Filled;
            PriceNumericUpDown.Value = dto.Price;
            DeliveryData.Value = dto.Delivery;
            FullNameBox.Text = dto.FullName;
            AdressBox.Text = dto.Addres;
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            listBox5.Items.Clear();
            foreach (var e in dto.BookTitles)
            {
                listBox1.Items.Add(e);
            }
            foreach (var e1 in dto.BookAuthors)
            {
                listBox2.Items.Add(e1);
            }
            foreach (var e2 in dto.BookGeneres)
            {
                listBox3.Items.Add(e2);
            }
            foreach (var e3 in dto.BookPrices)
            {
                listBox4.Items.Add(e3);
            }
            foreach (var e4 in dto.BookPresences)
            {
                listBox5.Items.Add(e4);
            }

        }


        private void SaveButton_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog() { Filter = "Файлы заказов|*.blackbook" };
            var result = sfd.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                var dto = GetModelFromUI();
                BooksDtoHelper.WriteToFile(sfd.FileName, dto);
            }
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog() { Filter = "Файл заказа|*.blackbook" };
            var result = ofd.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                var dto = BooksDtoHelper.LoadFromFile(ofd.FileName);
                SetModelToUI(dto);
            }
        }

        private void PluseButton_Click(object sender, EventArgs e)
        {
            var form1 = new BookDeteilsForm(new BookTitle(), new BookAuthor(), new BookGener(), new BookPrice(), new BookPresence());
            var res = form1.ShowDialog(this);
            if (res == DialogResult.OK)
            {
                listBox1.Items.Add(form1.bt.Title);
                listBox2.Items.Add(form1.ba.Author);
                listBox3.Items.Add(form1.bg.Genre);
                listBox4.Items.Add(form1.bp.Price);
                listBox5.Items.Add(form1.bpre.Presence);
                RecalculatePrice();
            }
        }


        private void RecalculatePrice()
        {
            var dto = GetModelFromUI();
            double price = 0;
            foreach (double e in listBox4.Items)
            {
                price += e;
                
            }
            PriceNumericUpDown.Value = (decimal)price;
        }



        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            ////////////////////////////////////////////////////
        }

        private void label8_Click(object sender, EventArgs e)
        {
            /////////////////////////////////////////////////
        }

        private void DeliveryData_ValueChanged(object sender, EventArgs e)
        {
            //////////////////////////////////////////////////
        }

        private void FullNameBox_TextChanged(object sender, EventArgs e)
        {
            if (String.Equals(FullNameBox.Text, ""))
                SaveButton.Enabled = false;
            else
            {
                foreach (char c in FullNameBox.Text)
                {
                    if (!Char.IsLetter(c))
                    {
                        SaveButton.Enabled = false;
                    }
                    else SaveButton.Enabled = true;
                }
            }
        }        
        private void AdressBox_TextChanged(object sender, EventArgs e)
        {
            if (String.Equals(AdressBox.Text, ""))
                SaveButton.Enabled = false;
            else
            {
                foreach (char c in AdressBox.Text)
                {
                    if (!Char.IsLetter(c))
                    {
                        SaveButton.Enabled = false;
                    }
                    else SaveButton.Enabled = true;
                }
            }
        }

        private void MinusButton_Click(object sender, EventArgs e)
        {
            var last = listBox1.SelectedIndex;
            listBox1.Items.RemoveAt(last);
            RecalculatePrice();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ////////////////////////////////////////////////
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            /////////////////////////////////////////////////
        }
    }
}
