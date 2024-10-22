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
    public partial class FrmRua : Form
    {
        public FrmRua()
        {
            InitializeComponent();
        }

        private void ruaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ruaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.lojaetec2024DataSet);

        }

        private void FrmRua_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'lojaetec2024DataSet.rua'. Você pode movê-la ou removê-la conforme necessário.
            this.ruaTableAdapter.Fill(this.lojaetec2024DataSet.rua);

        }
    }
}
