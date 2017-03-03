using Observer.Interface;

namespace Observer.Entidade
{
    public interface IAcao
    {
        void RegistraInteressado(IAcaoObserver observer);
        void CancelaInteressado(IAcaoObserver observer);
        void SetValor(decimal valor);
    }
}
