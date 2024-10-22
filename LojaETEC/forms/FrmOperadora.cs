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
    public partial class FrmOperadora : Form
    {
        public FrmOperadora()
        {
            InitializeComponent();
        }

        private void operadoraBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.operadoraBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.lojaetec2024DataSet);

        }

        private void FrmOperadora_Load(object sender, EventArgs e)
        {
            
            // TODO: esta linha de código carrega dados na tabela 'lojaetec2024DataSet.operadora'. Você pode movê-la ou removê-la conforme necessário.
            this.operadoraTableAdapter.Fill(this.lojaetec2024DataSet.operadora);

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
                operadoraBindingSource.AddNew();

                txtOperadora.Enabled = true;
                txtOperadora.Focus();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Cancelar o novo Registro?",
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
                operadoraBindingSource.CancelEdit();


                //Desativa o campo de CEP
                txtOperadora.Enabled = false;
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

                txtOperadora.Enabled = true;
                txtOperadora.Focus();
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
                operadoraBindingSource.EndEdit();
                operadoraTableAdapter.Update(lojaetec2024DataSet.operadora);

                //Desativa o campo de Trabalho
                txtOperadora.Enabled = false;
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
                operadoraBindingSource.RemoveCurrent();
                operadoraTableAdapter.Update(lojaetec2024DataSet.operadora);

                //txtCep.Enabled = true;
                //txtCep.Focus();
            }
        }

        private void btnPrimeiro_Click(object sender, EventArgs e)
        {
            operadoraBindingSource.MoveFirst();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            operadoraBindingSource.MovePrevious();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            operadoraBindingSource.MoveNext();
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            operadoraBindingSource.MoveLast();
        }
    }
}
