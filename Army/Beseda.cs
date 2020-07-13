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
    public partial class Beseda : Form
    {
        int id = -1;
        int idWho = -1;
        DataGridViewRow currentRow = null;

        public Beseda(int idWho)
        {
            InitializeComponent();
            this.idWho = idWho;
        }

        public Beseda(int idWho, DataGridViewRow currentRow)
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
            dateTimePicker1.Text = currentRow.Cells[3].Value.ToString();
            textBox2.Text = currentRow.Cells[4].Value.ToString();
        }

        private void save()
        {
            try
            {

                Database1DataSet.Кандидаты_на_военную_службуRow ground = (Database1DataSet.Кандидаты_на_военную_службуRow)database1DataSet.Кандидаты_на_военную_службу.Select($" ИД ='{idWho}'")[0];
                database1DataSet.Беседовали_с_кандидатом.AddБеседовали_с_кандидатомRow(
                    ground, textBox1.Text, dateTimePicker1.Value, textBox2.Text);
                this.беседовалиСКандидатомBindingSource.EndEdit();
                this.беседовали_с_кандидатомTableAdapter.Update(this.database1DataSet.Беседовали_с_кандидатом);
                this.database1DataSet.Беседовали_с_кандидатом.AcceptChanges();
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

                Database1DataSet.Беседовали_с_кандидатомRow row= database1DataSet.Беседовали_с_кандидатом.FindByИД(id);
                row[2] = textBox1.Text;
                row[3] = dateTimePicker1.Value;
                row[4] = textBox2.Text;
                row.EndEdit();

                this.беседовалиСКандидатомBindingSource.EndEdit();
                this.беседовали_с_кандидатомTableAdapter.Update(this.database1DataSet.Беседовали_с_кандидатом);

                this.database1DataSet.Беседовали_с_кандидатом.AcceptChanges();
                this.database1DataSet.AcceptChanges();
                MessageBox.Show("Обновлено. Обновите форму для просмотра");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка обновления. Проверьте вводимые данные");
            }
        }

       
        private void Beseda_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Беседовали_с_кандидатом". При необходимости она может быть перемещена или удалена.
            this.беседовали_с_кандидатомTableAdapter.Fill(this.database1DataSet.Беседовали_с_кандидатом);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Кандидаты_на_военную_службу". При необходимости она может быть перемещена или удалена.
            this.кандидаты_на_военную_службуTableAdapter.Fill(this.database1DataSet.Кандидаты_на_военную_службу);
            if (currentRow != null) load();
            comboBox2.SelectedValue = idWho;
        }
    }
}
