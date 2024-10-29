using LojaETEC.forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojaETEC
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void mnuSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Coloca a Data e Hora no StatusBar
            stlHora.Text = DateTime.Now.ToString();
        }

        private void mnuRua_Click(object sender, EventArgs e)
        {
            //Cria o objeto frmRua do tipo FrmRua
            FrmRua frmRua = new FrmRua();
            //Abre o objeto frmRua - Mostra na tela
            frmRua.ShowDialog();
        }

        private void mnuBairro_Click(object sender, EventArgs e)
        {
            FrmBairro frmBairro = new FrmBairro();
            frmBairro.ShowDialog();
        }

        private void mnuCep_Click(object sender, EventArgs e)
        {
            FrmCep frmCep = new FrmCep();
            frmCep.ShowDialog();
        }

        private void trabalhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTrabalho frmTrabalho = new FrmTrabalho();
            frmTrabalho.ShowDialog();
        }

        private void btnCadClientes_Click(object sender, EventArgs e)
        {

        }

        private void mnuRelatorios_Click(object sender, EventArgs e)
        {

        }

        private void MnuOperadora_Click(object sender, EventArgs e)
        {
            FrmOperadora frmOperadora = new FrmOperadora();
            frmOperadora.ShowDialog();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmClientes frmClientes = new FrmClientes();
            frmClientes.ShowDialog();
        }
    }
}
