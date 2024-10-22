namespace LojaETEC.forms
{
    partial class FrmOperadora
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
            System.Windows.Forms.Label nomeoperadoraLabel;
            this.codtrabalhoLabel1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNovo = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.btnSalvar = new System.Windows.Forms.ToolStripButton();
            this.btnApagar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnPrimeiro = new System.Windows.Forms.ToolStripButton();
            this.btnAnterior = new System.Windows.Forms.ToolStripButton();
            this.btnProximo = new System.Windows.Forms.ToolStripButton();
            this.btnUltimo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.lblBuscaTrabalho = new System.Windows.Forms.ToolStripLabel();
            this.txtBuscaCep = new System.Windows.Forms.ToolStripTextBox();
            this.btnBuscar = new System.Windows.Forms.ToolStripButton();
            this.lojaetec2024DataSet = new LojaETEC.lojaetec2024DataSet();
            this.operadoraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.operadoraTableAdapter = new LojaETEC.lojaetec2024DataSetTableAdapters.operadoraTableAdapter();
            this.tableAdapterManager = new LojaETEC.lojaetec2024DataSetTableAdapters.TableAdapterManager();
            this.txtOperadora = new System.Windows.Forms.TextBox();
            this.operadoraDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            codtrabalhoLabel = new System.Windows.Forms.Label();
            nomeoperadoraLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lojaetec2024DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.operadoraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.operadoraDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // codtrabalhoLabel
            // 
            codtrabalhoLabel.AutoSize = true;
            codtrabalhoLabel.Location = new System.Drawing.Point(12, 160);
            codtrabalhoLabel.Name = "codtrabalhoLabel";
            codtrabalhoLabel.Size = new System.Drawing.Size(43, 13);
            codtrabalhoLabel.TabIndex = 11;
            codtrabalhoLabel.Text = "Código:";
            // 
            // codtrabalhoLabel1
            // 
            this.codtrabalhoLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.operadoraBindingSource, "codoperadora", true));
            this.codtrabalhoLabel1.Location = new System.Drawing.Point(74, 160);
            this.codtrabalhoLabel1.Name = "codtrabalhoLabel1";
            this.codtrabalhoLabel1.Size = new System.Drawing.Size(100, 23);
            this.codtrabalhoLabel1.TabIndex = 13;
            this.codtrabalhoLabel1.Text = "label2";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(22, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(531, 100);
            this.panel1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(105, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(419, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cadastro de Operadoras";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = global::LojaETEC.Properties.Resources.chamada_telefonica;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
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
            this.toolStrip1.Size = new System.Drawing.Size(572, 37);
            this.toolStrip1.TabIndex = 9;
            this.toolStrip1.Text = "toolStrip1";
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
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 37);
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
            // lojaetec2024DataSet
            // 
            this.lojaetec2024DataSet.DataSetName = "lojaetec2024DataSet";
            this.lojaetec2024DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // operadoraBindingSource
            // 
            this.operadoraBindingSource.DataMember = "operadora";
            this.operadoraBindingSource.DataSource = this.lojaetec2024DataSet;
            // 
            // operadoraTableAdapter
            // 
            this.operadoraTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.operadoraTableAdapter = this.operadoraTableAdapter;
            this.tableAdapterManager.parcelacompraTableAdapter = null;
            this.tableAdapterManager.parcelavendaTableAdapter = null;
            this.tableAdapterManager.produtoTableAdapter = null;
            this.tableAdapterManager.ruaTableAdapter = null;
            this.tableAdapterManager.sexoTableAdapter = null;
            this.tableAdapterManager.situacaoTableAdapter = null;
            this.tableAdapterManager.telefoneTableAdapter = null;
            this.tableAdapterManager.tipoTableAdapter = null;
            this.tableAdapterManager.trabalhoTableAdapter = null;
            this.tableAdapterManager.ufTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = LojaETEC.lojaetec2024DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.vendaprodutoTableAdapter = null;
            // 
            // nomeoperadoraLabel
            // 
            nomeoperadoraLabel.AutoSize = true;
            nomeoperadoraLabel.Location = new System.Drawing.Point(11, 189);
            nomeoperadoraLabel.Name = "nomeoperadoraLabel";
            nomeoperadoraLabel.Size = new System.Drawing.Size(60, 13);
            nomeoperadoraLabel.TabIndex = 15;
            nomeoperadoraLabel.Text = "Operadora:";
            // 
            // txtOperadora
            // 
            this.txtOperadora.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.operadoraBindingSource, "nomeoperadora", true));
            this.txtOperadora.Enabled = false;
            this.txtOperadora.Location = new System.Drawing.Point(77, 186);
            this.txtOperadora.Name = "txtOperadora";
            this.txtOperadora.Size = new System.Drawing.Size(490, 20);
            this.txtOperadora.TabIndex = 16;
            // 
            // operadoraDataGridView
            // 
            this.operadoraDataGridView.AllowUserToAddRows = false;
            this.operadoraDataGridView.AllowUserToDeleteRows = false;
            this.operadoraDataGridView.AutoGenerateColumns = false;
            this.operadoraDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.operadoraDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.operadoraDataGridView.DataSource = this.operadoraBindingSource;
            this.operadoraDataGridView.Location = new System.Drawing.Point(15, 221);
            this.operadoraDataGridView.Name = "operadoraDataGridView";
            this.operadoraDataGridView.ReadOnly = true;
            this.operadoraDataGridView.Size = new System.Drawing.Size(552, 294);
            this.operadoraDataGridView.TabIndex = 16;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "codoperadora";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nomeoperadora";
            this.dataGridViewTextBoxColumn2.HeaderText = "Operadora";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // FrmOperadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 527);
            this.Controls.Add(this.operadoraDataGridView);
            this.Controls.Add(nomeoperadoraLabel);
            this.Controls.Add(this.txtOperadora);
            this.Controls.Add(codtrabalhoLabel);
            this.Controls.Add(this.codtrabalhoLabel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmOperadora";
            this.Text = "Cadastro de Operadoras";
            this.Load += new System.EventHandler(this.FrmOperadora_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lojaetec2024DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.operadoraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.operadoraDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label codtrabalhoLabel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
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
        private lojaetec2024DataSet lojaetec2024DataSet;
        private System.Windows.Forms.BindingSource operadoraBindingSource;
        private lojaetec2024DataSetTableAdapters.operadoraTableAdapter operadoraTableAdapter;
        private lojaetec2024DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txtOperadora;
        private System.Windows.Forms.DataGridView operadoraDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}