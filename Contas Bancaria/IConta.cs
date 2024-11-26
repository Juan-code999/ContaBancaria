using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contas_Bancaria
{
    public interface IConta
    {
        void Depositar(decimal valor);
        bool Sacar(decimal valor);
        void Transferir(decimal valor, IConta contaDestino);
        void ExibirInformacoes();

    }
}
