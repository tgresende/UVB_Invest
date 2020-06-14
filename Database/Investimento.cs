using System;
using System.Collections.Generic;
using System.Text;

namespace Database
{
    public class Investimento
    {

        public int Id;
        public string Ticker;
        public string NomeEmpresa;
        public string Setor;
        public string SubSetor;
        public string Segmento;

        public Investimento(int Id, string Ticker, string NomeEmpresa, Types.Setor Sector, Types.SubSetor SubSector, Types.Segmento Segment )
        {
            this.Id = Id;
            this.Ticker = Ticker;
            this.NomeEmpresa = NomeEmpresa;
            this.Setor = Types.ToDescriptionString(Sector);
            this.SubSetor = Types.ToDescriptionString(SubSector);
            this.Segmento = Types.ToDescriptionString(Segment);
        }

        public void SalvarNovo()
        {
            try
            {
                using (var cmd = DBcon.DbConnection().CreateCommand())
                {
                    cmd.CommandText = " Insert into Investimento (Id, Ticker, NomeEmpresa, Setor, SubSetor, Segmento) " +
                        "                         Values (@Id, @Ticker, @NomeEmpresa, @Setor, @SubSetor, @Segmento)";
                    cmd.Parameters.AddWithValue("@Id", Id);
                    cmd.Parameters.AddWithValue("Ticker", Ticker);
                    cmd.Parameters.AddWithValue("@NomeEmpresa", NomeEmpresa);
                    cmd.Parameters.AddWithValue("@Setor", Setor);
                    cmd.Parameters.AddWithValue("@SubSetor", SubSetor);
                    cmd.Parameters.AddWithValue("@Segmento", Segmento);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void SalvarExistente()
        {
            try
            {
                using (var cmd = DBcon.DbConnection().CreateCommand())
                {
                    cmd.CommandText = " Update Investimento Set " +
                                                " Ticker = @Ticker ," +
                                                " NomeEmpresa = @NomeEmpresa, " +
                                                " Setor= @Setor, " +
                                                " SubSetor= @SubSetor, " +
                                                " Segmento = @Segmento " +
                                                " where Id = @Id";


                    cmd.Parameters.AddWithValue("@Id", Id);
                    cmd.Parameters.AddWithValue("Ticker", Ticker);
                    cmd.Parameters.AddWithValue("@NomeEmpresa", NomeEmpresa);
                    cmd.Parameters.AddWithValue("@Setor", Setor);
                    cmd.Parameters.AddWithValue("@SubSetor", SubSetor);
                    cmd.Parameters.AddWithValue("@Segmento", Segmento);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
