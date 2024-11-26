using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contas_Bancaria.Entidades
{
    [Table("ContaPoupanca")]
    public class ContaPoupança : Conta
    {
        public decimal TaxaDeJuros { get; set; }

        public ContaPoupança(int Id, string Titular, decimal Saldo, decimal taxa)
            : base(Id, Titular, Saldo)
        {
            TaxaDeJuros = taxa;
        }

        public ContaPoupança()
        {

        }
        public void ExibirInformacoes()
        {
            Console.WriteLine($"Titular:{Titular}");
            Console.WriteLine($"Saldo: {Saldo}");
            Console.WriteLine($"Tipo de conta:Conta Poupança");

        }
        public void Depositar(decimal valor)
        {
            decimal resultado = valor + Saldo;

            TaxaDeJuros = 2;

            if (Saldo > 10)
            {
                decimal resultadoFinal = resultado + TaxaDeJuros;
                Console.WriteLine($"O valor é de {resultadoFinal}");
            }

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
