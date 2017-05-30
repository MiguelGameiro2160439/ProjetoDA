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
            this.SuspendLayout();
            // 
            // buttonSelect
            // 
            this.buttonSelect.Location = new System.Drawing.Point(395, 333);
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
            this.buttonRemover.Location = new System.Drawing.Point(270, 333);
            this.buttonRemover.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRemover.Name = "buttonRemover";
            this.buttonRemover.Size = new System.Drawing.Size(83, 41);
            this.buttonRemover.TabIndex = 10;
            this.buttonRemover.Text = "Remover";
            this.buttonRemover.UseVisualStyleBackColor = true;
            // 
            // buttonInserir
            // 
            this.buttonInserir.Location = new System.Drawing.Point(149, 333);
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
            this.listBoxJogadoresTorneio.Location = new System.Drawing.Point(419, 11);
            this.listBoxJogadoresTorneio.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxJogadoresTorneio.Name = "listBoxJogadoresTorneio";
            this.listBoxJogadoresTorneio.Size = new System.Drawing.Size(191, 290);
            this.listBoxJogadoresTorneio.TabIndex = 8;
            // 
            // listBoxJogadores
            // 
            this.listBoxJogadores.FormattingEnabled = true;
            this.listBoxJogadores.Location = new System.Drawing.Point(10, 11);
            this.listBoxJogadores.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxJogadores.Name = "listBoxJogadores";
            this.listBoxJogadores.Size = new System.Drawing.Size(201, 290);
            this.listBoxJogadores.TabIndex = 7;
            // 
            // listBoxTorneio
            // 
            this.listBoxTorneio.FormattingEnabled = true;
            this.listBoxTorneio.Location = new System.Drawing.Point(215, 11);
            this.listBoxTorneio.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxTorneio.Name = "listBoxTorneio";
            this.listBoxTorneio.Size = new System.Drawing.Size(201, 290);
            this.listBoxTorneio.TabIndex = 6;
            // 
            // FormAddJogadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 385);
            this.Controls.Add(this.buttonSelect);
            this.Controls.Add(this.buttonRemover);
            this.Controls.Add(this.buttonInserir);
            this.Controls.Add(this.listBoxJogadoresTorneio);
            this.Controls.Add(this.listBoxJogadores);
            this.Controls.Add(this.listBoxTorneio);
            this.Name = "FormAddJogadores";
            this.Text = "FormAddJogadores";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSelect;
        private System.Windows.Forms.Button buttonRemover;
        private System.Windows.Forms.Button buttonInserir;
        private System.Windows.Forms.ListBox listBoxJogadoresTorneio;
        private System.Windows.Forms.ListBox listBoxJogadores;
        private System.Windows.Forms.ListBox listBoxTorneio;
    }
}