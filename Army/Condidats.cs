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
    public partial class Condidats : Form
    {

        int id = -1;
        int idWho = -1;
        DataGridViewRow currentRow = null;

        public Condidats(int idWho)
        {
            InitializeComponent();
            this.idWho = idWho;
        }

        public Condidats(int idWho, DataGridViewRow currentRow)
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

            textBox1.Text = currentRow.Cells[1].Value.ToString();
            textBox2.Text = currentRow.Cells[2].Value.ToString();
            dateTimePicker1.Text = currentRow.Cells[3].Value.ToString();
            textBox3.Text = currentRow.Cells[4].Value.ToString();
            textBox4.Text = currentRow.Cells[5].Value.ToString();
            textBox5.Text = currentRow.Cells[6].Value.ToString();
            dateTimePicker2.Text = currentRow.Cells[7].Value.ToString();
            textBox6.Text = currentRow.Cells[8].Value.ToString();
        }

        private void save()
        {
            try
            {
                //Database1DataSet.ГлавнаяRow ground = (Database1DataSet.ГлавнаяRow)database1DataSet.Главная.Select($" ИД ='{idWho}'")[0];
                database1DataSet.Кандидаты_на_военную_службу.AddКандидаты_на_военную_службуRow(
                    textBox1.Text, textBox2.Text, dateTimePicker1.Value, textBox3.Text, textBox4.Text, textBox5.Text,
                    dateTimePicker2.Value, textBox6.Text);
                this.кандидатыНаВоеннуюСлужбуBindingSource.EndEdit();
                this.кандидаты_на_военную_службуTableAdapter.Update(this.database1DataSet.Кандидаты_на_военную_службу);
                this.database1DataSet.Кандидаты_на_военную_службу.AcceptChanges();
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
                Database1DataSet.Кандидаты_на_военную_службуRow row = database1DataSet.Кандидаты_на_военную_службу.FindByИД(id);
                row[1] = textBox1.Text;
                row[2] = textBox2.Text;
                row[3] = dateTimePicker1.Value;
                row[4] = textBox3.Text;
                row[5] = textBox4.Text;
                row[6] = textBox5.Text;
                row[7] = dateTimePicker2.Value;
                row[8] = textBox6.Text;
                row.EndEdit();

                this.кандидатыНаВоеннуюСлужбуBindingSource.EndEdit();
                this.кандидаты_на_военную_службуTableAdapter.Update(this.database1DataSet.Кандидаты_на_военную_службу);

                this.database1DataSet.Кандидаты_на_военную_службу.AcceptChanges();
                this.database1DataSet.AcceptChanges();
                MessageBox.Show("Обновлено. Обновите форму для просмотра");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка обновления. Проверьте вводимые данные");
            }
        }

        private void Condidats_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Кандидаты_на_военную_службу". При необходимости она может быть перемещена или удалена.
            this.кандидаты_на_военную_службуTableAdapter.Fill(this.database1DataSet.Кандидаты_на_военную_службу);
            if (currentRow != null) load();
        }
    }
}
