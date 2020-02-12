namespace SiGMun.Infra.Repositorios
{
    public interface IBase
    {
        void Inserir(object obj);
        void Alterar(object obj, int id);
        void Excluir(int id);
        void Carregar(object obj);

    }
}
