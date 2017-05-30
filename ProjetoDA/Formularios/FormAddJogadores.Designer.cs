namespace ProjetoDA
{
    partial class FormAddJogadores
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void 
            Dispose(bool disposing)
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
            this.buttonSelect = new System.Windows.Forms.Button();
            this.buttonRemover = new System.Windows.Forms.Button();
            this.buttonInserir = new System.Windows.Forms.Button();
            this.listBoxJogadoresTorneio = new System.Windows.Forms.ListBox();
            this.listBoxJogadores = new System.Windows.Forms.ListBox();
            this.listBoxTorneio = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSelect
            // 
            this.buttonSelect.Location = new System.Drawing.Point(419, 321);
            this.buttonSelect.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(83, 41);
            this.buttonSelect.TabIndex = 11;
            this.buttonSelect.Text = "Atualizar Lista";
            this.buttonSelect.UseVisualStyleBackColor = true;
            this.buttonSelect.Click += new System.EventHandler(this.buttonSelect_Click);
            // 
            // buttonRemover
            // 
            this.buttonRemover.Location = new System.Drawing.Point(275, 321);
            this.buttonRemover.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRemover.Name = "buttonRemover";
            this.buttonRemover.Size = new System.Drawing.Size(83, 41);
            this.buttonRemover.TabIndex = 10;
            this.buttonRemover.Text = "Remover";
            this.buttonRemover.UseVisualStyleBackColor = true;
            // 
            // buttonInserir
            // 
            this.buttonInserir.Location = new System.Drawing.Point(128, 321);
            this.buttonInserir.Margin = new System.Windows.Forms.Padding(2);
            this.buttonInserir.Name = "buttonInserir";
            this.buttonInserir.Size = new System.Drawing.Size(83, 41);
            this.buttonInserir.TabIndex = 9;
            this.buttonInserir.Text = "Inserir";
            this.buttonInserir.UseVisualStyleBackColor = true;
            this.buttonInserir.Click += new System.EventHandler(this.buttonInserir_Click);
            // 
            // listBoxJogadoresTorneio
            // 
            this.listBoxJogadoresTorneio.FormattingEnabled = true;
            this.listBoxJogadoresTorneio.Location = new System.Drawing.Point(419, 37);
            this.listBoxJogadoresTorneio.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxJogadoresTorneio.Name = "listBoxJogadoresTorneio";
            this.listBoxJogadoresTorneio.Size = new System.Drawing.Size(191, 264);
            this.listBoxJogadoresTorneio.TabIndex = 8;
            // 
            // listBoxJogadores
            // 
            this.listBoxJogadores.FormattingEnabled = true;
            this.listBoxJogadores.Location = new System.Drawing.Point(10, 37);
            this.listBoxJogadores.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxJogadores.Name = "listBoxJogadores";
            this.listBoxJogadores.Size = new System.Drawing.Size(201, 264);
            this.listBoxJogadores.TabIndex = 7;
            // 
            // listBoxTorneio
            // 
            this.listBoxTorneio.FormattingEnabled = true;
            this.listBoxTorneio.Location = new System.Drawing.Point(215, 37);
            this.listBoxTorneio.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxTorneio.Name = "listBoxTorneio";
            this.listBoxTorneio.Size = new System.Drawing.Size(201, 264);
            this.listBoxTorneio.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Jogadores";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(294, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Torneio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(467, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Jogadores-Torneio";
            // 
            // FormAddJogadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 385);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSelect);
            this.Controls.Add(this.buttonRemover);
            this.Controls.Add(this.buttonInserir);
            this.Controls.Add(this.listBoxJogadoresTorneio);
            this.Controls.Add(this.listBoxJogadores);
            this.Controls.Add(this.listBoxTorneio);
            this.Name = "FormAddJogadores";
            this.Text = "FormAddJogadores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSelect;
        private System.Windows.Forms.Button buttonRemover;
        private System.Windows.Forms.Button buttonInserir;
        private System.Windows.Forms.ListBox listBoxJogadoresTorneio;
        private System.Windows.Forms.ListBox listBoxJogadores;
        private System.Windows.Forms.ListBox listBoxTorneio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}