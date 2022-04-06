using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;

namespace Projeto_Entrevista
{
    internal class Banco
    {
        private static SQLiteConnection conexao;

        private static SQLiteConnection ConexaoBanco()
        {
            //Abrindo conexao com o banco
            conexao = new SQLiteConnection("Data Source=C:\\bd_passagem.db");
            conexao.Open();

            return conexao;
        }

        public static void InserirPassagem(Passagem p)
        {
            try
            {
                var cmd = ConexaoBanco().CreateCommand();

                cmd.CommandText = "INSERT INTO tb_passagens (V_PLACA, V_DATA, V_HORA, N_EQUIPAMENTO, N_FAIXA) VALUES (@placa, @data, @hora, @equipamento, @faixa)";
                cmd.Parameters.AddWithValue("@placa", p.Placa);
                cmd.Parameters.AddWithValue("@data", p.Data);
                cmd.Parameters.AddWithValue("@hora", p.Hora);
                cmd.Parameters.AddWithValue("@equipamento", p.Equipamento);
                cmd.Parameters.AddWithValue("@faixa", p.Faixa);

                cmd.ExecuteNonQuery();
                GlobalContador.lido++;
            }
            catch (Exception)
            {
                GlobalContador.naoLido++;
                conexao.Close();
            }
        }
    }
}
