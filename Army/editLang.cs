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
    public partial class editLang : Form
    {
        int id=-1;
        int fatId;
        DataGridViewRow currentRow = null;
        public editLang(int fatId)
        {
            InitializeComponent();
            this.fatId = fatId;
            comboBox1.SelectedValue = fatId;
        }
        public editLang(int fatId, DataGridViewRow currentRow)
        {
            InitializeComponent();
            this.fatId = fatId;
            this.currentRow = currentRow;
            comboBox1.SelectedValue = fatId;
            load();
        }
        private void load() {
            id = int.Parse(currentRow.Cells[0].Value.ToString());
            comboBox1.SelectedValue = currentRow.Cells[1].Value.ToString();
            textBox1.Text = currentRow.Cells[2].Value.ToString();
            textBox2.Text = currentRow.Cells[3].Value.ToString();
            textBox3.Text = currentRow.Cells[4].Value.ToString();
            textBox4.Text = currentRow.Cells[5].Value.ToString();
            textBox5.Text = currentRow.Cells[6].Value.ToString();
        }

        private void editLang_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Учеба". При необходимости она может быть перемещена или удалена.
            this.учебаTableAdapter.Fill(this.database1DataSet.Учеба);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Главная". При необходимости она может быть перемещена или удалена.
            this.главнаяTableAdapter.Fill(this.database1DataSet.Главная);
            if (currentRow != null) load();
            comboBox1.SelectedValue = fatId;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (id < 0) save();
            else update();
        }
        private void save()
        {
            try
            {
                Database1DataSet.ГлавнаяRow ground = (Database1DataSet.ГлавнаяRow)database1DataSet.Главная.Select($" ИД ='{comboBox1.SelectedValue}'")[0];

                database1DataSet.Учеба.AddУчебаRow(ground, textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);

                this.учебаBindingSource.EndEdit();
                this.учебаTableAdapter.Update(this.database1DataSet.Учеба);

                this.database1DataSet.Учеба.AcceptChanges();
                this.database1DataSet.AcceptChanges();
                MessageBox.Show("Добавлено. Обновите форму для просмотра");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка добавления. Проверьте вводимые данные.");
            }
        }
        private void update()
        {
            try
            {
                Database1DataSet.УчебаRow row = database1DataSet.Учеба.FindByИД(id);
            row[1] = comboBox1.SelectedValue;
            row[2] = textBox1.Text;
            row[3] = textBox2.Text;
            row[4] = textBox3.Text;
            row[5] = textBox4.Text;
            row[6] = textBox5.Text;
            row.EndEdit();

            this.учебаBindingSource.EndEdit();
            this.учебаTableAdapter.Update(this.database1DataSet.Учеба);

            this.database1DataSet.Учеба.AcceptChanges();
            this.database1DataSet.AcceptChanges();
            MessageBox.Show("Обновлено. Обновите форму для просмотра");
            this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка Обновления. Проверьте вводимые данные.");
            }
        }
    }
}
