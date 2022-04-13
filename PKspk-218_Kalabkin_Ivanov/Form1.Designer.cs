
namespace PKspk_218_Kalabkin_Ivanov
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label delim_chisloLabel;
            System.Windows.Forms.Label delitelLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataSet1 = new PKspk_218_Kalabkin_Ivanov.DataSet1();
            this.natural_ChislaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.natural_ChislaTableAdapter = new PKspk_218_Kalabkin_Ivanov.DataSet1TableAdapters.Natural_ChislaTableAdapter();
            this.tableAdapterManager = new PKspk_218_Kalabkin_Ivanov.DataSet1TableAdapters.TableAdapterManager();
            this.natural_ChislaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delim_chisloTextBox = new System.Windows.Forms.TextBox();
            this.delitelTextBox = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            delim_chisloLabel = new System.Windows.Forms.Label();
            delitelLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.natural_ChislaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.natural_ChislaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // delim_chisloLabel
            // 
            delim_chisloLabel.AutoSize = true;
            delim_chisloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            delim_chisloLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            delim_chisloLabel.Location = new System.Drawing.Point(27, 346);
            delim_chisloLabel.Name = "delim_chisloLabel";
            delim_chisloLabel.Size = new System.Drawing.Size(69, 16);
            delim_chisloLabel.TabIndex = 5;
            delim_chisloLabel.Text = "Делимое:";
            // 
            // delitelLabel
            // 
            delitelLabel.AutoSize = true;
            delitelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            delitelLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            delitelLabel.Location = new System.Drawing.Point(22, 380);
            delitelLabel.Name = "delitelLabel";
            delitelLabel.Size = new System.Drawing.Size(74, 16);
            delitelLabel.TabIndex = 7;
            delitelLabel.Text = "Делитель:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown1.Location = new System.Drawing.Point(560, 29);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            50000000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(241, 38);
            this.numericUpDown1.TabIndex = 0;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(560, 98);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(241, 196);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(977, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 67);
            this.button1.TabIndex = 2;
            this.button1.Text = "Вывести  сумму и количество натуральных чисел";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.button1.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(977, 227);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(179, 67);
            this.button2.TabIndex = 3;
            this.button2.Text = "Добавить натуральные делители в таблицу";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.MouseLeave += new System.EventHandler(this.button2_MouseLeave);
            this.button2.MouseHover += new System.EventHandler(this.button2_MouseHover);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // natural_ChislaBindingSource
            // 
            this.natural_ChislaBindingSource.DataMember = "Natural_Chisla";
            this.natural_ChislaBindingSource.DataSource = this.dataSet1;
            // 
            // natural_ChislaTableAdapter
            // 
            this.natural_ChislaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Natural_ChislaTableAdapter = this.natural_ChislaTableAdapter;
            this.tableAdapterManager.UpdateOrder = PKspk_218_Kalabkin_Ivanov.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // natural_ChislaDataGridView
            // 
            this.natural_ChislaDataGridView.AllowUserToAddRows = false;
            this.natural_ChislaDataGridView.AllowUserToDeleteRows = false;
            this.natural_ChislaDataGridView.AutoGenerateColumns = false;
            this.natural_ChislaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.natural_ChislaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.natural_ChislaDataGridView.DataSource = this.natural_ChislaBindingSource;
            this.natural_ChislaDataGridView.Location = new System.Drawing.Point(24, 29);
            this.natural_ChislaDataGridView.Name = "natural_ChislaDataGridView";
            this.natural_ChislaDataGridView.ReadOnly = true;
            this.natural_ChislaDataGridView.Size = new System.Drawing.Size(494, 265);
            this.natural_ChislaDataGridView.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "cat_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Номер числа";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Delim_chislo";
            this.dataGridViewTextBoxColumn2.HeaderText = "Делимое";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Delitel";
            this.dataGridViewTextBoxColumn3.HeaderText = "Делитель";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // delim_chisloTextBox
            // 
            this.delim_chisloTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.natural_ChislaBindingSource, "Delim_chislo", true));
            this.delim_chisloTextBox.Location = new System.Drawing.Point(102, 345);
            this.delim_chisloTextBox.Name = "delim_chisloTextBox";
            this.delim_chisloTextBox.Size = new System.Drawing.Size(100, 20);
            this.delim_chisloTextBox.TabIndex = 6;
            this.delim_chisloTextBox.TextChanged += new System.EventHandler(this.delim_chisloTextBox_TextChanged);
            // 
            // delitelTextBox
            // 
            this.delitelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.natural_ChislaBindingSource, "Delitel", true));
            this.delitelTextBox.Location = new System.Drawing.Point(102, 379);
            this.delitelTextBox.Name = "delitelTextBox";
            this.delitelTextBox.Size = new System.Drawing.Size(100, 20);
            this.delitelTextBox.TabIndex = 8;
            this.delitelTextBox.TextChanged += new System.EventHandler(this.delitelTextBox_TextChanged);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(977, 338);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(179, 67);
            this.button3.TabIndex = 9;
            this.button3.Text = "Закрыть приложение";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(646, 346);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(171, 59);
            this.button4.TabIndex = 10;
            this.button4.Text = "Очистить таблицу!";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(442, 346);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(179, 56);
            this.button5.TabIndex = 11;
            this.button5.Text = "Очистить консоль";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.Location = new System.Drawing.Point(251, 346);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(164, 56);
            this.button6.TabIndex = 12;
            this.button6.Text = "Руководство пользователя и авторы";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(524, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Waring";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(985, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(946, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.ClientSize = new System.Drawing.Size(1168, 426);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(delitelLabel);
            this.Controls.Add(this.delitelTextBox);
            this.Controls.Add(delim_chisloLabel);
            this.Controls.Add(this.delim_chisloTextBox);
            this.Controls.Add(this.natural_ChislaDataGridView);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.numericUpDown1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Калькулятор натуральных делителей ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.natural_ChislaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.natural_ChislaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource natural_ChislaBindingSource;
        private DataSet1TableAdapters.Natural_ChislaTableAdapter natural_ChislaTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView natural_ChislaDataGridView;
        private System.Windows.Forms.TextBox delim_chisloTextBox;
        private System.Windows.Forms.TextBox delitelTextBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

