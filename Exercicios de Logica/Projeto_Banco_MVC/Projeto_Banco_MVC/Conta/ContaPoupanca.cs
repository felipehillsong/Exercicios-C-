﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projeto_Banco_MVC.Models
{
    public class ContaPoupanca : Conta
    {
        public override int NumeroConta(int numeroConta)
        {
            return this.Numero = numeroConta;
        }

        public override double SaldoComeco()
        {
            return this.SaldoInicial = 300;
        }

        public override double Deposito(double valorDeposito)
        {
            double saldoInicial = SaldoComeco();
            return this.SaldoFinal = saldoInicial + valorDeposito - 0.10;
        }

        public override double Saque(double valorSaque)
        {
            double saldoFinal = this.SaldoFinal;
            if (saldoFinal >= valorSaque)
            {
                return this.SaldoFinalizado = saldoFinal - valorSaque;
            }
            else
            {                
                return 0;
            }

        }

        public double MostrarSaldoFinal()
        {
            return this.SaldoFinalizado;
        }
    }
}