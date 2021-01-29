
namespace Prog1
{
    partial class Etiketka
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Etiketka));
            this.CivrE = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.MT02 = new System.Windows.Forms.TextBox();
            this.NamePP = new System.Windows.Forms.TextBox();
            this.MT03 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.MT81 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.KodE = new System.Windows.Forms.ComboBox();
            this.DateE = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.NomTomE = new System.Windows.Forms.ComboBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button3 = new System.Windows.Forms.Button();
            this.saveToDb = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.etiketkaModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.decimalNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.programNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.volumeSequenceNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.setupDiscDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sourceDiscDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.etiketkaModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // CivrE
            // 
            this.CivrE.Font = new System.Drawing.Font("Arial", 9.75F);
            this.CivrE.Location = new System.Drawing.Point(246, 6);
            this.CivrE.Multiline = true;
            this.CivrE.Name = "CivrE";
            this.CivrE.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CivrE.Size = new System.Drawing.Size(140, 24);
            this.CivrE.TabIndex = 1;
            this.toolTip1.SetToolTip(this.CivrE, "Пример: 00649-01");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Децимальный номер";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label2.Location = new System.Drawing.Point(12, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "№ МНЗ 12 02 Установочный диск";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label3.Location = new System.Drawing.Point(12, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Наименование программы";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(555, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(243, 36);
            this.button1.TabIndex = 10;
            this.button1.Text = "Сформировать и открыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // MT02
            // 
            this.MT02.Font = new System.Drawing.Font("Arial", 9.75F);
            this.MT02.Location = new System.Drawing.Point(246, 157);
            this.MT02.Multiline = true;
            this.MT02.Name = "MT02";
            this.MT02.Size = new System.Drawing.Size(140, 24);
            this.MT02.TabIndex = 6;
            this.toolTip1.SetToolTip(this.MT02, "Пример: 9001");
            // 
            // NamePP
            // 
            this.NamePP.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NamePP.Location = new System.Drawing.Point(246, 37);
            this.NamePP.Multiline = true;
            this.NamePP.Name = "NamePP";
            this.NamePP.Size = new System.Drawing.Size(552, 24);
            this.NamePP.TabIndex = 2;
            this.toolTip1.SetToolTip(this.NamePP, "Пример: Программно-технического комплекса руководителя полетов");
            this.NamePP.TextChanged += new System.EventHandler(this.NamePP_TextChanged);
            // 
            // MT03
            // 
            this.MT03.Font = new System.Drawing.Font("Arial", 9.75F);
            this.MT03.Location = new System.Drawing.Point(246, 187);
            this.MT03.Multiline = true;
            this.MT03.Name = "MT03";
            this.MT03.Size = new System.Drawing.Size(140, 24);
            this.MT03.TabIndex = 7;
            this.toolTip1.SetToolTip(this.MT03, "Пример: 9001");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label4.Location = new System.Drawing.Point(12, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(234, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "№ МНЗ 12 03 Диск исходных текстов";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label5.Location = new System.Drawing.Point(12, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(218, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "№ МНЗ 81 Пояснительная записка";
            // 
            // MT81
            // 
            this.MT81.Font = new System.Drawing.Font("Arial", 9.75F);
            this.MT81.Location = new System.Drawing.Point(246, 217);
            this.MT81.Multiline = true;
            this.MT81.Name = "MT81";
            this.MT81.Size = new System.Drawing.Size(140, 24);
            this.MT81.TabIndex = 8;
            this.toolTip1.SetToolTip(this.MT81, "Пример: 9001");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label6.Location = new System.Drawing.Point(12, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Код документа";
            // 
            // KodE
            // 
            this.KodE.Font = new System.Drawing.Font("Arial", 9.75F);
            this.KodE.FormattingEnabled = true;
            this.KodE.Items.AddRange(new object[] {
            "П",
            "Д",
            "К",
            "КК"});
            this.KodE.Location = new System.Drawing.Point(246, 67);
            this.KodE.Name = "KodE";
            this.KodE.Size = new System.Drawing.Size(140, 24);
            this.KodE.TabIndex = 3;
            this.toolTip1.SetToolTip(this.KodE, "П - подлинник\r\nД - дубликат\r\nК - копия\r\nКК - контрольная копия");
            // 
            // DateE
            // 
            this.DateE.Font = new System.Drawing.Font("Arial", 9.75F);
            this.DateE.Location = new System.Drawing.Point(246, 97);
            this.DateE.MinimumSize = new System.Drawing.Size(140, 24);
            this.DateE.Name = "DateE";
            this.DateE.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DateE.Size = new System.Drawing.Size(140, 24);
            this.DateE.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label7.Location = new System.Drawing.Point(12, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Дата записи на носитель";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label8.Location = new System.Drawing.Point(12, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "Порядковый номер тома";
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 200;
            this.toolTip1.ReshowDelay = 100;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Подсказка";
            // 
            // NomTomE
            // 
            this.NomTomE.Font = new System.Drawing.Font("Arial", 9.75F);
            this.NomTomE.FormattingEnabled = true;
            this.NomTomE.Items.AddRange(new object[] {
            "1/1"});
            this.NomTomE.Location = new System.Drawing.Point(246, 127);
            this.NomTomE.Name = "NomTomE";
            this.NomTomE.Size = new System.Drawing.Size(140, 24);
            this.NomTomE.TabIndex = 5;
            this.toolTip1.SetToolTip(this.NomTomE, "Примеры:\r\n1/2\r\n2/2");
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(555, 168);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(243, 31);
            this.button3.TabIndex = 9;
            this.button3.Text = "Пример оформления";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // saveToDb
            // 
            this.saveToDb.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveToDb.Location = new System.Drawing.Point(555, 123);
            this.saveToDb.Name = "saveToDb";
            this.saveToDb.Size = new System.Drawing.Size(243, 31);
            this.saveToDb.TabIndex = 17;
            this.saveToDb.Text = "Сохранить в БД";
            this.saveToDb.UseVisualStyleBackColor = true;
            this.saveToDb.Click += new System.EventHandler(this.saveToDb_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.decimalNumberDataGridViewTextBoxColumn,
            this.programNameDataGridViewTextBoxColumn,
            this.documentCodeDataGridViewTextBoxColumn,
            this.createDateDataGridViewTextBoxColumn,
            this.volumeSequenceNumberDataGridViewTextBoxColumn,
            this.setupDiscDataGridViewTextBoxColumn,
            this.sourceDiscDataGridViewTextBoxColumn,
            this.noteDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.etiketkaModelBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(15, 258);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(783, 281);
            this.dataGridView1.TabIndex = 18;
            // 
            // etiketkaModelBindingSource
            // 
            this.etiketkaModelBindingSource.DataSource = typeof(Prog1.Models.LabelModel);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // decimalNumberDataGridViewTextBoxColumn
            // 
            this.decimalNumberDataGridViewTextBoxColumn.DataPropertyName = "DecimalNumber";
            this.decimalNumberDataGridViewTextBoxColumn.HeaderText = "DecimalNumber";
            this.decimalNumberDataGridViewTextBoxColumn.Name = "decimalNumberDataGridViewTextBoxColumn";
            // 
            // programNameDataGridViewTextBoxColumn
            // 
            this.programNameDataGridViewTextBoxColumn.DataPropertyName = "ProgramName";
            this.programNameDataGridViewTextBoxColumn.HeaderText = "ProgramName";
            this.programNameDataGridViewTextBoxColumn.Name = "programNameDataGridViewTextBoxColumn";
            // 
            // documentCodeDataGridViewTextBoxColumn
            // 
            this.documentCodeDataGridViewTextBoxColumn.DataPropertyName = "DocumentCode";
            this.documentCodeDataGridViewTextBoxColumn.HeaderText = "DocumentCode";
            this.documentCodeDataGridViewTextBoxColumn.Name = "documentCodeDataGridViewTextBoxColumn";
            // 
            // createDateDataGridViewTextBoxColumn
            // 
            this.createDateDataGridViewTextBoxColumn.DataPropertyName = "CreateDate";
            this.createDateDataGridViewTextBoxColumn.HeaderText = "CreateDate";
            this.createDateDataGridViewTextBoxColumn.Name = "createDateDataGridViewTextBoxColumn";
            // 
            // volumeSequenceNumberDataGridViewTextBoxColumn
            // 
            this.volumeSequenceNumberDataGridViewTextBoxColumn.DataPropertyName = "VolumeSequenceNumber";
            this.volumeSequenceNumberDataGridViewTextBoxColumn.HeaderText = "VolumeSequenceNumber";
            this.volumeSequenceNumberDataGridViewTextBoxColumn.Name = "volumeSequenceNumberDataGridViewTextBoxColumn";
            // 
            // setupDiscDataGridViewTextBoxColumn
            // 
            this.setupDiscDataGridViewTextBoxColumn.DataPropertyName = "SetupDisc";
            this.setupDiscDataGridViewTextBoxColumn.HeaderText = "SetupDisc";
            this.setupDiscDataGridViewTextBoxColumn.Name = "setupDiscDataGridViewTextBoxColumn";
            // 
            // sourceDiscDataGridViewTextBoxColumn
            // 
            this.sourceDiscDataGridViewTextBoxColumn.DataPropertyName = "SourceDisc";
            this.sourceDiscDataGridViewTextBoxColumn.HeaderText = "SourceDisc";
            this.sourceDiscDataGridViewTextBoxColumn.Name = "sourceDiscDataGridViewTextBoxColumn";
            // 
            // noteDataGridViewTextBoxColumn
            // 
            this.noteDataGridViewTextBoxColumn.DataPropertyName = "Note";
            this.noteDataGridViewTextBoxColumn.HeaderText = "Note";
            this.noteDataGridViewTextBoxColumn.Name = "noteDataGridViewTextBoxColumn";
            // 
            // Etiketka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 551);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.saveToDb);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.NomTomE);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DateE);
            this.Controls.Add(this.KodE);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.MT81);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MT03);
            this.Controls.Add(this.NamePP);
            this.Controls.Add(this.MT02);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CivrE);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Etiketka";
            this.Text = "Этикетки";
            this.Load += new System.EventHandler(this.Etiketka_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.etiketkaModelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CivrE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox MT02;
        private System.Windows.Forms.TextBox NamePP;
        private System.Windows.Forms.TextBox MT03;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox MT81;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox KodE;
        private System.Windows.Forms.DateTimePicker DateE;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ComboBox NomTomE;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button saveToDb;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn decimalNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn programNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn volumeSequenceNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn setupDiscDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sourceDiscDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource etiketkaModelBindingSource;
    }
}