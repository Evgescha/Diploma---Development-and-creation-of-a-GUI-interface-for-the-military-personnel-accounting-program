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
    public partial class Commandir : Form
    {
        int id = -1;
        int idWho = -1;
        DataGridViewRow currentRow = null;

        public Commandir(int idWho)
        {
            InitializeComponent();
            this.idWho = idWho;
        }

        public Commandir(int idWho, DataGridViewRow currentRow)
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

        private void Commandir_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Командировки". При необходимости она может быть перемещена или удалена.
            this.командировкиTableAdapter.Fill(this.database1DataSet.Командировки);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Главная". При необходимости она может быть перемещена или удалена.
            this.главнаяTableAdapter.Fill(this.database1DataSet.Главная);
            if (currentRow != null) load();
            comboBox2.SelectedValue = idWho;
        }
        private void load()
        {

            textBox1.Text = currentRow.Cells[2].Value.ToString();
            textBox2.Text = currentRow.Cells[3].Value.ToString();
            textBox3.Text = currentRow.Cells[4].Value.ToString();
            textBox4.Text = currentRow.Cells[5].Value.ToString();
        }

        private void save()
        {
            try
            {
                Database1DataSet.ГлавнаяRow ground = (Database1DataSet.ГлавнаяRow)database1DataSet.Главная.Select($" ИД ='{idWho}'")[0];
                database1DataSet.Командировки.AddКомандировкиRow(ground, textBox1.Text, int.Parse(textBox2.Text), int.Parse(textBox3.Text), textBox4.Text);
                this.командировкиBindingSource.EndEdit();
                this.командировкиTableAdapter.Update(this.database1DataSet.Командировки);
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

                Database1DataSet.КомандировкиRow row = database1DataSet.Командировки.FindByИД(id);
                row[2] = textBox1.Text;
                row[3] = int.Parse(textBox2.Text);
                row[4] = int.Parse(textBox3.Text);
                row[5] = textBox4.Text;
                row.EndEdit();

                this.командировкиBindingSource.EndEdit();
                this.командировкиTableAdapter.Update(this.database1DataSet.Командировки);

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
