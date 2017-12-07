using Command.Players.Interfaces;

namespace Command.Players
{
    public class TocaMusicaComando : IComando
    {
        private readonly IPlayer _player;
        public TocaMusicaComando(IPlayer player)
        {
            _player = player;   
        }
        public void Executa()
        {
            throw new System.NotImplementedException();
        }
    }
}
