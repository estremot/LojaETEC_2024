namespace LojaETEC.forms
{
    partial class FrmClientes
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
            System.Windows.Forms.Label codclienteLabel;
            System.Windows.Forms.Label nomeclienteLabel;
            System.Windows.Forms.Label fotoLabel;
            System.Windows.Forms.Label datanascLabel;
            System.Windows.Forms.Label codsexoLabel;
            System.Windows.Forms.Label codruaLabel;
            System.Windows.Forms.Label codbairroLabel;
            System.Windows.Forms.Label codcepLabel;
            System.Windows.Forms.Label codcidadeLabel;
            System.Windows.Forms.Label codufLabel;
            System.Windows.Forms.Label salarioLabel;
            System.Windows.Forms.Label codtrabalhoLabel;
            System.Windows.Forms.Label numerocasaLabel;
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.lblBuscaTrabalho = new System.Windows.Forms.ToolStripLabel();
            this.txtBuscaCep = new System.Windows.Forms.ToolStripTextBox();
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
            this.clienteDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lojaetec2024DataSet = new LojaETEC.lojaetec2024DataSet();
            this.clienteTableAdapter = new LojaETEC.lojaetec2024DataSetTableAdapters.clienteTableAdapter();
            this.tableAdapterManager = new LojaETEC.lojaetec2024DataSetTableAdapters.TableAdapterManager();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.pcbFoto = new System.Windows.Forms.PictureBox();
            this.datanascDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.sexoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sexoTableAdapter = new LojaETEC.lojaetec2024DataSetTableAdapters.sexoTableAdapter();
            this.codsexoComboBox = new System.Windows.Forms.ComboBox();
            this.codruaComboBox = new System.Windows.Forms.ComboBox();
            this.ruaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ruaTableAdapter = new LojaETEC.lojaetec2024DataSetTableAdapters.ruaTableAdapter();
            this.codbairroComboBox = new System.Windows.Forms.ComboBox();
            this.bairroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bairroTableAdapter = new LojaETEC.lojaetec2024DataSetTableAdapters.bairroTableAdapter();
            this.codcepComboBox = new System.Windows.Forms.ComboBox();
            this.cepBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cepTableAdapter = new LojaETEC.lojaetec2024DataSetTableAdapters.cepTableAdapter();
            this.codcidadeComboBox = new System.Windows.Forms.ComboBox();
            this.cidadeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cidadeTableAdapter = new LojaETEC.lojaetec2024DataSetTableAdapters.cidadeTableAdapter();
            this.codufComboBox = new System.Windows.Forms.ComboBox();
            this.ufBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ufTableAdapter = new LojaETEC.lojaetec2024DataSetTableAdapters.ufTableAdapter();
            this.salarioTextBox = new System.Windows.Forms.TextBox();
            this.codtrabalhoComboBox = new System.Windows.Forms.ComboBox();
            this.trabalhoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trabalhoTableAdapter = new LojaETEC.lojaetec2024DataSetTableAdapters.trabalhoTableAdapter();
            this.numerocasaTextBox = new System.Windows.Forms.TextBox();
            this.btnFoto = new System.Windows.Forms.Button();
            this.btnRua = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            codclienteLabel = new System.Windows.Forms.Label();
            nomeclienteLabel = new System.Windows.Forms.Label();
            fotoLabel = new System.Windows.Forms.Label();
            datanascLabel = new System.Windows.Forms.Label();
            codsexoLabel = new System.Windows.Forms.Label();
            codruaLabel = new System.Windows.Forms.Label();
            codbairroLabel = new System.Windows.Forms.Label();
            codcepLabel = new System.Windows.Forms.Label();
            codcidadeLabel = new System.Windows.Forms.Label();
            codufLabel = new System.Windows.Forms.Label();
            salarioLabel = new System.Windows.Forms.Label();
            codtrabalhoLabel = new System.Windows.Forms.Label();
            numerocasaLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lojaetec2024DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sexoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ruaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bairroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cepBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cidadeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ufBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trabalhoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(15, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(823, 100);
            this.panel1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(273, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cadastro de Clientes";
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
            this.toolStrip1.Size = new System.Drawing.Size(858, 37);
            this.toolStrip1.TabIndex = 9;
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
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = global::LojaETEC.Properties.Resources.cliente;
            this.pictureBox1.Location = new System.Drawing.Point(29, 3);
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
            // clienteDataGridView
            // 
            this.clienteDataGridView.AllowUserToAddRows = false;
            this.clienteDataGridView.AllowUserToDeleteRows = false;
            this.clienteDataGridView.AutoGenerateColumns = false;
            this.clienteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clienteDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewImageColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.clienteDataGridView.DataSource = this.clienteBindingSource;
            this.clienteDataGridView.Location = new System.Drawing.Point(12, 305);
            this.clienteDataGridView.Name = "clienteDataGridView";
            this.clienteDataGridView.ReadOnly = true;
            this.clienteDataGridView.Size = new System.Drawing.Size(826, 143);
            this.clienteDataGridView.TabIndex = 16;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "codcliente";
            this.dataGridViewTextBoxColumn1.HeaderText = "codcliente";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nomecliente";
            this.dataGridViewTextBoxColumn2.HeaderText = "nomecliente";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "foto";
            this.dataGridViewImageColumn1.HeaderText = "foto";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "datanasc";
            this.dataGridViewTextBoxColumn3.HeaderText = "datanasc";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "codsexo";
            this.dataGridViewTextBoxColumn4.HeaderText = "codsexo";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "codrua";
            this.dataGridViewTextBoxColumn5.HeaderText = "codrua";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "codbairro";
            this.dataGridViewTextBoxColumn6.HeaderText = "codbairro";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "codcep";
            this.dataGridViewTextBoxColumn7.HeaderText = "codcep";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "codcidade";
            this.dataGridViewTextBoxColumn8.HeaderText = "codcidade";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "coduf";
            this.dataGridViewTextBoxColumn9.HeaderText = "coduf";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "salario";
            this.dataGridViewTextBoxColumn10.HeaderText = "salario";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "codtrabalho";
            this.dataGridViewTextBoxColumn11.HeaderText = "codtrabalho";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "numerocasa";
            this.dataGridViewTextBoxColumn12.HeaderText = "numerocasa";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "cliente";
            this.clienteBindingSource.DataSource = this.lojaetec2024DataSet;
            // 
            // lojaetec2024DataSet
            // 
            this.lojaetec2024DataSet.DataSetName = "lojaetec2024DataSet";
            this.lojaetec2024DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.acessoTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.bairroTableAdapter = null;
            this.tableAdapterManager.cepTableAdapter = null;
            this.tableAdapterManager.cidadeTableAdapter = null;
            this.tableAdapterManager.clienteTableAdapter = this.clienteTableAdapter;
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
            this.tableAdapterManager.trabalhoTableAdapter = null;
            this.tableAdapterManager.ufTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = LojaETEC.lojaetec2024DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.vendaprodutoTableAdapter = null;
            // 
            // codclienteLabel
            // 
            codclienteLabel.AutoSize = true;
            codclienteLabel.Location = new System.Drawing.Point(12, 153);
            codclienteLabel.Name = "codclienteLabel";
            codclienteLabel.Size = new System.Drawing.Size(43, 13);
            codclienteLabel.TabIndex = 16;
            codclienteLabel.Text = "Código:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "codcliente", true));
            this.lblCodigo.Location = new System.Drawing.Point(56, 153);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(100, 23);
            this.lblCodigo.TabIndex = 17;
            this.lblCodigo.Text = "label2";
            // 
            // nomeclienteLabel
            // 
            nomeclienteLabel.AutoSize = true;
            nomeclienteLabel.Location = new System.Drawing.Point(12, 182);
            nomeclienteLabel.Name = "nomeclienteLabel";
            nomeclienteLabel.Size = new System.Drawing.Size(38, 13);
            nomeclienteLabel.TabIndex = 17;
            nomeclienteLabel.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "nomecliente", true));
            this.txtNome.Enabled = false;
            this.txtNome.Location = new System.Drawing.Point(57, 179);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(282, 20);
            this.txtNome.TabIndex = 18;
            // 
            // fotoLabel
            // 
            fotoLabel.AutoSize = true;
            fotoLabel.Location = new System.Drawing.Point(647, 153);
            fotoLabel.Name = "fotoLabel";
            fotoLabel.Size = new System.Drawing.Size(31, 13);
            fotoLabel.TabIndex = 18;
            fotoLabel.Text = "Foto:";
            // 
            // pcbFoto
            // 
            this.pcbFoto.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.clienteBindingSource, "foto", true));
            this.pcbFoto.Enabled = false;
            this.pcbFoto.Location = new System.Drawing.Point(681, 153);
            this.pcbFoto.Name = "pcbFoto";
            this.pcbFoto.Size = new System.Drawing.Size(157, 146);
            this.pcbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbFoto.TabIndex = 19;
            this.pcbFoto.TabStop = false;
            // 
            // datanascLabel
            // 
            datanascLabel.AutoSize = true;
            datanascLabel.Location = new System.Drawing.Point(344, 183);
            datanascLabel.Name = "datanascLabel";
            datanascLabel.Size = new System.Drawing.Size(35, 13);
            datanascLabel.TabIndex = 19;
            datanascLabel.Text = "Nasc:";
            // 
            // datanascDateTimePicker
            // 
            this.datanascDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.clienteBindingSource, "datanasc", true));
            this.datanascDateTimePicker.Enabled = false;
            this.datanascDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datanascDateTimePicker.Location = new System.Drawing.Point(381, 177);
            this.datanascDateTimePicker.Name = "datanascDateTimePicker";
            this.datanascDateTimePicker.Size = new System.Drawing.Size(109, 20);
            this.datanascDateTimePicker.TabIndex = 20;
            // 
            // sexoBindingSource
            // 
            this.sexoBindingSource.DataMember = "sexo";
            this.sexoBindingSource.DataSource = this.lojaetec2024DataSet;
            // 
            // sexoTableAdapter
            // 
            this.sexoTableAdapter.ClearBeforeFill = true;
            // 
            // codsexoLabel
            // 
            codsexoLabel.AutoSize = true;
            codsexoLabel.Location = new System.Drawing.Point(493, 181);
            codsexoLabel.Name = "codsexoLabel";
            codsexoLabel.Size = new System.Drawing.Size(34, 13);
            codsexoLabel.TabIndex = 20;
            codsexoLabel.Text = "Sexo:";
            // 
            // codsexoComboBox
            // 
            this.codsexoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.clienteBindingSource, "codsexo", true));
            this.codsexoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sexoBindingSource, "nomecidadesexo", true));
            this.codsexoComboBox.DataSource = this.sexoBindingSource;
            this.codsexoComboBox.DisplayMember = "nomecidadesexo";
            this.codsexoComboBox.Enabled = false;
            this.codsexoComboBox.FormattingEnabled = true;
            this.codsexoComboBox.Location = new System.Drawing.Point(530, 175);
            this.codsexoComboBox.Name = "codsexoComboBox";
            this.codsexoComboBox.Size = new System.Drawing.Size(137, 21);
            this.codsexoComboBox.TabIndex = 21;
            this.codsexoComboBox.ValueMember = "codsexo";
            // 
            // codruaLabel
            // 
            codruaLabel.AutoSize = true;
            codruaLabel.Location = new System.Drawing.Point(14, 210);
            codruaLabel.Name = "codruaLabel";
            codruaLabel.Size = new System.Drawing.Size(30, 13);
            codruaLabel.TabIndex = 21;
            codruaLabel.Text = "Rua:";
            // 
            // codruaComboBox
            // 
            this.codruaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.clienteBindingSource, "codrua", true));
            this.codruaComboBox.DataSource = this.ruaBindingSource;
            this.codruaComboBox.DisplayMember = "nomerua";
            this.codruaComboBox.Enabled = false;
            this.codruaComboBox.FormattingEnabled = true;
            this.codruaComboBox.Location = new System.Drawing.Point(59, 205);
            this.codruaComboBox.Name = "codruaComboBox";
            this.codruaComboBox.Size = new System.Drawing.Size(240, 21);
            this.codruaComboBox.TabIndex = 22;
            this.codruaComboBox.ValueMember = "codrua";
            // 
            // ruaBindingSource
            // 
            this.ruaBindingSource.DataMember = "rua";
            this.ruaBindingSource.DataSource = this.lojaetec2024DataSet;
            // 
            // ruaTableAdapter
            // 
            this.ruaTableAdapter.ClearBeforeFill = true;
            // 
            // codbairroLabel
            // 
            codbairroLabel.AutoSize = true;
            codbairroLabel.Location = new System.Drawing.Point(345, 210);
            codbairroLabel.Name = "codbairroLabel";
            codbairroLabel.Size = new System.Drawing.Size(37, 13);
            codbairroLabel.TabIndex = 22;
            codbairroLabel.Text = "Bairro:";
            // 
            // codbairroComboBox
            // 
            this.codbairroComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.clienteBindingSource, "codbairro", true));
            this.codbairroComboBox.DataSource = this.bairroBindingSource;
            this.codbairroComboBox.DisplayMember = "nomebairro";
            this.codbairroComboBox.Enabled = false;
            this.codbairroComboBox.FormattingEnabled = true;
            this.codbairroComboBox.Location = new System.Drawing.Point(383, 206);
            this.codbairroComboBox.Name = "codbairroComboBox";
            this.codbairroComboBox.Size = new System.Drawing.Size(72, 21);
            this.codbairroComboBox.TabIndex = 23;
            this.codbairroComboBox.ValueMember = "codbairro";
            // 
            // bairroBindingSource
            // 
            this.bairroBindingSource.DataMember = "bairro";
            this.bairroBindingSource.DataSource = this.lojaetec2024DataSet;
            // 
            // bairroTableAdapter
            // 
            this.bairroTableAdapter.ClearBeforeFill = true;
            // 
            // codcepLabel
            // 
            codcepLabel.AutoSize = true;
            codcepLabel.Location = new System.Drawing.Point(496, 210);
            codcepLabel.Name = "codcepLabel";
            codcepLabel.Size = new System.Drawing.Size(31, 13);
            codcepLabel.TabIndex = 23;
            codcepLabel.Text = "CEP:";
            // 
            // codcepComboBox
            // 
            this.codcepComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.clienteBindingSource, "codcep", true));
            this.codcepComboBox.DataSource = this.cepBindingSource;
            this.codcepComboBox.DisplayMember = "numerocep";
            this.codcepComboBox.Enabled = false;
            this.codcepComboBox.FormattingEnabled = true;
            this.codcepComboBox.Location = new System.Drawing.Point(532, 206);
            this.codcepComboBox.Name = "codcepComboBox";
            this.codcepComboBox.Size = new System.Drawing.Size(96, 21);
            this.codcepComboBox.TabIndex = 24;
            this.codcepComboBox.ValueMember = "codcep";
            // 
            // cepBindingSource
            // 
            this.cepBindingSource.DataMember = "cep";
            this.cepBindingSource.DataSource = this.lojaetec2024DataSet;
            // 
            // cepTableAdapter
            // 
            this.cepTableAdapter.ClearBeforeFill = true;
            // 
            // codcidadeLabel
            // 
            codcidadeLabel.AutoSize = true;
            codcidadeLabel.Location = new System.Drawing.Point(16, 235);
            codcidadeLabel.Name = "codcidadeLabel";
            codcidadeLabel.Size = new System.Drawing.Size(43, 13);
            codcidadeLabel.TabIndex = 24;
            codcidadeLabel.Text = "Cidade:";
            // 
            // codcidadeComboBox
            // 
            this.codcidadeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.clienteBindingSource, "codcidade", true));
            this.codcidadeComboBox.DataSource = this.cidadeBindingSource;
            this.codcidadeComboBox.DisplayMember = "nomecidade";
            this.codcidadeComboBox.Enabled = false;
            this.codcidadeComboBox.FormattingEnabled = true;
            this.codcidadeComboBox.Location = new System.Drawing.Point(60, 231);
            this.codcidadeComboBox.Name = "codcidadeComboBox";
            this.codcidadeComboBox.Size = new System.Drawing.Size(279, 21);
            this.codcidadeComboBox.TabIndex = 25;
            this.codcidadeComboBox.ValueMember = "codcidade";
            // 
            // cidadeBindingSource
            // 
            this.cidadeBindingSource.DataMember = "cidade";
            this.cidadeBindingSource.DataSource = this.lojaetec2024DataSet;
            // 
            // cidadeTableAdapter
            // 
            this.cidadeTableAdapter.ClearBeforeFill = true;
            // 
            // codufLabel
            // 
            codufLabel.AutoSize = true;
            codufLabel.Location = new System.Drawing.Point(349, 238);
            codufLabel.Name = "codufLabel";
            codufLabel.Size = new System.Drawing.Size(24, 13);
            codufLabel.TabIndex = 25;
            codufLabel.Text = "UF:";
            // 
            // codufComboBox
            // 
            this.codufComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.clienteBindingSource, "coduf", true));
            this.codufComboBox.DataSource = this.ufBindingSource;
            this.codufComboBox.DisplayMember = "nomeuf";
            this.codufComboBox.Enabled = false;
            this.codufComboBox.FormattingEnabled = true;
            this.codufComboBox.Location = new System.Drawing.Point(383, 234);
            this.codufComboBox.Name = "codufComboBox";
            this.codufComboBox.Size = new System.Drawing.Size(107, 21);
            this.codufComboBox.TabIndex = 26;
            this.codufComboBox.ValueMember = "coduf";
            // 
            // ufBindingSource
            // 
            this.ufBindingSource.DataMember = "uf";
            this.ufBindingSource.DataSource = this.lojaetec2024DataSet;
            // 
            // ufTableAdapter
            // 
            this.ufTableAdapter.ClearBeforeFill = true;
            // 
            // salarioLabel
            // 
            salarioLabel.AutoSize = true;
            salarioLabel.Location = new System.Drawing.Point(492, 241);
            salarioLabel.Name = "salarioLabel";
            salarioLabel.Size = new System.Drawing.Size(42, 13);
            salarioLabel.TabIndex = 26;
            salarioLabel.Text = "Salário:";
            // 
            // salarioTextBox
            // 
            this.salarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "salario", true));
            this.salarioTextBox.Enabled = false;
            this.salarioTextBox.Location = new System.Drawing.Point(535, 236);
            this.salarioTextBox.Name = "salarioTextBox";
            this.salarioTextBox.Size = new System.Drawing.Size(131, 20);
            this.salarioTextBox.TabIndex = 27;
            // 
            // codtrabalhoLabel
            // 
            codtrabalhoLabel.AutoSize = true;
            codtrabalhoLabel.Location = new System.Drawing.Point(6, 263);
            codtrabalhoLabel.Name = "codtrabalhoLabel";
            codtrabalhoLabel.Size = new System.Drawing.Size(52, 13);
            codtrabalhoLabel.TabIndex = 27;
            codtrabalhoLabel.Text = "Trabalho:";
            // 
            // codtrabalhoComboBox
            // 
            this.codtrabalhoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.clienteBindingSource, "codtrabalho", true));
            this.codtrabalhoComboBox.DataSource = this.trabalhoBindingSource;
            this.codtrabalhoComboBox.DisplayMember = "nomecidadetrabalho";
            this.codtrabalhoComboBox.Enabled = false;
            this.codtrabalhoComboBox.FormattingEnabled = true;
            this.codtrabalhoComboBox.Location = new System.Drawing.Point(61, 258);
            this.codtrabalhoComboBox.Name = "codtrabalhoComboBox";
            this.codtrabalhoComboBox.Size = new System.Drawing.Size(238, 21);
            this.codtrabalhoComboBox.TabIndex = 28;
            this.codtrabalhoComboBox.ValueMember = "codtrabalho";
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
            // numerocasaLabel
            // 
            numerocasaLabel.AutoSize = true;
            numerocasaLabel.Location = new System.Drawing.Point(349, 265);
            numerocasaLabel.Name = "numerocasaLabel";
            numerocasaLabel.Size = new System.Drawing.Size(47, 13);
            numerocasaLabel.TabIndex = 28;
            numerocasaLabel.Text = "Número:";
            // 
            // numerocasaTextBox
            // 
            this.numerocasaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "numerocasa", true));
            this.numerocasaTextBox.Enabled = false;
            this.numerocasaTextBox.Location = new System.Drawing.Point(402, 261);
            this.numerocasaTextBox.Name = "numerocasaTextBox";
            this.numerocasaTextBox.Size = new System.Drawing.Size(88, 20);
            this.numerocasaTextBox.TabIndex = 29;
            // 
            // btnFoto
            // 
            this.btnFoto.Location = new System.Drawing.Point(591, 275);
            this.btnFoto.Name = "btnFoto";
            this.btnFoto.Size = new System.Drawing.Size(75, 24);
            this.btnFoto.TabIndex = 30;
            this.btnFoto.Text = "Foto";
            this.btnFoto.UseVisualStyleBackColor = true;
            this.btnFoto.Click += new System.EventHandler(this.btnFoto_Click);
            // 
            // btnRua
            // 
            this.btnRua.Location = new System.Drawing.Point(305, 203);
            this.btnRua.Name = "btnRua";
            this.btnRua.Size = new System.Drawing.Size(33, 23);
            this.btnRua.TabIndex = 31;
            this.btnRua.Text = "+";
            this.btnRua.UseVisualStyleBackColor = true;
            this.btnRua.Click += new System.EventHandler(this.btnRua_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(457, 204);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 23);
            this.button1.TabIndex = 32;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(633, 204);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(33, 23);
            this.button2.TabIndex = 33;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(306, 256);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(33, 23);
            this.button3.TabIndex = 34;
            this.button3.Text = "+";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FrmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 497);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnRua);
            this.Controls.Add(this.btnFoto);
            this.Controls.Add(numerocasaLabel);
            this.Controls.Add(this.numerocasaTextBox);
            this.Controls.Add(codtrabalhoLabel);
            this.Controls.Add(this.codtrabalhoComboBox);
            this.Controls.Add(salarioLabel);
            this.Controls.Add(this.salarioTextBox);
            this.Controls.Add(codufLabel);
            this.Controls.Add(this.codufComboBox);
            this.Controls.Add(codcidadeLabel);
            this.Controls.Add(this.codcidadeComboBox);
            this.Controls.Add(codcepLabel);
            this.Controls.Add(this.codcepComboBox);
            this.Controls.Add(codbairroLabel);
            this.Controls.Add(this.codbairroComboBox);
            this.Controls.Add(codruaLabel);
            this.Controls.Add(this.codruaComboBox);
            this.Controls.Add(codsexoLabel);
            this.Controls.Add(this.codsexoComboBox);
            this.Controls.Add(datanascLabel);
            this.Controls.Add(this.datanascDateTimePicker);
            this.Controls.Add(fotoLabel);
            this.Controls.Add(this.pcbFoto);
            this.Controls.Add(nomeclienteLabel);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(codclienteLabel);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.clienteDataGridView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmClientes";
            this.Text = "FrmClientes";
            this.Load += new System.EventHandler(this.FrmClientes_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lojaetec2024DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sexoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ruaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bairroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cepBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cidadeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ufBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trabalhoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private lojaetec2024DataSetTableAdapters.clienteTableAdapter clienteTableAdapter;
        private lojaetec2024DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView clienteDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.PictureBox pcbFoto;
        private System.Windows.Forms.DateTimePicker datanascDateTimePicker;
        private System.Windows.Forms.BindingSource sexoBindingSource;
        private lojaetec2024DataSetTableAdapters.sexoTableAdapter sexoTableAdapter;
        private System.Windows.Forms.ComboBox codsexoComboBox;
        private System.Windows.Forms.ComboBox codruaComboBox;
        private System.Windows.Forms.BindingSource ruaBindingSource;
        private lojaetec2024DataSetTableAdapters.ruaTableAdapter ruaTableAdapter;
        private System.Windows.Forms.ComboBox codbairroComboBox;
        private System.Windows.Forms.BindingSource bairroBindingSource;
        private lojaetec2024DataSetTableAdapters.bairroTableAdapter bairroTableAdapter;
        private System.Windows.Forms.ComboBox codcepComboBox;
        private System.Windows.Forms.BindingSource cepBindingSource;
        private lojaetec2024DataSetTableAdapters.cepTableAdapter cepTableAdapter;
        private System.Windows.Forms.ComboBox codcidadeComboBox;
        private System.Windows.Forms.BindingSource cidadeBindingSource;
        private lojaetec2024DataSetTableAdapters.cidadeTableAdapter cidadeTableAdapter;
        private System.Windows.Forms.ComboBox codufComboBox;
        private System.Windows.Forms.BindingSource ufBindingSource;
        private lojaetec2024DataSetTableAdapters.ufTableAdapter ufTableAdapter;
        private System.Windows.Forms.TextBox salarioTextBox;
        private System.Windows.Forms.ComboBox codtrabalhoComboBox;
        private System.Windows.Forms.BindingSource trabalhoBindingSource;
        private lojaetec2024DataSetTableAdapters.trabalhoTableAdapter trabalhoTableAdapter;
        private System.Windows.Forms.TextBox numerocasaTextBox;
        private System.Windows.Forms.Button btnFoto;
        private System.Windows.Forms.Button btnRua;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}