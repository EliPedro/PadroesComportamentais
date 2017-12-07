using Command.Players.Interfaces;
using System;

namespace Command.Players
{
    public class DiminuiVolumeComando : IComando
    {
        private readonly IPlayer _player;

        public DiminuiVolumeComando(IPlayer player)
        {
            _player = player;
        }
        public void Executa()
        {
            throw new NotImplementedException();
        }
    }
}
