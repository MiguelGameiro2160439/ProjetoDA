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
            this.SuspendLayout();
            // 
            // listBoxBaralho
            // 
            this.listBoxBaralho.FormattingEnabled = true;
            this.listBoxBaralho.ItemHeight = 16;
            this.listBoxBaralho.Location = new System.Drawing.Point(285, 12);
            this.listBoxBaralho.Name = "listBoxBaralho";
            this.listBoxBaralho.Size = new System.Drawing.Size(267, 356);
            this.listBoxBaralho.TabIndex = 0;
            // 
            // listBoxCartas
            // 
            this.listBoxCartas.FormattingEnabled = true;
            this.listBoxCartas.ItemHeight = 16;
            this.listBoxCartas.Location = new System.Drawing.Point(12, 12);
            this.listBoxCartas.Name = "listBoxCartas";
            this.listBoxCartas.Size = new System.Drawing.Size(267, 356);
            this.listBoxCartas.TabIndex = 1;
            // 
            // listBoxCartasBaralho
            // 
            this.listBoxCartasBaralho.FormattingEnabled = true;
            this.listBoxCartasBaralho.ItemHeight = 16;
            this.listBoxCartasBaralho.Location = new System.Drawing.Point(558, 12);
            this.listBoxCartasBaralho.Name = "listBoxCartasBaralho";
            this.listBoxCartasBaralho.Size = new System.Drawing.Size(253, 356);
            this.listBoxCartasBaralho.TabIndex = 2;
            // 
            // buttonInserir
            // 
            this.buttonInserir.Location = new System.Drawing.Point(194, 430);
            this.buttonInserir.Name = "buttonInserir";
            this.buttonInserir.Size = new System.Drawing.Size(111, 50);
            this.buttonInserir.TabIndex = 3;
            this.buttonInserir.Text = "Inserir";
            this.buttonInserir.UseVisualStyleBackColor = true;
            this.buttonInserir.Click += new System.EventHandler(this.buttonInserir_Click);
            // 
            // buttonRemover
            // 
            this.buttonRemover.Location = new System.Drawing.Point(362, 430);
            this.buttonRemover.Name = "buttonRemover";
            this.buttonRemover.Size = new System.Drawing.Size(111, 50);
            this.buttonRemover.TabIndex = 4;
            this.buttonRemover.Text = "Remover";
            this.buttonRemover.UseVisualStyleBackColor = true;
            this.buttonRemover.Click += new System.EventHandler(this.buttonRemover_Click);
            // 
            // buttonSelect
            // 
            this.buttonSelect.Location = new System.Drawing.Point(528, 430);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(111, 50);
            this.buttonSelect.TabIndex = 5;
            this.buttonSelect.Text = "Selecionar";
            this.buttonSelect.UseVisualStyleBackColor = true;
            this.buttonSelect.Click += new System.EventHandler(this.buttonSelect_Click);
            // 
            // FormAddCartas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 519);
            this.Controls.Add(this.buttonSelect);
            this.Controls.Add(this.buttonRemover);
            this.Controls.Add(this.buttonInserir);
            this.Controls.Add(this.listBoxCartasBaralho);
            this.Controls.Add(this.listBoxCartas);
            this.Controls.Add(this.listBoxBaralho);
            this.Name = "FormAddCartas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxBaralho;
        private System.Windows.Forms.ListBox listBoxCartas;
        private System.Windows.Forms.ListBox listBoxCartasBaralho;
        private System.Windows.Forms.Button buttonInserir;
        private System.Windows.Forms.Button buttonRemover;
        private System.Windows.Forms.Button buttonSelect;
    }
}