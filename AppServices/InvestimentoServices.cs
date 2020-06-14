using System;
using Database;

namespace AppServices
{
    public class InvestimentoServices
    {
        Investimento _investimento;
     
        public InvestimentoServices(Investimento _invest)
        {
            _investimento = _invest;
        }

        public string ValidacaoPendencias()
        {
            if (_investimento.Ticker.Replace(" ", string.Empty).Length == 0)
                return "Favor informar o ticker";
            else if  (_investimento.NomeEmpresa.Replace(" ", string.Empty).Length == 0)
                return "Favor informar o nome da empresa.";
            else if (_investimento.Segmento.Replace(" ", string.Empty).Length == 0)
                return "Favor informar o segmento da empresa.";
            else if (_investimento.Setor.Replace(" ", string.Empty).Length == 0)
                return "Favor informar o setor da empresa.";
            else if (_investimento.SubSetor.Replace(" ", string.Empty).Length == 0)
                return "Favor informar o subsetor da empresa.";

            return "";
        }

        public void Gravar()
        {
            if (_investimento.Id == 0)
                _investimento.SalvarNovo();
            else
                _investimento.SalvarExistente();
        }

    }
}
