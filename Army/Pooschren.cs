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
    public partial class Pooschren : Form
    {
        int id = -1;
        int idWho = -1;
        DataGridViewRow currentRow = null;

        public Pooschren(int idWho)
        {
            InitializeComponent();
            this.idWho = idWho;
        }

        public Pooschren(int idWho, DataGridViewRow currentRow)
        {
            InitializeComponent();
            this.currentRow = currentRow;
            this.id = int.Parse(currentRow.Cells[0].Value.ToString());
            this.idWho = idWho;
        }


        private void Pooschren_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Поощрения". При необходимости она может быть перемещена или удалена.
            this.поощренияTableAdapter.Fill(this.database1DataSet.Поощрения);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Виды_поощерений". При необходимости она может быть перемещена или удалена.
            this.виды_поощеренийTableAdapter.Fill(this.database1DataSet.Виды_поощерений);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Главная". При необходимости она может быть перемещена или удалена.
            this.главнаяTableAdapter.Fill(this.database1DataSet.Главная);
            this.главнаяTableAdapter.Fill(this.database1DataSet.Главная);
            if (currentRow != null) load();
            comboBox2.SelectedValue = idWho;
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
            textBox1.Text = currentRow.Cells[4].Value.ToString();
            textBox2.Text = currentRow.Cells[5].Value.ToString();
            textBox3.Text = currentRow.Cells[6].Value.ToString();
        }

        private void save()
        {
            try
            {
                Database1DataSet.ГлавнаяRow ground = (Database1DataSet.ГлавнаяRow)database1DataSet.Главная.Select($" ИД ='{idWho}'")[0];
                Database1DataSet.Виды_поощеренийRow rel = (Database1DataSet.Виды_поощеренийRow)database1DataSet.Виды_поощерений.Select($" Вид ='{comboBox1.SelectedValue}'")[0];
                database1DataSet.Поощрения.AddПоощренияRow(ground, rel,dateTimePicker1.Value, textBox1.Text, textBox2.Text, textBox3.Text);
                this.поощренияBindingSource.EndEdit();
                this.поощренияTableAdapter.Update(this.database1DataSet.Поощрения);
                this.database1DataSet.Поощрения.AcceptChanges();
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

                Database1DataSet.ПоощренияRow row = database1DataSet.Поощрения.FindByИД(id);
                row[2] = comboBox1.SelectedValue;
                row[3] = dateTimePicker1.Value;
                row[4] = textBox1.Text;
                row[5] = textBox2.Text;
                row[6] = textBox3.Text;
                row.EndEdit();

                this.поощренияBindingSource.EndEdit();
                this.поощренияTableAdapter.Update(this.database1DataSet.Поощрения);

                this.database1DataSet.Поощрения.AcceptChanges();
                this.database1DataSet.AcceptChanges();
                MessageBox.Show("Обновлено. Обновите форму для просмотра");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка обновления. Проверьте вводимые данные");
            }
        }
    }
}
