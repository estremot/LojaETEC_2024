using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojaETEC.forms
{
    public partial class FrmCep : Form
    {
        public FrmCep()
        {
            InitializeComponent();
        }

        private void cepBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cepBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.lojaetec2024DataSet);

        }

        private void FrmCep_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'lojaetec2024DataSet.cep'. Você pode movê-la ou removê-la conforme necessário.
            this.cepTableAdapter.Fill(this.lojaetec2024DataSet.cep);

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Inserir um novo Registro?",
                "Loja ETEC 2024",MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //Desativar os Botões
                btnNovo.Enabled = false;
                btnEditar.Enabled = false;
                btnApagar.Enabled = false;
                //Ativar Botões
                btnCancelar.Enabled = true;
                btnSalvar.Enabled = true;

                //Colocar a Tabela CEP em modo de inserção
                cepBindingSource.AddNew();

                txtCep.Enabled = true;
                txtCep.Focus();
            }
        }

        private void btnPrimeiro_Click(object sender, EventArgs e)
        {
            cepBindingSource.MoveFirst();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            cepBindingSource.MovePrevious();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            cepBindingSource.MoveNext();
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            cepBindingSource.MoveLast();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Salvar o novo Registro?",
                "Loja ETEC 2024", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //ativar os Botões
                btnNovo.Enabled = true;
                btnEditar.Enabled = true;
                btnApagar.Enabled = true;
                //desativar Botões
                btnCancelar.Enabled = false;
                btnSalvar.Enabled = false;

                //Salvar os Dados na Tabela CEP
                cepBindingSource.EndEdit();
                cepTableAdapter.Update(lojaetec2024DataSet.cep);
                
                //Desativa o campo de CEP
                txtCep.Enabled = false;
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Salvar o novo Registro?",
               "Loja ETEC 2024", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //ativar os Botões
                btnNovo.Enabled = true;
                btnEditar.Enabled = true;
                btnApagar.Enabled = true;
                //desativar Botões
                btnCancelar.Enabled = false;
                btnSalvar.Enabled = false;

                //Cancelar a Edição Tabela CEP
                cepBindingSource.CancelEdit();
           

                //Desativa o campo de CEP
                txtCep.Enabled = false;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Editar o Registro?",
               "Loja ETEC 2024", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //Desativar os Botões
                btnNovo.Enabled = false;
                btnEditar.Enabled = false;
                btnApagar.Enabled = false;
                //Ativar Botões
                btnCancelar.Enabled = true;
                btnSalvar.Enabled = true;

                txtCep.Enabled = true;
                txtCep.Focus();
            }
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apagar Registro?",
               "Loja ETEC 2024", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //Desativar os Botões
                btnNovo.Enabled = true;
                btnEditar.Enabled = true;
                btnApagar.Enabled = true;
                //Ativar Botões
                btnCancelar.Enabled = false;
                btnSalvar.Enabled = false;

                //Colocar a Tabela CEP em modo de inserção
                cepBindingSource.RemoveCurrent();
                cepTableAdapter.Update(lojaetec2024DataSet.cep);

                //txtCep.Enabled = true;
                //txtCep.Focus();
            }
        }
    }
}
