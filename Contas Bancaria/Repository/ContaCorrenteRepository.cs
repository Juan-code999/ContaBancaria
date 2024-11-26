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
    public class ContaCorrenteRepository : IContaCorrente
    {
        private readonly string ConnectionString;

        public ContaCorrenteRepository(IConfiguration config)
        {
            ConnectionString = config.GetConnectionString("DefaultConnection");
        }

        public void Adicionar(ContaCorrente carro)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Insert<ContaCorrente>(carro);
        }
        public void Remover(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            ContaCorrente carrinho = BuscarPorId(id);
            connection.Delete<ContaCorrente>(carrinho);
        }
        public void Editar(ContaCorrente carrinho)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Update<ContaCorrente>(carrinho);
        }
        public List<ContaCorrente> Listar()
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.GetAll<ContaCorrente>().ToList();
        }
        public ContaCorrente BuscarPorId(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.Get<ContaCorrente>(id);
        }

    }
}
