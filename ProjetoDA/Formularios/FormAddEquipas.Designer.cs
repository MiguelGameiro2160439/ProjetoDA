namespace ProjetoDA
{
    partial class FormAddEquipas
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSelect = new System.Windows.Forms.Button();
            this.buttonRemover = new System.Windows.Forms.Button();
            this.buttonInserir = new System.Windows.Forms.Button();
            this.listBoxEquipasTorneio = new System.Windows.Forms.ListBox();
            this.listBoxEquipas = new System.Windows.Forms.ListBox();
            this.listBoxTorneio = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(622, 21);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "Equipas-Torneio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(391, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Torneio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Equipas";
            // 
            // buttonSelect
            // 
            this.buttonSelect.Location = new System.Drawing.Point(558, 393);
            this.buttonSelect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(111, 50);
            this.buttonSelect.TabIndex = 20;
            this.buttonSelect.Text = "Atualizar Lista";
            this.buttonSelect.UseVisualStyleBackColor = true;
            this.buttonSelect.Click += new System.EventHandler(this.buttonSelect_Click);
            // 
            // buttonRemover
            // 
            this.buttonRemover.Location = new System.Drawing.Point(366, 393);
            this.buttonRemover.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRemover.Name = "buttonRemover";
            this.buttonRemover.Size = new System.Drawing.Size(111, 50);
            this.buttonRemover.TabIndex = 19;
            this.buttonRemover.Text = "Remover";
            this.buttonRemover.UseVisualStyleBackColor = true;
            this.buttonRemover.Click += new System.EventHandler(this.buttonRemover_Click);
            // 
            // buttonInserir
            // 
            this.buttonInserir.Location = new System.Drawing.Point(170, 393);
            this.buttonInserir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonInserir.Name = "buttonInserir";
            this.buttonInserir.Size = new System.Drawing.Size(111, 50);
            this.buttonInserir.TabIndex = 18;
            this.buttonInserir.Text = "Inserir";
            this.buttonInserir.UseVisualStyleBackColor = true;
            this.buttonInserir.Click += new System.EventHandler(this.buttonInserir_Click);
            // 
            // listBoxEquipasTorneio
            // 
            this.listBoxEquipasTorneio.FormattingEnabled = true;
            this.listBoxEquipasTorneio.ItemHeight = 16;
            this.listBoxEquipasTorneio.Location = new System.Drawing.Point(558, 44);
            this.listBoxEquipasTorneio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxEquipasTorneio.Name = "listBoxEquipasTorneio";
            this.listBoxEquipasTorneio.Size = new System.Drawing.Size(253, 324);
            this.listBoxEquipasTorneio.TabIndex = 17;
            // 
            // listBoxEquipas
            // 
            this.listBoxEquipas.FormattingEnabled = true;
            this.listBoxEquipas.ItemHeight = 16;
            this.listBoxEquipas.Location = new System.Drawing.Point(12, 44);
            this.listBoxEquipas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxEquipas.Name = "listBoxEquipas";
            this.listBoxEquipas.Size = new System.Drawing.Size(267, 324);
            this.listBoxEquipas.TabIndex = 16;
            // 
            // listBoxTorneio
            // 
            this.listBoxTorneio.FormattingEnabled = true;
            this.listBoxTorneio.ItemHeight = 16;
            this.listBoxTorneio.Location = new System.Drawing.Point(286, 44);
            this.listBoxTorneio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxTorneio.Name = "listBoxTorneio";
            this.listBoxTorneio.Size = new System.Drawing.Size(267, 324);
            this.listBoxTorneio.TabIndex = 15;
            // 
            // FormAddEquipas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 464);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSelect);
            this.Controls.Add(this.buttonRemover);
            this.Controls.Add(this.buttonInserir);
            this.Controls.Add(this.listBoxEquipasTorneio);
            this.Controls.Add(this.listBoxEquipas);
            this.Controls.Add(this.listBoxTorneio);
            this.Name = "FormAddEquipas";
            this.Text = "FormAddEquipas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSelect;
        private System.Windows.Forms.Button buttonRemover;
        private System.Windows.Forms.Button buttonInserir;
        private System.Windows.Forms.ListBox listBoxEquipasTorneio;
        private System.Windows.Forms.ListBox listBoxEquipas;
        private System.Windows.Forms.ListBox listBoxTorneio;
    }
}