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
    public partial class Form3 : Form
    {
        string success = "Данные обновлены...!";
        public Form3()
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

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Подразделение". При необходимости она может быть перемещена или удалена.
            this.подразделениеTableAdapter.Fill(this.database1DataSet.Подразделение);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Владение_языком". При необходимости она может быть перемещена или удалена.
            this.владение_языкомTableAdapter.Fill(this.database1DataSet.Владение_языком);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Языки". При необходимости она может быть перемещена или удалена.
            this.языкиTableAdapter.Fill(this.database1DataSet.Языки);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Родственные_связи". При необходимости она может быть перемещена или удалена.
            this.родственные_связиTableAdapter.Fill(this.database1DataSet.Родственные_связи);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Специализация". При необходимости она может быть перемещена или удалена.
            this.специализацияTableAdapter.Fill(this.database1DataSet.Специализация);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Звание". При необходимости она может быть перемещена или удалена.
            this.званиеTableAdapter.Fill(this.database1DataSet.Звание);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Должность". При необходимости она может быть перемещена или удалена.
            this.должностьTableAdapter.Fill(this.database1DataSet.Должность);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Семейное_положение". При необходимости она может быть перемещена или удалена.
            this.семейное_положениеTableAdapter.Fill(this.database1DataSet.Семейное_положение);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Национальность". При необходимости она может быть перемещена или удалена.
            this.национальностьTableAdapter.Fill(this.database1DataSet.Национальность);

        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                this.Validate();
                this.национальностьBindingSource.EndEdit();
                this.семейноеПоложениеBindingSource.EndEdit();
                this.должностьBindingSource.EndEdit();
                this.званиеBindingSource.EndEdit();
                this.специализацияBindingSource.EndEdit();
                this.родственныеСвязиBindingSource.EndEdit();
                this.языкиBindingSource.EndEdit();
                this.владениеЯзыкомBindingSource.EndEdit();
                this.подразделениеBindingSource.EndEdit();

                this.национальностьTableAdapter.Update(this.database1DataSet.Национальность);
                this.семейное_положениеTableAdapter.Update(this.database1DataSet.Семейное_положение);
                this.должностьTableAdapter.Update(this.database1DataSet.Должность);
                this.званиеTableAdapter.Update(this.database1DataSet.Звание);
                this.специализацияTableAdapter.Update(this.database1DataSet.Специализация);
                this.родственные_связиTableAdapter.Update(this.database1DataSet.Родственные_связи);
                this.языкиTableAdapter.Update(this.database1DataSet.Языки);
                this.владение_языкомTableAdapter.Update(this.database1DataSet.Владение_языком);
                this.подразделениеTableAdapter.Update(this.database1DataSet.Подразделение);

                this.database1DataSet.Национальность.AcceptChanges();
                this.database1DataSet.Семейное_положение.AcceptChanges();
                this.database1DataSet.Звание.AcceptChanges();
                this.database1DataSet.Должность.AcceptChanges();
                this.database1DataSet.Специализация.AcceptChanges();
                this.database1DataSet.Родственные_связи.AcceptChanges();
                this.database1DataSet.Языки.AcceptChanges();
                this.database1DataSet.Владение_языком.AcceptChanges();
                this.database1DataSet.Подразделение.AcceptChanges();
                MessageBox.Show(success);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
