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
    public partial class Form1 : Form
    {
        editMan man;
        familyEdit fam;
        editLang uh;
        editLanguage lang;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Иностранный". При необходимости она может быть перемещена или удалена.
            this.иностранныйTableAdapter.Fill(this.database1DataSet.Иностранный);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Учеба". При необходимости она может быть перемещена или удалена.
            this.учебаTableAdapter.Fill(this.database1DataSet.Учеба);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Состав_семьи". При необходимости она может быть перемещена или удалена.
            this.состав_семьиTableAdapter.Fill(this.database1DataSet.Состав_семьи);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Главная". При необходимости она может быть перемещена или удалена.
            this.главнаяTableAdapter.Fill(this.database1DataSet.Главная);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Подразделение". При необходимости она может быть перемещена или удалена.
            this.подразделениеTableAdapter.Fill(this.database1DataSet.Подразделение);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Подразделение". При необходимости она может быть перемещена или удалена.
            this.подразделениеTableAdapter.Fill(this.database1DataSet.Подразделение);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Иностранный". При необходимости она может быть перемещена или удалена.
            this.иностранныйTableAdapter.Fill(this.database1DataSet.Иностранный);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Учеба". При необходимости она может быть перемещена или удалена.
            this.учебаTableAdapter.Fill(this.database1DataSet.Учеба);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Состав_семьи". При необходимости она может быть перемещена или удалена.
            this.состав_семьиTableAdapter.Fill(this.database1DataSet.Состав_семьи);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Главная". При необходимости она может быть перемещена или удалена.
            this.главнаяTableAdapter.Fill(this.database1DataSet.Главная);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            man = new editMan(-1);
            man.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try {
                man = new editMan(dataGridView2.CurrentRow, dataGridView6.CurrentRow.Cells[0].Value.ToString());
                man.Show();
            } catch (Exception ex) { MessageBox.Show("Ошибка при попытке изменить выбранного служащего"); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Действительно удалить ?", "Подтвердите удаление", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int id = int.Parse(dataGridView2.CurrentRow.Cells[0].Value.ToString());
                    Database1DataSet.ГлавнаяRow row = database1DataSet.Главная.FindByИД(id);
                    //row.Delete();
                    this.главнаяBindingSource.RemoveAt(this.главнаяBindingSource.Find("ИД", id));
                    //database1DataSet.Главная.RemoveГлавнаяRow(row);
                    //this.главнаяBindingSource.Remove(row);
                    this.Validate();
                    this.главнаяBindingSource.EndEdit();
                    this.главнаяTableAdapter.Update(this.database1DataSet.Главная);
                    //this.database1DataSet.Главная.AcceptChanges();
                    //this.database1DataSet.AcceptChanges();

                }
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try { 
            if (tabControl2.SelectedIndex == 0)
            {
                fam = new familyEdit(int.Parse(dataGridView2.CurrentRow.Cells[0].Value.ToString()));
                fam.Show();
            }
            if (tabControl2.SelectedIndex == 1)
            {
                uh = new editLang(int.Parse(dataGridView2.CurrentRow.Cells[0].Value.ToString()));
                uh.Show();
            }
            if (tabControl2.SelectedIndex == 2)
            {
                lang = new editLanguage(int.Parse(dataGridView2.CurrentRow.Cells[0].Value.ToString()));
                lang.Show();
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка. Проверьте выбираемые данные.");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try { 
            if (tabControl2.SelectedIndex == 0)
            {
                fam = new familyEdit(dataGridView3.CurrentRow, int.Parse(dataGridView2.CurrentRow.Cells[0].Value.ToString()));
                fam.Show();
            }
            if (tabControl2.SelectedIndex == 1)
            {
                uh = new editLang(int.Parse(dataGridView2.CurrentRow.Cells[0].Value.ToString()), dataGridView4.CurrentRow);
                uh.Show();
            }
            if (tabControl2.SelectedIndex == 2)
            {
                lang = new editLanguage(int.Parse(dataGridView2.CurrentRow.Cells[0].Value.ToString()), dataGridView5.CurrentRow);
                lang.Show();
            }
        }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка. Проверьте выбираемые данные.");
            }
}

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (tabControl2.SelectedIndex == 0)
                {
                    if (MessageBox.Show("Действительно удалить ?", "Подтвердите удаление", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        int id = int.Parse(dataGridView3.CurrentRow.Cells[0].Value.ToString());
                        Database1DataSet.Состав_семьиRow row = database1DataSet.Состав_семьи.FindByИД(id);
                        row.Delete();
                        this.Validate();
                        this.главнаяСоставСемьиBindingSource.EndEdit();
                        this.состав_семьиTableAdapter.Update(this.database1DataSet.Состав_семьи);

                    }
                }
                if (tabControl2.SelectedIndex == 1)
                {
                    if (MessageBox.Show("Действительно удалить ?", "Подтвердите удаление", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        int id = int.Parse(dataGridView4.CurrentRow.Cells[0].Value.ToString());
                        Database1DataSet.УчебаRow row = database1DataSet.Учеба.FindByИД(id);
                        row.Delete();
                        this.Validate();
                        this.главнаяУчебаBindingSource.EndEdit();
                        this.учебаTableAdapter.Update(this.database1DataSet.Учеба);

                    }
                }
                if (tabControl2.SelectedIndex == 2)
                {
                    if (MessageBox.Show("Действительно удалить ?", "Подтвердите удаление", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        int id = int.Parse(dataGridView5.CurrentRow.Cells[0].Value.ToString());
                        Database1DataSet.ИностранныйRow row = database1DataSet.Иностранный.FindByИД(id);
                        row.Delete();
                        this.Validate();
                        this.иностранныйBindingSource.EndEdit();
                        this.иностранныйTableAdapter.Update(this.database1DataSet.Иностранный);

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка Удаления. Возможно остались связанные данные.");
            }
        }
    }
}
