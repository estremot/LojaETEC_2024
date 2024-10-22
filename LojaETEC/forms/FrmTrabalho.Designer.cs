namespace LojaETEC.forms
{
    partial class FrmTrabalho
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label codtrabalhoLabel;
            System.Windows.Forms.Label nomecidadetrabalhoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTrabalho));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.lblBuscaTrabalho = new System.Windows.Forms.ToolStripLabel();
            this.txtBuscaCep = new System.Windows.Forms.ToolStripTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lojaetec2024DataSet = new LojaETEC.lojaetec2024DataSet();
            this.trabalhoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trabalhoTableAdapter = new LojaETEC.lojaetec2024DataSetTableAdapters.trabalhoTableAdapter();
            this.tableAdapterManager = new LojaETEC.lojaetec2024DataSetTableAdapters.TableAdapterManager();
            this.trabalhoDataGridView = new System.Windows.Forms.DataGridView();
            this.codtrabalhoLabel1 = new System.Windows.Forms.Label();
            this.txtTrabalho = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnNovo = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.btnSalvar = new System.Windows.Forms.ToolStripButton();
            this.btnApagar = new System.Windows.Forms.ToolStripButton();
            this.btnPrimeiro = new System.Windows.Forms.ToolStripButton();
            this.btnAnterior = new System.Windows.Forms.ToolStripButton();
            this.btnProximo = new System.Windows.Forms.ToolStripButton();
            this.btnUltimo = new System.Windows.Forms.ToolStripButton();
            this.btnBuscar = new System.Windows.Forms.ToolStripButton();
            codtrabalhoLabel = new System.Windows.Forms.Label();
            nomecidadetrabalhoLabel = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lojaetec2024DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trabalhoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trabalhoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNovo,
            this.btnCancelar,
            this.btnEditar,
            this.btnSalvar,
            this.btnApagar,
            this.toolStripSeparator1,
            this.btnPrimeiro,
            this.btnAnterior,
            this.btnProximo,
            this.btnUltimo,
            this.toolStripSeparator2,
            this.lblBuscaTrabalho,
            this.txtBuscaCep,
            this.btnBuscar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(533, 37);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 37);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 37);
            // 
            // lblBuscaTrabalho
            // 
            this.lblBuscaTrabalho.Name = "lblBuscaTrabalho";
            this.lblBuscaTrabalho.Size = new System.Drawing.Size(32, 34);
            this.lblBuscaTrabalho.Text = "Cod:";
            // 
            // txtBuscaCep
            // 
            this.txtBuscaCep.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBuscaCep.Name = "txtBuscaCep";
            this.txtBuscaCep.Size = new System.Drawing.Size(100, 37);
            this.txtBuscaCep.ToolTipText = "Digite o valor";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(14, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(501, 100);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(389, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cadastro de Trabalhos";
            // 
            // lojaetec2024DataSet
            // 
            this.lojaetec2024DataSet.DataSetName = "lojaetec2024DataSet";
            this.lojaetec2024DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // trabalhoBindingSource
            // 
            this.trabalhoBindingSource.DataMember = "trabalho";
            this.trabalhoBindingSource.DataSource = this.lojaetec2024DataSet;
            // 
            // trabalhoTableAdapter
            // 
            this.trabalhoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.acessoTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.bairroTableAdapter = null;
            this.tableAdapterManager.cepTableAdapter = null;
            this.tableAdapterManager.cidadeTableAdapter = null;
            this.tableAdapterManager.clienteTableAdapter = null;
            this.tableAdapterManager.compraprodutoTableAdapter = null;
            this.tableAdapterManager.controlelogsistemaTableAdapter = null;
            this.tableAdapterManager.fornecedorTableAdapter = null;
            this.tableAdapterManager.funcaoTableAdapter = null;
            this.tableAdapterManager.funcionarioTableAdapter = null;
            this.tableAdapterManager.imagensTableAdapter = null;
            this.tableAdapterManager.itensacessologinTableAdapter = null;
            this.tableAdapterManager.itenscompraprodutoTableAdapter = null;
            this.tableAdapterManager.itenstelefoneclienteTableAdapter = null;
            this.tableAdapterManager.itenstelefonefornecedorTableAdapter = null;
            this.tableAdapterManager.itenstelefonefuncionarioTableAdapter = null;
            this.tableAdapterManager.itenstelefonelojaTableAdapter = null;
            this.tableAdapterManager.itenstelefonetrabalhoTableAdapter = null;
            this.tableAdapterManager.itensvendaprodutoTableAdapter = null;
            this.tableAdapterManager.loginsTableAdapter = null;
            this.tableAdapterManager.lojaTableAdapter = null;
            this.tableAdapterManager.marcaTableAdapter = null;
            this.tableAdapterManager.operadoraTableAdapter = null;
            this.tableAdapterManager.parcelacompraTableAdapter = null;
            this.tableAdapterManager.parcelavendaTableAdapter = null;
            this.tableAdapterManager.produtoTableAdapter = null;
            this.tableAdapterManager.ruaTableAdapter = null;
            this.tableAdapterManager.sexoTableAdapter = null;
            this.tableAdapterManager.situacaoTableAdapter = null;
            this.tableAdapterManager.telefoneTableAdapter = null;
            this.tableAdapterManager.tipoTableAdapter = null;
            this.tableAdapterManager.trabalhoTableAdapter = this.trabalhoTableAdapter;
            this.tableAdapterManager.ufTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = LojaETEC.lojaetec2024DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.vendaprodutoTableAdapter = null;
            // 
            // trabalhoDataGridView
            // 
            this.trabalhoDataGridView.AllowUserToAddRows = false;
            this.trabalhoDataGridView.AllowUserToDeleteRows = false;
            this.trabalhoDataGridView.AutoGenerateColumns = false;
            this.trabalhoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.trabalhoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.trabalhoDataGridView.DataSource = this.trabalhoBindingSource;
            this.trabalhoDataGridView.Location = new System.Drawing.Point(12, 228);
            this.trabalhoDataGridView.Name = "trabalhoDataGridView";
            this.trabalhoDataGridView.ReadOnly = true;
            this.trabalhoDataGridView.Size = new System.Drawing.Size(503, 220);
            this.trabalhoDataGridView.TabIndex = 5;
            // 
            // codtrabalhoLabel
            // 
            codtrabalhoLabel.AutoSize = true;
            codtrabalhoLabel.Location = new System.Drawing.Point(12, 159);
            codtrabalhoLabel.Name = "codtrabalhoLabel";
            codtrabalhoLabel.Size = new System.Drawing.Size(43, 13);
            codtrabalhoLabel.TabIndex = 5;
            codtrabalhoLabel.Text = "Código:";
            // 
            // codtrabalhoLabel1
            // 
            this.codtrabalhoLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.trabalhoBindingSource, "codtrabalho", true));
            this.codtrabalhoLabel1.Location = new System.Drawing.Point(124, 159);
            this.codtrabalhoLabel1.Name = "codtrabalhoLabel1";
            this.codtrabalhoLabel1.Size = new System.Drawing.Size(100, 23);
            this.codtrabalhoLabel1.TabIndex = 6;
            this.codtrabalhoLabel1.Text = "label2";
            // 
            // nomecidadetrabalhoLabel
            // 
            nomecidadetrabalhoLabel.AutoSize = true;
            nomecidadetrabalhoLabel.Location = new System.Drawing.Point(12, 188);
            nomecidadetrabalhoLabel.Name = "nomecidadetrabalhoLabel";
            nomecidadetrabalhoLabel.Size = new System.Drawing.Size(83, 13);
            nomecidadetrabalhoLabel.TabIndex = 7;
            nomecidadetrabalhoLabel.Text = "Nome Trabalho:";
            // 
            // txtTrabalho
            // 
            this.txtTrabalho.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.trabalhoBindingSource, "nomecidadetrabalho", true));
            this.txtTrabalho.Enabled = false;
            this.txtTrabalho.Location = new System.Drawing.Point(124, 185);
            this.txtTrabalho.Name = "txtTrabalho";
            this.txtTrabalho.Size = new System.Drawing.Size(391, 20);
            this.txtTrabalho.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "codtrabalho";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.ToolTipText = "Código do Trabalho";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nomecidadetrabalho";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome Trabalho";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.ToolTipText = "Nome do Trabalho";
            this.dataGridViewTextBoxColumn2.Width = 350;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = global::LojaETEC.Properties.Resources.trabalho;
            this.pictureBox1.Location = new System.Drawing.Point(18, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnNovo
            // 
            this.btnNovo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNovo.Image = global::LojaETEC.Properties.Resources.AddCliente;
            this.btnNovo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(34, 34);
            this.btnNovo.Text = "toolStripButton1";
            this.btnNovo.ToolTipText = "Novo Registro";
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Image = global::LojaETEC.Properties.Resources.Cancelar;
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(34, 34);
            this.btnCancelar.Text = "toolStripButton1";
            this.btnCancelar.ToolTipText = "Cancelar Edição";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEditar.Image = global::LojaETEC.Properties.Resources.Editar;
            this.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(34, 34);
            this.btnEditar.Text = "toolStripButton1";
            this.btnEditar.ToolTipText = "Editar Registro";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSalvar.Enabled = false;
            this.btnSalvar.Image = global::LojaETEC.Properties.Resources.Salvar;
            this.btnSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(34, 34);
            this.btnSalvar.Text = "toolStripButton1";
            this.btnSalvar.ToolTipText = "Salvar Registro";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnApagar.Image = global::LojaETEC.Properties.Resources.Apagar;
            this.btnApagar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(34, 34);
            this.btnApagar.Text = "toolStripButton1";
            this.btnApagar.ToolTipText = "Apagar Registro";
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // btnPrimeiro
            // 
            this.btnPrimeiro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPrimeiro.Image = global::LojaETEC.Properties.Resources.Primeiro;
            this.btnPrimeiro.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrimeiro.Name = "btnPrimeiro";
            this.btnPrimeiro.Size = new System.Drawing.Size(34, 34);
            this.btnPrimeiro.Text = "toolStripButton1";
            this.btnPrimeiro.ToolTipText = "Primeiro Registro";
            this.btnPrimeiro.Click += new System.EventHandler(this.btnPrimeiro_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAnterior.Image = global::LojaETEC.Properties.Resources.Anterior;
            this.btnAnterior.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(34, 34);
            this.btnAnterior.Text = "toolStripButton1";
            this.btnAnterior.ToolTipText = "Registro Anterior";
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnProximo
            // 
            this.btnProximo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnProximo.Image = global::LojaETEC.Properties.Resources.Proximo;
            this.btnProximo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(34, 34);
            this.btnProximo.Text = "toolStripButton1";
            this.btnProximo.ToolTipText = "Próximo Registro";
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // btnUltimo
            // 
            this.btnUltimo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnUltimo.Image = global::LojaETEC.Properties.Resources.Ultimo;
            this.btnUltimo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUltimo.Name = "btnUltimo";
            this.btnUltimo.Size = new System.Drawing.Size(34, 34);
            this.btnUltimo.Text = "toolStripButton1";
            this.btnUltimo.ToolTipText = "Último Registro";
            this.btnUltimo.Click += new System.EventHandler(this.btnUltimo_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnBuscar.Image = global::LojaETEC.Properties.Resources.Procurar;
            this.btnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(34, 34);
            this.btnBuscar.Text = "toolStripButton1";
            this.btnBuscar.ToolTipText = "Buscar Valor";
            // 
            // FrmTrabalho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 469);
            this.Controls.Add(codtrabalhoLabel);
            this.Controls.Add(this.codtrabalhoLabel1);
            this.Controls.Add(nomecidadetrabalhoLabel);
            this.Controls.Add(this.txtTrabalho);
            this.Controls.Add(this.trabalhoDataGridView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTrabalho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Trabalhos";
            this.Load += new System.EventHandler(this.FrmTrabalho_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lojaetec2024DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trabalhoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trabalhoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnNovo;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.ToolStripButton btnEditar;
        private System.Windows.Forms.ToolStripButton btnSalvar;
        private System.Windows.Forms.ToolStripButton btnApagar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnPrimeiro;
        private System.Windows.Forms.ToolStripButton btnAnterior;
        private System.Windows.Forms.ToolStripButton btnProximo;
        private System.Windows.Forms.ToolStripButton btnUltimo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel lblBuscaTrabalho;
        private System.Windows.Forms.ToolStripTextBox txtBuscaCep;
        private System.Windows.Forms.ToolStripButton btnBuscar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private lojaetec2024DataSet lojaetec2024DataSet;
        private System.Windows.Forms.BindingSource trabalhoBindingSource;
        private lojaetec2024DataSetTableAdapters.trabalhoTableAdapter trabalhoTableAdapter;
        private lojaetec2024DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView trabalhoDataGridView;
        private System.Windows.Forms.Label codtrabalhoLabel1;
        private System.Windows.Forms.TextBox txtTrabalho;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}