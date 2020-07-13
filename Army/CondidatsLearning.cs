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
    public partial class CondidatsLearning : Form
    {
        int id = -1;
        int idWho = -1;
        DataGridViewRow currentRow = null;

        public CondidatsLearning(int idWho)
        {
            InitializeComponent();
            this.idWho = idWho;
        }

        public CondidatsLearning(int idWho, DataGridViewRow currentRow)
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
            textBox1.Text = currentRow.Cells[2].Value.ToString();
            textBox2.Text = currentRow.Cells[3].Value.ToString();
            textBox3.Text = currentRow.Cells[4].Value.ToString();
            textBox4.Text = currentRow.Cells[5].Value.ToString();
            textBox5.Text = currentRow.Cells[6].Value.ToString();
        }

        private void save()
        {
            try
            {

                Database1DataSet.Кандидаты_на_военную_службуRow ground = (Database1DataSet.Кандидаты_на_военную_службуRow)database1DataSet.Кандидаты_на_военную_службу.Select($" ИД ='{idWho}'")[0];
                database1DataSet.Учеба_кандидата.AddУчеба_кандидатаRow(
                    ground, textBox1.Text, textBox2.Text, int.Parse(textBox3.Text), int.Parse(textBox4.Text), textBox5.Text);
                this.учебаКандидатаBindingSource.EndEdit();
                this.учеба_кандидатаTableAdapter.Update(this.database1DataSet.Учеба_кандидата);
                this.database1DataSet.Учеба_кандидата.AcceptChanges();
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

                Database1DataSet.Учеба_кандидатаRow row = database1DataSet.Учеба_кандидата.FindByИД(id);
                row[2] = textBox1.Text;
                row[3] = textBox2.Text;
                row[4] = textBox3.Text;
                row[5] = textBox4.Text;
                row[6] = textBox5.Text;
                row.EndEdit();

                this.учебаКандидатаBindingSource.EndEdit();
                this.учеба_кандидатаTableAdapter.Update(this.database1DataSet.Учеба_кандидата);

                this.database1DataSet.Учеба_кандидата.AcceptChanges();
                this.database1DataSet.AcceptChanges();
                MessageBox.Show("Обновлено. Обновите форму для просмотра");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка обновления. Проверьте вводимые данные");
            }
        }

        private void CondidatsLearning_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Учеба_кандидата". При необходимости она может быть перемещена или удалена.
            this.учеба_кандидатаTableAdapter.Fill(this.database1DataSet.Учеба_кандидата);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Кандидаты_на_военную_службу". При необходимости она может быть перемещена или удалена.
            this.кандидаты_на_военную_службуTableAdapter.Fill(this.database1DataSet.Кандидаты_на_военную_службу);
            if (currentRow != null) load();
            comboBox2.SelectedValue = idWho;
        }
    }
}
