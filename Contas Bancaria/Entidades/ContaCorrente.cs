using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contas_Bancaria.Entidades
{
    [Table("ContaCorrente")]
    public class ContaCorrente : Conta
    {
        public decimal LimiteDeCredito { get; set; }

        public ContaCorrente(int Id, string Titular, decimal Saldo, decimal LimiteDecredito)
            : base(Id, Titular, Saldo)
        {
            LimiteDeCredito = LimiteDecredito;
        }

        public ContaCorrente()
        {

        }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Titular:{Titular}");
            Console.WriteLine($"Saldo: {Saldo}");
            Console.WriteLine($"Tipo de conta:Conta Corrente");

        }


        public void Depositar(decimal valor)
        {
            decimal resultado = valor + Saldo;
            Console.WriteLine($"O resultado do depósito com o saldo é:{resultado}");

        }
        public bool Sacar(decimal valor)
        {
            if (Saldo < 0 || Saldo < valor)
            {
                Console.WriteLine("Impossível sacar esse valor.");
                return false;
            }
            else
            {
                decimal resultado = Saldo - valor;
                return true;

            }

        }
    }
}
