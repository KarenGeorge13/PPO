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
            AddNote.Click += ChangeNote_Click;
            AddPicture.Click += AddPicture_Click;
        }
        private void Iniz(Drink d) 
        {
            drinkTypeChose.Text = d.type;
            drinkGrade.Text = d.grade;
            drinkHard.Text = d.hard;
            drinkPrice.Text = d.price.ToString();
            drinkWeight.Text = d.weight.ToString();
            path = d.getPath();
        }
        private void ChangeNote_Click(object sender, EventArgs e)
        {
			labelIncorrectInput.Visible = false;
			Drink drink = fill();
			if (drink != null)
			{
				Control.Change(index, drink);
				this.Close();
			}
        }
        private void AddPicture_Click(object sender, EventArgs e)
        {
            searchPicture.Filter = "Файлы изображений|*.png;*.jpg";
            if (searchPicture.ShowDialog() != DialogResult.OK)
                return;
            Image img;//= new Bitmap(openFileDialog1.FileName);
            try
            {
                img = Image.FromFile(searchPicture.FileName);
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
            labelIncorrectInput.Visible = false;
			Drink drink = fill();
			if (drink != null)
			{
				Control.Add(drink);
				drinkTypeChose.Text = "";
				drinkGrade.Text = "";
				drinkHard.Text = "";
				drinkPrice.Text = "";
				drinkWeight.Text = "";
				path = "";
				AddPicture.Text = "Добавить картинку";
			}
        }
		private Drink fill()
		{
			bool flag = true;
			string type = "", grade = "", hard = "", picture_path;
			double price = 0, weight = 0;
			if (drinkTypeChose.Text != "")
			{
				labelDrinkType.ForeColor = Color.Black;
				type = drinkTypeChose.Text;
			}
			else
			{
				labelDrinkType.ForeColor = Color.Red;
				flag = false;
			}
			if (drinkGrade.Text != "")
			{
				labelDrinkGrade.ForeColor = Color.Black;
				grade = drinkGrade.Text;
			}
			else
			{
				labelDrinkGrade.ForeColor = Color.Red;
				flag = false;
			}
			if (drinkHard.Text != "")
			{
				labelDrinkHard.ForeColor = Color.Black;
				hard = drinkHard.Text;
			}
			else
			{
				labelDrinkHard.ForeColor = Color.Red;
				flag = false;
			}
			if (drinkPrice.Text != "")
			{
				if (Double.TryParse(drinkPrice.Text, out price))
				{
					labelDrinkPrice.ForeColor = Color.Black;
				}
				else
				{
					labelDrinkPrice.ForeColor = Color.Red;
					labelIncorrectInput.Visible = true;
					flag = false;
				}
			}
			else
			{
				labelDrinkPrice.ForeColor = Color.Red;
				flag = false;
			}
			if (drinkWeight.Text != "")
			{
				if (Double.TryParse(drinkWeight.Text, out weight))
				{
					labelDrinkWeight.ForeColor = Color.Black;
				}
				else
				{
					labelDrinkWeight.ForeColor = Color.Red;
					labelIncorrectInput.Visible = true;
					flag = false;
				}
			}
			else
			{
				labelDrinkWeight.ForeColor = Color.Red;
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
