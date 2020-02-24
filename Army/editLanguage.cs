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
    public partial class editLanguage : Form
    {
        int id = -1;
        int fatId;
        DataGridViewRow currentRow = null;
        public editLanguage(int fatId)
        {
            InitializeComponent();
            this.fatId = fatId;
        }
        public editLanguage(int fath, DataGridViewRow currentRow)
        {
            InitializeComponent();
            this.currentRow = currentRow;
            fatId = fath;
            comboBox1.SelectedValue = fatId;
            load();
        }
        private void load() {
            id = int.Parse(currentRow.Cells[0].Value.ToString());
            comboBox1.SelectedValue = currentRow.Cells[1].Value.ToString();
            comboBox2.SelectedValue = currentRow.Cells[2].Value.ToString();
            comboBox3.SelectedValue = currentRow.Cells[3].Value.ToString();
            textBox1.Text = currentRow.Cells[4].Value.ToString();
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
                Database1DataSet.ЯзыкиRow lan = (Database1DataSet.ЯзыкиRow)database1DataSet.Языки.Select($" Название ='{comboBox2.SelectedValue}'")[0];
                Database1DataSet.Владение_языкомRow us = (Database1DataSet.Владение_языкомRow)database1DataSet.Владение_языком.Select($" Название ='{comboBox3.SelectedValue}'")[0];

                database1DataSet.Иностранный.AddИностранныйRow(ground, lan, us, textBox1.Text);

                this.иностранныйBindingSource.EndEdit();
                this.иностранныйTableAdapter.Update(this.database1DataSet.Иностранный);

                this.database1DataSet.Иностранный.AcceptChanges();
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
                Database1DataSet.ИностранныйRow row = database1DataSet.Иностранный.FindByИД(id);
            row[1] = comboBox1.SelectedValue;
            row[2] = comboBox2.SelectedValue;
            row[3] = comboBox3.SelectedValue;
            row[4] = textBox1.Text;
            row.EndEdit();

            this.иностранныйBindingSource.EndEdit();
            this.иностранныйTableAdapter.Update(this.database1DataSet.Иностранный);

            this.database1DataSet.Иностранный.AcceptChanges();
            this.database1DataSet.AcceptChanges();
            MessageBox.Show("Обновлено. Обновите форму для просмотра");
            this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка обновления. Проверьте вводимые данные");
            }
        }
        private void editLanguage_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Иностранный". При необходимости она может быть перемещена или удалена.
            this.иностранныйTableAdapter.Fill(this.database1DataSet.Иностранный);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Владение_языком". При необходимости она может быть перемещена или удалена.
            this.владение_языкомTableAdapter.Fill(this.database1DataSet.Владение_языком);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Языки". При необходимости она может быть перемещена или удалена.
            this.языкиTableAdapter.Fill(this.database1DataSet.Языки);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Главная". При необходимости она может быть перемещена или удалена.
            this.главнаяTableAdapter.Fill(this.database1DataSet.Главная);
            if (currentRow != null) load();
            comboBox1.SelectedValue = fatId;
        }
    }
}
