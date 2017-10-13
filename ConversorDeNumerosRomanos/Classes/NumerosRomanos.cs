using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorDeNumerosRomanos.Classes
{
    class NumerosRomanos
    {
        private string[] unidadesRomanos =
            new string[] {"", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };

        private string[] dezenasRomanos =
            new string[] {"", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };

        private string[] centenasRomanos =
            new string[] {"", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };

        private string[] milharesRomanos =
            new string[] {"", "M", "MM", "MMM" };

        public string ConverterParaRomano(string EntradaEmDecimal)
        {
            this.ValidaSeMenor4000(EntradaEmDecimal);

            int RetornoInteiro = Convert.ToInt32(EntradaEmDecimal.Trim());

            int Unidade = RetornoInteiro % 10;
            int Dezena = (RetornoInteiro/10) % 10;
            int Centena = (RetornoInteiro/100) % 10;
            int Milhar = (RetornoInteiro/1000) % 10;
                         
            return milharesRomanos[Milhar] + centenasRomanos[Centena] +
                    dezenasRomanos[Dezena] + unidadesRomanos[Unidade];
        }

        private void ValidaSeMenor4000(string EntradaEmDecimal)
        {
            if (Convert.ToInt32(EntradaEmDecimal) > 3999)
            {
                throw new ArgumentException("Não é possível representar um valor " +
                    "maior que 3999, Sorry");
            }
        }
    }
}
