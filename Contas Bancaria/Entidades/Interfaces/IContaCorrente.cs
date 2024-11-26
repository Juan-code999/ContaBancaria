using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contas_Bancaria.Entidades.Interfaces
{
    public interface IContaCorrente
    {
        public void Adicionar(ContaCorrente carro);
        public void Remover(int id);
        public void Editar(ContaCorrente carrinho);
        public List<ContaCorrente> Listar();
        public ContaCorrente BuscarPorId(int id);
    }
}
