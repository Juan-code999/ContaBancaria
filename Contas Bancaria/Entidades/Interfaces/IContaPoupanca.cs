using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contas_Bancaria.Entidades.Interfaces
{
    public interface IContaPoupança
    {
        public void Adicionar(ContaPoupança carro);
        public void Remover(int id);
        public void Editar(ContaPoupança carrinho);
        public List<ContaPoupança> Listar();
        public ContaPoupança BuscarPorId(int id);
    }
}
