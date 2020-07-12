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
    public partial class familyEdit : Form
    {
        int id = -1;
        int fatId;
        DataGridViewRow currentRow = null;
        public familyEdit(int fatId)
        {
            InitializeComponent();
            this.fatId = fatId;
            
        }
        public familyEdit(DataGridViewRow currentRow,int fath)
        {
            InitializeComponent();
            this.currentRow = currentRow;
            fatId = fath;
            comboBox1.SelectedValue = fatId;
            load();
        }

        public Form1 Form1
        {
            get => default(Form1);
            set
            {
            }
        }

        private void load() {
            id = int.Parse(currentRow.Cells[0].Value.ToString());
            comboBox1.SelectedText = currentRow.Cells[1].Value.ToString();
            textBox1.Text = currentRow.Cells[2].Value.ToString();
            comboBox2.SelectedValue = currentRow.Cells[3].Value.ToString();
            dateTimePicker1.Text= currentRow.Cells[4].Value.ToString();
            textBox3.Text = currentRow.Cells[5].Value.ToString();

        }


        private void familyEdit_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Состав_семьи". При необходимости она может быть перемещена или удалена.
            this.состав_семьиTableAdapter.Fill(this.database1DataSet.Состав_семьи);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Родственные_связи". При необходимости она может быть перемещена или удалена.
            this.родственные_связиTableAdapter.Fill(this.database1DataSet.Родственные_связи);
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
        private void save() {
            try
            {
                Database1DataSet.ГлавнаяRow ground = (Database1DataSet.ГлавнаяRow)database1DataSet.Главная.Select($" ИД ='{comboBox1.SelectedValue}'")[0];
                Database1DataSet.Родственные_связиRow rel = (Database1DataSet.Родственные_связиRow)database1DataSet.Родственные_связи.Select($" Название ='{comboBox2.SelectedValue}'")[0];

                database1DataSet.Состав_семьи.AddСостав_семьиRow(ground, textBox1.Text, rel, dateTimePicker1.Value, textBox3.Text);

                this.составСемьиBindingSource.EndEdit();
                this.состав_семьиTableAdapter.Update(this.database1DataSet.Состав_семьи);

                this.database1DataSet.Состав_семьи.AcceptChanges();
                this.database1DataSet.AcceptChanges();
                MessageBox.Show("Добавлено. Обновите форму для просмотра");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка добавления. Проверьте вводимые данные.");
            }
        }
        private void update() {
            try { 
            Database1DataSet.Состав_семьиRow row = database1DataSet.Состав_семьи.FindByИД(id);
            row[1]=comboBox1.SelectedValue;
            row[2]=textBox1.Text;
            row[3]=comboBox2.Text;
            row[4]=dateTimePicker1.Value;
            row[5]=textBox3.Text;
            row.EndEdit();

            //row.AcceptChanges();
            this.составСемьиBindingSource.EndEdit();
            this.состав_семьиTableAdapter.Update(this.database1DataSet.Состав_семьи);

            this.database1DataSet.Состав_семьи.AcceptChanges();
            this.database1DataSet.AcceptChanges();
            MessageBox.Show("Обновлено. Обновите форму для просмотра");
            this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка обновления. Проверьте вводимые данные.");
            }
        }
    }
}
