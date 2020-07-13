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
        // форма работы с послужным списком
        ArmyList armyList;
        //командировки
        Commandir commandir;
        //родственники 
        FamilyAbroad familyAbroad;
        //поощрения
        Pooschren pooschren;
        //взыскания
        Disciplin disciplin;
        //кондидат
        Condidats condidat;
        //учеба кондидата
        CondidatsLearning condidatsLearning;
        //разговор с кондидатом
        Beseda beseda;
        public Form1()
        {
            InitializeComponent();

        }

      
        private void upload() {
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
        private void Form1_Load(object sender, EventArgs e)
        {
            upload();
            loadNames();
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
            try
            {
                man = new editMan(dataGridView2.CurrentRow, dataGridView6.CurrentRow.Cells[0].Value.ToString());
                man.Show();
            }
            catch (Exception ex) { MessageBox.Show("Ошибка при попытке изменить выбранного служащего"); }
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

            try
            {
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

                ///послужной список
                else if (tabControl2.SelectedIndex == 3)
                {
                    armyList = new ArmyList(int.Parse(dataGridView2.CurrentRow.Cells[0].Value.ToString()));
                    armyList.Show();
                }
                ////////////////////////////////////////
                // командировки
                else if (tabControl2.SelectedIndex == 4)
                {
                    commandir = new Commandir(int.Parse(dataGridView2.CurrentRow.Cells[0].Value.ToString()));
                    commandir.Show();
                }
                //родственники
                else if (tabControl2.SelectedIndex == 5)
                {
                    familyAbroad = new FamilyAbroad(int.Parse(dataGridView2.CurrentRow.Cells[0].Value.ToString()));
                    familyAbroad.Show();
                }
                // поощрения
                else if (tabControl2.SelectedIndex == 6)
                {
                    pooschren = new Pooschren(int.Parse(dataGridView2.CurrentRow.Cells[0].Value.ToString()));
                    pooschren.Show();
                }
                //взыскание
                else if (tabControl2.SelectedIndex == 7)
                {
                    disciplin = new Disciplin(int.Parse(dataGridView2.CurrentRow.Cells[0].Value.ToString()));
                    disciplin.Show();
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


            try
            {
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
                // если открыта вкладка послужной список
                else if (tabControl2.SelectedIndex == 3)
                {
                    armyList = new ArmyList(int.Parse(dataGridView2.CurrentRow.Cells[0].Value.ToString()), dataGridView14.CurrentRow);
                    armyList.Show();
                }
                //коммандировки
                else if (tabControl2.SelectedIndex == 4)
                {
                    commandir = new Commandir(int.Parse(dataGridView2.CurrentRow.Cells[0].Value.ToString()), dataGridView15.CurrentRow);
                    commandir.Show();
                }
                //родственники за границей
                else if (tabControl2.SelectedIndex == 5)
                {
                    familyAbroad = new FamilyAbroad(int.Parse(dataGridView2.CurrentRow.Cells[0].Value.ToString()), dataGridView16.CurrentRow);
                    familyAbroad.Show();
                }
                //поощрения
                else if (tabControl2.SelectedIndex == 6)
                {
                    pooschren = new Pooschren(int.Parse(dataGridView2.CurrentRow.Cells[0].Value.ToString()), dataGridView17.CurrentRow);
                    pooschren.Show();
                }
                //взыскания
                else if (tabControl2.SelectedIndex == 7)
                {
                    disciplin = new Disciplin(int.Parse(dataGridView2.CurrentRow.Cells[0].Value.ToString()), dataGridView18.CurrentRow);
                    disciplin.Show();
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
                // удаляем послужной
                else if (tabControl2.SelectedIndex == 3)
                {
                    if (MessageBox.Show("Действительно удалить ?", "Подтвердите удаление", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        int id = int.Parse(dataGridView14.CurrentRow.Cells[0].Value.ToString());
                        Database1DataSet.Послужой_списокRow row = database1DataSet.Послужой_список.FindByИД(id);
                        row.Delete();
                        this.Validate();
                        this.главнаяПослужойСписокBindingSource.EndEdit();
                        this.послужой_списокTableAdapter.Update(this.database1DataSet.Послужой_список);

                    }
                }
                //коммандировки
                else if (tabControl2.SelectedIndex == 4)
                {
                    if (MessageBox.Show("Действительно удалить ?", "Подтвердите удаление", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        int id = int.Parse(dataGridView15.CurrentRow.Cells[0].Value.ToString());
                        Database1DataSet.КомандировкиRow row = database1DataSet.Командировки.FindByИД(id);
                        row.Delete();
                        this.Validate();
                        this.главнаяКомандировкиBindingSource.EndEdit();
                        this.командировкиTableAdapter.Update(this.database1DataSet.Командировки);

                    }
                }
                // родственники за границей
                else if (tabControl2.SelectedIndex == 5)
                {
                    if (MessageBox.Show("Действительно удалить ?", "Подтвердите удаление", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        int id = int.Parse(dataGridView16.CurrentRow.Cells[0].Value.ToString());
                        Database1DataSet.Родственники_за_границейRow row = database1DataSet.Родственники_за_границей.FindByИД(id);
                        row.Delete();
                        this.Validate();
                        this.главнаяРодственникиЗаГраницейBindingSource.EndEdit();
                        this.родственники_за_границейTableAdapter.Update(this.database1DataSet.Родственники_за_границей);

                    }
                }
                // пощрения
                else if (tabControl2.SelectedIndex == 6)
                {
                    if (MessageBox.Show("Действительно удалить ?", "Подтвердите удаление", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        int id = int.Parse(dataGridView17.CurrentRow.Cells[0].Value.ToString());
                        Database1DataSet.ПоощренияRow row = database1DataSet.Поощрения.FindByИД(id);
                        row.Delete();
                        this.Validate();
                        this.главнаяПоощренияBindingSource.EndEdit();
                        this.поощренияTableAdapter.Update(this.database1DataSet.Поощрения);

                    }
                }
                // вззыскания
                else if (tabControl2.SelectedIndex == 7)
                {
                    if (MessageBox.Show("Действительно удалить ?", "Подтвердите удаление", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        int id = int.Parse(dataGridView18.CurrentRow.Cells[0].Value.ToString());
                        Database1DataSet.Дисциплинарные_взысканияRow row = database1DataSet.Дисциплинарные_взыскания.FindByИД(id);
                        row.Delete();
                        this.Validate();
                        this.главнаяДисциплинарныеВзысканияBindingSource.EndEdit();
                        this.дисциплинарные_взысканияTableAdapter.Update(this.database1DataSet.Дисциплинарные_взыскания);

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
            if (dataGridView2.CurrentRow != null)
            {
                // запоминаем ид текущего служащего
                string id = dataGridView2.CurrentRow.Cells[0].Value.ToString();
                // в невидимой таблице ищем его и выбираем
                for (int i = 0; i < dataGridView7.RowCount; i++)
                {
                    if (dataGridView7[0, i].Value.ToString().Equals(id))
                        dataGridView7.CurrentCell = dataGridView7[0, i];
                }
            }
        }


        //добавить кондидата
        private void button9_Click(object sender, EventArgs e)
        {
            condidat = new Condidats(-1);
            condidat.Show();
        }
        //изменить кандидата
        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView8.RowCount > 0)
                {
                    condidat = new Condidats(int.Parse(dataGridView8.CurrentRow.Cells[0].Value.ToString()), dataGridView8.CurrentRow);
                    condidat.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка добавления кандидата.");
            }
        }
        //удалить кандидата
        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView8.CurrentRow != null)
                {
                    if (MessageBox.Show("Действительно удалить ?", "Подтвердите удаление", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        int id = int.Parse(dataGridView8.CurrentRow.Cells[0].Value.ToString());
                        Database1DataSet.Кандидаты_на_военную_службуRow row = database1DataSet.Кандидаты_на_военную_службу.FindByИД(id);
                        row.Delete();
                        this.Validate();
                        this.кандидатыНаВоеннуюСлужбуBindingSource.EndEdit();
                        this.кандидаты_на_военную_службуTableAdapter.Update(this.database1DataSet.Кандидаты_на_военную_службу);

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка удаления кандидата. Проверьте выбранный вариант.");
            }
        }



        // добавить свойства кандидата
        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                // учеба
                if (tabControl3.SelectedIndex == 0)
                {
                    condidatsLearning = new CondidatsLearning(int.Parse(dataGridView8.CurrentRow.Cells[0].Value.ToString()));
                    condidatsLearning.Show();
                }
                //беседа
                else if (tabControl3.SelectedIndex == 1)
                {
                    beseda = new Beseda(int.Parse(dataGridView8.CurrentRow.Cells[0].Value.ToString()));
                    beseda.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка. Проверьте выбираемые данные.");
            }
        }
        //изменить свойства кандидата
        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                // учеба
                if (tabControl3.SelectedIndex == 0)
                {
                    condidatsLearning = new CondidatsLearning(int.Parse(dataGridView8.CurrentRow.Cells[0].Value.ToString()), dataGridView20.CurrentRow);
                    condidatsLearning.Show();
                }
                //беседа
                else if (tabControl3.SelectedIndex == 1)
                {
                    beseda = new Beseda(int.Parse(dataGridView8.CurrentRow.Cells[0].Value.ToString()), dataGridView21.CurrentRow);
                    beseda.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка. Возможно не выбрано значение или остались связанные данные.");
            }
        }
        // удаление свойств кандидата
        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                // учеба 
                if (tabControl3.SelectedIndex == 0)
                {
                    if (MessageBox.Show("Действительно удалить ?", "Подтвердите удаление", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        int id = int.Parse(dataGridView20.CurrentRow.Cells[0].Value.ToString());
                        Database1DataSet.Учеба_кандидатаRow row = database1DataSet.Учеба_кандидата.FindByИД(id);
                        row.Delete();
                        this.Validate();
                        this.кандидатыНаВоеннуюСлужбуУчебаКандидатаBindingSource.EndEdit();
                        this.учеба_кандидатаTableAdapter.Update(this.database1DataSet.Учеба_кандидата);

                    }
                }
                //беседа
                else if (tabControl3.SelectedIndex == 1)
                {
                    if (MessageBox.Show("Действительно удалить ?", "Подтвердите удаление", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        int id = int.Parse(dataGridView21.CurrentRow.Cells[0].Value.ToString());
                        Database1DataSet.Беседовали_с_кандидатомRow row = database1DataSet.Беседовали_с_кандидатом.FindByИД(id);
                        row.Delete();
                        this.Validate();
                        this.кандидатыНаВоеннуюСлужбуБеседовалиСКандидатомBindingSource.EndEdit();
                        this.беседовали_с_кандидатомTableAdapter.Update(this.database1DataSet.Беседовали_с_кандидатом);

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка Удаления. Возможно остались связанные данные.");
            }
        }


        // обновление данных
        private void button13_Click(object sender, EventArgs e)
        {
            upload();
            loadNames();
        }
        //загрузка имен военных для таблиц
        private void loadNames()
        {
            //иностранный
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                try
                {
                    int index1 = главнаяBindingSource.Find("ИД", dataGridView1[1, i].Value.ToString());
                    dataGridView1[2, i].Value = ((DataRowView)(главнаяBindingSource[index1]))[1]+" "+ ((DataRowView)(главнаяBindingSource[index1]))[2]+" "+ ((DataRowView)(главнаяBindingSource[index1]))[3];
                }
                catch (Exception ex) { Console.WriteLine("нет элемента"); }
               
            }
            //командировки
            for (int i = 0; i < dataGridView9.RowCount; i++)
            {
                try
                {
                    int index1 = главнаяBindingSource.Find("ИД", dataGridView9[1, i].Value.ToString());
                    dataGridView9[2, i].Value = ((DataRowView)(главнаяBindingSource[index1]))[1] + " " + ((DataRowView)(главнаяBindingSource[index1]))[2] + " " + ((DataRowView)(главнаяBindingSource[index1]))[3];
                }
                catch (Exception ex) { Console.WriteLine("нет элемента"); }
            }
            //поощрения
            for (int i = 0; i < dataGridView12.RowCount; i++)
            {
                try
                {
                    int index1 = главнаяBindingSource.Find("ИД", dataGridView12[1, i].Value.ToString());
                    dataGridView12[2, i].Value = ((DataRowView)(главнаяBindingSource[index1]))[1] + " " + ((DataRowView)(главнаяBindingSource[index1]))[2] + " " + ((DataRowView)(главнаяBindingSource[index1]))[3];
                }
                catch (Exception ex) { Console.WriteLine("нет элемента"); }
            }
            //взыскания
            for (int i = 0; i < dataGridView13.RowCount; i++)
            {
                try
                {
                    int index1 = главнаяBindingSource.Find("ИД", dataGridView13[1, i].Value.ToString());
                    dataGridView13[2, i].Value = ((DataRowView)(главнаяBindingSource[index1]))[1] + " " + ((DataRowView)(главнаяBindingSource[index1]))[2] + " " + ((DataRowView)(главнаяBindingSource[index1]))[3];
                }
                catch (Exception ex) { Console.WriteLine("нет элемента"); }
            }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            loadNames();
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            loadNames();
        }
    }
}
