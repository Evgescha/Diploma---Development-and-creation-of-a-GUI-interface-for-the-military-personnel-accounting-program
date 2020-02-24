namespace Army
{
    partial class editLang
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
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.database1DataSet = new Army.Database1DataSet();
            this.главнаяBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.главнаяTableAdapter = new Army.Database1DataSetTableAdapters.ГлавнаяTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.учебаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.учебаTableAdapter = new Army.Database1DataSetTableAdapters.УчебаTableAdapter();
            this.иДDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.идВоеннослужащегоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.вУЗDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.специальностьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.годПоступленияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.годВыпускаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.примечаниеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.главнаяBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.учебаBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Служащий";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Вуз";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Специальность";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Год поступления";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Год окончания";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Примечание";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.главнаяBindingSource;
            this.comboBox1.DisplayMember = "Фамилия";
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(141, 9);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.ValueMember = "ИД";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(141, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(141, 63);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 20);
            this.textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(141, 92);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(121, 20);
            this.textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(141, 118);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(121, 20);
            this.textBox4.TabIndex = 10;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(141, 144);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(121, 20);
            this.textBox5.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(15, 175);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(247, 33);
            this.button1.TabIndex = 12;
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
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.иДDataGridViewTextBoxColumn,
            this.идВоеннослужащегоDataGridViewTextBoxColumn,
            this.вУЗDataGridViewTextBoxColumn,
            this.специальностьDataGridViewTextBoxColumn,
            this.годПоступленияDataGridViewTextBoxColumn,
            this.годВыпускаDataGridViewTextBoxColumn,
            this.примечаниеDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.учебаBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(258, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 13;
            // 
            // учебаBindingSource
            // 
            this.учебаBindingSource.DataMember = "Учеба";
            this.учебаBindingSource.DataSource = this.database1DataSet;
            // 
            // учебаTableAdapter
            // 
            this.учебаTableAdapter.ClearBeforeFill = true;
            // 
            // иДDataGridViewTextBoxColumn
            // 
            this.иДDataGridViewTextBoxColumn.DataPropertyName = "ИД";
            this.иДDataGridViewTextBoxColumn.HeaderText = "ИД";
            this.иДDataGridViewTextBoxColumn.Name = "иДDataGridViewTextBoxColumn";
            // 
            // идВоеннослужащегоDataGridViewTextBoxColumn
            // 
            this.идВоеннослужащегоDataGridViewTextBoxColumn.DataPropertyName = "Ид_Военнослужащего";
            this.идВоеннослужащегоDataGridViewTextBoxColumn.HeaderText = "Ид_Военнослужащего";
            this.идВоеннослужащегоDataGridViewTextBoxColumn.Name = "идВоеннослужащегоDataGridViewTextBoxColumn";
            // 
            // вУЗDataGridViewTextBoxColumn
            // 
            this.вУЗDataGridViewTextBoxColumn.DataPropertyName = "ВУЗ";
            this.вУЗDataGridViewTextBoxColumn.HeaderText = "ВУЗ";
            this.вУЗDataGridViewTextBoxColumn.Name = "вУЗDataGridViewTextBoxColumn";
            // 
            // специальностьDataGridViewTextBoxColumn
            // 
            this.специальностьDataGridViewTextBoxColumn.DataPropertyName = "Специальность";
            this.специальностьDataGridViewTextBoxColumn.HeaderText = "Специальность";
            this.специальностьDataGridViewTextBoxColumn.Name = "специальностьDataGridViewTextBoxColumn";
            // 
            // годПоступленияDataGridViewTextBoxColumn
            // 
            this.годПоступленияDataGridViewTextBoxColumn.DataPropertyName = "Год поступления";
            this.годПоступленияDataGridViewTextBoxColumn.HeaderText = "Год поступления";
            this.годПоступленияDataGridViewTextBoxColumn.Name = "годПоступленияDataGridViewTextBoxColumn";
            // 
            // годВыпускаDataGridViewTextBoxColumn
            // 
            this.годВыпускаDataGridViewTextBoxColumn.DataPropertyName = "Год выпуска";
            this.годВыпускаDataGridViewTextBoxColumn.HeaderText = "Год выпуска";
            this.годВыпускаDataGridViewTextBoxColumn.Name = "годВыпускаDataGridViewTextBoxColumn";
            // 
            // примечаниеDataGridViewTextBoxColumn
            // 
            this.примечаниеDataGridViewTextBoxColumn.DataPropertyName = "Примечание";
            this.примечаниеDataGridViewTextBoxColumn.HeaderText = "Примечание";
            this.примечаниеDataGridViewTextBoxColumn.Name = "примечаниеDataGridViewTextBoxColumn";
            // 
            // editLang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 216);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "editLang";
            this.Text = "editLang";
            this.Load += new System.EventHandler(this.editLang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.главнаяBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.учебаBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button1;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource главнаяBindingSource;
        private Database1DataSetTableAdapters.ГлавнаяTableAdapter главнаяTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource учебаBindingSource;
        private Database1DataSetTableAdapters.УчебаTableAdapter учебаTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn иДDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn идВоеннослужащегоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn вУЗDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn специальностьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn годПоступленияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn годВыпускаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn примечаниеDataGridViewTextBoxColumn;
    }
}