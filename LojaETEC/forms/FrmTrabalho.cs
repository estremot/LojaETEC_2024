using LojaETEC.lojaetec2024DataSetTableAdapters;
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
    public partial class FrmTrabalho : Form
    {
        public FrmTrabalho()
        {
            InitializeComponent();
        }

        private void trabalhoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.trabalhoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.lojaetec2024DataSet);

        }

        private void FrmTrabalho_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'lojaetec2024DataSet.trabalho'. Você pode movê-la ou removê-la conforme necessário.
            this.trabalhoTableAdapter.Fill(this.lojaetec2024DataSet.trabalho);

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Inserir um novo Registro?",
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

                //Colocar a Tabela Trabalho em modo de inserção
                trabalhoBindingSource.AddNew();

                txtTrabalho.Enabled = true;
                txtTrabalho.Focus();
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

                //Cancelar a Edição Tabela Trabalho
                trabalhoBindingSource.CancelEdit();


                //Desativa o campo de CEP
                txtTrabalho.Enabled = false;
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

                txtTrabalho.Enabled = true;
                txtTrabalho.Focus();
            }
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

                //Salvar os Dados na Tabela Trabalho
                trabalhoBindingSource.EndEdit();
                trabalhoTableAdapter.Update(lojaetec2024DataSet.trabalho);

                //Desativa o campo de Trabalho
                txtTrabalho.Enabled = false;
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
                trabalhoBindingSource.RemoveCurrent();
                trabalhoTableAdapter.Update(lojaetec2024DataSet.trabalho);

                //txtCep.Enabled = true;
                //txtCep.Focus();
            }
        }

        private void btnPrimeiro_Click(object sender, EventArgs e)
        {
            trabalhoBindingSource.MoveFirst();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            trabalhoBindingSource.MovePrevious();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            trabalhoBindingSource.MoveNext();
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            trabalhoBindingSource.MoveLast();
        }
    }
}
