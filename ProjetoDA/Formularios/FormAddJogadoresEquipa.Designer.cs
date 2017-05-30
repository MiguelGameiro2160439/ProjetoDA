namespace ProjetoDA
{
    partial class FormAddJogadoresEquipa
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
            this.buttonSelect = new System.Windows.Forms.Button();
            this.buttonRemover = new System.Windows.Forms.Button();
            this.buttonInserir = new System.Windows.Forms.Button();
            this.listBoxJogadoresEquipas = new System.Windows.Forms.ListBox();
            this.listBoxJogadores = new System.Windows.Forms.ListBox();
            this.listBoxEquipas = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // buttonSelect
            // 
            this.buttonSelect.Location = new System.Drawing.Point(398, 350);
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
            this.buttonRemover.Location = new System.Drawing.Point(274, 350);
            this.buttonRemover.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRemover.Name = "buttonRemover";
            this.buttonRemover.Size = new System.Drawing.Size(83, 41);
            this.buttonRemover.TabIndex = 10;
            this.buttonRemover.Text = "Remover";
            this.buttonRemover.UseVisualStyleBackColor = true;
            this.buttonRemover.Click += new System.EventHandler(this.buttonRemover_Click);
            // 
            // buttonInserir
            // 
            this.buttonInserir.Location = new System.Drawing.Point(148, 350);
            this.buttonInserir.Margin = new System.Windows.Forms.Padding(2);
            this.buttonInserir.Name = "buttonInserir";
            this.buttonInserir.Size = new System.Drawing.Size(83, 41);
            this.buttonInserir.TabIndex = 9;
            this.buttonInserir.Text = "Inserir";
            this.buttonInserir.UseVisualStyleBackColor = true;
            this.buttonInserir.Click += new System.EventHandler(this.buttonInserir_Click);
            // 
            // listBoxJogadoresEquipas
            // 
            this.listBoxJogadoresEquipas.FormattingEnabled = true;
            this.listBoxJogadoresEquipas.Location = new System.Drawing.Point(420, 11);
            this.listBoxJogadoresEquipas.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxJogadoresEquipas.Name = "listBoxJogadoresEquipas";
            this.listBoxJogadoresEquipas.Size = new System.Drawing.Size(191, 290);
            this.listBoxJogadoresEquipas.TabIndex = 8;
            // 
            // listBoxJogadores
            // 
            this.listBoxJogadores.FormattingEnabled = true;
            this.listBoxJogadores.Location = new System.Drawing.Point(11, 11);
            this.listBoxJogadores.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxJogadores.Name = "listBoxJogadores";
            this.listBoxJogadores.Size = new System.Drawing.Size(201, 290);
            this.listBoxJogadores.TabIndex = 7;
            // 
            // listBoxEquipas
            // 
            this.listBoxEquipas.FormattingEnabled = true;
            this.listBoxEquipas.Location = new System.Drawing.Point(216, 11);
            this.listBoxEquipas.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxEquipas.Name = "listBoxEquipas";
            this.listBoxEquipas.Size = new System.Drawing.Size(201, 290);
            this.listBoxEquipas.TabIndex = 6;
            // 
            // FormAddJogadoresEquipa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 395);
            this.Controls.Add(this.buttonSelect);
            this.Controls.Add(this.buttonRemover);
            this.Controls.Add(this.buttonInserir);
            this.Controls.Add(this.listBoxJogadoresEquipas);
            this.Controls.Add(this.listBoxJogadores);
            this.Controls.Add(this.listBoxEquipas);
            this.Name = "FormAddJogadoresEquipa";
            this.Text = "FormAddJogadoresEquipa";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSelect;
        private System.Windows.Forms.Button buttonRemover;
        private System.Windows.Forms.Button buttonInserir;
        private System.Windows.Forms.ListBox listBoxJogadoresEquipas;
        private System.Windows.Forms.ListBox listBoxJogadores;
        private System.Windows.Forms.ListBox listBoxEquipas;
    }
}