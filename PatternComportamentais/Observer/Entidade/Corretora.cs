using Observer.Interface;
using System;

namespace Observer.Entidade
{
    class Corretora : IAcaoObserver
    {
        private string Nome { get; set; }

        public Corretora(string nome)
        {
            this.Nome = nome;
        }
        public void NotificaAlteracao(Acao acao)
        {
            Console.WriteLine("Corretora " + this.Nome + " sendo notificada :");
            Console.WriteLine("A ação " + acao.Codigo + 
            " teve o seu valor alterado para " + acao.Valor);
        }
    }
}
