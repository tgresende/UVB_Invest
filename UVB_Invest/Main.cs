using AppServices;
using System;
using Database;
using System.Windows.Forms;

namespace UVB_Invest
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Investimento invest = new Investimento(0, txtTicker.Text, txtNomeEmpresa.Text, Types.Setor.Saude, Types.SubSetor.Saude, Types.Segmento.Saude);
            
            InvestimentoServices investServices = new InvestimentoServices(invest);

            var pendencias = investServices.ValidacaoPendencias();

            if (pendencias != "")
                MessageBox.Show(pendencias);
            else
                investServices.Gravar();


        }
    }
}
