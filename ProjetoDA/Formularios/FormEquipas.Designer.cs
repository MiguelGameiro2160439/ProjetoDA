namespace ProjetoDA
{
    partial class FormEquipas
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
            this.Nome = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonProcAvatar = new System.Windows.Forms.Button();
            this.textBoxAvatar = new System.Windows.Forms.TextBox();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Location = new System.Drawing.Point(12, 9);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(35, 13);
            this.Nome.TabIndex = 0;
            this.Nome.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Avatar";
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(206, 85);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 2;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonProcAvatar
            // 
            this.buttonProcAvatar.Location = new System.Drawing.Point(67, 61);
            this.buttonProcAvatar.Name = "buttonProcAvatar";
            this.buttonProcAvatar.Size = new System.Drawing.Size(75, 23);
            this.buttonProcAvatar.TabIndex = 3;
            this.buttonProcAvatar.Text = "Procurar";
            this.buttonProcAvatar.UseVisualStyleBackColor = true;
            this.buttonProcAvatar.Click += new System.EventHandler(this.buttonProcAvatar_Click);
            // 
            // textBoxAvatar
            // 
            this.textBoxAvatar.Location = new System.Drawing.Point(67, 35);
            this.textBoxAvatar.Name = "textBoxAvatar";
            this.textBoxAvatar.Size = new System.Drawing.Size(161, 20);
            this.textBoxAvatar.TabIndex = 4;
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(67, 6);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(161, 20);
            this.textBoxNome.TabIndex = 5;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FormEquipas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 120);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.textBoxAvatar);
            this.Controls.Add(this.buttonProcAvatar);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Nome);
            this.Name = "FormEquipas";
            this.Text = "FormEquipas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonProcAvatar;
        private System.Windows.Forms.TextBox textBoxAvatar;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}