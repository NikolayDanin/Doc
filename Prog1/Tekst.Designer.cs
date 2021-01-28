namespace Prog1
{
    partial class Tekst
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tekst));
            this.label1 = new System.Windows.Forms.Label();
            this.CivrT = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.NameT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NaUsT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.NaIsT = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.NakopiT = new System.Windows.Forms.ComboBox();
            this.OCT = new System.Windows.Forms.ComboBox();
            this.LangT = new System.Windows.Forms.ComboBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.LiteraT = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Децимальный номер";
            // 
            // CivrT
            // 
            this.CivrT.Font = new System.Drawing.Font("Arial", 9.75F);
            this.CivrT.Location = new System.Drawing.Point(176, 15);
            this.CivrT.Multiline = true;
            this.CivrT.Name = "CivrT";
            this.CivrT.Size = new System.Drawing.Size(100, 24);
            this.CivrT.TabIndex = 1;
            this.toolTip1.SetToolTip(this.CivrT, "Пример: 00649-01");
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(485, 252);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(243, 36);
            this.button1.TabIndex = 12;
            this.button1.Text = "Сформировать и открыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Наименование программы";
            // 
            // NameT
            // 
            this.NameT.Font = new System.Drawing.Font("Arial", 9.75F);
            this.NameT.Location = new System.Drawing.Point(176, 45);
            this.NameT.Multiline = true;
            this.NameT.Name = "NameT";
            this.NameT.Size = new System.Drawing.Size(552, 24);
            this.NameT.TabIndex = 2;
            this.toolTip1.SetToolTip(this.NameT, "Пример: Программно-технического комплекса руководителя полетов");
            this.NameT.TextChanged += new System.EventHandler(this.NameT_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label3.Location = new System.Drawing.Point(12, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Операционная система";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label4.Location = new System.Drawing.Point(12, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Язык программирования";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label5.Location = new System.Drawing.Point(6, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Имя файла";
            // 
            // NaUsT
            // 
            this.NaUsT.Font = new System.Drawing.Font("Arial", 9.75F);
            this.NaUsT.Location = new System.Drawing.Point(165, 17);
            this.NaUsT.Multiline = true;
            this.NaUsT.Name = "NaUsT";
            this.NaUsT.Size = new System.Drawing.Size(179, 24);
            this.NaUsT.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label6.Location = new System.Drawing.Point(6, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Имя файла";
            // 
            // NaIsT
            // 
            this.NaIsT.Font = new System.Drawing.Font("Arial", 9.75F);
            this.NaIsT.Location = new System.Drawing.Point(160, 18);
            this.NaIsT.Multiline = true;
            this.NaIsT.Name = "NaIsT";
            this.NaIsT.Size = new System.Drawing.Size(180, 24);
            this.NaIsT.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.NaUsT);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(12, 196);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 51);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "12 02 Установочный пакет";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 15);
            this.label9.TabIndex = 15;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.NaIsT);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(378, 196);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(350, 51);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "12 03 Исходные тексты";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label10.Location = new System.Drawing.Point(12, 138);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(133, 16);
            this.label10.TabIndex = 19;
            this.label10.Text = "Данные записаны на";
            // 
            // NakopiT
            // 
            this.NakopiT.Font = new System.Drawing.Font("Arial", 9.75F);
            this.NakopiT.FormattingEnabled = true;
            this.NakopiT.Items.AddRange(new object[] {
            "DVD-диске",
            "USB-накопителе"});
            this.NakopiT.Location = new System.Drawing.Point(176, 135);
            this.NakopiT.Name = "NakopiT";
            this.NakopiT.Size = new System.Drawing.Size(130, 24);
            this.NakopiT.TabIndex = 5;
            this.toolTip1.SetToolTip(this.NakopiT, "Выбрать или ввести вручную");
            // 
            // OCT
            // 
            this.OCT.Font = new System.Drawing.Font("Arial", 9.75F);
            this.OCT.FormattingEnabled = true;
            this.OCT.Items.AddRange(new object[] {
            "Astra Linux Special Edition Смоленск 1.5",
            "Astra Linux Special Edition Смоленск 1.6"});
            this.OCT.Location = new System.Drawing.Point(176, 75);
            this.OCT.Name = "OCT";
            this.OCT.Size = new System.Drawing.Size(552, 24);
            this.OCT.TabIndex = 3;
            this.toolTip1.SetToolTip(this.OCT, "Выбрать или ввести вручную");
            // 
            // LangT
            // 
            this.LangT.AutoCompleteCustomSource.AddRange(new string[] {
            "С",
            "С ++"});
            this.LangT.Font = new System.Drawing.Font("Arial", 9.75F);
            this.LangT.FormattingEnabled = true;
            this.LangT.Items.AddRange(new object[] {
            "C",
            "C++"});
            this.LangT.Location = new System.Drawing.Point(176, 105);
            this.LangT.Name = "LangT";
            this.LangT.Size = new System.Drawing.Size(130, 24);
            this.LangT.TabIndex = 4;
            this.toolTip1.SetToolTip(this.LangT, "Выбрать или ввести вручную");
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 200;
            this.toolTip1.ReshowDelay = 100;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Подсказка";
            // 
            // LiteraT
            // 
            this.LiteraT.Font = new System.Drawing.Font("Arial", 9.75F);
            this.LiteraT.FormattingEnabled = true;
            this.LiteraT.Items.AddRange(new object[] {
            "О1"});
            this.LiteraT.Location = new System.Drawing.Point(176, 165);
            this.LiteraT.Name = "LiteraT";
            this.LiteraT.Size = new System.Drawing.Size(130, 24);
            this.LiteraT.TabIndex = 6;
            this.toolTip1.SetToolTip(this.LiteraT, "Выбрать или ввести вручную");
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(327, 252);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 36);
            this.button2.TabIndex = 11;
            this.button2.Text = "Пример оформления";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label7.Location = new System.Drawing.Point(12, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 16);
            this.label7.TabIndex = 21;
            this.label7.Text = "Литера";
            // 
            // Tekst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 298);
            this.Controls.Add(this.LiteraT);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.LangT);
            this.Controls.Add(this.OCT);
            this.Controls.Add(this.NakopiT);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NameT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CivrT);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Tekst";
            this.Text = " Текст программы";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CivrT;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NameT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NaUsT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox NaIsT;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox NakopiT;
        private System.Windows.Forms.ComboBox OCT;
        private System.Windows.Forms.ComboBox LangT;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox LiteraT;
        private System.Windows.Forms.Label label7;
    }
}