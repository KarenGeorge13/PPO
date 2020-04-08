using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursedWorkForm
{
    public partial class AddForm : Form
    {
        private string path;
        private int index;
        public AddForm()
        {
            InitializeComponent();
            path = "";
            AddNote.Click += AddNote_Click;
            AddPicture.Click += AddPicture_Click;
        }
        public AddForm(Drink d, int index)  
        {
            InitializeComponent();
            this.index = index;
            Iniz(d);
            if (path != "") 
            {
                AddPicture.Text = "Изменить картинку";
            }
            AddNote.Text = "Изменить";
            AddNote.Click += AddNote_Click1;
            AddPicture.Click += AddPicture_Click;
        }
        private void Iniz(Drink d) 
        {
            comboBox1.Text = d.type;
            textBox2.Text = d.grade;
            textBox3.Text = d.hard;
            textBox4.Text = d.price.ToString();
            textBox5.Text = d.weight.ToString();
            path = d.getPath();
        }
        private void AddNote_Click1(object sender, EventArgs e)
        {
			label7.Visible = false;
			Drink drink = fill();
			if (drink != null)
			{
				Control.Change(index, drink);
				this.Close();
			}
        }
        private void AddPicture_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Файлы изображений|*.png;*.jpg";
            if (openFileDialog1.ShowDialog() != DialogResult.OK)
                return;
            Image img;//= new Bitmap(openFileDialog1.FileName);
            try
            {
                img = Image.FromFile(openFileDialog1.FileName);
            }
            catch (OutOfMemoryException ex)
            {
                MessageBox.Show("Ошибка чтения картинки");
                path = "";
                return;
            }
            BindingList<Drink> bL = Control.bindList;
            Random rand = new Random();
            bool flag = true;
            while (flag)
            {
                path = "image\\" + rand.Next(1, 100000) + ".png";
                if (bL.Count == 0) { break; }
                for (int i = 0; i < bL.Count; i++)
                {
                    if (bL.ElementAt(i).getPath() == path)
                    {
                        break;
                    }
                    if (i == bL.Count - 1)
                    {
                        flag = false;
                    }
                }
            }
            img.Save(path);
			AddPicture.Text = "Изменить картинку";
        }
        private void AddNote_Click(object sender, EventArgs e)
        {
            label7.Visible = false;
			Drink drink = fill();
			if (drink != null)
			{
				Control.Add(drink);
				comboBox1.Text = "";
				textBox2.Text = "";
				textBox3.Text = "";
				textBox4.Text = "";
				textBox5.Text = "";
				path = "";
				AddPicture.Text = "Добавить картинку";
			}
        }
		private Drink fill()
		{
			bool flag = true;
			string type = "", grade = "", hard = "", picture_path;
			double price = 0, weight = 0;
			if (comboBox1.Text != "")
			{
				label1.ForeColor = Color.Black;
				type = comboBox1.Text;
			}
			else
			{
				label1.ForeColor = Color.Red;
				flag = false;
			}
			if (textBox2.Text != "")
			{
				label2.ForeColor = Color.Black;
				grade = textBox2.Text;
			}
			else
			{
				label2.ForeColor = Color.Red;
				flag = false;
			}
			if (textBox3.Text != "")
			{
				label3.ForeColor = Color.Black;
				hard = textBox3.Text;
			}
			else
			{
				label3.ForeColor = Color.Red;
				flag = false;
			}
			if (textBox4.Text != "")
			{
				if (Double.TryParse(textBox4.Text, out price))
				{
					label4.ForeColor = Color.Black;
				}
				else
				{
					label4.ForeColor = Color.Red;
					label7.Visible = true;
					flag = false;
				}
			}
			else
			{
				label4.ForeColor = Color.Red;
				flag = false;
			}
			if (textBox5.Text != "")
			{
				if (Double.TryParse(textBox5.Text, out weight))
				{
					label5.ForeColor = Color.Black;
				}
				else
				{
					label5.ForeColor = Color.Red;
					label7.Visible = true;
					flag = false;
				}
			}
			else
			{
				label5.ForeColor = Color.Red;
				flag = false;
			}
			picture_path = path;
			if (flag)
			{
				return new Drink(type, grade, hard, weight, price, picture_path);
			}
			else
			{
				return null;
			}
		}
	}
	
}
