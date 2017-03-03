using Observer.Entidade;
using System;

namespace Observer
{
    /*
        Objetivo: Definir um mecanismo eficiente para reagir ás alterações 
        realizadas em determinados objetos.
     */

    class Testaobserver
    {
        static void Main(string[] args)
        {
            IAcao acao = new Acao("Vale-100", 100);

            var corretora_1 = new Corretora("Corretora 1");
            var corretora_2 = new Corretora("Corretora 2");

            acao.RegistraInteressado(corretora_1);
            acao.RegistraInteressado(corretora_2);

            acao.SetValor(20);


            Console.ReadKey();




        }
    }
}
