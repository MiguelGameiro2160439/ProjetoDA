namespace ProjetoDA
{
    partial class FormJogoNormal
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
            this.comboBoxBaralho2 = new System.Windows.Forms.ComboBox();
            this.comboBoxBaralho1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonAdicionar = new System.Windows.Forms.Button();
            this.Label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownNum = new System.Windows.Forms.NumericUpDown();
            this.dateTimePickerData = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDescricao = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNum)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxBaralho2
            // 
            this.comboBoxBaralho2.FormattingEnabled = true;
            this.comboBoxBaralho2.Location = new System.Drawing.Point(12, 163);
            this.comboBoxBaralho2.Name = "comboBoxBaralho2";
            this.comboBoxBaralho2.Size = new System.Drawing.Size(110, 21);
            this.comboBoxBaralho2.TabIndex = 21;
            // 
            // comboBoxBaralho1
            // 
            this.comboBoxBaralho1.FormattingEnabled = true;
            this.comboBoxBaralho1.Location = new System.Drawing.Point(12, 116);
            this.comboBoxBaralho1.Name = "comboBoxBaralho1";
            this.comboBoxBaralho1.Size = new System.Drawing.Size(110, 21);
            this.comboBoxBaralho1.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Baralho  2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Baralho 1";
            // 
            // buttonAdicionar
            // 
            this.buttonAdicionar.Location = new System.Drawing.Point(229, 163);
            this.buttonAdicionar.Name = "buttonAdicionar";
            this.buttonAdicionar.Size = new System.Drawing.Size(75, 23);
            this.buttonAdicionar.TabIndex = 17;
            this.buttonAdicionar.Text = "OK";
            this.buttonAdicionar.UseVisualStyleBackColor = true;
            this.buttonAdicionar.Click += new System.EventHandler(this.buttonAdicionar_Click);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(12, 51);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(30, 13);
            this.Label3.TabIndex = 16;
            this.Label3.Text = "Data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Número";
            // 
            // numericUpDownNum
            // 
            this.numericUpDownNum.Location = new System.Drawing.Point(12, 28);
            this.numericUpDownNum.Name = "numericUpDownNum";
            this.numericUpDownNum.Size = new System.Drawing.Size(49, 20);
            this.numericUpDownNum.TabIndex = 14;
            // 
            // dateTimePickerData
            // 
            this.dateTimePickerData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerData.Location = new System.Drawing.Point(12, 67);
            this.dateTimePickerData.Name = "dateTimePickerData";
            this.dateTimePickerData.Size = new System.Drawing.Size(87, 20);
            this.dateTimePickerData.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(156, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Descrição";
            // 
            // textBoxDescricao
            // 
            this.textBoxDescricao.Location = new System.Drawing.Point(159, 28);
            this.textBoxDescricao.Multiline = true;
            this.textBoxDescricao.Name = "textBoxDescricao";
            this.textBoxDescricao.Size = new System.Drawing.Size(145, 85);
            this.textBoxDescricao.TabIndex = 11;
            // 
            // FormJogoNormal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 198);
            this.Controls.Add(this.comboBoxBaralho2);
            this.Controls.Add(this.comboBoxBaralho1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonAdicionar);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDownNum);
            this.Controls.Add(this.dateTimePickerData);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxDescricao);
            this.Name = "FormJogoNormal";
            this.Text = "FormJogoNormal";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxBaralho2;
        private System.Windows.Forms.ComboBox comboBoxBaralho1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonAdicionar;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownNum;
        private System.Windows.Forms.DateTimePicker dateTimePickerData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDescricao;
    }
}