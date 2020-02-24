namespace Army
{
    partial class familyEdit
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.database1DataSet = new Army.Database1DataSet();
            this.главнаяBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.главнаяTableAdapter = new Army.Database1DataSetTableAdapters.ГлавнаяTableAdapter();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.родственныеСвязиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.родственные_связиTableAdapter = new Army.Database1DataSetTableAdapters.Родственные_связиTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.составСемьиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.состав_семьиTableAdapter = new Army.Database1DataSetTableAdapters.Состав_семьиTableAdapter();
            this.иДDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.иДВоеннослужащегоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.родственнаяСвязьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.годРожденияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.примечаниеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.главнаяBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.родственныеСвязиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.составСемьиBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Служащий";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ФИО родственника";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Родственная связь";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Примечание";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Год рождения";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.главнаяBindingSource;
            this.comboBox1.DisplayMember = "Фамилия";
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(134, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.ValueMember = "ИД";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(134, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(134, 125);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(121, 20);
            this.textBox3.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(238, 34);
            this.button1.TabIndex = 10;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(134, 98);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(121, 20);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.родственныеСвязиBindingSource;
            this.comboBox2.DisplayMember = "Название";
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(134, 72);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 12;
            this.comboBox2.ValueMember = "Название";
            // 
            // родственныеСвязиBindingSource
            // 
            this.родственныеСвязиBindingSource.DataMember = "Родственные связи";
            this.родственныеСвязиBindingSource.DataSource = this.database1DataSet;
            // 
            // родственные_связиTableAdapter
            // 
            this.родственные_связиTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.иДDataGridViewTextBoxColumn,
            this.иДВоеннослужащегоDataGridViewTextBoxColumn,
            this.фИОDataGridViewTextBoxColumn,
            this.родственнаяСвязьDataGridViewTextBoxColumn,
            this.годРожденияDataGridViewTextBoxColumn,
            this.примечаниеDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.составСемьиBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(102, 153);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.Visible = false;
            // 
            // составСемьиBindingSource
            // 
            this.составСемьиBindingSource.DataMember = "Состав семьи";
            this.составСемьиBindingSource.DataSource = this.database1DataSet;
            // 
            // состав_семьиTableAdapter
            // 
            this.состав_семьиTableAdapter.ClearBeforeFill = true;
            // 
            // иДDataGridViewTextBoxColumn
            // 
            this.иДDataGridViewTextBoxColumn.DataPropertyName = "ИД";
            this.иДDataGridViewTextBoxColumn.HeaderText = "ИД";
            this.иДDataGridViewTextBoxColumn.Name = "иДDataGridViewTextBoxColumn";
            // 
            // иДВоеннослужащегоDataGridViewTextBoxColumn
            // 
            this.иДВоеннослужащегоDataGridViewTextBoxColumn.DataPropertyName = "ИД_Военнослужащего";
            this.иДВоеннослужащегоDataGridViewTextBoxColumn.HeaderText = "ИД_Военнослужащего";
            this.иДВоеннослужащегоDataGridViewTextBoxColumn.Name = "иДВоеннослужащегоDataGridViewTextBoxColumn";
            // 
            // фИОDataGridViewTextBoxColumn
            // 
            this.фИОDataGridViewTextBoxColumn.DataPropertyName = "ФИО";
            this.фИОDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.фИОDataGridViewTextBoxColumn.Name = "фИОDataGridViewTextBoxColumn";
            // 
            // родственнаяСвязьDataGridViewTextBoxColumn
            // 
            this.родственнаяСвязьDataGridViewTextBoxColumn.DataPropertyName = "Родственная связь";
            this.родственнаяСвязьDataGridViewTextBoxColumn.HeaderText = "Родственная связь";
            this.родственнаяСвязьDataGridViewTextBoxColumn.Name = "родственнаяСвязьDataGridViewTextBoxColumn";
            // 
            // годРожденияDataGridViewTextBoxColumn
            // 
            this.годРожденияDataGridViewTextBoxColumn.DataPropertyName = "Год рождения";
            this.годРожденияDataGridViewTextBoxColumn.HeaderText = "Год рождения";
            this.годРожденияDataGridViewTextBoxColumn.Name = "годРожденияDataGridViewTextBoxColumn";
            // 
            // примечаниеDataGridViewTextBoxColumn
            // 
            this.примечаниеDataGridViewTextBoxColumn.DataPropertyName = "Примечание";
            this.примечаниеDataGridViewTextBoxColumn.HeaderText = "Примечание";
            this.примечаниеDataGridViewTextBoxColumn.Name = "примечаниеDataGridViewTextBoxColumn";
            // 
            // familyEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 196);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "familyEdit";
            this.Text = "Дата рождения";
            this.Load += new System.EventHandler(this.familyEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.главнаяBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.родственныеСвязиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.составСемьиBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource главнаяBindingSource;
        private Database1DataSetTableAdapters.ГлавнаяTableAdapter главнаяTableAdapter;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.BindingSource родственныеСвязиBindingSource;
        private Database1DataSetTableAdapters.Родственные_связиTableAdapter родственные_связиTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource составСемьиBindingSource;
        private Database1DataSetTableAdapters.Состав_семьиTableAdapter состав_семьиTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn иДDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn иДВоеннослужащегоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn родственнаяСвязьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn годРожденияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn примечаниеDataGridViewTextBoxColumn;
    }
}