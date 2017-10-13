using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConversorDeNumerosRomanos.Forms;
using ConversorDeNumerosRomanos.Classes;

namespace ConversorDeNumerosRomanos
{
    public partial class frmPrincipal : Form
    {
        
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Conversao.ListarConversoes().Count; i++)
            {
                gridViewConversoes.Rows.Insert(i,Conversao.ListarConversoes());
            }
        }

        private void btnAbrirFrmConversao_Click(object sender, EventArgs e)
        {
            frmConversao FrmConversao = new frmConversao();
            FrmConversao.Show();
        }
    }
}
