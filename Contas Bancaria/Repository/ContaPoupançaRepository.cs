using Contas_Bancaria.Entidades.Interfaces;
using Contas_Bancaria.Entidades;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Contas_Bancaria.Repository
{
    public class ContaPoupançaRepository : IContaPoupança
    {
        private readonly string ConnectionString;

        public ContaPoupançaRepository(IConfiguration config)
        {
            ConnectionString = config.GetConnectionString("DefaultConnection");
        }

        public void Adicionar(ContaPoupança carro)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Insert<ContaPoupança>(carro);
            connection.Insert<ContaPoupança>(carro);
        }
        public void Remover(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            ContaPoupança carrinho = BuscarPorId(id);
            connection.Delete<ContaPoupança>(carrinho);
        }
        public void Editar(ContaPoupança carrinho)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Update<ContaPoupança>(carrinho);
        }
        public List<ContaPoupança> Listar()
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.GetAll<ContaPoupança>().ToList();
        }
        public ContaPoupança BuscarPorId(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.Get<ContaPoupança>(id);
        }
    }
}
