using Contas_Bancaria.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contas_Bancaria.Service.Interfaces
{
    public interface IContaCorrenteService
    {
        public void Adicionar(ContaCorrente carrinho);
        public ContaCorrente BuscarTimePorId(int id);
        public void Editar(ContaCorrente editPessoa);
        public List<ContaCorrente> Listar();
        public void Remover(int id);
    }
}
