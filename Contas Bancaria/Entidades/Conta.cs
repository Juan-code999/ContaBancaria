using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contas_Bancaria.Entidades
{
    public class Conta : IConta
    {
        public Conta(int id, string titular, decimal saldo)
        {
            Titular = titular;
            Saldo = saldo;
            Id = id;
        }
        public Conta()
        {

        }
        public int Id { get; set; }
        public string Titular { get; set; }
        public decimal Saldo { get; set; }

        public override string ToString()
        {
            return $"Titular: {Titular}, Saldo: {Saldo}";
        }

        public void Depositar(decimal valor)
        {
            Console.WriteLine("Qual foi o valor depositado?");
            decimal deposito = decimal.Parse(Console.ReadLine());
            Console.WriteLine($"R${deposito} depositado com sucesso");

        }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Titular:{Titular}");
            Console.WriteLine($"Saldo: {Saldo}");
            Console.WriteLine($"Tipo de conta:");

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

        public void Transferir(decimal valor, IConta contaDestino)
        {
            Sacar(valor);
            contaDestino.Depositar((decimal)valor);
        }
    }
}
