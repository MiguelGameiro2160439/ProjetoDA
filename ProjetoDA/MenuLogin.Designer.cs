namespace ProjetoDA
{
    partial class MenuLogin
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
            this.buttonAdministrador = new System.Windows.Forms.Button();
            this.buttonArbitro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAdministrador
            // 
            this.buttonAdministrador.Location = new System.Drawing.Point(95, 57);
            this.buttonAdministrador.Name = "buttonAdministrador";
            this.buttonAdministrador.Size = new System.Drawing.Size(75, 23);
            this.buttonAdministrador.TabIndex = 0;
            this.buttonAdministrador.Text = "Administrador";
            this.buttonAdministrador.UseVisualStyleBackColor = true;
            // 
            // buttonArbitro
            // 
            this.buttonArbitro.Location = new System.Drawing.Point(95, 124);
            this.buttonArbitro.Name = "buttonArbitro";
            this.buttonArbitro.Size = new System.Drawing.Size(75, 23);
            this.buttonArbitro.TabIndex = 1;
            this.buttonArbitro.Text = "Arbitro";
            this.buttonArbitro.UseVisualStyleBackColor = true;
            // 
            // MenuLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.buttonArbitro);
            this.Controls.Add(this.buttonAdministrador);
            this.Name = "MenuLogin";
            this.Text = "MenuLogin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAdministrador;
        private System.Windows.Forms.Button buttonArbitro;
    }
}