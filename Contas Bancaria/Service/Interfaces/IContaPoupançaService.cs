using Contas_Bancaria.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contas_Bancaria.Service.Interfaces
{
    public interface IContaPoupançaService
    {
        public void Adicionar(ContaPoupança carrinho);
        public ContaPoupança BuscarTimePorId(int id);
        public void Editar(ContaPoupança editPessoa);
        public List<ContaPoupança> Listar();
        public void Remover(int id);
    }
}
