namespace ProjetoDA
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
            this.SuspendLayout();
            // 
            // listBoxTorneios
            // 
            this.listBoxTorneios.FormattingEnabled = true;
            this.listBoxTorneios.Location = new System.Drawing.Point(12, 12);
            this.listBoxTorneios.Name = "listBoxTorneios";
            this.listBoxTorneios.Size = new System.Drawing.Size(475, 134);
            this.listBoxTorneios.TabIndex = 0;
            this.listBoxTorneios.SelectedIndexChanged += new System.EventHandler(this.listBoxTorneios_SelectedIndexChanged);
            // 
            // buttonAdicionar
            // 
            this.buttonAdicionar.Location = new System.Drawing.Point(12, 214);
            this.buttonAdicionar.Name = "buttonAdicionar";
            this.buttonAdicionar.Size = new System.Drawing.Size(75, 23);
            this.buttonAdicionar.TabIndex = 1;
            this.buttonAdicionar.Text = "Inserir";
            this.buttonAdicionar.UseVisualStyleBackColor = true;
            this.buttonAdicionar.Click += new System.EventHandler(this.buttonAdicionar_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(213, 214);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(75, 23);
            this.buttonEditar.TabIndex = 2;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(412, 214);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(75, 23);
            this.buttonEliminar.TabIndex = 3;
            this.buttonEliminar.Text = "Remover";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // TabelaTorneios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 261);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.buttonAdicionar);
            this.Controls.Add(this.listBoxTorneios);
            this.Name = "TabelaTorneios";
            this.Text = "TabelaTorneios";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxTorneios;
        private System.Windows.Forms.Button buttonAdicionar;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.Button buttonEliminar;
    }
}