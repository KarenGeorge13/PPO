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
            dataGridView1.DataSource = Control.bindList;
            this.FormClosing += Save_Click;
            DGVset();
            Add.Click += Add_Click;
            Delete.Click += Delete_Click;
            Change.Click += Change_Click;
            Save.Click += Save_Click;
            dataGridView1.RowHeaderMouseDoubleClick += MoreKnowledge_Click;
        }
        private void Save_Click(object sender, EventArgs e)
        {
            Control.Save();
        }
        private void MoreKnowledge_Click(object sender, EventArgs e)
        {
            DataGridViewRow row;
            int index = -1;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                row = dataGridView1.Rows[i];
                if (dataGridView1.SelectedRows.Contains(row))
                {
                    index = i;
                    break;
                }
            }
            if (index != -1)
            {
                Drink d = Control.bindList.ElementAt(index);
                ViewForm f = new ViewForm(d);
                f.Show();
            }
        }
        private void Change_Click(object sender, EventArgs e)
        {
            DataGridViewRow row;
            int index = -1;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                row = dataGridView1.Rows[i];
                if (dataGridView1.SelectedRows.Contains(row))
                {
                    index = i;
                    break;
                }
            }
            if (index != -1)
            {
                Drink d = Control.bindList.ElementAt(index);
                AddForm f = new AddForm(d, index);
                f.Show();
            }
        }
        private void Delete_Click(object sender, EventArgs e)
        {
            DataGridViewRow row;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                row = dataGridView1.Rows[i];
                if (dataGridView1.SelectedRows.Contains(row))
                {
                    Control.Delete(i);
                    break;
                }
            }
        }
        private void Add_Click(object sender, EventArgs e)
        {
            AddForm f = new AddForm();
            f.Show();
        }
        private void DGVset()
        {
            dataGridView1.Columns[0].HeaderCell.Value = "Тип";
            dataGridView1.Columns[1].HeaderCell.Value = "Сорт";
            dataGridView1.Columns[2].HeaderCell.Value = "Терпкость";
            dataGridView1.Columns[3].HeaderCell.Value = "Цена";
            dataGridView1.Columns[4].HeaderCell.Value = "Вес";
            dataGridView1.RowHeadersWidth = 58;
            for (int i = 0; i < dataGridView1.Columns.Count; i++) 
            {
                dataGridView1.Columns[i].Width = 150;
            }
        
        }
    }
}
