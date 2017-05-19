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
            this.buttonAdministrador.Location = new System.Drawing.Point(127, 70);
            this.buttonAdministrador.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAdministrador.Name = "buttonAdministrador";
            this.buttonAdministrador.Size = new System.Drawing.Size(119, 44);
            this.buttonAdministrador.TabIndex = 0;
            this.buttonAdministrador.Text = "Administrador";
            this.buttonAdministrador.UseVisualStyleBackColor = true;
            this.buttonAdministrador.Click += new System.EventHandler(this.buttonAdministrador_Click);
            // 
            // buttonArbitro
            // 
            this.buttonArbitro.Location = new System.Drawing.Point(127, 153);
            this.buttonArbitro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonArbitro.Name = "buttonArbitro";
            this.buttonArbitro.Size = new System.Drawing.Size(119, 47);
            this.buttonArbitro.TabIndex = 1;
            this.buttonArbitro.Text = "Arbitro";
            this.buttonArbitro.UseVisualStyleBackColor = true;
            this.buttonArbitro.Click += new System.EventHandler(this.buttonArbitro_Click);
            // 
            // MenuLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 321);
            this.Controls.Add(this.buttonArbitro);
            this.Controls.Add(this.buttonAdministrador);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MenuLogin";
            this.Text = "MenuLogin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAdministrador;
        private System.Windows.Forms.Button buttonArbitro;
    }
}