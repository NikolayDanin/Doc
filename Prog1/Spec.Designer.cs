namespace Prog1
{
    partial class Spec
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Spec));
            this.label1 = new System.Windows.Forms.Label();
            this.CivrSp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NamePPSp = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.NakopiSp = new System.Windows.Forms.ComboBox();
            this.OCSp = new System.Windows.Forms.ComboBox();
            this.LiteraSp = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Децимальный номер";
            // 
            // CivrSp
            // 
            this.CivrSp.Font = new System.Drawing.Font("Arial", 9.75F);
            this.CivrSp.Location = new System.Drawing.Point(184, 8);
            this.CivrSp.Multiline = true;
            this.CivrSp.Name = "CivrSp";
            this.CivrSp.Size = new System.Drawing.Size(124, 24);
            this.CivrSp.TabIndex = 1;
            this.toolTip1.SetToolTip(this.CivrSp, "Пример: 00649-01");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Наименование программы";
            // 
            // NamePPSp
            // 
            this.NamePPSp.Font = new System.Drawing.Font("Arial", 9.75F);
            this.NamePPSp.Location = new System.Drawing.Point(184, 38);
            this.NamePPSp.Multiline = true;
            this.NamePPSp.Name = "NamePPSp";
            this.NamePPSp.Size = new System.Drawing.Size(552, 24);
            this.NamePPSp.TabIndex = 2;
            this.toolTip1.SetToolTip(this.NamePPSp, "Пример: Программно-технического комплекса руководителя полетов");
            this.NamePPSp.EnabledChanged += new System.EventHandler(this.NamePPSp_TextChanged);
            this.NamePPSp.TextChanged += new System.EventHandler(this.NamePPSp_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(507, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(229, 36);
            this.button1.TabIndex = 7;
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
            // NakopiSp
            // 
            this.NakopiSp.Font = new System.Drawing.Font("Arial", 9.75F);
            this.NakopiSp.FormattingEnabled = true;
            this.NakopiSp.Items.AddRange(new object[] {
            "DVD-диске",
            "USB-накопителе"});
            this.NakopiSp.Location = new System.Drawing.Point(184, 98);
            this.NakopiSp.Name = "NakopiSp";
            this.NakopiSp.Size = new System.Drawing.Size(124, 24);
            this.NakopiSp.TabIndex = 4;
            this.toolTip1.SetToolTip(this.NakopiSp, "Выбрать или ввести вручную");
            // 
            // OCSp
            // 
            this.OCSp.Font = new System.Drawing.Font("Arial", 9.75F);
            this.OCSp.FormattingEnabled = true;
            this.OCSp.Items.AddRange(new object[] {
            "Astra Linux Special Edition Смоленск 1.5",
            "Astra Linux Special Edition Смоленск 1.6"});
            this.OCSp.Location = new System.Drawing.Point(184, 68);
            this.OCSp.Name = "OCSp";
            this.OCSp.Size = new System.Drawing.Size(358, 24);
            this.OCSp.TabIndex = 3;
            this.toolTip1.SetToolTip(this.OCSp, "Выбрать или ввести вручную");
            // 
            // LiteraSp
            // 
            this.LiteraSp.Font = new System.Drawing.Font("Arial", 9.75F);
            this.LiteraSp.FormattingEnabled = true;
            this.LiteraSp.Items.AddRange(new object[] {
            "О1"});
            this.LiteraSp.Location = new System.Drawing.Point(184, 128);
            this.LiteraSp.Name = "LiteraSp";
            this.LiteraSp.Size = new System.Drawing.Size(124, 24);
            this.LiteraSp.TabIndex = 5;
            this.toolTip1.SetToolTip(this.LiteraSp, "Выбрать или ввести вручную");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label3.Location = new System.Drawing.Point(12, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Операционная система";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label4.Location = new System.Drawing.Point(12, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Данные записаны на";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial", 9F);
            this.button2.Location = new System.Drawing.Point(353, 116);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 36);
            this.button2.TabIndex = 6;
            this.button2.Text = "Пример оформления";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F);
            this.label5.Location = new System.Drawing.Point(12, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Литера";
            // 
            // Spec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 161);
            this.Controls.Add(this.LiteraSp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.OCSp);
            this.Controls.Add(this.NakopiSp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.NamePPSp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CivrSp);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Spec";
            this.Text = "Спецификация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CivrSp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NamePPSp;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox NakopiSp;
        private System.Windows.Forms.ComboBox OCSp;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox LiteraSp;
    }
}