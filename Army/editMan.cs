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
    public partial class editMan : Form
    {
        int id;
        private DataGridViewRow currentRow;
        private string podrasd;

        public editMan(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        public editMan(DataGridViewRow currentRow,string podrasd)
        {
            InitializeComponent();
            this.podrasd = podrasd;
            this.currentRow = currentRow;
            load();
        }

        public Form1 Form1
        {
            get => default(Form1);
            set
            {
            }
        }

        private void editMan_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Главная". При необходимости она может быть перемещена или удалена.
            this.главнаяTableAdapter.Fill(this.database1DataSet.Главная);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Подразделение". При необходимости она может быть перемещена или удалена.
            this.подразделениеTableAdapter.Fill(this.database1DataSet.Подразделение);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Специализация". При необходимости она может быть перемещена или удалена.
            this.специализацияTableAdapter.Fill(this.database1DataSet.Специализация);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Должность". При необходимости она может быть перемещена или удалена.
            this.должностьTableAdapter.Fill(this.database1DataSet.Должность);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Звание". При необходимости она может быть перемещена или удалена.
            this.званиеTableAdapter.Fill(this.database1DataSet.Звание);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Семейное_положение". При необходимости она может быть перемещена или удалена.
            this.семейное_положениеTableAdapter.Fill(this.database1DataSet.Семейное_положение);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Национальность". При необходимости она может быть перемещена или удалена.
            this.национальностьTableAdapter.Fill(this.database1DataSet.Национальность);

        }
        private void load() {
            comboBox7.SelectedText = podrasd;
            id = int.Parse(currentRow.Cells[0].Value.ToString());
            textBox2.Text = currentRow.Cells[1].Value.ToString();
            textBox3.Text = currentRow.Cells[2].Value.ToString();
            textBox4.Text = currentRow.Cells[3].Value.ToString();
            dateTimePicker1.Text= currentRow.Cells[4].Value.ToString();
            comboBox1.SelectedText = currentRow.Cells[5].Value.ToString().ToUpper();

            textBox5.Text = currentRow.Cells[6].Value.ToString();
            comboBox8.SelectedText = currentRow.Cells[7].Value.ToString();
            comboBox4.SelectedText = currentRow.Cells[8].Value.ToString();
            textBox6.Text = currentRow.Cells[9].Value.ToString();
            textBox7.Text = currentRow.Cells[10].Value.ToString();
            textBox8.Text = currentRow.Cells[11].Value.ToString();


            textBox9.Text = currentRow.Cells[12].Value.ToString();
            comboBox4.SelectedText = currentRow.Cells[13].Value.ToString();
            textBox10.Text = currentRow.Cells[14].Value.ToString();
            dateTimePicker2.Text = currentRow.Cells[15].Value.ToString();
            comboBox5.SelectedText = currentRow.Cells[16].Value.ToString();
            textBox12.Text = currentRow.Cells[17].Value.ToString();
            textBox13.Text = currentRow.Cells[18].Value.ToString();
            textBox14.Text = currentRow.Cells[19].Value.ToString();
            textBox15.Text = currentRow.Cells[20].Value.ToString();
            comboBox6.SelectedText = currentRow.Cells[21].Value.ToString();
            textBox16.Text = currentRow.Cells[22].Value.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (id < 0) save();
            else update();
        }
        private void save() {
            try
            {
                Database1DataSet.НациональностьRow nation = (Database1DataSet.НациональностьRow)database1DataSet.Национальность.Select($" Название ='{comboBox8.SelectedValue}'")[0];
                Database1DataSet.Семейное_положениеRow family = (Database1DataSet.Семейное_положениеRow)database1DataSet.Семейное_положение.Select($" Название ='{comboBox3.SelectedValue}'")[0];
                Database1DataSet.ЗваниеRow swan = (Database1DataSet.ЗваниеRow)database1DataSet.Звание.Select($" Название ='{comboBox4.SelectedValue}'")[0];
                Database1DataSet.ДолжностьRow dolsh = (Database1DataSet.ДолжностьRow)database1DataSet.Должность.Select($" Название ='{comboBox5.SelectedValue}'")[0];
                Database1DataSet.СпециализацияRow spec = (Database1DataSet.СпециализацияRow)database1DataSet.Специализация.Select($" Название ='{comboBox6.SelectedValue}'")[0];
                Database1DataSet.ПодразделениеRow podr = (Database1DataSet.ПодразделениеRow)database1DataSet.Подразделение.Select($" Наименование ='{comboBox7.SelectedValue}'")[0];
               
                database1DataSet.Главная.AddГлавнаяRow(
                    textBox2.Text, textBox3.Text, textBox4.Text, 
                    dateTimePicker1.Value, comboBox1.Text,
                    textBox5.Text, nation,  family, 
                    textBox6.Text, textBox7.Text, textBox8.Text,
                    textBox9.Text, swan, textBox10.Text, dateTimePicker2.Value,
                    dolsh, textBox12.Text, textBox13.Text,
                    int.Parse(textBox14.Text), int.Parse(textBox15.Text),
                    spec, textBox16.Text,
                    podr).EndEdit();

                this.главнаяBindingSource.EndEdit();
                this.главнаяTableAdapter.Update(this.database1DataSet.Главная);

                this.database1DataSet.Главная.AcceptChanges();
                this.database1DataSet.AcceptChanges();
                MessageBox.Show("Добавлено. Обновите форму для просмотра");
                this.Close();
            }
            catch (Exception ex) {
                MessageBox.Show("Ошибка добавления. Проверьте вводимые данные.");
            }
        }
        private void update() {
            try { 
            //DataRow row = database1DataSet.Главная.Select(" ИД = " + id)[0];            
            Database1DataSet.НациональностьRow nation = (Database1DataSet.НациональностьRow)database1DataSet.Национальность.Select($" Название ='{comboBox8.SelectedValue}'")[0];
            Database1DataSet.Семейное_положениеRow family = (Database1DataSet.Семейное_положениеRow)database1DataSet.Семейное_положение.Select($" Название ='{comboBox3.SelectedValue}'")[0];
            Database1DataSet.ЗваниеRow swan = (Database1DataSet.ЗваниеRow)database1DataSet.Звание.Select($" Название ='{comboBox4.SelectedValue}'")[0];
            Database1DataSet.ДолжностьRow dolsh = (Database1DataSet.ДолжностьRow)database1DataSet.Должность.Select($" Название ='{comboBox5.SelectedValue}'")[0];
            Database1DataSet.СпециализацияRow spec = (Database1DataSet.СпециализацияRow)database1DataSet.Специализация.Select($" Название ='{comboBox6.SelectedValue}'")[0];
            Database1DataSet.ПодразделениеRow podr = (Database1DataSet.ПодразделениеRow)database1DataSet.Подразделение.Select($" Наименование ='{comboBox7.SelectedValue}'")[0];

            Database1DataSet.ГлавнаяRow row = database1DataSet.Главная.FindByИД(id);
            
            //row.BeginEdit();
            //row.Подразделение = comboBox7.SelectedValue.ToString();
            row[1] = textBox2.Text;
            row[2] = textBox3.Text;
            row[3] = textBox4.Text;
            row[4] = dateTimePicker1.Text;
            row[5] = comboBox1.Text;
            row[6] = textBox5.Text;
            row[7] = comboBox8.SelectedValue;
            row[8] = comboBox3.SelectedValue;
            row[9] = textBox6.Text;
            row[10] = textBox7.Text;
            row[11] = textBox8.Text;
            row[12] = textBox9.Text;
            row[13] = comboBox4.SelectedValue;
            row[14] = textBox10.Text;
            row[15] = dateTimePicker2.Text;
            row[16] = comboBox5.SelectedValue;
            row[17] = textBox12.Text;
            row[18] = textBox13.Text;
            row[19] = int.Parse(textBox14.Text);
            row[20] = int.Parse(textBox15.Text);
            row[21] = comboBox6.SelectedValue;
            row[22] = textBox16.Text;
            row[23] = comboBox7.SelectedValue;

            row.EndEdit();

            //row.AcceptChanges();
            this.главнаяBindingSource.EndEdit();
            this.главнаяTableAdapter.Update(this.database1DataSet.Главная);

            this.database1DataSet.Главная.AcceptChanges();
            this.database1DataSet.AcceptChanges();
            MessageBox.Show("Обнавлено. Обновите форму для просмотра");
            this.Close();
        }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка Обновления. Проверьте вводимые данные.");
            }
    }
    }
}
