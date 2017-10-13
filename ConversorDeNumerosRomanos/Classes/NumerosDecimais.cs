using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorDeNumerosRomanos.Classes
{
    class NumerosDecimais
    {
        private Dictionary<char, int> NumerosRomanosEquivalentes =
            new Dictionary<char, int>();

        public NumerosDecimais() {
            NumerosRomanosEquivalentes.Add('I',1);
            NumerosRomanosEquivalentes.Add('V', 5);
            NumerosRomanosEquivalentes.Add('X', 10);
            NumerosRomanosEquivalentes.Add('L', 50);
            NumerosRomanosEquivalentes.Add('C', 100);
            NumerosRomanosEquivalentes.Add('D', 500);
            NumerosRomanosEquivalentes.Add('M', 1000);
        }

        
        int valorTotal;
        int valorLetraAnterior;
        int valorLetraAtual;
        int DireitaMenor;

        public string ConverteParaDecimal(string EntradaEmRomano)
        {
            EntradaEmRomano.Trim();
            valorTotal = 0;
            valorLetraAnterior = 0;
            for (int Posicao = EntradaEmRomano.Length - 1; Posicao >= 0; Posicao--)
            {
                valorLetraAtual = NumerosRomanosEquivalentes[
                                        EntradaEmRomano.ToUpper()[Posicao]];
                
                DireitaMenor = 1;
                if (valorLetraAtual < valorLetraAnterior) {
                    DireitaMenor = -1;                                 
                }
                valorTotal += NumerosRomanosEquivalentes[
                               EntradaEmRomano.ToUpper()[Posicao]] * DireitaMenor;

                valorLetraAnterior = valorLetraAtual;
            }

            return valorTotal.ToString();    
        }

        char LetraAtual;
        string LetraAnterior;
        public void ValidaSeRomano(string EntradaEmRomano)
        {
            int posicao = 0;
            for (posicao = 0; posicao < EntradaEmRomano.Length; posicao++)
            {
                foreach (var item in NumerosRomanosEquivalentes)
                {
                    if (!(item.Key == EntradaEmRomano[posicao]) && item.Key == 'M')
                    {
                        throw new ArgumentException("Falha ao identificar o algarismo");                        
                    }
                    else
                    {
                        break;
                    }
                }   
            }

            for (posicao = 0; posicao < EntradaEmRomano.Length - 1; posicao++)
            {
                LetraAtual = EntradaEmRomano[posicao];
                if (LetraAtual == EntradaEmRomano[posicao])
                {
                    LetraAnterior += LetraAtual.ToString();
                    if (LetraAnterior.Length > 2)
                    {
                        throw new ArgumentException("As letras Romanas não podem se repetir " +
                         "mais de 3 vezes, revise o valor de entrada");
                    }

                }
                else
                {
                    LetraAnterior = "";
                }
            }
                if (Convert.ToInt32(this.ConverteParaDecimal(EntradaEmRomano)) > 3999)
                {
                    throw new ArgumentException("Não é possível representar um valor " +
                        "maior que 3999, Sorry");
                }
        }     
    }
}
