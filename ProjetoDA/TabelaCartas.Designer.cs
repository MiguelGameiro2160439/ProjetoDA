namespace ProjetoDA
{
    partial class TabelaCartas
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
            this.listBoxCartas = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // buttonRemover
            // 
            this.buttonRemover.Location = new System.Drawing.Point(294, 166);
            this.buttonRemover.Name = "buttonRemover";
            this.buttonRemover.Size = new System.Drawing.Size(75, 23);
            this.buttonRemover.TabIndex = 11;
            this.buttonRemover.Text = "Remover";
            this.buttonRemover.UseVisualStyleBackColor = true;
            this.buttonRemover.Click += new System.EventHandler(this.buttonRemover_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(153, 166);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(75, 23);
            this.buttonEditar.TabIndex = 10;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // buttonAdicionarCarta
            // 
            this.buttonAdicionarCarta.Location = new System.Drawing.Point(34, 166);
            this.buttonAdicionarCarta.Name = "buttonAdicionarCarta";
            this.buttonAdicionarCarta.Size = new System.Drawing.Size(75, 23);
            this.buttonAdicionarCarta.TabIndex = 9;
            this.buttonAdicionarCarta.Text = "Inserir";
            this.buttonAdicionarCarta.UseVisualStyleBackColor = true;
            this.buttonAdicionarCarta.Click += new System.EventHandler(this.buttonAdicionarCarta_Click);
            // 
            // listBoxCartas
            // 
            this.listBoxCartas.FormattingEnabled = true;
            this.listBoxCartas.Location = new System.Drawing.Point(12, 12);
            this.listBoxCartas.Name = "listBoxCartas";
            this.listBoxCartas.Size = new System.Drawing.Size(422, 134);
            this.listBoxCartas.TabIndex = 8;
            this.listBoxCartas.SelectedIndexChanged += new System.EventHandler(this.listBoxCartas_SelectedIndexChanged);
            // 
            // TabelaCartas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 208);
            this.Controls.Add(this.buttonRemover);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.buttonAdicionarCarta);
            this.Controls.Add(this.listBoxCartas);
            this.Name = "TabelaCartas";
            this.Text = "TabelaCartas";
            this.Load += new System.EventHandler(this.TabelaCartas_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonRemover;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.Button buttonAdicionarCarta;
        private System.Windows.Forms.ListBox listBoxCartas;
    }
}