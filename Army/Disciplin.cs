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
    public partial class Disciplin : Form
    {
        int id = -1;
        int idWho = -1;
        DataGridViewRow currentRow = null;

        public Disciplin(int idWho)
        {
            InitializeComponent();
            this.idWho = idWho;
        }

        public Disciplin(int idWho, DataGridViewRow currentRow)
        {
            InitializeComponent();
            this.currentRow = currentRow;
            this.id = int.Parse(currentRow.Cells[0].Value.ToString());
            this.idWho = idWho;
        }
      

        private void button1_Click(object sender, EventArgs e)
        {
            if (currentRow == null) save();
            else update();
        }
        private void load()
        {
            comboBox1.Text = currentRow.Cells[2].Value.ToString();
            dateTimePicker1.Text = currentRow.Cells[3].Value.ToString();
            dateTimePicker2.Text = currentRow.Cells[4].Value.ToString();
            textBox1.Text = currentRow.Cells[5].Value.ToString();
            dateTimePicker3.Text = currentRow.Cells[6].Value.ToString();
            textBox2.Text = currentRow.Cells[7].Value.ToString();
            textBox3.Text = currentRow.Cells[8].Value.ToString();
            dateTimePicker4.Text = currentRow.Cells[9].Value.ToString();
            textBox4.Text = currentRow.Cells[10].Value.ToString();
        }

        private void save()
        {
            try
            {
                Database1DataSet.ГлавнаяRow ground = (Database1DataSet.ГлавнаяRow)database1DataSet.Главная.Select($" ИД ='{idWho}'")[0];
                Database1DataSet.Виды_взысканияRow rel = (Database1DataSet.Виды_взысканияRow)database1DataSet.Виды_взыскания.Select($" Вид ='{comboBox1.SelectedValue}'")[0];
                database1DataSet.Дисциплинарные_взыскания.AddДисциплинарные_взысканияRow(
                    ground, comboBox1.Text, dateTimePicker1.Value, dateTimePicker2.Value, 
                    textBox1.Text, dateTimePicker3.Value, textBox2.Text, textBox3.Text,
                    dateTimePicker1.Value,textBox4.Text);
                this.дисциплинарныеВзысканияBindingSource.EndEdit();
                this.дисциплинарные_взысканияTableAdapter.Update(this.database1DataSet.Дисциплинарные_взыскания);
                this.database1DataSet.Дисциплинарные_взыскания.AcceptChanges();
                this.database1DataSet.AcceptChanges();

                MessageBox.Show("Добавлено. Обновите форму для просмотра");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка добавления. Проверьте вводимые данные");
            }
        }
        private void update()
        {
            try
            {

                Database1DataSet.Дисциплинарные_взысканияRow row = database1DataSet.Дисциплинарные_взыскания.FindByИД(id);
                row[2] = comboBox1.SelectedValue;
                row[3] = dateTimePicker1.Value;
                row[4] = dateTimePicker2.Value;
                row[5] = textBox1.Text;
                row[6] = dateTimePicker3.Value;
                row[7] = textBox2.Text;
                row[8] = textBox3.Text;
                row[9] = dateTimePicker4.Value;
                row[10] = textBox4.Text;
                row.EndEdit();

                this.дисциплинарныеВзысканияBindingSource.EndEdit();
                this.дисциплинарные_взысканияTableAdapter.Update(this.database1DataSet.Дисциплинарные_взыскания);

                this.database1DataSet.Дисциплинарные_взыскания.AcceptChanges();
                this.database1DataSet.AcceptChanges();
                MessageBox.Show("Обновлено. Обновите форму для просмотра");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка обновления. Проверьте вводимые данные");
            }
        }

        private void Disciplin_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Дисциплинарные_взыскания". При необходимости она может быть перемещена или удалена.
            this.дисциплинарные_взысканияTableAdapter.Fill(this.database1DataSet.Дисциплинарные_взыскания);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Виды_взыскания". При необходимости она может быть перемещена или удалена.
            this.виды_взысканияTableAdapter.Fill(this.database1DataSet.Виды_взыскания);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Главная". При необходимости она может быть перемещена или удалена.
            this.главнаяTableAdapter.Fill(this.database1DataSet.Главная);
            if (currentRow != null) load();
            comboBox2.SelectedValue = idWho;
        }
    }
}
