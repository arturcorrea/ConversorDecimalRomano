using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace ConversorDeNumerosRomanos.Classes
{
    class Conversao
    {
        private string ValorDecimal { get; set; }
        private string ValorRomano { get; set; }



        public static void GravarConversao(Conversao NovaConversao)
        {

            XElement GravaNoXML = new XElement("Conversao");
            GravaNoXML.Add(new XAttribute("Decimal", NovaConversao.ValorDecimal));
            GravaNoXML.Add(new XAttribute("Romano", NovaConversao.ValorRomano));
            XElement xml = XElement.Load(@"Dados/Conversoes.xml");
            xml.Add(GravaNoXML);
            xml.Save(@"Dados/Conversoes.xml");           
         
        }

        private void VerificaSeExistente(Conversao NovaConversao)
        {

        }

        public Conversao(string valorDecimal, string valorRomano)
        {
            this.ValorDecimal = valorDecimal;
            this.ValorRomano = valorRomano;
        }

        public Conversao() { }

        public static List<Conversao> ListarConversoes()
        {
            List<Conversao> Conversoes = new List<Conversao>();
            XElement xml = XElement.Load(@"Dados\Conversoes.xml");
            foreach (XElement x in xml.Elements())
            {
                Conversao ListarConversao = new Conversao()
                {
                    ValorDecimal = x.Attribute("Decimal").Value,
                    ValorRomano = x.Attribute("Romano").Value,                    
                };
                Conversoes.Add(ListarConversao);
            }
            return Conversoes;


        }
    }
}
