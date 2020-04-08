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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            drinkDataGriedView.DataSource = Control.bindList;
            this.FormClosing += Save_Click;
            DGVset();
            Add.Click += Add_Click;
            Delete.Click += Delete_Click;
            Change.Click += Change_Click;
            Save.Click += Save_Click;
            drinkDataGriedView.RowHeaderMouseDoubleClick += MoreKnowledge_Click;
        }
        private void Save_Click(object sender, EventArgs e)
        {
            Control.Save();
        }
        private void MoreKnowledge_Click(object sender, EventArgs e)
        {
            if (drinkDataGriedView.SelectedRows.Count != 0) 
            {
                int index = drinkDataGriedView.SelectedRows[0].Index;
                Drink d = Control.bindList.ElementAt(index);
                ViewForm f = new ViewForm(d);
                f.Show();
            }
        }
        private void Change_Click(object sender, EventArgs e)
        {
            if (drinkDataGriedView.SelectedRows.Count != 0)
            {
                int index = drinkDataGriedView.SelectedRows[0].Index;
                Drink d = Control.bindList.ElementAt(index);
                AddForm f = new AddForm(d, index);
                f.Show();
            }
        }
        private void Delete_Click(object sender, EventArgs e)
        {
            if (drinkDataGriedView.SelectedRows.Count != 0)
            {
                int index = drinkDataGriedView.SelectedRows[0].Index;
                Control.Delete(index);
            }
        }
        private void Add_Click(object sender, EventArgs e)
        {
            AddForm f = new AddForm();
            f.Show();
        }
        private void DGVset()
        {
            drinkDataGriedView.Columns[0].HeaderCell.Value = "Тип";
            drinkDataGriedView.Columns[1].HeaderCell.Value = "Сорт";
            drinkDataGriedView.Columns[2].HeaderCell.Value = "Терпкость";
            drinkDataGriedView.Columns[3].HeaderCell.Value = "Цена";
            drinkDataGriedView.Columns[4].HeaderCell.Value = "Вес";
            drinkDataGriedView.RowHeadersWidth = 58;
            for (int i = 0; i < drinkDataGriedView.Columns.Count; i++) 
            {
                drinkDataGriedView.Columns[i].Width = 150;
            }
        
        }
    }
}
