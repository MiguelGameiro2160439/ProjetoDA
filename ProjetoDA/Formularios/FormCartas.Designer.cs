namespace ProjetoDA
{
    partial class FormCartas
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
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.textBoxRegras = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxTipo = new System.Windows.Forms.ComboBox();
            this.comboBoxFacao = new System.Windows.Forms.ComboBox();
            this.textBoxCusto = new System.Windows.Forms.TextBox();
            this.numericUpDownLealdade = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownDefesa = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownAtaque = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLealdade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDefesa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAtaque)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(66, 14);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(100, 20);
            this.textBoxNome.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fação";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(237, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ataque";
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(372, 243);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 6;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // textBoxRegras
            // 
            this.textBoxRegras.Location = new System.Drawing.Point(18, 150);
            this.textBoxRegras.Multiline = true;
            this.textBoxRegras.Name = "textBoxRegras";
            this.textBoxRegras.Size = new System.Drawing.Size(429, 87);
            this.textBoxRegras.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(256, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "custo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(237, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "lealdade";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Regras";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Tipo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Defesa";
            // 
            // comboBoxTipo
            // 
            this.comboBoxTipo.FormattingEnabled = true;
            this.comboBoxTipo.Items.AddRange(new object[] {
            "Creature",
            "Event",
            "Equipment",
            "Magic",
            "Echantment",
            "City"});
            this.comboBoxTipo.Location = new System.Drawing.Point(66, 69);
            this.comboBoxTipo.Name = "comboBoxTipo";
            this.comboBoxTipo.Size = new System.Drawing.Size(100, 21);
            this.comboBoxTipo.TabIndex = 17;
            // 
            // comboBoxFacao
            // 
            this.comboBoxFacao.FormattingEnabled = true;
            this.comboBoxFacao.Items.AddRange(new object[] {
            "Galan Love for Life",
            "Uneasy Alliance"});
            this.comboBoxFacao.Location = new System.Drawing.Point(66, 39);
            this.comboBoxFacao.Name = "comboBoxFacao";
            this.comboBoxFacao.Size = new System.Drawing.Size(100, 21);
            this.comboBoxFacao.TabIndex = 18;
            // 
            // textBoxCusto
            // 
            this.textBoxCusto.Location = new System.Drawing.Point(290, 14);
            this.textBoxCusto.Name = "textBoxCusto";
            this.textBoxCusto.Size = new System.Drawing.Size(100, 20);
            this.textBoxCusto.TabIndex = 8;
            // 
            // numericUpDownLealdade
            // 
            this.numericUpDownLealdade.Location = new System.Drawing.Point(290, 40);
            this.numericUpDownLealdade.Name = "numericUpDownLealdade";
            this.numericUpDownLealdade.Size = new System.Drawing.Size(64, 20);
            this.numericUpDownLealdade.TabIndex = 19;
            // 
            // numericUpDownDefesa
            // 
            this.numericUpDownDefesa.Location = new System.Drawing.Point(66, 97);
            this.numericUpDownDefesa.Name = "numericUpDownDefesa";
            this.numericUpDownDefesa.Size = new System.Drawing.Size(100, 20);
            this.numericUpDownDefesa.TabIndex = 20;
            // 
            // numericUpDownAtaque
            // 
            this.numericUpDownAtaque.Location = new System.Drawing.Point(290, 66);
            this.numericUpDownAtaque.Name = "numericUpDownAtaque";
            this.numericUpDownAtaque.Size = new System.Drawing.Size(70, 20);
            this.numericUpDownAtaque.TabIndex = 21;
            // 
            // FormCartas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 278);
            this.Controls.Add(this.numericUpDownAtaque);
            this.Controls.Add(this.numericUpDownDefesa);
            this.Controls.Add(this.numericUpDownLealdade);
            this.Controls.Add(this.comboBoxFacao);
            this.Controls.Add(this.comboBoxTipo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxRegras);
            this.Controls.Add(this.textBoxCusto);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNome);
            this.Name = "FormCartas";
            this.Text = "FormCartas";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLealdade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDefesa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAtaque)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.TextBox textBoxRegras;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxTipo;
        private System.Windows.Forms.ComboBox comboBoxFacao;
        private System.Windows.Forms.TextBox textBoxCusto;
        private System.Windows.Forms.NumericUpDown numericUpDownLealdade;
        private System.Windows.Forms.NumericUpDown numericUpDownDefesa;
        private System.Windows.Forms.NumericUpDown numericUpDownAtaque;
    }
}