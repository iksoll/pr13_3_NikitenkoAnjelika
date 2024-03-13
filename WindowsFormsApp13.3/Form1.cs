using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp13._3
{
	public partial class Form1 : Form
	{
		private DataGridViewColumn dataGridViewColumn1 = null;
		private DataGridViewColumn dataGridViewColumn2 = null;
		private DataGridViewColumn dataGridViewColumn3 = null;
		private DataGridViewColumn dataGridViewColumn4 = null;
		public Form1()
		{
			InitializeComponent();
		}

		private DataGridViewColumn getdtaGridViewColumn1()
        {
			if (dataGridViewColumn1 == null)
            {
				dataGridViewColumn1 = new DataGridViewTextBoxColumn();
				dataGridViewColumn1.Name = "";
				dataGridViewColumn1.HeaderText = "Пол";
				dataGridViewColumn1.ValueType = typeof(string);
				dataGridViewColumn1.Width = dataGridView1.Width / 4;
            }
			return dataGridViewColumn1;
        }

		private DataGridViewColumn getdataGridViewColumn2()
		{
			if (dataGridViewColumn1 == null)
			{
				dataGridViewColumn1 = new DataGridViewTextBoxColumn();
				dataGridViewColumn1.Name = "";
				dataGridViewColumn1.HeaderText = "Размер";
				dataGridViewColumn1.ValueType = typeof(string);
				dataGridViewColumn1.Width = dataGridView1.Width / 4;
			}
			return dataGridViewColumn1;
		}

		private DataGridViewColumn getdataGridViewColumn3()
		{
			if (dataGridViewColumn1 == null)
			{
				dataGridViewColumn1 = new DataGridViewTextBoxColumn();
				dataGridViewColumn1.Name = "";
				dataGridViewColumn1.HeaderText = "Бренд";
				dataGridViewColumn1.ValueType = typeof(string);
				dataGridViewColumn1.Width = dataGridView1.Width / 4;
			}
			return dataGridViewColumn1;
		}

		private DataGridViewColumn getdataGridViewColumn4()
		{
			if (dataGridViewColumn1 == null)
			{
				dataGridViewColumn1 = new DataGridViewTextBoxColumn();
				dataGridViewColumn1.Name = "";
				dataGridViewColumn1.HeaderText = "Цвет";
				dataGridViewColumn1.ValueType = typeof(string);
				dataGridViewColumn1.Width = dataGridView1.Width / 4;
			}
			return dataGridViewColumn1;
		}

		private void initDataGridView()
		{
			dataGridView1.DataSource = null;
			dataGridView1.Columns.Add(getdtaGridViewColumn1());
			dataGridView1.Columns.Add(getdataGridViewColumn2());
			dataGridView1.Columns.Add(getdataGridViewColumn3());
			dataGridView1.Columns.Add(getdataGridViewColumn4());
			dataGridView1.AutoResizeColumns();
		}

		private void button1_Click(object sender, EventArgs e)
        {
			if (radioButton1.Checked==true)
            {
				dataGridView1.Rows.Add("Женский");
			}
            else if (radioButton2.Checked==true)
            {
				dataGridView1.Rows.Add("Мужской");
			}
			dataGridView1.Rows.Add(numericUpDown1.Text);
			dataGridView1.Rows.Add(textBox1.Text);
			dataGridView1.Rows.Add(textBox2.Text);
		}
    }
}
