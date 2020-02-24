using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Army
{
    public partial class Form1 : Form
    {
        editMan man;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Иностранный". При необходимости она может быть перемещена или удалена.
            this.иностранныйTableAdapter.Fill(this.database1DataSet.Иностранный);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Учеба". При необходимости она может быть перемещена или удалена.
            this.учебаTableAdapter.Fill(this.database1DataSet.Учеба);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Состав_семьи". При необходимости она может быть перемещена или удалена.
            this.состав_семьиTableAdapter.Fill(this.database1DataSet.Состав_семьи);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Главная". При необходимости она может быть перемещена или удалена.
            this.главнаяTableAdapter.Fill(this.database1DataSet.Главная);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Подразделение". При необходимости она может быть перемещена или удалена.
            this.подразделениеTableAdapter.Fill(this.database1DataSet.Подразделение);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Подразделение". При необходимости она может быть перемещена или удалена.
            this.подразделениеTableAdapter.Fill(this.database1DataSet.Подразделение);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Иностранный". При необходимости она может быть перемещена или удалена.
            this.иностранныйTableAdapter.Fill(this.database1DataSet.Иностранный);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Учеба". При необходимости она может быть перемещена или удалена.
            this.учебаTableAdapter.Fill(this.database1DataSet.Учеба);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Состав_семьи". При необходимости она может быть перемещена или удалена.
            this.состав_семьиTableAdapter.Fill(this.database1DataSet.Состав_семьи);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Главная". При необходимости она может быть перемещена или удалена.
            this.главнаяTableAdapter.Fill(this.database1DataSet.Главная);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            man = new editMan(-1);
            man.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try {
                man = new editMan(dataGridView2.CurrentRow, dataGridView6.CurrentRow.Cells[0].Value.ToString());
                man.Show();
            } catch (Exception ex) { MessageBox.Show("Ошибка при попытке изменить выбранного служащего"); }
        }
    }
}
