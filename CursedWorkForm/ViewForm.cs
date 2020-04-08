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
    public partial class ViewForm : Form
    {
        public ViewForm(Drink d)
        {
            InitializeComponent();
            TextFull(d);
        }
        private void TextFull(Drink d) 
        {
            drinkType.Text = d.type;
            drinkGrade.Text = d.grade;
            drinkHard.Text = d.hard;
            drinkPrice.Text = d.price.ToString();
            drinkWeight.Text = d.weight.ToString();
            try
            {
                Image img = new Bitmap(new Bitmap(d.getPath()), 300, 300);
                DrinkPictureBox.Image = img;
            }
            catch (Exception e)
            {
                Image img = new Bitmap(new Bitmap("image\\banned.png"), 300, 300);
                DrinkPictureBox.Image = img;
                return;
            }
        }
    }
}
