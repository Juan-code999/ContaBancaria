using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contas_Bancaria.Repository.Data
{
    public class InicializadorBD
    {
        private const string ConnectionString = "Data Source=ContaBancaria.db";

        public static void Inicializar()
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                string commandoSQL = @"   
                CREATE TABLE IF NOT EXISTS ContaCorrente(
                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                Titular TEXT NOT NULL,
                Saldo DECIMAL NOT NULL,
                LimiteDeCredito DECIMAL NOT NULL
                );";

                commandoSQL += @"   
                CREATE TABLE IF NOT EXISTS ContaPoupanca(
                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                Titular TEXT NOT NULL,
                Saldo DECIMAL NOT NULL,
                TaxaDeJuros DECIMAL NOT NULL
                );";

                connection.Execute(commandoSQL);
            }
        }
    }
}
