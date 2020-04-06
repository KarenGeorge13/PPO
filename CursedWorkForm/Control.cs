using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace CursedWorkForm
{
    static class Control
    {
        private static string path;// путь к файлу с данными
        public static BindingList<Drink> bindList { get; }
        static Control()
        {
            bindList = new BindingList<Drink>();
            path = "datebase.txt";
            if (File.Exists(path))
            {
                string[] str = File.ReadAllLines(path);
                for (int i = 0; i < str.Length; i++)
                {
                    string[] bufstr = str[i].Split(';');
                    bindList.Add(new Drink(bufstr[0], bufstr[1], bufstr[2], Convert.ToInt32(bufstr[3]), Convert.ToInt32(bufstr[4]), bufstr[5]));
                }
            }
            else
            {
                File.WriteAllText(path, "");
            }
        }
        public static void Add(Drink obj)
        {
            bindList.Add(obj);
        }
        public static void Delete(int pos)
        {
            if (bindList.ElementAt(pos).getPath() != "")
            {
                File.Delete(bindList.ElementAt(pos).getPath());
            }
            bindList.RemoveAt(pos);
        }
        public static void Change(int pos, Drink changeDrink)
        {
            if (bindList.ElementAt(pos).getPath() != "" && bindList.ElementAt(pos).getPath() != changeDrink.getPath())
            {
                File.Delete(bindList.ElementAt(pos).getPath());
            }
            bindList.RemoveAt(pos);
            bindList.Insert(pos, changeDrink);
        }
        public static void Save()
        {
            string[] str = new string[bindList.Count];
            for (int i = 0; i < bindList.Count; i++)
            {
                str[i] = bindList.ElementAt(i).ToString();
            }
            File.WriteAllLines(path, str);
            //сохранение списка
        }
    }
}
