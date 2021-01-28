namespace Prog1
{
    partial class Vedomostb
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vedomostb));
            this.label1 = new System.Windows.Forms.Label();
            this.CivrVE = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.NameVe = new System.Windows.Forms.TextBox();
            this.kV1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MestoV1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.MestoV2 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.kV2 = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.MestoV3 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.kV3 = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.MestoV4 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.kV4 = new System.Windows.Forms.ComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.LiteraVe = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label1.Location = new System.Drawing.Point(8, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Децимальный номер";
            // 
            // CivrVE
            // 
            this.CivrVE.Font = new System.Drawing.Font("Arial", 9.75F);
            this.CivrVE.Location = new System.Drawing.Point(188, 8);
            this.CivrVE.Multiline = true;
            this.CivrVE.Name = "CivrVE";
            this.CivrVE.Size = new System.Drawing.Size(100, 24);
            this.CivrVE.TabIndex = 1;
            this.toolTip1.SetToolTip(this.CivrVE, "Пример: 00649-01");
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(519, 264);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(243, 36);
            this.button1.TabIndex = 17;
            this.button1.Text = "Сформировать и открыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label2.Location = new System.Drawing.Point(8, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Наименование программы";
            // 
            // NameVe
            // 
            this.NameVe.Font = new System.Drawing.Font("Arial", 9.75F);
            this.NameVe.Location = new System.Drawing.Point(188, 39);
            this.NameVe.Multiline = true;
            this.NameVe.Name = "NameVe";
            this.NameVe.Size = new System.Drawing.Size(575, 24);
            this.NameVe.TabIndex = 2;
            this.toolTip1.SetToolTip(this.NameVe, "Пример: Программно-технического комплекса руководителя полетов");
            this.NameVe.TextChanged += new System.EventHandler(this.NameVe_TextChanged);
            // 
            // kV1
            // 
            this.kV1.Font = new System.Drawing.Font("Arial", 9.75F);
            this.kV1.FormattingEnabled = true;
            this.kV1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            ""});
            this.kV1.Location = new System.Drawing.Point(177, 15);
            this.kV1.Name = "kV1";
            this.kV1.Size = new System.Drawing.Size(42, 24);
            this.kV1.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label4.Location = new System.Drawing.Point(6, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Колличество экземпляров";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MestoV1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.kV1);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(10, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(496, 47);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "30 Формуляр";
            // 
            // MestoV1
            // 
            this.MestoV1.Font = new System.Drawing.Font("Arial", 9.75F);
            this.MestoV1.FormattingEnabled = true;
            this.MestoV1.Items.AddRange(new object[] {
            "Папка № 1"});
            this.MestoV1.Location = new System.Drawing.Point(369, 14);
            this.MestoV1.Name = "MestoV1";
            this.MestoV1.Size = new System.Drawing.Size(121, 24);
            this.MestoV1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label3.Location = new System.Drawing.Point(236, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Местонахождение";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.MestoV2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.kV2);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(10, 147);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(496, 47);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "31 Описание применения";
            // 
            // MestoV2
            // 
            this.MestoV2.Font = new System.Drawing.Font("Arial", 9.75F);
            this.MestoV2.FormattingEnabled = true;
            this.MestoV2.Items.AddRange(new object[] {
            "Папка № 1"});
            this.MestoV2.Location = new System.Drawing.Point(369, 14);
            this.MestoV2.Name = "MestoV2";
            this.MestoV2.Size = new System.Drawing.Size(121, 24);
            this.MestoV2.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label5.Location = new System.Drawing.Point(236, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Местонахождение";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label6.Location = new System.Drawing.Point(6, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Колличество экземпляров";
            // 
            // kV2
            // 
            this.kV2.Font = new System.Drawing.Font("Arial", 9.75F);
            this.kV2.FormattingEnabled = true;
            this.kV2.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            ""});
            this.kV2.Location = new System.Drawing.Point(177, 14);
            this.kV2.Name = "kV2";
            this.kV2.Size = new System.Drawing.Size(42, 24);
            this.kV2.TabIndex = 8;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.MestoV3);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.kV3);
            this.groupBox3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox3.Location = new System.Drawing.Point(10, 200);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(496, 47);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "32 Руководство системного программиста";
            // 
            // MestoV3
            // 
            this.MestoV3.Font = new System.Drawing.Font("Arial", 9.75F);
            this.MestoV3.FormattingEnabled = true;
            this.MestoV3.Items.AddRange(new object[] {
            "Папка № 1"});
            this.MestoV3.Location = new System.Drawing.Point(369, 14);
            this.MestoV3.Name = "MestoV3";
            this.MestoV3.Size = new System.Drawing.Size(121, 24);
            this.MestoV3.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label7.Location = new System.Drawing.Point(236, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Местонахождение";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label8.Location = new System.Drawing.Point(6, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(165, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Колличество экземпляров";
            // 
            // kV3
            // 
            this.kV3.Font = new System.Drawing.Font("Arial", 9.75F);
            this.kV3.FormattingEnabled = true;
            this.kV3.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            ""});
            this.kV3.Location = new System.Drawing.Point(177, 14);
            this.kV3.Name = "kV3";
            this.kV3.Size = new System.Drawing.Size(42, 24);
            this.kV3.TabIndex = 11;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.MestoV4);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.kV4);
            this.groupBox4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox4.Location = new System.Drawing.Point(10, 253);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(496, 47);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "34 Руководство оператора";
            // 
            // MestoV4
            // 
            this.MestoV4.Font = new System.Drawing.Font("Arial", 9.75F);
            this.MestoV4.FormattingEnabled = true;
            this.MestoV4.Items.AddRange(new object[] {
            "Папка № 1"});
            this.MestoV4.Location = new System.Drawing.Point(369, 14);
            this.MestoV4.Name = "MestoV4";
            this.MestoV4.Size = new System.Drawing.Size(121, 24);
            this.MestoV4.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label9.Location = new System.Drawing.Point(236, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "Местонахождение";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label10.Location = new System.Drawing.Point(6, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(165, 16);
            this.label10.TabIndex = 7;
            this.label10.Text = "Колличество экземпляров";
            // 
            // kV4
            // 
            this.kV4.Font = new System.Drawing.Font("Arial", 9.75F);
            this.kV4.FormattingEnabled = true;
            this.kV4.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            ""});
            this.kV4.Location = new System.Drawing.Point(177, 14);
            this.kV4.Name = "kV4";
            this.kV4.Size = new System.Drawing.Size(42, 24);
            this.kV4.TabIndex = 14;
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 200;
            this.toolTip1.ReshowDelay = 100;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Подсказка";
            // 
            // LiteraVe
            // 
            this.LiteraVe.Font = new System.Drawing.Font("Arial", 9.75F);
            this.LiteraVe.FormattingEnabled = true;
            this.LiteraVe.Items.AddRange(new object[] {
            "О1"});
            this.LiteraVe.Location = new System.Drawing.Point(188, 69);
            this.LiteraVe.Name = "LiteraVe";
            this.LiteraVe.Size = new System.Drawing.Size(124, 24);
            this.LiteraVe.TabIndex = 3;
            this.toolTip1.SetToolTip(this.LiteraVe, "Выбрать или ввести вручную");
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial", 9F);
            this.button2.Location = new System.Drawing.Point(519, 230);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(242, 28);
            this.button2.TabIndex = 16;
            this.button2.Text = "Пример оформления";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label11.Location = new System.Drawing.Point(8, 72);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 16);
            this.label11.TabIndex = 20;
            this.label11.Text = "Литера";
            // 
            // Vedomostb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 308);
            this.Controls.Add(this.LiteraVe);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.NameVe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CivrVE);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Vedomostb";
            this.Text = "Ведомость эксплуатационных документов";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CivrVE;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NameVe;
        private System.Windows.Forms.ComboBox kV1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox MestoV1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox MestoV2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox kV2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox MestoV3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox kV3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox MestoV4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox kV4;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox LiteraVe;
        private System.Windows.Forms.Label label11;
    }
}