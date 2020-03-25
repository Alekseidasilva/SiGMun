using System.Data;
using SiGMun.Infra;
using SiGMun.MVCPro._Contratos;

namespace SiGMun.MVCPro._Repositorios
{
    public class RegraProviderRep:IRegraProvider
    {
        private ADOConexao conexao = new ADOConexao();
        public void CarregarRegraPorUsuario(string email)
        {
            conexao.LimparParametro();
            conexao.AdicionarParametros("", email);
            DataTable tbRegras = conexao.ExecutarConsulta(CommandType.StoredProcedure, "");
            foreach (DataRow linha in tbRegras.Rows)
            {

            }
            throw new System.NotImplementedException();
        }

      
    }
}