﻿namespace ProjetoDA
{
    partial class TabelaTorneios
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
            this.listBoxTorneios = new System.Windows.Forms.ListBox();
            this.buttonAdicionar = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.listBoxTorneioNormal = new System.Windows.Forms.ListBox();
            this.buttonEditarNormal = new System.Windows.Forms.Button();
            this.buttonRemoverNormal = new System.Windows.Forms.Button();
            this.buttonAdicionarNormal = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxTorneios
            // 
            this.listBoxTorneios.FormattingEnabled = true;
            this.listBoxTorneios.Location = new System.Drawing.Point(12, 25);
            this.listBoxTorneios.Name = "listBoxTorneios";
            this.listBoxTorneios.Size = new System.Drawing.Size(153, 160);
            this.listBoxTorneios.TabIndex = 0;
            this.listBoxTorneios.SelectedIndexChanged += new System.EventHandler(this.listBoxTorneios_SelectedIndexChanged);
            // 
            // buttonAdicionar
            // 
            this.buttonAdicionar.Location = new System.Drawing.Point(12, 191);
            this.buttonAdicionar.Name = "buttonAdicionar";
            this.buttonAdicionar.Size = new System.Drawing.Size(75, 23);
            this.buttonAdicionar.TabIndex = 1;
            this.buttonAdicionar.Text = "Inserir";
            this.buttonAdicionar.UseVisualStyleBackColor = true;
            this.buttonAdicionar.Click += new System.EventHandler(this.buttonAdicionar_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(90, 191);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(75, 23);
            this.buttonEditar.TabIndex = 2;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(90, 220);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(75, 23);
            this.buttonEliminar.TabIndex = 3;
            this.buttonEliminar.Text = "Remover";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // listBoxTorneioNormal
            // 
            this.listBoxTorneioNormal.FormattingEnabled = true;
            this.listBoxTorneioNormal.Location = new System.Drawing.Point(229, 25);
            this.listBoxTorneioNormal.Name = "listBoxTorneioNormal";
            this.listBoxTorneioNormal.Size = new System.Drawing.Size(153, 160);
            this.listBoxTorneioNormal.TabIndex = 4;
            this.listBoxTorneioNormal.SelectedIndexChanged += new System.EventHandler(this.listBoxTorneioNormal_SelectedIndexChanged);
            // 
            // buttonEditarNormal
            // 
            this.buttonEditarNormal.Location = new System.Drawing.Point(307, 191);
            this.buttonEditarNormal.Name = "buttonEditarNormal";
            this.buttonEditarNormal.Size = new System.Drawing.Size(75, 23);
            this.buttonEditarNormal.TabIndex = 5;
            this.buttonEditarNormal.Text = "Editar";
            this.buttonEditarNormal.UseVisualStyleBackColor = true;
            this.buttonEditarNormal.Click += new System.EventHandler(this.buttonEditarNormal_Click);
            // 
            // buttonRemoverNormal
            // 
            this.buttonRemoverNormal.Location = new System.Drawing.Point(229, 220);
            this.buttonRemoverNormal.Name = "buttonRemoverNormal";
            this.buttonRemoverNormal.Size = new System.Drawing.Size(75, 23);
            this.buttonRemoverNormal.TabIndex = 6;
            this.buttonRemoverNormal.Text = "Remover";
            this.buttonRemoverNormal.UseVisualStyleBackColor = true;
            this.buttonRemoverNormal.Click += new System.EventHandler(this.buttonRemoverNormal_Click);
            // 
            // buttonAdicionarNormal
            // 
            this.buttonAdicionarNormal.Location = new System.Drawing.Point(229, 191);
            this.buttonAdicionarNormal.Name = "buttonAdicionarNormal";
            this.buttonAdicionarNormal.Size = new System.Drawing.Size(75, 23);
            this.buttonAdicionarNormal.TabIndex = 7;
            this.buttonAdicionarNormal.Text = "Inserir";
            this.buttonAdicionarNormal.UseVisualStyleBackColor = true;
            this.buttonAdicionarNormal.Click += new System.EventHandler(this.buttonAdicionarNormal_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 220);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 39);
            this.button1.TabIndex = 8;
            this.button1.Text = "Adicionar Jogadores";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(310, 220);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(72, 39);
            this.button2.TabIndex = 9;
            this.button2.Text = "Adicionar Jogadores";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Torneios";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(229, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Torneio Normal";
            // 
            // TabelaTorneios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 290);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonAdicionarNormal);
            this.Controls.Add(this.buttonRemoverNormal);
            this.Controls.Add(this.buttonEditarNormal);
            this.Controls.Add(this.listBoxTorneioNormal);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.buttonAdicionar);
            this.Controls.Add(this.listBoxTorneios);
            this.Name = "TabelaTorneios";
            this.Text = "TabelaTorneios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxTorneios;
        private System.Windows.Forms.Button buttonAdicionar;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.ListBox listBoxTorneioNormal;
        private System.Windows.Forms.Button buttonEditarNormal;
        private System.Windows.Forms.Button buttonRemoverNormal;
        private System.Windows.Forms.Button buttonAdicionarNormal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}