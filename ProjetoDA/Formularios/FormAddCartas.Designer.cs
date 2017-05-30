namespace ProjetoDA
{
    partial class FormAddCartas
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
            this.listBoxBaralho = new System.Windows.Forms.ListBox();
            this.listBoxCartas = new System.Windows.Forms.ListBox();
            this.listBoxCartasBaralho = new System.Windows.Forms.ListBox();
            this.buttonInserir = new System.Windows.Forms.Button();
            this.buttonRemover = new System.Windows.Forms.Button();
            this.buttonSelect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxBaralho
            // 
            this.listBoxBaralho.FormattingEnabled = true;
            this.listBoxBaralho.Location = new System.Drawing.Point(213, 29);
            this.listBoxBaralho.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxBaralho.Name = "listBoxBaralho";
            this.listBoxBaralho.Size = new System.Drawing.Size(201, 290);
            this.listBoxBaralho.TabIndex = 0;
            // 
            // listBoxCartas
            // 
            this.listBoxCartas.FormattingEnabled = true;
            this.listBoxCartas.Location = new System.Drawing.Point(9, 29);
            this.listBoxCartas.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxCartas.Name = "listBoxCartas";
            this.listBoxCartas.Size = new System.Drawing.Size(201, 290);
            this.listBoxCartas.TabIndex = 1;
            // 
            // listBoxCartasBaralho
            // 
            this.listBoxCartasBaralho.FormattingEnabled = true;
            this.listBoxCartasBaralho.Location = new System.Drawing.Point(418, 29);
            this.listBoxCartasBaralho.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxCartasBaralho.Name = "listBoxCartasBaralho";
            this.listBoxCartasBaralho.Size = new System.Drawing.Size(191, 290);
            this.listBoxCartasBaralho.TabIndex = 2;
            // 
            // buttonInserir
            // 
            this.buttonInserir.Location = new System.Drawing.Point(146, 349);
            this.buttonInserir.Margin = new System.Windows.Forms.Padding(2);
            this.buttonInserir.Name = "buttonInserir";
            this.buttonInserir.Size = new System.Drawing.Size(83, 41);
            this.buttonInserir.TabIndex = 3;
            this.buttonInserir.Text = "Inserir";
            this.buttonInserir.UseVisualStyleBackColor = true;
            this.buttonInserir.Click += new System.EventHandler(this.buttonInserir_Click);
            // 
            // buttonRemover
            // 
            this.buttonRemover.Location = new System.Drawing.Point(272, 349);
            this.buttonRemover.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRemover.Name = "buttonRemover";
            this.buttonRemover.Size = new System.Drawing.Size(83, 41);
            this.buttonRemover.TabIndex = 4;
            this.buttonRemover.Text = "Remover";
            this.buttonRemover.UseVisualStyleBackColor = true;
            this.buttonRemover.Click += new System.EventHandler(this.buttonRemover_Click);
            // 
            // buttonSelect
            // 
            this.buttonSelect.Location = new System.Drawing.Point(396, 349);
            this.buttonSelect.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(83, 41);
            this.buttonSelect.TabIndex = 5;
            this.buttonSelect.Text = "Atualizar Lista";
            this.buttonSelect.UseVisualStyleBackColor = true;
            this.buttonSelect.Click += new System.EventHandler(this.buttonSelect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Cartas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(293, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Baralho";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(481, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cartas-Baralho";
            // 
            // FormAddCartas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 422);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSelect);
            this.Controls.Add(this.buttonRemover);
            this.Controls.Add(this.buttonInserir);
            this.Controls.Add(this.listBoxCartasBaralho);
            this.Controls.Add(this.listBoxCartas);
            this.Controls.Add(this.listBoxBaralho);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormAddCartas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxBaralho;
        private System.Windows.Forms.ListBox listBoxCartas;
        private System.Windows.Forms.ListBox listBoxCartasBaralho;
        private System.Windows.Forms.Button buttonInserir;
        private System.Windows.Forms.Button buttonRemover;
        private System.Windows.Forms.Button buttonSelect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}