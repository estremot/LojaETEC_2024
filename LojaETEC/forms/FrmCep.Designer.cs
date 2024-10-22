namespace LojaETEC.forms
{
    partial class FrmCep
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
            System.Windows.Forms.Label codcepLabel;
            System.Windows.Forms.Label numerocepLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCep));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.lblBuscaCep = new System.Windows.Forms.ToolStripLabel();
            this.txtBuscaCep = new System.Windows.Forms.ToolStripTextBox();
            this.lojaetec2024DataSet = new LojaETEC.lojaetec2024DataSet();
            this.cepBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cepTableAdapter = new LojaETEC.lojaetec2024DataSetTableAdapters.cepTableAdapter();
            this.tableAdapterManager = new LojaETEC.lojaetec2024DataSetTableAdapters.TableAdapterManager();
            this.codcepLabel1 = new System.Windows.Forms.Label();
            this.txtCep = new System.Windows.Forms.MaskedTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codcepDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numerocepDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            codcepLabel = new System.Windows.Forms.Label();
            numerocepLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lojaetec2024DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cepBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // codcepLabel
            // 
            codcepLabel.AutoSize = true;
            codcepLabel.Location = new System.Drawing.Point(8, 153);
            codcepLabel.Name = "codcepLabel";
            codcepLabel.Size = new System.Drawing.Size(43, 13);
            codcepLabel.TabIndex = 3;
            codcepLabel.Text = "Código:";
            // 
            // numerocepLabel
            // 
            numerocepLabel.AutoSize = true;
            numerocepLabel.Location = new System.Drawing.Point(12, 182);
            numerocepLabel.Name = "numerocepLabel";
            numerocepLabel.Size = new System.Drawing.Size(31, 13);
            numerocepLabel.TabIndex = 5;
            numerocepLabel.Text = "CEP:";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(8, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(501, 100);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(125, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cadastro de CEP";
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
            this.lblBuscaCep,
            this.txtBuscaCep,
            this.btnBuscar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(521, 37);
            this.toolStrip1.TabIndex = 2;
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
            // lblBuscaCep
            // 
            this.lblBuscaCep.Name = "lblBuscaCep";
            this.lblBuscaCep.Size = new System.Drawing.Size(31, 34);
            this.lblBuscaCep.Text = "CEP:";
            // 
            // txtBuscaCep
            // 
            this.txtBuscaCep.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBuscaCep.Name = "txtBuscaCep";
            this.txtBuscaCep.Size = new System.Drawing.Size(100, 37);
            this.txtBuscaCep.ToolTipText = "Digite o valor";
            // 
            // lojaetec2024DataSet
            // 
            this.lojaetec2024DataSet.DataSetName = "lojaetec2024DataSet";
            this.lojaetec2024DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.acessoTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.bairroTableAdapter = null;
            this.tableAdapterManager.cepTableAdapter = this.cepTableAdapter;
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
            this.tableAdapterManager.trabalhoTableAdapter = null;
            this.tableAdapterManager.ufTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = LojaETEC.lojaetec2024DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.vendaprodutoTableAdapter = null;
            // 
            // codcepLabel1
            // 
            this.codcepLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cepBindingSource, "codcep", true));
            this.codcepLabel1.Location = new System.Drawing.Point(60, 153);
            this.codcepLabel1.Name = "codcepLabel1";
            this.codcepLabel1.Size = new System.Drawing.Size(100, 23);
            this.codcepLabel1.TabIndex = 4;
            this.codcepLabel1.Text = "label2";
            // 
            // txtCep
            // 
            this.txtCep.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cepBindingSource, "numerocep", true));
            this.txtCep.Enabled = false;
            this.txtCep.Location = new System.Drawing.Point(62, 179);
            this.txtCep.Mask = "00000-999";
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(100, 20);
            this.txtCep.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codcepDataGridViewTextBoxColumn,
            this.numerocepDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cepBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 218);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(501, 150);
            this.dataGridView1.TabIndex = 7;
            // 
            // codcepDataGridViewTextBoxColumn
            // 
            this.codcepDataGridViewTextBoxColumn.DataPropertyName = "codcep";
            this.codcepDataGridViewTextBoxColumn.HeaderText = "Código";
            this.codcepDataGridViewTextBoxColumn.Name = "codcepDataGridViewTextBoxColumn";
            this.codcepDataGridViewTextBoxColumn.ReadOnly = true;
            this.codcepDataGridViewTextBoxColumn.ToolTipText = "Código do CEP";
            // 
            // numerocepDataGridViewTextBoxColumn
            // 
            this.numerocepDataGridViewTextBoxColumn.DataPropertyName = "numerocep";
            this.numerocepDataGridViewTextBoxColumn.HeaderText = "CEP";
            this.numerocepDataGridViewTextBoxColumn.Name = "numerocepDataGridViewTextBoxColumn";
            this.numerocepDataGridViewTextBoxColumn.ReadOnly = true;
            this.numerocepDataGridViewTextBoxColumn.ToolTipText = "Número do CEP";
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
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = global::LojaETEC.Properties.Resources.codigo_postal;
            this.pictureBox1.Location = new System.Drawing.Point(18, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // FrmCep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 374);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(numerocepLabel);
            this.Controls.Add(this.txtCep);
            this.Controls.Add(codcepLabel);
            this.Controls.Add(this.codcepLabel1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCep";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de CEPs";
            this.Load += new System.EventHandler(this.FrmCep_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lojaetec2024DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cepBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.ToolStripLabel lblBuscaCep;
        private System.Windows.Forms.ToolStripTextBox txtBuscaCep;
        private System.Windows.Forms.ToolStripButton btnBuscar;
        private lojaetec2024DataSet lojaetec2024DataSet;
        private System.Windows.Forms.BindingSource cepBindingSource;
        private lojaetec2024DataSetTableAdapters.cepTableAdapter cepTableAdapter;
        private lojaetec2024DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label codcepLabel1;
        private System.Windows.Forms.MaskedTextBox txtCep;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codcepDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numerocepDataGridViewTextBoxColumn;
    }
}