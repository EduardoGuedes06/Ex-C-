using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Aula
{
    internal class ContaCorrente
    {
        public string titular;
        public string conta;
        public int num_agencia;
        public string nome_agencia;
        public double saldo;

        public bool Sacar(double valor)
        {
            if (saldo < valor)
            {
                return false;
            }
            if(valor < 0){

                return false;
            }
            else
            {
                saldo = saldo - valor;
                return true;
            }
        }

        public void Depositar(double valor)
        {
            saldo = saldo + valor;
        }





    }
}
