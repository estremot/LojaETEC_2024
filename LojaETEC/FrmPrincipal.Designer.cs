namespace LojaETEC
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.MenuLoja = new System.Windows.Forms.MenuStrip();
            this.mnuArquivo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCadastros = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRelatorios = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuVenda = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCompra = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.barraFerramentas = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.barraStatus = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.stlHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pcbLogotipo = new System.Windows.Forms.PictureBox();
            this.btnCadClientes = new System.Windows.Forms.ToolStripButton();
            this.btnCadProdutos = new System.Windows.Forms.ToolStripButton();
            this.btnCadVendas = new System.Windows.Forms.ToolStripButton();
            this.btnRelatorioVendas = new System.Windows.Forms.ToolStripButton();
            this.btnLogout = new System.Windows.Forms.ToolStripButton();
            this.mnuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBairro = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCep = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRua = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuOperadora = new System.Windows.Forms.ToolStripMenuItem();
            this.trabalhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuLoja.SuspendLayout();
            this.barraFerramentas.SuspendLayout();
            this.barraStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogotipo)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuLoja
            // 
            this.MenuLoja.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuArquivo,
            this.mnuCadastros,
            this.mnuRelatorios,
            this.mnuVenda,
            this.mnuCompra,
            this.mnuAdmin});
            this.MenuLoja.Location = new System.Drawing.Point(0, 0);
            this.MenuLoja.Name = "MenuLoja";
            this.MenuLoja.Size = new System.Drawing.Size(800, 24);
            this.MenuLoja.TabIndex = 0;
            this.MenuLoja.Text = "menuStrip1";
            // 
            // mnuArquivo
            // 
            this.mnuArquivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSair});
            this.mnuArquivo.Name = "mnuArquivo";
            this.mnuArquivo.Size = new System.Drawing.Size(61, 20);
            this.mnuArquivo.Text = "Arquivo";
            // 
            // mnuCadastros
            // 
            this.mnuCadastros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBairro,
            this.mnuCep,
            this.clientesToolStripMenuItem,
            this.mnuRua,
            this.MnuOperadora,
            this.trabalhoToolStripMenuItem});
            this.mnuCadastros.Name = "mnuCadastros";
            this.mnuCadastros.Size = new System.Drawing.Size(71, 20);
            this.mnuCadastros.Text = "Cadastros";
            // 
            // mnuRelatorios
            // 
            this.mnuRelatorios.Name = "mnuRelatorios";
            this.mnuRelatorios.Size = new System.Drawing.Size(71, 20);
            this.mnuRelatorios.Text = "Relatórios";
            this.mnuRelatorios.Click += new System.EventHandler(this.mnuRelatorios_Click);
            // 
            // mnuVenda
            // 
            this.mnuVenda.Name = "mnuVenda";
            this.mnuVenda.Size = new System.Drawing.Size(51, 20);
            this.mnuVenda.Text = "Venda";
            // 
            // mnuCompra
            // 
            this.mnuCompra.Name = "mnuCompra";
            this.mnuCompra.Size = new System.Drawing.Size(62, 20);
            this.mnuCompra.Text = "Compra";
            // 
            // mnuAdmin
            // 
            this.mnuAdmin.Name = "mnuAdmin";
            this.mnuAdmin.Size = new System.Drawing.Size(96, 20);
            this.mnuAdmin.Text = "Administração";
            // 
            // barraFerramentas
            // 
            this.barraFerramentas.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.barraFerramentas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCadClientes,
            this.btnCadProdutos,
            this.btnCadVendas,
            this.btnRelatorioVendas,
            this.toolStripSeparator1,
            this.btnLogout});
            this.barraFerramentas.Location = new System.Drawing.Point(0, 24);
            this.barraFerramentas.Name = "barraFerramentas";
            this.barraFerramentas.Size = new System.Drawing.Size(800, 37);
            this.barraFerramentas.TabIndex = 1;
            this.barraFerramentas.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 37);
            // 
            // barraStatus
            // 
            this.barraStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.stlHora});
            this.barraStatus.Location = new System.Drawing.Point(0, 428);
            this.barraStatus.Name = "barraStatus";
            this.barraStatus.Size = new System.Drawing.Size(800, 22);
            this.barraStatus.TabIndex = 2;
            this.barraStatus.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(36, 17);
            this.toolStripStatusLabel1.Text = "Hora:";
            // 
            // stlHora
            // 
            this.stlHora.Name = "stlHora";
            this.stlHora.Size = new System.Drawing.Size(59, 17);
            this.stlHora.Text = "hh:mm:ss";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pcbLogotipo
            // 
            this.pcbLogotipo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcbLogotipo.Image = global::LojaETEC.Properties.Resources.Loja;
            this.pcbLogotipo.Location = new System.Drawing.Point(0, 61);
            this.pcbLogotipo.Name = "pcbLogotipo";
            this.pcbLogotipo.Size = new System.Drawing.Size(800, 367);
            this.pcbLogotipo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbLogotipo.TabIndex = 3;
            this.pcbLogotipo.TabStop = false;
            // 
            // btnCadClientes
            // 
            this.btnCadClientes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCadClientes.Image = global::LojaETEC.Properties.Resources.AddCliente;
            this.btnCadClientes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCadClientes.Name = "btnCadClientes";
            this.btnCadClientes.Size = new System.Drawing.Size(34, 34);
            this.btnCadClientes.Text = "toolStripButton1";
            this.btnCadClientes.ToolTipText = "Adicionar Cliente";
            this.btnCadClientes.Click += new System.EventHandler(this.btnCadClientes_Click);
            // 
            // btnCadProdutos
            // 
            this.btnCadProdutos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCadProdutos.Image = global::LojaETEC.Properties.Resources.CadProdutos;
            this.btnCadProdutos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCadProdutos.Name = "btnCadProdutos";
            this.btnCadProdutos.Size = new System.Drawing.Size(34, 34);
            this.btnCadProdutos.Text = "toolStripButton2";
            this.btnCadProdutos.ToolTipText = "Cadastro de Produtos";
            // 
            // btnCadVendas
            // 
            this.btnCadVendas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCadVendas.Image = global::LojaETEC.Properties.Resources.CadVendas;
            this.btnCadVendas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCadVendas.Name = "btnCadVendas";
            this.btnCadVendas.Size = new System.Drawing.Size(34, 34);
            this.btnCadVendas.Text = "toolStripButton3";
            this.btnCadVendas.ToolTipText = "Cadastro de Vendas";
            // 
            // btnRelatorioVendas
            // 
            this.btnRelatorioVendas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRelatorioVendas.Image = global::LojaETEC.Properties.Resources.Relatorios;
            this.btnRelatorioVendas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRelatorioVendas.Name = "btnRelatorioVendas";
            this.btnRelatorioVendas.Size = new System.Drawing.Size(34, 34);
            this.btnRelatorioVendas.Text = "toolStripButton4";
            this.btnRelatorioVendas.ToolTipText = "Relatório de Vendas";
            // 
            // btnLogout
            // 
            this.btnLogout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnLogout.Image = global::LojaETEC.Properties.Resources.Logout;
            this.btnLogout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(34, 34);
            this.btnLogout.Text = "toolStripButton5";
            this.btnLogout.ToolTipText = "Logout do Sistema";
            // 
            // mnuSair
            // 
            this.mnuSair.Image = global::LojaETEC.Properties.Resources.sair;
            this.mnuSair.Name = "mnuSair";
            this.mnuSair.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.mnuSair.Size = new System.Drawing.Size(133, 22);
            this.mnuSair.Text = "&Sair";
            this.mnuSair.ToolTipText = "Finaliza a Aplicação";
            this.mnuSair.Click += new System.EventHandler(this.mnuSair_Click);
            // 
            // mnuBairro
            // 
            this.mnuBairro.Image = global::LojaETEC.Properties.Resources.bairro;
            this.mnuBairro.Name = "mnuBairro";
            this.mnuBairro.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.mnuBairro.Size = new System.Drawing.Size(180, 22);
            this.mnuBairro.Text = "&Bairro";
            this.mnuBairro.ToolTipText = "Cadastro de Bairros";
            this.mnuBairro.Click += new System.EventHandler(this.mnuBairro_Click);
            // 
            // mnuCep
            // 
            this.mnuCep.Image = global::LojaETEC.Properties.Resources.codigo_postal;
            this.mnuCep.Name = "mnuCep";
            this.mnuCep.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.C)));
            this.mnuCep.Size = new System.Drawing.Size(180, 22);
            this.mnuCep.Text = "&Cep";
            this.mnuCep.Click += new System.EventHandler(this.mnuCep_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Image = global::LojaETEC.Properties.Resources.cliente;
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.L)));
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clientesToolStripMenuItem.Text = "C&lientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // mnuRua
            // 
            this.mnuRua.Image = global::LojaETEC.Properties.Resources.estrada;
            this.mnuRua.Name = "mnuRua";
            this.mnuRua.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.mnuRua.Size = new System.Drawing.Size(180, 22);
            this.mnuRua.Text = "&Rua";
            this.mnuRua.ToolTipText = "Acessa o Cadastro de Ruas";
            this.mnuRua.Click += new System.EventHandler(this.mnuRua_Click);
            // 
            // MnuOperadora
            // 
            this.MnuOperadora.Image = global::LojaETEC.Properties.Resources.chamada_telefonica;
            this.MnuOperadora.Name = "MnuOperadora";
            this.MnuOperadora.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.MnuOperadora.Size = new System.Drawing.Size(180, 22);
            this.MnuOperadora.Text = "&Operadora";
            this.MnuOperadora.Click += new System.EventHandler(this.MnuOperadora_Click);
            // 
            // trabalhoToolStripMenuItem
            // 
            this.trabalhoToolStripMenuItem.Image = global::LojaETEC.Properties.Resources.trabalho;
            this.trabalhoToolStripMenuItem.Name = "trabalhoToolStripMenuItem";
            this.trabalhoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.trabalhoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.trabalhoToolStripMenuItem.Text = "&Trabalho";
            this.trabalhoToolStripMenuItem.Click += new System.EventHandler(this.trabalhoToolStripMenuItem_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pcbLogotipo);
            this.Controls.Add(this.barraStatus);
            this.Controls.Add(this.barraFerramentas);
            this.Controls.Add(this.MenuLoja);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.MenuLoja;
            this.Name = "FrmPrincipal";
            this.Text = "Loja ETEC - 2024";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MenuLoja.ResumeLayout(false);
            this.MenuLoja.PerformLayout();
            this.barraFerramentas.ResumeLayout(false);
            this.barraFerramentas.PerformLayout();
            this.barraStatus.ResumeLayout(false);
            this.barraStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogotipo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuLoja;
        private System.Windows.Forms.ToolStripMenuItem mnuArquivo;
        private System.Windows.Forms.ToolStripMenuItem mnuSair;
        private System.Windows.Forms.ToolStrip barraFerramentas;
        private System.Windows.Forms.ToolStripButton btnCadClientes;
        private System.Windows.Forms.ToolStripButton btnCadProdutos;
        private System.Windows.Forms.ToolStripButton btnCadVendas;
        private System.Windows.Forms.ToolStripButton btnRelatorioVendas;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnLogout;
        private System.Windows.Forms.StatusStrip barraStatus;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel stlHora;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pcbLogotipo;
        private System.Windows.Forms.ToolStripMenuItem mnuCadastros;
        private System.Windows.Forms.ToolStripMenuItem mnuRua;
        private System.Windows.Forms.ToolStripMenuItem mnuBairro;
        private System.Windows.Forms.ToolStripMenuItem mnuRelatorios;
        private System.Windows.Forms.ToolStripMenuItem mnuVenda;
        private System.Windows.Forms.ToolStripMenuItem mnuCompra;
        private System.Windows.Forms.ToolStripMenuItem mnuAdmin;
        private System.Windows.Forms.ToolStripMenuItem mnuCep;
        private System.Windows.Forms.ToolStripMenuItem trabalhoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MnuOperadora;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
    }
}

