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
    public partial class ArmyList : Form
    {

        int id = -1;
        int idWho = -1;
        DataGridViewRow currentRow = null;

        public ArmyList(int idWho)
        {
            InitializeComponent();
            this.idWho = idWho;
        }

        public ArmyList(int idWho, DataGridViewRow currentRow)
        {
            InitializeComponent();
            this.currentRow = currentRow;
            this.id = int.Parse(currentRow.Cells[0].Value.ToString());
            this.idWho = idWho;
        }
        private void load() {
            
            textBox1.Text = currentRow.Cells[2].Value.ToString();
            comboBox1.Text = currentRow.Cells[3].Value.ToString();
            dateTimePicker1.Text = currentRow.Cells[4].Value.ToString();
            dateTimePicker2.Text = currentRow.Cells[5].Value.ToString();
            textBox2.Text = currentRow.Cells[6].Value.ToString();
        }

        private void save()
        {
            try
            {
                var s = database1DataSet.Главная.Select($" ИД ='{idWho}'");
                Database1DataSet.ГлавнаяRow ground = (Database1DataSet.ГлавнаяRow)database1DataSet.Главная.Select($" ИД ='{idWho}'")[0];
                database1DataSet.Послужой_список.AddПослужой_списокRow(ground, textBox1.Text,comboBox1.Text,dateTimePicker1.Value,dateTimePicker2.Value,textBox2.Text);
                this.послужойСписокBindingSource.EndEdit();
                this.послужой_списокTableAdapter.Update(this.database1DataSet.Послужой_список);
                this.database1DataSet.Послужой_список.AcceptChanges();
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

                Database1DataSet.Послужой_списокRow row = database1DataSet.Послужой_список.FindByИД(id);
                row[2] = textBox1.Text;
                row[3] = comboBox1.Text;
                row[4] = dateTimePicker1.Value;
                row[5] = dateTimePicker2.Value;
                row[6] = textBox2.Text;
                row.EndEdit();

                this.послужойСписокBindingSource.EndEdit();
                this.послужой_списокTableAdapter.Update(this.database1DataSet.Послужой_список);

                this.database1DataSet.Послужой_список.AcceptChanges();
                this.database1DataSet.AcceptChanges();
                MessageBox.Show("Обновлено. Обновите форму для просмотра");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка обновления. Проверьте вводимые данные");
            }
        }

        private void ArmyList_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Главная". При необходимости она может быть перемещена или удалена.
            this.главнаяTableAdapter.Fill(this.database1DataSet.Главная);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Послужой_список". При необходимости она может быть перемещена или удалена.
            this.послужой_списокTableAdapter.Fill(this.database1DataSet.Послужой_список);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Должность". При необходимости она может быть перемещена или удалена.
            this.должностьTableAdapter.Fill(this.database1DataSet.Должность);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Послужой_список". При необходимости она может быть перемещена или удалена.
            this.послужой_списокTableAdapter.Fill(this.database1DataSet.Послужой_список);
            if(currentRow!=null)load();
            comboBox2.SelectedValue = idWho;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (currentRow == null) save();
            else update();
        }
    }
}
