using Observer.Interface;
using System.Collections.Generic;

namespace Observer.Entidade
{
    public class Acao : IAcao
    {
        public string Codigo { get; set; }
        public decimal Valor { get; set; }

        private ISet<IAcaoObserver> observadores = new HashSet<IAcaoObserver>();
        
        public Acao(string codigo,  decimal valor)
        {
            this.Codigo = codigo;
            this.Valor = valor;
        }

        public void RegistraInteressado(IAcaoObserver observer)
        {
            this.observadores.Add(observer);
        }

        public void CancelaInteressado(IAcaoObserver observer)
        {
            this.observadores.Remove(observer);
        }

        public void SetValor(decimal valor)
        {
            this.Valor = valor;

            foreach(var obs in observadores)
            {
                obs.NotificaAlteracao(this);
            }
        }
    }
}
