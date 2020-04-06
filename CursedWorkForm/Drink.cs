using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursedWorkForm
{
    public class Drink
    {
        public string type { get; }// чай или кофе
        public string grade { get; } // сорт
        public string hard { get; } // терпкость
        public double price { get; } // цена
        public double weight { get; } // вес
        private string picture_path;// путь к картинке

        public Drink(string type, string grade, string hard, double weight, double price, string picture_path = "guir")
        {
            this.type = type;
            this.grade = grade;
            this.hard = hard;
            this.weight = weight;
            this.price = price;
            this.picture_path = picture_path;
        }
        public string getPath() 
        {
            return picture_path;
        }
        public override string ToString()
        {
            string str = type + ";" + grade + ";" + hard + ";" + price + ";" + weight + ";" + picture_path;
            return str;
        }
    }
}
