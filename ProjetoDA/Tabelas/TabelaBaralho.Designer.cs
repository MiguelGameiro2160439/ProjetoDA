namespace ProjetoDA
{
    partial class TabelaBaralho
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
            this.buttonRemover = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonAdicionarCarta = new System.Windows.Forms.Button();
            this.listBoxBaralho = new System.Windows.Forms.ListBox();
            this.buttonInserirBaralho = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonRemover
            // 
            this.buttonRemover.Location = new System.Drawing.Point(460, 166);
            this.buttonRemover.Name = "buttonRemover";
            this.buttonRemover.Size = new System.Drawing.Size(75, 23);
            this.buttonRemover.TabIndex = 7;
            this.buttonRemover.Text = "Remover";
            this.buttonRemover.UseVisualStyleBackColor = true;
            this.buttonRemover.Click += new System.EventHandler(this.buttonRemover_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(319, 166);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(75, 23);
            this.buttonEditar.TabIndex = 6;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // buttonAdicionarCarta
            // 
            this.buttonAdicionarCarta.Location = new System.Drawing.Point(24, 166);
            this.buttonAdicionarCarta.Name = "buttonAdicionarCarta";
            this.buttonAdicionarCarta.Size = new System.Drawing.Size(84, 23);
            this.buttonAdicionarCarta.TabIndex = 5;
            this.buttonAdicionarCarta.Text = "Inserir Cartas";
            this.buttonAdicionarCarta.UseVisualStyleBackColor = true;
            // 
            // listBoxBaralho
            // 
            this.listBoxBaralho.FormattingEnabled = true;
            this.listBoxBaralho.Location = new System.Drawing.Point(12, 12);
            this.listBoxBaralho.Name = "listBoxBaralho";
            this.listBoxBaralho.Size = new System.Drawing.Size(422, 134);
            this.listBoxBaralho.TabIndex = 4;
            this.listBoxBaralho.SelectedIndexChanged += new System.EventHandler(this.listBoxBaralho_SelectedIndexChanged);
            // 
            // buttonInserirBaralho
            // 
            this.buttonInserirBaralho.Location = new System.Drawing.Point(440, 123);
            this.buttonInserirBaralho.Name = "buttonInserirBaralho";
            this.buttonInserirBaralho.Size = new System.Drawing.Size(116, 23);
            this.buttonInserirBaralho.TabIndex = 8;
            this.buttonInserirBaralho.Text = "Inserir Baralho";
            this.buttonInserirBaralho.UseVisualStyleBackColor = true;
            this.buttonInserirBaralho.Click += new System.EventHandler(this.buttonInserirBaralho_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(440, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nome:";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(440, 87);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(100, 20);
            this.textBoxNome.TabIndex = 10;
            // 
            // TabelaBaralho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 244);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonInserirBaralho);
            this.Controls.Add(this.buttonRemover);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.buttonAdicionarCarta);
            this.Controls.Add(this.listBoxBaralho);
            this.Name = "TabelaBaralho";
            this.Text = "TabelaBaralho";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRemover;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.Button buttonAdicionarCarta;
        private System.Windows.Forms.ListBox listBoxBaralho;
        private System.Windows.Forms.Button buttonInserirBaralho;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNome;
    }
}