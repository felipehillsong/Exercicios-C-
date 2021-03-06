﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EstacionamentoESilva.Acesso
{
    public struct ValoresFixos
    {
        private decimal Fracao { get; set; }

        private decimal Fracionamento { get; set; }

        private decimal Hora { get; set; }

        private decimal Dia { get; set; }

        private decimal Mes { get; set; }

        public decimal PrecoFracao()
        {
            return this.Fracao = 3M;
        }

        public decimal PrecoFracionamento()
        {
            return this.Fracionamento = 12M;
        }

        public decimal Horista()
        {
            return this.Hora = 10M;
        }

        public decimal Diarista()
        {
            return this.Dia = 60M;
        }

        public decimal Mensalista()
        {
            return this.Mes = 200M;
        }
    }
}