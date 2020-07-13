namespace Army
{
    partial class ArmyList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.должностьBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new Army.Database1DataSet();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.должностьTableAdapter = new Army.Database1DataSetTableAdapters.ДолжностьTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.иДDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ктоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.гдеСлужилDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.должностьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.служитСDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.служитПоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.примечанияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.послужойСписокBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.послужой_списокTableAdapter = new Army.Database1DataSetTableAdapters.Послужой_списокTableAdapter();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.главнаяBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.главнаяTableAdapter = new Army.Database1DataSetTableAdapters.ГлавнаяTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.должностьBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.послужойСписокBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.главнаяBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Где";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Должность";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Служит с";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Служит по";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Примечание";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(107, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(107, 154);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 6;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.должностьBindingSource;
            this.comboBox1.DisplayMember = "Название";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(107, 65);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.ValueMember = "Название";
            // 
            // должностьBindingSource
            // 
            this.должностьBindingSource.DataMember = "Должность";
            this.должностьBindingSource.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(107, 96);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(100, 20);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(107, 128);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(100, 20);
            this.dateTimePicker2.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 178);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 27);
            this.button1.TabIndex = 10;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // должностьTableAdapter
            // 
            this.должностьTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.иДDataGridViewTextBoxColumn,
            this.ктоDataGridViewTextBoxColumn,
            this.гдеСлужилDataGridViewTextBoxColumn,
            this.должностьDataGridViewTextBoxColumn,
            this.служитСDataGridViewTextBoxColumn,
            this.служитПоDataGridViewTextBoxColumn,
            this.примечанияDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.послужойСписокBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 211);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 117);
            this.dataGridView1.TabIndex = 11;
            // 
            // иДDataGridViewTextBoxColumn
            // 
            this.иДDataGridViewTextBoxColumn.DataPropertyName = "ИД";
            this.иДDataGridViewTextBoxColumn.HeaderText = "ИД";
            this.иДDataGridViewTextBoxColumn.Name = "иДDataGridViewTextBoxColumn";
            // 
            // ктоDataGridViewTextBoxColumn
            // 
            this.ктоDataGridViewTextBoxColumn.DataPropertyName = "Кто";
            this.ктоDataGridViewTextBoxColumn.HeaderText = "Кто";
            this.ктоDataGridViewTextBoxColumn.Name = "ктоDataGridViewTextBoxColumn";
            // 
            // гдеСлужилDataGridViewTextBoxColumn
            // 
            this.гдеСлужилDataGridViewTextBoxColumn.DataPropertyName = "Где служил";
            this.гдеСлужилDataGridViewTextBoxColumn.HeaderText = "Где служил";
            this.гдеСлужилDataGridViewTextBoxColumn.Name = "гдеСлужилDataGridViewTextBoxColumn";
            // 
            // должностьDataGridViewTextBoxColumn
            // 
            this.должностьDataGridViewTextBoxColumn.DataPropertyName = "Должность";
            this.должностьDataGridViewTextBoxColumn.HeaderText = "Должность";
            this.должностьDataGridViewTextBoxColumn.Name = "должностьDataGridViewTextBoxColumn";
            // 
            // служитСDataGridViewTextBoxColumn
            // 
            this.служитСDataGridViewTextBoxColumn.DataPropertyName = "Служит с";
            this.служитСDataGridViewTextBoxColumn.HeaderText = "Служит с";
            this.служитСDataGridViewTextBoxColumn.Name = "служитСDataGridViewTextBoxColumn";
            // 
            // служитПоDataGridViewTextBoxColumn
            // 
            this.служитПоDataGridViewTextBoxColumn.DataPropertyName = "Служит по";
            this.служитПоDataGridViewTextBoxColumn.HeaderText = "Служит по";
            this.служитПоDataGridViewTextBoxColumn.Name = "служитПоDataGridViewTextBoxColumn";
            // 
            // примечанияDataGridViewTextBoxColumn
            // 
            this.примечанияDataGridViewTextBoxColumn.DataPropertyName = "Примечания";
            this.примечанияDataGridViewTextBoxColumn.HeaderText = "Примечания";
            this.примечанияDataGridViewTextBoxColumn.Name = "примечанияDataGridViewTextBoxColumn";
            // 
            // послужойСписокBindingSource
            // 
            this.послужойСписокBindingSource.DataMember = "Послужой список";
            this.послужойСписокBindingSource.DataSource = this.database1DataSet;
            // 
            // послужой_списокTableAdapter
            // 
            this.послужой_списокTableAdapter.ClearBeforeFill = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Военный";
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.главнаяBindingSource;
            this.comboBox2.DisplayMember = "Фамилия";
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Enabled = false;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(107, 12);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(100, 21);
            this.comboBox2.TabIndex = 13;
            this.comboBox2.ValueMember = "ИД";
            // 
            // главнаяBindingSource
            // 
            this.главнаяBindingSource.DataMember = "Главная";
            this.главнаяBindingSource.DataSource = this.database1DataSet;
            // 
            // главнаяTableAdapter
            // 
            this.главнаяTableAdapter.ClearBeforeFill = true;
            // 
            // ArmyList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 221);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ArmyList";
            this.Text = "Послужной список";
            this.Load += new System.EventHandler(this.ArmyList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.должностьBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.послужойСписокBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.главнаяBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button button1;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource должностьBindingSource;
        private Database1DataSetTableAdapters.ДолжностьTableAdapter должностьTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource послужойСписокBindingSource;
        private Database1DataSetTableAdapters.Послужой_списокTableAdapter послужой_списокTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn иДDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ктоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn гдеСлужилDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn должностьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn служитСDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn служитПоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn примечанияDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.BindingSource главнаяBindingSource;
        private Database1DataSetTableAdapters.ГлавнаяTableAdapter главнаяTableAdapter;
    }
}