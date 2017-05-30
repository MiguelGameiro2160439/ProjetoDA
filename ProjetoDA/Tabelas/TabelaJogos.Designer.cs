namespace ProjetoDA
{
    partial class TabelaJogos
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
            this.listBoxJogos = new System.Windows.Forms.ListBox();
            this.buttonAdicionar = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.listBoxJogosStandard = new System.Windows.Forms.ListBox();
            this.buttonAdicionarStandard = new System.Windows.Forms.Button();
            this.buttonEditarStandard = new System.Windows.Forms.Button();
            this.buttonRemoverJogoNormal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxJogos
            // 
            this.listBoxJogos.FormattingEnabled = true;
            this.listBoxJogos.Location = new System.Drawing.Point(12, 25);
            this.listBoxJogos.Name = "listBoxJogos";
            this.listBoxJogos.Size = new System.Drawing.Size(162, 121);
            this.listBoxJogos.TabIndex = 0;
            this.listBoxJogos.SelectedIndexChanged += new System.EventHandler(this.listBoxJogos_SelectedIndexChanged);
            // 
            // buttonAdicionar
            // 
            this.buttonAdicionar.Location = new System.Drawing.Point(12, 162);
            this.buttonAdicionar.Name = "buttonAdicionar";
            this.buttonAdicionar.Size = new System.Drawing.Size(75, 23);
            this.buttonAdicionar.TabIndex = 1;
            this.buttonAdicionar.Text = "Inserir";
            this.buttonAdicionar.UseVisualStyleBackColor = true;
            this.buttonAdicionar.Click += new System.EventHandler(this.buttonAdicionar_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(93, 162);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(75, 23);
            this.buttonEditar.TabIndex = 2;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(12, 191);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(75, 23);
            this.buttonEliminar.TabIndex = 3;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // listBoxJogosStandard
            // 
            this.listBoxJogosStandard.FormattingEnabled = true;
            this.listBoxJogosStandard.Location = new System.Drawing.Point(220, 25);
            this.listBoxJogosStandard.Name = "listBoxJogosStandard";
            this.listBoxJogosStandard.Size = new System.Drawing.Size(157, 121);
            this.listBoxJogosStandard.TabIndex = 4;
            this.listBoxJogosStandard.SelectedIndexChanged += new System.EventHandler(this.listBoxJogosStandard_SelectedIndexChanged);
            // 
            // buttonAdicionarStandard
            // 
            this.buttonAdicionarStandard.Location = new System.Drawing.Point(220, 162);
            this.buttonAdicionarStandard.Name = "buttonAdicionarStandard";
            this.buttonAdicionarStandard.Size = new System.Drawing.Size(75, 23);
            this.buttonAdicionarStandard.TabIndex = 5;
            this.buttonAdicionarStandard.Text = "Inserir";
            this.buttonAdicionarStandard.UseVisualStyleBackColor = true;
            this.buttonAdicionarStandard.Click += new System.EventHandler(this.buttonAdicionarStandard_Click);
            // 
            // buttonEditarStandard
            // 
            this.buttonEditarStandard.Location = new System.Drawing.Point(303, 162);
            this.buttonEditarStandard.Name = "buttonEditarStandard";
            this.buttonEditarStandard.Size = new System.Drawing.Size(75, 23);
            this.buttonEditarStandard.TabIndex = 7;
            this.buttonEditarStandard.Text = "Editar";
            this.buttonEditarStandard.UseVisualStyleBackColor = true;
            this.buttonEditarStandard.Click += new System.EventHandler(this.buttonEditarStandard_Click);
            // 
            // buttonRemoverJogoNormal
            // 
            this.buttonRemoverJogoNormal.Location = new System.Drawing.Point(303, 191);
            this.buttonRemoverJogoNormal.Name = "buttonRemoverJogoNormal";
            this.buttonRemoverJogoNormal.Size = new System.Drawing.Size(75, 23);
            this.buttonRemoverJogoNormal.TabIndex = 8;
            this.buttonRemoverJogoNormal.Text = "Eliminar";
            this.buttonRemoverJogoNormal.UseVisualStyleBackColor = true;
            this.buttonRemoverJogoNormal.Click += new System.EventHandler(this.buttonRemoverJogoNormal_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Jogo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(220, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Jogos Standard";
            // 
            // TabelaJogos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 261);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonRemoverJogoNormal);
            this.Controls.Add(this.buttonEditarStandard);
            this.Controls.Add(this.buttonAdicionarStandard);
            this.Controls.Add(this.listBoxJogosStandard);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.buttonAdicionar);
            this.Controls.Add(this.listBoxJogos);
            this.Name = "TabelaJogos";
            this.Text = "TabelaJogos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxJogos;
        private System.Windows.Forms.Button buttonAdicionar;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.ListBox listBoxJogosStandard;
        private System.Windows.Forms.Button buttonAdicionarStandard;
        private System.Windows.Forms.Button buttonEditarStandard;
        private System.Windows.Forms.Button buttonRemoverJogoNormal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}