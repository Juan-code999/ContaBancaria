using Contas_Bancaria.Entidades.Interfaces;
using Contas_Bancaria.Entidades;
using Contas_Bancaria.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contas_Bancaria.Service
{
    public class ContaPoupançaService : IContaPoupançaService
    {
        private readonly IContaPoupança repository;
        public ContaPoupançaService(IContaPoupança carrinhoRepository)
        {
            repository = carrinhoRepository;
        }

        public void Adicionar(ContaPoupança carrinho)
        {
            repository.Adicionar(carrinho);
        }

        public ContaPoupança BuscarTimePorId(int id)
        {
            return repository.BuscarPorId(id);
        }

        public void Editar(ContaPoupança editPessoa)
        {
            repository.Editar(editPessoa);
        }

        public List<ContaPoupança> Listar()
        {
            return repository.Listar();
        }

        public void Remover(int id)
        {
            repository.Remover(id);
        }
    }
}
