namespace ProjetoDA
{
    partial class EditUtilizadores
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
            this.buttonAdmin = new System.Windows.Forms.Button();
            this.buttonArbitro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAdmin
            // 
            this.buttonAdmin.Location = new System.Drawing.Point(221, 109);
            this.buttonAdmin.Name = "buttonAdmin";
            this.buttonAdmin.Size = new System.Drawing.Size(119, 57);
            this.buttonAdmin.TabIndex = 0;
            this.buttonAdmin.Text = "Administrador";
            this.buttonAdmin.UseVisualStyleBackColor = true;
            this.buttonAdmin.Click += new System.EventHandler(this.buttonAdmin_Click);
            // 
            // buttonArbitro
            // 
            this.buttonArbitro.Location = new System.Drawing.Point(221, 247);
            this.buttonArbitro.Name = "buttonArbitro";
            this.buttonArbitro.Size = new System.Drawing.Size(119, 57);
            this.buttonArbitro.TabIndex = 1;
            this.buttonArbitro.Text = "Arbitro";
            this.buttonArbitro.UseVisualStyleBackColor = true;
            this.buttonArbitro.Click += new System.EventHandler(this.buttonArbitro_Click);
            // 
            // EditUtilizadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 411);
            this.Controls.Add(this.buttonArbitro);
            this.Controls.Add(this.buttonAdmin);
            this.Name = "EditUtilizadores";
            this.Text = "EditUtilizadores";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAdmin;
        private System.Windows.Forms.Button buttonArbitro;
    }
}