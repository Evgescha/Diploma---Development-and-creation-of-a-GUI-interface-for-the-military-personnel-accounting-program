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
    public partial class FamilyAbroad : Form
    {
        int id = -1;
        int idWho = -1;
        DataGridViewRow currentRow = null;

        public FamilyAbroad(int idWho)
        {
            InitializeComponent();
            this.idWho = idWho;
        }

        public FamilyAbroad(int idWho, DataGridViewRow currentRow)
        {
            InitializeComponent();
            this.currentRow = currentRow;
            this.id = int.Parse(currentRow.Cells[0].Value.ToString());
            this.idWho = idWho;
        }
      

        private void FamilyAbroad_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Родственники_за_границей". При необходимости она может быть перемещена или удалена.
            this.родственники_за_границейTableAdapter.Fill(this.database1DataSet.Родственники_за_границей);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Родственные_связи". При необходимости она может быть перемещена или удалена.
            this.родственные_связиTableAdapter.Fill(this.database1DataSet.Родственные_связи);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Главная". При необходимости она может быть перемещена или удалена.
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

            textBox1.Text = currentRow.Cells[2].Value.ToString();
            comboBox1.Text = currentRow.Cells[3].Value.ToString();
            textBox2.Text = currentRow.Cells[4].Value.ToString();
            textBox3.Text = currentRow.Cells[5].Value.ToString();
        }

        private void save()
        {
            try
            {
                Database1DataSet.ГлавнаяRow ground = (Database1DataSet.ГлавнаяRow)database1DataSet.Главная.Select($" ИД ='{idWho}'")[0];
                Database1DataSet.Родственные_связиRow rel = (Database1DataSet.Родственные_связиRow)database1DataSet.Родственные_связи.Select($" Название ='{comboBox1.SelectedValue}'")[0];
                database1DataSet.Родственники_за_границей.AddРодственники_за_границейRow(ground, textBox1.Text, rel, textBox2.Text, textBox3.Text);
                this.родственникиЗаГраницейBindingSource.EndEdit();
                this.родственники_за_границейTableAdapter.Update(this.database1DataSet.Родственники_за_границей);
                this.database1DataSet.Родственники_за_границей.AcceptChanges();
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

                Database1DataSet.Родственники_за_границейRow row = database1DataSet.Родственники_за_границей.FindByИД(id);
                row[2] = textBox1.Text;
                row[3] = comboBox1.SelectedValue;
                row[4] = textBox2.Text;
                row[5] = textBox3.Text;
                row.EndEdit();

                this.родственникиЗаГраницейBindingSource.EndEdit();
                this.родственники_за_границейTableAdapter.Update(this.database1DataSet.Родственники_за_границей);

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
    }
}
