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
            textBox1.Text = d.type;
            textBox2.Text = d.grade;
            textBox3.Text = d.hard;
            textBox4.Text = d.price.ToString();
            textBox5.Text = d.weight.ToString();
            try
            {
                Image img = new Bitmap(new Bitmap(d.getPath()), 300, 300);
                pictureBox1.Image = img;
            }
            catch (Exception e)
            {
                Image img = new Bitmap(new Bitmap("image\\banned.png"), 300, 300);
                pictureBox1.Image = img;
                return;
            }
        }
    }
}
