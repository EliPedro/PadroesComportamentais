using Observer.Entidade;

namespace Observer.Interface
{
    public interface IAcaoObserver
    {
        void NotificaAlteracao(Acao acao);
    }
}
