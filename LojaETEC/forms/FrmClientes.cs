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
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
        }

        private void clienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.lojaetec2024DataSet);

        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'lojaetec2024DataSet.trabalho'. Você pode movê-la ou removê-la conforme necessário.
            this.trabalhoTableAdapter.Fill(this.lojaetec2024DataSet.trabalho);
            // TODO: esta linha de código carrega dados na tabela 'lojaetec2024DataSet.uf'. Você pode movê-la ou removê-la conforme necessário.
            this.ufTableAdapter.Fill(this.lojaetec2024DataSet.uf);
            // TODO: esta linha de código carrega dados na tabela 'lojaetec2024DataSet.cidade'. Você pode movê-la ou removê-la conforme necessário.
            this.cidadeTableAdapter.Fill(this.lojaetec2024DataSet.cidade);
            // TODO: esta linha de código carrega dados na tabela 'lojaetec2024DataSet.cep'. Você pode movê-la ou removê-la conforme necessário.
            this.cepTableAdapter.Fill(this.lojaetec2024DataSet.cep);
            // TODO: esta linha de código carrega dados na tabela 'lojaetec2024DataSet.bairro'. Você pode movê-la ou removê-la conforme necessário.
            this.bairroTableAdapter.Fill(this.lojaetec2024DataSet.bairro);
            // TODO: esta linha de código carrega dados na tabela 'lojaetec2024DataSet.rua'. Você pode movê-la ou removê-la conforme necessário.
            this.ruaTableAdapter.Fill(this.lojaetec2024DataSet.rua);

            // TODO: esta linha de código carrega dados na tabela 'lojaetec2024DataSet.cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.clienteTableAdapter.Fill(this.lojaetec2024DataSet.cliente);

        }

        private void salarioTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRua_Click(object sender, EventArgs e)
        {
            FrmRua frmRua = new FrmRua();
            frmRua.ShowDialog();    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmBairro frmBairro = new FrmBairro();
            frmBairro.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmCep frmCep = new FrmCep();   
            frmCep.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmTrabalho frmTrabalho = new FrmTrabalho();
            frmTrabalho.ShowDialog();
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
                clienteBindingSource.AddNew();

                txtNome.Enabled = true;
                datanascDateTimePicker.Enabled = true;
                codsexoComboBox.Enabled = true;
                codruaComboBox.Enabled = true;
                codbairroComboBox.Enabled = true;
                codcepComboBox.Enabled = true;
                codcidadeComboBox.Enabled = true;
                codufComboBox.Enabled = true;
                salarioTextBox.Enabled = true;
                codtrabalhoComboBox.Enabled = true;
                numerocasaTextBox.Enabled = true;

                txtNome.Focus();
            }
        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Image imagem = Image.FromFile(openFileDialog1.FileName);
                pcbFoto.Image = imagem;
            }
        }
    }
}
