using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contas_Bancaria
{
    public class GestaoContas
    {
        private List<IConta> contas;

        public GestaoContas()
        {
            contas = new List<IConta>();
        }

        public void AdicionarConta(IConta conta)
        {
            contas.Add(conta);
            Console.WriteLine($"Conta {conta} foi adicionada.");
        }

        public void ExibirContas()
        {
            if (contas.Count == 0)
            {
                Console.WriteLine("Não há conta cadastradas.");
                return;
            }

            foreach (IConta conta in contas)
            {
                Console.WriteLine($"Conta: {conta.ToString}");
            }
        }
    }
}
