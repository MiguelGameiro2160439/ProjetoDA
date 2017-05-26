namespace ProjetoDA
{
    partial class VistaAdmin
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.jogadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inserirEditarRemoverJogadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.equipasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inserirEditarRemoverEquipasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.torneiosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.torneioDeEquipaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inserirEditarRemoverEquipaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.torneioNormalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inserirEditarRemoverNormalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jogoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inserirEditarRemoverJogoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inserirEditarRemoverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jogoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.inserirEditarRemoverToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cartasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inserirEditarRemoverCartaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baralhosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inserirEditarRemoverBaralhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utilizadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inserirEditarRemoverUtilizadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listBoxTorneios = new System.Windows.Forms.ListBox();
            this.listBoxArbitros = new System.Windows.Forms.ListBox();
            this.listBoxJogos = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jogadoresToolStripMenuItem,
            this.equipasToolStripMenuItem,
            this.torneiosToolStripMenuItem,
            this.jogoToolStripMenuItem,
            this.cartasToolStripMenuItem,
            this.baralhosToolStripMenuItem,
            this.utilizadoresToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(624, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // jogadoresToolStripMenuItem
            // 
            this.jogadoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inserirEditarRemoverJogadorToolStripMenuItem});
            this.jogadoresToolStripMenuItem.Name = "jogadoresToolStripMenuItem";
            this.jogadoresToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.jogadoresToolStripMenuItem.Text = "Jogador";
            // 
            // inserirEditarRemoverJogadorToolStripMenuItem
            // 
            this.inserirEditarRemoverJogadorToolStripMenuItem.Name = "inserirEditarRemoverJogadorToolStripMenuItem";
            this.inserirEditarRemoverJogadorToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.inserirEditarRemoverJogadorToolStripMenuItem.Text = "Inserir/Editar/Remover";
            this.inserirEditarRemoverJogadorToolStripMenuItem.Click += new System.EventHandler(this.inserirEditarRemoverJogadorToolStripMenuItem_Click);
            // 
            // equipasToolStripMenuItem
            // 
            this.equipasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inserirEditarRemoverEquipasToolStripMenuItem});
            this.equipasToolStripMenuItem.Name = "equipasToolStripMenuItem";
            this.equipasToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.equipasToolStripMenuItem.Text = "Equipas";
            // 
            // inserirEditarRemoverEquipasToolStripMenuItem
            // 
            this.inserirEditarRemoverEquipasToolStripMenuItem.Name = "inserirEditarRemoverEquipasToolStripMenuItem";
            this.inserirEditarRemoverEquipasToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.inserirEditarRemoverEquipasToolStripMenuItem.Text = "Inserir/Editar/Remover";
            this.inserirEditarRemoverEquipasToolStripMenuItem.Click += new System.EventHandler(this.inserirEditarRemoverEquipasToolStripMenuItem_Click);
            // 
            // torneiosToolStripMenuItem
            // 
            this.torneiosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.torneioDeEquipaToolStripMenuItem,
            this.torneioNormalToolStripMenuItem});
            this.torneiosToolStripMenuItem.Name = "torneiosToolStripMenuItem";
            this.torneiosToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.torneiosToolStripMenuItem.Text = "Torneio";
            // 
            // torneioDeEquipaToolStripMenuItem
            // 
            this.torneioDeEquipaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inserirEditarRemoverEquipaToolStripMenuItem});
            this.torneioDeEquipaToolStripMenuItem.Name = "torneioDeEquipaToolStripMenuItem";
            this.torneioDeEquipaToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.torneioDeEquipaToolStripMenuItem.Text = "Torneio de Equipa";
            // 
            // inserirEditarRemoverEquipaToolStripMenuItem
            // 
            this.inserirEditarRemoverEquipaToolStripMenuItem.Name = "inserirEditarRemoverEquipaToolStripMenuItem";
            this.inserirEditarRemoverEquipaToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.inserirEditarRemoverEquipaToolStripMenuItem.Text = "Inserir/Editar/Remover";
            // 
            // torneioNormalToolStripMenuItem
            // 
            this.torneioNormalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inserirEditarRemoverNormalToolStripMenuItem});
            this.torneioNormalToolStripMenuItem.Name = "torneioNormalToolStripMenuItem";
            this.torneioNormalToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.torneioNormalToolStripMenuItem.Text = "Torneio Normal";
            // 
            // inserirEditarRemoverNormalToolStripMenuItem
            // 
            this.inserirEditarRemoverNormalToolStripMenuItem.Name = "inserirEditarRemoverNormalToolStripMenuItem";
            this.inserirEditarRemoverNormalToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.inserirEditarRemoverNormalToolStripMenuItem.Text = "Inserir/Editar/Remover";
            // 
            // jogoToolStripMenuItem
            // 
            this.jogoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inserirEditarRemoverJogoToolStripMenuItem,
            this.jogoToolStripMenuItem1});
            this.jogoToolStripMenuItem.Name = "jogoToolStripMenuItem";
            this.jogoToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.jogoToolStripMenuItem.Text = "Jogo";
            // 
            // inserirEditarRemoverJogoToolStripMenuItem
            // 
            this.inserirEditarRemoverJogoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inserirEditarRemoverToolStripMenuItem});
            this.inserirEditarRemoverJogoToolStripMenuItem.Name = "inserirEditarRemoverJogoToolStripMenuItem";
            this.inserirEditarRemoverJogoToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.inserirEditarRemoverJogoToolStripMenuItem.Text = "Jogo de Equipa";
            this.inserirEditarRemoverJogoToolStripMenuItem.Click += new System.EventHandler(this.inserirEditarRemoverJogoToolStripMenuItem_Click);
            // 
            // inserirEditarRemoverToolStripMenuItem
            // 
            this.inserirEditarRemoverToolStripMenuItem.Name = "inserirEditarRemoverToolStripMenuItem";
            this.inserirEditarRemoverToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.inserirEditarRemoverToolStripMenuItem.Text = "Inserir/Editar/Remover";
            // 
            // jogoToolStripMenuItem1
            // 
            this.jogoToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inserirEditarRemoverToolStripMenuItem1});
            this.jogoToolStripMenuItem1.Name = "jogoToolStripMenuItem1";
            this.jogoToolStripMenuItem1.Size = new System.Drawing.Size(187, 26);
            this.jogoToolStripMenuItem1.Text = "Jogo Normal";
            // 
            // inserirEditarRemoverToolStripMenuItem1
            // 
            this.inserirEditarRemoverToolStripMenuItem1.Name = "inserirEditarRemoverToolStripMenuItem1";
            this.inserirEditarRemoverToolStripMenuItem1.Size = new System.Drawing.Size(234, 26);
            this.inserirEditarRemoverToolStripMenuItem1.Text = "Inserir/Editar/Remover";
            // 
            // cartasToolStripMenuItem
            // 
            this.cartasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inserirEditarRemoverCartaToolStripMenuItem});
            this.cartasToolStripMenuItem.Name = "cartasToolStripMenuItem";
            this.cartasToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.cartasToolStripMenuItem.Text = "Cartas";
            // 
            // inserirEditarRemoverCartaToolStripMenuItem
            // 
            this.inserirEditarRemoverCartaToolStripMenuItem.Name = "inserirEditarRemoverCartaToolStripMenuItem";
            this.inserirEditarRemoverCartaToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.inserirEditarRemoverCartaToolStripMenuItem.Text = "Inserir/Editar/Remover";
            this.inserirEditarRemoverCartaToolStripMenuItem.Click += new System.EventHandler(this.inserirEditarRemoverCartaToolStripMenuItem_Click);
            // 
            // baralhosToolStripMenuItem
            // 
            this.baralhosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inserirEditarRemoverBaralhoToolStripMenuItem});
            this.baralhosToolStripMenuItem.Name = "baralhosToolStripMenuItem";
            this.baralhosToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.baralhosToolStripMenuItem.Text = "Baralhos";
            // 
            // inserirEditarRemoverBaralhoToolStripMenuItem
            // 
            this.inserirEditarRemoverBaralhoToolStripMenuItem.Name = "inserirEditarRemoverBaralhoToolStripMenuItem";
            this.inserirEditarRemoverBaralhoToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.inserirEditarRemoverBaralhoToolStripMenuItem.Text = "Inserir/Editar/Remover";
            this.inserirEditarRemoverBaralhoToolStripMenuItem.Click += new System.EventHandler(this.inserirEditarRemoverBaralhoToolStripMenuItem_Click);
            // 
            // utilizadoresToolStripMenuItem
            // 
            this.utilizadoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inserirEditarRemoverUtilizadorToolStripMenuItem});
            this.utilizadoresToolStripMenuItem.Name = "utilizadoresToolStripMenuItem";
            this.utilizadoresToolStripMenuItem.Size = new System.Drawing.Size(100, 24);
            this.utilizadoresToolStripMenuItem.Text = "Utilizadores";
            // 
            // inserirEditarRemoverUtilizadorToolStripMenuItem
            // 
            this.inserirEditarRemoverUtilizadorToolStripMenuItem.Name = "inserirEditarRemoverUtilizadorToolStripMenuItem";
            this.inserirEditarRemoverUtilizadorToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.inserirEditarRemoverUtilizadorToolStripMenuItem.Text = "Inserir/Editar/Remover";
            this.inserirEditarRemoverUtilizadorToolStripMenuItem.Click += new System.EventHandler(this.inserirEditarRemoverUtilizadorToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(17, 304);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(397, 22);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(424, 300);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "Procurar Arbitros";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // listBoxTorneios
            // 
            this.listBoxTorneios.FormattingEnabled = true;
            this.listBoxTorneios.ItemHeight = 16;
            this.listBoxTorneios.Location = new System.Drawing.Point(217, 64);
            this.listBoxTorneios.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxTorneios.Name = "listBoxTorneios";
            this.listBoxTorneios.Size = new System.Drawing.Size(190, 228);
            this.listBoxTorneios.TabIndex = 3;
            // 
            // listBoxArbitros
            // 
            this.listBoxArbitros.FormattingEnabled = true;
            this.listBoxArbitros.ItemHeight = 16;
            this.listBoxArbitros.Location = new System.Drawing.Point(12, 63);
            this.listBoxArbitros.Name = "listBoxArbitros";
            this.listBoxArbitros.Size = new System.Drawing.Size(198, 228);
            this.listBoxArbitros.TabIndex = 4;
            // 
            // listBoxJogos
            // 
            this.listBoxJogos.FormattingEnabled = true;
            this.listBoxJogos.ItemHeight = 16;
            this.listBoxJogos.Location = new System.Drawing.Point(414, 64);
            this.listBoxJogos.Name = "listBoxJogos";
            this.listBoxJogos.Size = new System.Drawing.Size(198, 228);
            this.listBoxJogos.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Arbitros";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(275, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Torneios";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(488, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Jogos";
            // 
            // VistaAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 364);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxJogos);
            this.Controls.Add(this.listBoxArbitros);
            this.Controls.Add(this.listBoxTorneios);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "VistaAdmin";
            this.Text = "VistaAdmin";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem jogadoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem torneiosToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBoxTorneios;
        private System.Windows.Forms.ToolStripMenuItem jogoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem torneioDeEquipaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem torneioNormalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inserirEditarRemoverJogadorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inserirEditarRemoverEquipaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inserirEditarRemoverNormalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inserirEditarRemoverJogoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cartasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inserirEditarRemoverCartaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem baralhosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inserirEditarRemoverBaralhoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem utilizadoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inserirEditarRemoverUtilizadorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem equipasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inserirEditarRemoverEquipasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inserirEditarRemoverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jogoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem inserirEditarRemoverToolStripMenuItem1;
        private System.Windows.Forms.ListBox listBoxArbitros;
        private System.Windows.Forms.ListBox listBoxJogos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}