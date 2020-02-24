namespace Army
{
    partial class editLanguage
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.главнаяBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new Army.Database1DataSet();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.языкиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.владениеЯзыкомBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.главнаяTableAdapter = new Army.Database1DataSetTableAdapters.ГлавнаяTableAdapter();
            this.языкиTableAdapter = new Army.Database1DataSetTableAdapters.ЯзыкиTableAdapter();
            this.владение_языкомTableAdapter = new Army.Database1DataSetTableAdapters.Владение_языкомTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.иДDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.иДВоеннослужащегоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.языкDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.степеньDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.примечаниеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.иностранныйBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.иностранныйTableAdapter = new Army.Database1DataSetTableAdapters.ИностранныйTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.главнаяBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.языкиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.владениеЯзыкомBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.иностранныйBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Служащий";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Язык";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Умение";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Примечание";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.главнаяBindingSource;
            this.comboBox1.DisplayMember = "Фамилия";
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(86, 13);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.ValueMember = "ИД";
            // 
            // главнаяBindingSource
            // 
            this.главнаяBindingSource.DataMember = "Главная";
            this.главнаяBindingSource.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.языкиBindingSource;
            this.comboBox2.DisplayMember = "Название";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(86, 40);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 5;
            this.comboBox2.ValueMember = "Название";
            // 
            // языкиBindingSource
            // 
            this.языкиBindingSource.DataMember = "Языки";
            this.языкиBindingSource.DataSource = this.database1DataSet;
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.владениеЯзыкомBindingSource;
            this.comboBox3.DisplayMember = "Название";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(86, 67);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 6;
            this.comboBox3.ValueMember = "Название";
            // 
            // владениеЯзыкомBindingSource
            // 
            this.владениеЯзыкомBindingSource.DataMember = "Владение языком";
            this.владениеЯзыкомBindingSource.DataSource = this.database1DataSet;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(86, 95);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 35);
            this.button1.TabIndex = 8;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // главнаяTableAdapter
            // 
            this.главнаяTableAdapter.ClearBeforeFill = true;
            // 
            // языкиTableAdapter
            // 
            this.языкиTableAdapter.ClearBeforeFill = true;
            // 
            // владение_языкомTableAdapter
            // 
            this.владение_языкомTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.иДDataGridViewTextBoxColumn,
            this.иДВоеннослужащегоDataGridViewTextBoxColumn,
            this.языкDataGridViewTextBoxColumn,
            this.степеньDataGridViewTextBoxColumn,
            this.примечаниеDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.иностранныйBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-33, 137);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.Visible = false;
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
            // языкDataGridViewTextBoxColumn
            // 
            this.языкDataGridViewTextBoxColumn.DataPropertyName = "Язык";
            this.языкDataGridViewTextBoxColumn.HeaderText = "Язык";
            this.языкDataGridViewTextBoxColumn.Name = "языкDataGridViewTextBoxColumn";
            // 
            // степеньDataGridViewTextBoxColumn
            // 
            this.степеньDataGridViewTextBoxColumn.DataPropertyName = "Степень";
            this.степеньDataGridViewTextBoxColumn.HeaderText = "Степень";
            this.степеньDataGridViewTextBoxColumn.Name = "степеньDataGridViewTextBoxColumn";
            // 
            // примечаниеDataGridViewTextBoxColumn
            // 
            this.примечаниеDataGridViewTextBoxColumn.DataPropertyName = "Примечание";
            this.примечаниеDataGridViewTextBoxColumn.HeaderText = "Примечание";
            this.примечаниеDataGridViewTextBoxColumn.Name = "примечаниеDataGridViewTextBoxColumn";
            // 
            // иностранныйBindingSource
            // 
            this.иностранныйBindingSource.DataMember = "Иностранный";
            this.иностранныйBindingSource.DataSource = this.database1DataSet;
            // 
            // иностранныйTableAdapter
            // 
            this.иностранныйTableAdapter.ClearBeforeFill = true;
            // 
            // editLanguage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(211, 168);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "editLanguage";
            this.Text = "editLanguage";
            this.Load += new System.EventHandler(this.editLanguage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.главнаяBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.языкиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.владениеЯзыкомBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.иностранныйBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource главнаяBindingSource;
        private Database1DataSetTableAdapters.ГлавнаяTableAdapter главнаяTableAdapter;
        private System.Windows.Forms.BindingSource языкиBindingSource;
        private Database1DataSetTableAdapters.ЯзыкиTableAdapter языкиTableAdapter;
        private System.Windows.Forms.BindingSource владениеЯзыкомBindingSource;
        private Database1DataSetTableAdapters.Владение_языкомTableAdapter владение_языкомTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource иностранныйBindingSource;
        private Database1DataSetTableAdapters.ИностранныйTableAdapter иностранныйTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn иДDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn иДВоеннослужащегоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn языкDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn степеньDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn примечаниеDataGridViewTextBoxColumn;
    }
}