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
        // форма работы с военнослужащим
        editMan man;
        // форма работы с родственниками
        familyEdit fam;
        // форма работы с учебой служащего
        editLang uh;
        // форма работы с иностранными языками
        editLanguage lang;
        public Form1()
        {
            InitializeComponent();
        }

        public Form2 Form2
        {
            get => default(Form2);
            set
            {
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Дисциплинарные_взыскания". При необходимости она может быть перемещена или удалена.
            this.дисциплинарные_взысканияTableAdapter.Fill(this.database1DataSet.Дисциплинарные_взыскания);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Поощрения". При необходимости она может быть перемещена или удалена.
            this.поощренияTableAdapter.Fill(this.database1DataSet.Поощрения);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Родственники_за_границей". При необходимости она может быть перемещена или удалена.
            this.родственники_за_границейTableAdapter.Fill(this.database1DataSet.Родственники_за_границей);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Командировки". При необходимости она может быть перемещена или удалена.
            this.командировкиTableAdapter.Fill(this.database1DataSet.Командировки);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Послужой_список". При необходимости она может быть перемещена или удалена.
            this.послужой_списокTableAdapter.Fill(this.database1DataSet.Послужой_список);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Беседовали_с_кандидатом". При необходимости она может быть перемещена или удалена.
            this.беседовали_с_кандидатомTableAdapter.Fill(this.database1DataSet.Беседовали_с_кандидатом);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Учеба_кандидата". При необходимости она может быть перемещена или удалена.
            this.учеба_кандидатаTableAdapter.Fill(this.database1DataSet.Учеба_кандидата);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Кандидаты_на_военную_службу". При необходимости она может быть перемещена или удалена.
            this.кандидаты_на_военную_службуTableAdapter.Fill(this.database1DataSet.Кандидаты_на_военную_службу);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Кандидаты_на_военную_службу". При необходимости она может быть перемещена или удалена.
            this.кандидаты_на_военную_службуTableAdapter.Fill(this.database1DataSet.Кандидаты_на_военную_службу);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Кандидаты_на_военную_службу". При необходимости она может быть перемещена или удалена.
            this.кандидаты_на_военную_службуTableAdapter.Fill(this.database1DataSet.Кандидаты_на_военную_службу);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Родственники_за_границей". При необходимости она может быть перемещена или удалена.
            this.родственники_за_границейTableAdapter.Fill(this.database1DataSet.Родственники_за_границей);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet1.Командировки". При необходимости она может быть перемещена или удалена.
            this.командировкиTableAdapter.Fill(this.database1DataSet1.Командировки);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet1.Поощрения". При необходимости она может быть перемещена или удалена.
            this.поощренияTableAdapter.Fill(this.database1DataSet1.Поощрения);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet1.Дисциплинарные_взыскания". При необходимости она может быть перемещена или удалена.
            this.дисциплинарные_взысканияTableAdapter.Fill(this.database1DataSet1.Дисциплинарные_взыскания);
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
        // добавить служащего
        private void button1_Click(object sender, EventArgs e)
        {
            man = new editMan(-1);
            man.Show();
        }
        // редактировать служащего
        private void button2_Click(object sender, EventArgs e)
        {
            try {
                man = new editMan(dataGridView2.CurrentRow, dataGridView6.CurrentRow.Cells[0].Value.ToString());
                man.Show();
            } catch (Exception ex) { MessageBox.Show("Ошибка при попытке изменить выбранного служащего"); }
        }
        // удалить служащего
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
        // добавить свойство для выбранного служащего
        private void button6_Click(object sender, EventArgs e)
        {
            
            try {
                // если открыта вкладка родственника
                if (tabControl2.SelectedIndex == 0)
                {
                    fam = new familyEdit(int.Parse(dataGridView2.CurrentRow.Cells[0].Value.ToString()));
                    fam.Show();
                }
                // если открыта вкладка учебы
                else if (tabControl2.SelectedIndex == 1)
                {
                    uh = new editLang(int.Parse(dataGridView2.CurrentRow.Cells[0].Value.ToString()));
                    uh.Show();
                }
                // если открыта вкладка иностранного
                else if (tabControl2.SelectedIndex == 2)
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
        // редактирование свойств служащего
        private void button5_Click(object sender, EventArgs e)
        { 
            

            try {
                // если открыта вкладка родственника
                if (tabControl2.SelectedIndex == 0)
                {
                    fam = new familyEdit(dataGridView3.CurrentRow, int.Parse(dataGridView2.CurrentRow.Cells[0].Value.ToString()));
                    fam.Show();
                }
                // если открыта вкладка учебы
                else if (tabControl2.SelectedIndex == 1)
                {
                    uh = new editLang(int.Parse(dataGridView2.CurrentRow.Cells[0].Value.ToString()), dataGridView4.CurrentRow);
                    uh.Show();
                }
                // если открыта вкладка иностранного
                else if (tabControl2.SelectedIndex == 2)
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
        // удаление свойств служащего
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                // удаляем рожственников
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
                // удаляем учебу
                else if (tabControl2.SelectedIndex == 1)
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
                // удаляем иностранный
                else if (tabControl2.SelectedIndex == 2)
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
        // нажатие по служащему, сделано для корректного отображения свойств служащего
        private void dataGridView2_Click(object sender, EventArgs e)
        {
            // если нажали не на пустое место
            if (dataGridView2.CurrentRow != null) {
                // запоминаем ид текущего служащего
                string id = dataGridView2.CurrentRow.Cells[0].Value.ToString();
                // в невидимой таблице ищем его и выбираем
                for (int i = 0; i < dataGridView7.RowCount; i++) {
                    if (dataGridView7[0, i].Value.ToString().Equals(id))
                        dataGridView7.CurrentCell = dataGridView7[0, i];
                }
            }
        }
    }
}
