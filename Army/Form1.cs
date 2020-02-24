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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet1.Иностранный". При необходимости она может быть перемещена или удалена.
            this.иностранныйTableAdapter.Fill(this.database1DataSet1.Иностранный);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Иностранный". При необходимости она может быть перемещена или удалена.
            this.иностранныйTableAdapter.Fill(this.database1DataSet.Иностранный);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Учеба". При необходимости она может быть перемещена или удалена.
            this.учебаTableAdapter.Fill(this.database1DataSet.Учеба);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Состав_семьи". При необходимости она может быть перемещена или удалена.
            this.состав_семьиTableAdapter.Fill(this.database1DataSet.Состав_семьи);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Главная". При необходимости она может быть перемещена или удалена.
            this.главнаяTableAdapter.Fill(this.database1DataSet.Главная);

        }

    }
}
