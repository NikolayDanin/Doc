namespace Prog1
{
    partial class LU
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LU));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SoglL = new System.Windows.Forms.ComboBox();
            this.SoglFIOL = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.UtverDolgL = new System.Windows.Forms.ComboBox();
            this.UtverFIOL = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.NameL = new System.Windows.Forms.TextBox();
            this.CivrL = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.NormL = new System.Windows.Forms.ComboBox();
            this.IspolnL = new System.Windows.Forms.TextBox();
            this.RukRazrL = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.PredstL = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.LiteraL = new System.Windows.Forms.ComboBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Согласовано должность";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label2.Location = new System.Drawing.Point(6, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Согласовано ФИО";
            // 
            // SoglL
            // 
            this.SoglL.Font = new System.Drawing.Font("Arial", 9.75F);
            this.SoglL.FormattingEnabled = true;
            this.SoglL.Items.AddRange(new object[] {
            "Начальник 2 отдела 119 ВП МО РФ"});
            this.SoglL.Location = new System.Drawing.Point(165, 14);
            this.SoglL.Name = "SoglL";
            this.SoglL.Size = new System.Drawing.Size(281, 24);
            this.SoglL.TabIndex = 9;
            this.toolTip1.SetToolTip(this.SoglL, "Выбрать или ввести вручную\r\n");
            // 
            // SoglFIOL
            // 
            this.SoglFIOL.Font = new System.Drawing.Font("Arial", 9.75F);
            this.SoglFIOL.FormattingEnabled = true;
            this.SoglFIOL.Items.AddRange(new object[] {
            "М.А. Логинов"});
            this.SoglFIOL.Location = new System.Drawing.Point(165, 44);
            this.SoglFIOL.Name = "SoglFIOL";
            this.SoglFIOL.Size = new System.Drawing.Size(281, 24);
            this.SoglFIOL.TabIndex = 10;
            this.toolTip1.SetToolTip(this.SoglFIOL, "Выбрать или ввести вручную\r\nПример: И.И. Иванов");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label3.Location = new System.Drawing.Point(11, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Утверждено должность";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label4.Location = new System.Drawing.Point(11, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Утверждено ФИО";
            // 
            // UtverDolgL
            // 
            this.UtverDolgL.Font = new System.Drawing.Font("Arial", 9.75F);
            this.UtverDolgL.FormattingEnabled = true;
            this.UtverDolgL.Items.AddRange(new object[] {
            "Зам. начальника ОКБ «ЛЭМЗ» – Директор НПЦ СПб ПАО «НПО «Алмаз»"});
            this.UtverDolgL.Location = new System.Drawing.Point(165, 14);
            this.UtverDolgL.Name = "UtverDolgL";
            this.UtverDolgL.Size = new System.Drawing.Size(281, 24);
            this.UtverDolgL.TabIndex = 12;
            this.toolTip1.SetToolTip(this.UtverDolgL, "Выбрать или ввести вручную\r\n");
            // 
            // UtverFIOL
            // 
            this.UtverFIOL.Font = new System.Drawing.Font("Arial", 9.75F);
            this.UtverFIOL.FormattingEnabled = true;
            this.UtverFIOL.Items.AddRange(new object[] {
            "С.Ю. Нестеров"});
            this.UtverFIOL.Location = new System.Drawing.Point(165, 44);
            this.UtverFIOL.Name = "UtverFIOL";
            this.UtverFIOL.Size = new System.Drawing.Size(281, 24);
            this.UtverFIOL.TabIndex = 13;
            this.toolTip1.SetToolTip(this.UtverFIOL, "Выбрать или ввести вручную\r\nПример: И.И. Иванов");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label5.Location = new System.Drawing.Point(11, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Наименование программы";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label6.Location = new System.Drawing.Point(11, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Децимальный номер";
            // 
            // NameL
            // 
            this.NameL.Font = new System.Drawing.Font("Arial", 9.75F);
            this.NameL.Location = new System.Drawing.Point(179, 39);
            this.NameL.Multiline = true;
            this.NameL.Name = "NameL";
            this.NameL.Size = new System.Drawing.Size(552, 24);
            this.NameL.TabIndex = 2;
            this.toolTip1.SetToolTip(this.NameL, "Пример: Программно-технического комплекса руководителя полетов");
            this.NameL.TextChanged += new System.EventHandler(this.NameL_TextChanged);
            // 
            // CivrL
            // 
            this.CivrL.Font = new System.Drawing.Font("Arial", 9.75F);
            this.CivrL.Location = new System.Drawing.Point(179, 8);
            this.CivrL.Multiline = true;
            this.CivrL.Name = "CivrL";
            this.CivrL.Size = new System.Drawing.Size(281, 24);
            this.CivrL.TabIndex = 1;
            this.toolTip1.SetToolTip(this.CivrL, "Пример: 00649-01");
            this.CivrL.TextChanged += new System.EventHandler(this.CivrL_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label7.Location = new System.Drawing.Point(11, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Руководитель разработки";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label8.Location = new System.Drawing.Point(11, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "Исполнитель";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label9.Location = new System.Drawing.Point(11, 166);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 16);
            this.label9.TabIndex = 14;
            this.label9.Text = "Нормоконтролер";
            // 
            // NormL
            // 
            this.NormL.Font = new System.Drawing.Font("Arial", 9.75F);
            this.NormL.FormattingEnabled = true;
            this.NormL.Items.AddRange(new object[] {
            "Д.Н. Жигарев"});
            this.NormL.Location = new System.Drawing.Point(179, 163);
            this.NormL.Name = "NormL";
            this.NormL.Size = new System.Drawing.Size(281, 24);
            this.NormL.TabIndex = 6;
            this.toolTip1.SetToolTip(this.NormL, "Выбрать или ввести вручную\r\nПример: И.И. Иванов");
            // 
            // IspolnL
            // 
            this.IspolnL.Font = new System.Drawing.Font("Arial", 9.75F);
            this.IspolnL.Location = new System.Drawing.Point(179, 132);
            this.IspolnL.Multiline = true;
            this.IspolnL.Name = "IspolnL";
            this.IspolnL.Size = new System.Drawing.Size(281, 24);
            this.IspolnL.TabIndex = 5;
            this.toolTip1.SetToolTip(this.IspolnL, "Пример: И.И. Иванов");
            // 
            // RukRazrL
            // 
            this.RukRazrL.Font = new System.Drawing.Font("Arial", 9.75F);
            this.RukRazrL.Location = new System.Drawing.Point(179, 101);
            this.RukRazrL.Multiline = true;
            this.RukRazrL.Name = "RukRazrL";
            this.RukRazrL.Size = new System.Drawing.Size(281, 24);
            this.RukRazrL.TabIndex = 4;
            this.toolTip1.SetToolTip(this.RukRazrL, "Пример: И.И. Иванов");
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(488, 337);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(243, 36);
            this.button1.TabIndex = 15;
            this.button1.Text = "Сформировать и открыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label10.Location = new System.Drawing.Point(11, 73);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 16);
            this.label10.TabIndex = 19;
            this.label10.Text = "Представитель";
            // 
            // PredstL
            // 
            this.PredstL.Font = new System.Drawing.Font("Arial", 9.75F);
            this.PredstL.FormattingEnabled = true;
            this.PredstL.Items.AddRange(new object[] {
            "Представитель 2 отдела 119 ВП МО РФ"});
            this.PredstL.Location = new System.Drawing.Point(179, 70);
            this.PredstL.Name = "PredstL";
            this.PredstL.Size = new System.Drawing.Size(281, 24);
            this.PredstL.TabIndex = 3;
            this.toolTip1.SetToolTip(this.PredstL, "Выбрать или ввести вручную");
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.SoglL);
            this.groupBox1.Controls.Add(this.SoglFIOL);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(14, 219);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(458, 77);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Согласование";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.UtverFIOL);
            this.groupBox2.Controls.Add(this.UtverDolgL);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(14, 296);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(458, 77);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Утверждение";
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 200;
            this.toolTip1.ReshowDelay = 100;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Подсказка";
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // LiteraL
            // 
            this.LiteraL.Font = new System.Drawing.Font("Arial", 9.75F);
            this.LiteraL.FormattingEnabled = true;
            this.LiteraL.Items.AddRange(new object[] {
            "О1"});
            this.LiteraL.Location = new System.Drawing.Point(179, 193);
            this.LiteraL.Name = "LiteraL";
            this.LiteraL.Size = new System.Drawing.Size(281, 24);
            this.LiteraL.TabIndex = 7;
            this.toolTip1.SetToolTip(this.LiteraL, "Выбрать или ввести вручную");
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial", 9F);
            this.button2.Location = new System.Drawing.Point(489, 299);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(242, 32);
            this.button2.TabIndex = 14;
            this.button2.Text = "Пример оформления";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label11.Location = new System.Drawing.Point(11, 196);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 16);
            this.label11.TabIndex = 21;
            this.label11.Text = "Литера";
            // 
            // LU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(742, 381);
            this.Controls.Add(this.LiteraL);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PredstL);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.RukRazrL);
            this.Controls.Add(this.IspolnL);
            this.Controls.Add(this.NormL);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CivrL);
            this.Controls.Add(this.NameL);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LU";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Листы утверждения";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox SoglL;
        private System.Windows.Forms.ComboBox SoglFIOL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox UtverDolgL;
        private System.Windows.Forms.ComboBox UtverFIOL;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox NameL;
        private System.Windows.Forms.TextBox CivrL;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox NormL;
        private System.Windows.Forms.TextBox IspolnL;
        private System.Windows.Forms.TextBox RukRazrL;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox PredstL;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox LiteraL;
        private System.Windows.Forms.Label label11;
    }
}