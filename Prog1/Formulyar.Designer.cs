namespace Prog1
{
    partial class Formulyar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formulyar));
            this.label1 = new System.Windows.Forms.Label();
            this.CivrF = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NameF = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.IzdF = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.OrRazrabF = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.NakopiF = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.LiteraF = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Децимальный номер";
            // 
            // CivrF
            // 
            this.CivrF.Font = new System.Drawing.Font("Arial", 9.75F);
            this.CivrF.Location = new System.Drawing.Point(184, 9);
            this.CivrF.Multiline = true;
            this.CivrF.Name = "CivrF";
            this.CivrF.Size = new System.Drawing.Size(121, 24);
            this.CivrF.TabIndex = 1;
            this.toolTip1.SetToolTip(this.CivrF, "Пример: 00649-01");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Наименование программы";
            // 
            // NameF
            // 
            this.NameF.Font = new System.Drawing.Font("Arial", 9.75F);
            this.NameF.Location = new System.Drawing.Point(184, 39);
            this.NameF.Multiline = true;
            this.NameF.Name = "NameF";
            this.NameF.Size = new System.Drawing.Size(552, 24);
            this.NameF.TabIndex = 2;
            this.toolTip1.SetToolTip(this.NameF, "Пример: Программно-технического комплекса руководителя полетов");
            this.NameF.TextChanged += new System.EventHandler(this.NameF_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label3.Location = new System.Drawing.Point(12, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Наименование изделия";
            // 
            // IzdF
            // 
            this.IzdF.Font = new System.Drawing.Font("Arial", 9.75F);
            this.IzdF.Location = new System.Drawing.Point(184, 69);
            this.IzdF.Multiline = true;
            this.IzdF.Name = "IzdF";
            this.IzdF.Size = new System.Drawing.Size(552, 24);
            this.IzdF.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label4.Location = new System.Drawing.Point(12, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Организация разработчик";
            // 
            // OrRazrabF
            // 
            this.OrRazrabF.Font = new System.Drawing.Font("Arial", 9.75F);
            this.OrRazrabF.FormattingEnabled = true;
            this.OrRazrabF.Items.AddRange(new object[] {
            "ПАО «НПО «Алмаз»"});
            this.OrRazrabF.Location = new System.Drawing.Point(184, 99);
            this.OrRazrabF.Name = "OrRazrabF";
            this.OrRazrabF.Size = new System.Drawing.Size(334, 24);
            this.OrRazrabF.TabIndex = 4;
            this.toolTip1.SetToolTip(this.OrRazrabF, "Выбрать или ввести вручную");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label5.Location = new System.Drawing.Point(12, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Тип носителя";
            // 
            // NakopiF
            // 
            this.NakopiF.Font = new System.Drawing.Font("Arial", 9.75F);
            this.NakopiF.FormattingEnabled = true;
            this.NakopiF.Items.AddRange(new object[] {
            "DVD-диск",
            "USB-накопитель"});
            this.NakopiF.Location = new System.Drawing.Point(184, 129);
            this.NakopiF.Name = "NakopiF";
            this.NakopiF.Size = new System.Drawing.Size(121, 24);
            this.NakopiF.TabIndex = 5;
            this.toolTip1.SetToolTip(this.NakopiF, "Выбрать или ввести вручную");
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(529, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(207, 36);
            this.button1.TabIndex = 8;
            this.button1.Text = "Сформировать и открыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 200;
            this.toolTip1.ReshowDelay = 100;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Подсказка";
            // 
            // LiteraF
            // 
            this.LiteraF.Font = new System.Drawing.Font("Arial", 9.75F);
            this.LiteraF.FormattingEnabled = true;
            this.LiteraF.Items.AddRange(new object[] {
            "О1"});
            this.LiteraF.Location = new System.Drawing.Point(184, 159);
            this.LiteraF.Name = "LiteraF";
            this.LiteraF.Size = new System.Drawing.Size(121, 24);
            this.LiteraF.TabIndex = 6;
            this.toolTip1.SetToolTip(this.LiteraF, "Выбрать или ввести вручную");
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(361, 152);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 36);
            this.button2.TabIndex = 7;
            this.button2.Text = "Пример оформления";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label6.Location = new System.Drawing.Point(12, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Литера";
            // 
            // Formulyar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 195);
            this.Controls.Add(this.LiteraF);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.NakopiF);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.OrRazrabF);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.IzdF);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NameF);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CivrF);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Formulyar";
            this.Text = "Формуляр";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CivrF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NameF;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox IzdF;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox OrRazrabF;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox NakopiF;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox LiteraF;
        private System.Windows.Forms.Label label6;
    }
}