using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConversorDeNumerosRomanos.Classes;

namespace ConversorDeNumerosRomanos.Forms
{
    public partial class frmConversao : Form
    {
        public frmConversao()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmConversao_Load(object sender, EventArgs e)
        {

        }
        
        private void btnConverterValoresDeEntrada_Click(object sender, EventArgs e)
        {
            if (this.VerificaSeDecimal(txtEntradaParaConversao.Text))
            {
                try
                {                   
                    NumerosRomanos ConverteNumerosRomanos = new NumerosRomanos();
                    txtSaidaConvertida.Text =
                        ConverteNumerosRomanos.ConverterParaRomano(txtEntradaParaConversao.Text);
                }
                catch (Exception Excecao)
                {
                    MessageBox.Show(Excecao.Message);
                    throw;
                }
            }
            else
            {
                try
                {
                    NumerosDecimais ConverteNumerosDecimais = new NumerosDecimais();
                    ConverteNumerosDecimais.ValidaSeRomano(txtEntradaParaConversao.Text);
                    txtSaidaConvertida.Text =
                         ConverteNumerosDecimais.ConverteParaDecimal(txtEntradaParaConversao.Text);

                    Conversao SalvandoConversao = new Conversao(txtSaidaConvertida.Text,
                                                                txtEntradaParaConversao.Text.ToUpper());
                    Conversao.GravarConversao(SalvandoConversao);
                }
                catch (Exception Excecao)
                {
                    MessageBox.Show(Excecao.Message);
                }


            }
                  
        }

        private bool VerificaSeDecimal(string EntradaDecimal)
        {
            for (int charPosicao = 0; charPosicao < EntradaDecimal.Length; charPosicao++)
            {
                if (char.IsLetter(txtEntradaParaConversao.Text[charPosicao]))
                {
                    return false;
                }
                
            }

            return true;
        }
    }
}
