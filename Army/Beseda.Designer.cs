namespace Army
{
    partial class Beseda
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.database1DataSet = new Army.Database1DataSet();
            this.кандидатыНаВоеннуюСлужбуBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.кандидаты_на_военную_службуTableAdapter = new Army.Database1DataSetTableAdapters.Кандидаты_на_военную_службуTableAdapter();
            this.беседовалиСКандидатомBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.беседовали_с_кандидатомTableAdapter = new Army.Database1DataSetTableAdapters.Беседовали_с_кандидатомTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.кандидатыНаВоеннуюСлужбуBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.беседовалиСКандидатомBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Кто";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Когда";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Примечание";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(116, 64);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(103, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(116, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(103, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(116, 90);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(103, 20);
            this.textBox2.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 41);
            this.button1.TabIndex = 6;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.кандидатыНаВоеннуюСлужбуBindingSource;
            this.comboBox2.DisplayMember = "ФИО";
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Enabled = false;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(116, 12);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(103, 21);
            this.comboBox2.TabIndex = 21;
            this.comboBox2.ValueMember = "ИД";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Кандидат";
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // кандидатыНаВоеннуюСлужбуBindingSource
            // 
            this.кандидатыНаВоеннуюСлужбуBindingSource.DataMember = "Кандидаты на военную службу";
            this.кандидатыНаВоеннуюСлужбуBindingSource.DataSource = this.database1DataSet;
            // 
            // кандидаты_на_военную_службуTableAdapter
            // 
            this.кандидаты_на_военную_службуTableAdapter.ClearBeforeFill = true;
            // 
            // беседовалиСКандидатомBindingSource
            // 
            this.беседовалиСКандидатомBindingSource.DataMember = "Беседовали с кандидатом";
            this.беседовалиСКандидатомBindingSource.DataSource = this.database1DataSet;
            // 
            // беседовали_с_кандидатомTableAdapter
            // 
            this.беседовали_с_кандидатомTableAdapter.ClearBeforeFill = true;
            // 
            // Beseda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 170);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Beseda";
            this.Text = "Беседас кандидатом";
            this.Load += new System.EventHandler(this.Beseda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.кандидатыНаВоеннуюСлужбуBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.беседовалиСКандидатомBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label6;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource кандидатыНаВоеннуюСлужбуBindingSource;
        private Database1DataSetTableAdapters.Кандидаты_на_военную_службуTableAdapter кандидаты_на_военную_службуTableAdapter;
        private System.Windows.Forms.BindingSource беседовалиСКандидатомBindingSource;
        private Database1DataSetTableAdapters.Беседовали_с_кандидатомTableAdapter беседовали_с_кандидатомTableAdapter;
    }
}