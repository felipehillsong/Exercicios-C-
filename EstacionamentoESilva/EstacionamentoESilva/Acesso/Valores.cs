﻿using EstacionamentoESilva.Data;
using EstacionamentoESilva.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EstacionamentoESilva.Acesso
{
    public class Valores
    {
        private EstacionamentoESilvaContext db = new EstacionamentoESilvaContext();
        public ValoresFixos valoresFixos { get; set; }
        
        public Valores()
        {
            valoresFixos = new ValoresFixos();
        }

        public decimal Fracionista(int? id)
        {
            Servico servico = db.Servico.Find(id);
            servico.Valor = valoresFixos.PrecoFracionamento();

            var anoHojeH = DateTime.Now;
            var mesHojeH = DateTime.Now;
            var diaHojeH = DateTime.Now;
            var horaHojeH = DateTime.Now;

            var anoAgoraH = anoHojeH.Year;
            var diaAgoraH = diaHojeH.Day;
            var mesAgoraH = mesHojeH.Month;

            var anoEntradaH = servico.HoraEntrada.Value.Year;
            var mesEntradaH = servico.HoraEntrada.Value.Month;
            var diaEntradaH = servico.HoraEntrada.Value.Day;

            if (anoEntradaH == anoAgoraH && mesEntradaH == mesAgoraH)
            {
                if (diaEntradaH == diaAgoraH)
                {
                    DateTime dataCompletaHoje = DateTime.Now;
                    DateTime dataEntradaCompleta = servico.HoraEntrada.Value;
                    TimeSpan subtracaoDeTempo = dataCompletaHoje - dataEntradaCompleta;
                    var horasQueFicou = subtracaoDeTempo.TotalHours;
                    TimeSpan fracao = new TimeSpan(00, 20, 00);

                    if (subtracaoDeTempo <= fracao)
                    {
                        return servico.Valor = valoresFixos.PrecoFracao();
                    }
                    else
                    {
                        decimal totalHoras = decimal.Parse(horasQueFicou.ToString());
                        return servico.Valor *= totalHoras;
                    }

                }
                else if (diaAgoraH > diaEntradaH)
                {
                    DateTime dataCompletaHoje = DateTime.Now;
                    DateTime dataEntradaCompleta = servico.HoraEntrada.Value;
                    TimeSpan subtracaoDeTempo = dataCompletaHoje - dataEntradaCompleta;
                    var horasQueFicou = subtracaoDeTempo.TotalHours;
                    TimeSpan fracao = new TimeSpan(00, 20, 00);

                    if (subtracaoDeTempo <= fracao)
                    {
                        return servico.Valor = valoresFixos.PrecoFracao();
                    }
                    else
                    {
                        decimal totalHoras = decimal.Parse(horasQueFicou.ToString());
                        return servico.Valor *= totalHoras;
                    }
                }

            }
            else if (mesEntradaH != mesAgoraH || anoEntradaH != anoAgoraH)
            {
                DateTime dataCompletaHoje = DateTime.Now;
                DateTime dataEntradaCompleta = servico.HoraEntrada.Value;
                TimeSpan subtracaoDeTempo = dataCompletaHoje - dataEntradaCompleta;
                var horasQueFicou = subtracaoDeTempo.TotalHours;
                TimeSpan fracao = new TimeSpan(00, 20, 00);

                if (subtracaoDeTempo <= fracao)
                {
                    return servico.Valor = valoresFixos.PrecoFracao();
                }
                else
                {
                    decimal totalHoras = decimal.Parse(horasQueFicou.ToString());
                    return servico.Valor *= totalHoras;
                }
            }

            return servico.Valor;
        }

        public decimal Horista(int? id)
        {           
            Servico servico = db.Servico.Find(id);
            servico.Valor = valoresFixos.Horista();

            var anoHojeH = DateTime.Now;
            var mesHojeH = DateTime.Now;
            var diaHojeH = DateTime.Now;
            var horaHojeH = DateTime.Now;

            var anoAgoraH = anoHojeH.Year;
            var diaAgoraH = diaHojeH.Day;
            var mesAgoraH = mesHojeH.Month;

            var anoEntradaH = servico.HoraEntrada.Value.Year;
            var mesEntradaH = servico.HoraEntrada.Value.Month;
            var diaEntradaH = servico.HoraEntrada.Value.Day;

            if (anoEntradaH == anoAgoraH && mesEntradaH == mesAgoraH)
            {
                if (diaEntradaH == diaAgoraH)
                {
                    DateTime dataCompletaHoje = DateTime.Now;
                    DateTime dataEntradaCompleta = servico.HoraEntrada.Value;
                    TimeSpan subtracaoDeTempo = dataCompletaHoje - dataEntradaCompleta;
                    var horasQueFicou = subtracaoDeTempo.TotalHours;                   
                    TimeSpan fracao = new TimeSpan(00, 20, 00);
                    
                    if (subtracaoDeTempo <= fracao)
                    {
                        return servico.Valor = valoresFixos.PrecoFracao();
                    }
                    else
                    {
                        decimal totalHoras = decimal.Parse(horasQueFicou.ToString());
                        return servico.Valor *= totalHoras;
                    }

                }
                else if (diaAgoraH > diaEntradaH)
                {
                    DateTime dataCompletaHoje = DateTime.Now;
                    DateTime dataEntradaCompleta = servico.HoraEntrada.Value;
                    TimeSpan subtracaoDeTempo = dataCompletaHoje - dataEntradaCompleta;
                    var horasQueFicou = subtracaoDeTempo.TotalHours;
                    TimeSpan fracao = new TimeSpan(00, 20, 00);

                    if (subtracaoDeTempo <= fracao)
                    {
                        return servico.Valor = valoresFixos.PrecoFracao();
                    }
                    else
                    {
                        decimal totalHoras = decimal.Parse(horasQueFicou.ToString());
                        return servico.Valor *= totalHoras;
                    }
                }

            }
            else if (mesEntradaH != mesAgoraH || anoEntradaH != anoAgoraH)
            {
                DateTime dataCompletaHoje = DateTime.Now;
                DateTime dataEntradaCompleta = servico.HoraEntrada.Value;
                TimeSpan subtracaoDeTempo = dataCompletaHoje - dataEntradaCompleta;
                var horasQueFicou = subtracaoDeTempo.TotalHours;
                TimeSpan fracao = new TimeSpan(00, 20, 00);

                if (subtracaoDeTempo <= fracao)
                {
                    return servico.Valor = valoresFixos.PrecoFracao();
                }
                else
                {
                    decimal totalHoras = decimal.Parse(horasQueFicou.ToString());
                    return servico.Valor *= totalHoras;
                }
            }

            return servico.Valor;
        }

        public decimal Diarista(int? id)
        {
            Servico servico = db.Servico.Find(id);
            servico.Valor = valoresFixos.Diarista();
            
            var anoHojeD = DateTime.Now;
            var mesHojeD = DateTime.Now;
            var diaHojeD = DateTime.Now;
            var horaHojeD = DateTime.Now;

            var anoAgoraD = anoHojeD.Year;
            var diaAgoraD = diaHojeD.Date;
            var mesAgoraD = mesHojeD.Month;

            var anoEntradaD = servico.HoraEntrada.Value.Year;
            var mesEntradaD = servico.MesEntrada.Value.Month;
            DateTime diaEntradaD = servico.DiaEntrada.Value;
            DateTime diaDaSaida = servico.DiaEntrada.Value.AddDays(1);

            if (anoAgoraD == anoEntradaD && mesAgoraD == mesEntradaD)
            {
                if (diaHojeD <= diaDaSaida)
                {
                    DateTime dataCompletaHoje = DateTime.Now;
                    DateTime dataEntradaCompleta = servico.DiaEntrada.Value;
                    TimeSpan subtracaoDeTempo = dataCompletaHoje - dataEntradaCompleta;
                    var diasQueFicou = subtracaoDeTempo.TotalDays;
                    var horasQueFicou = subtracaoDeTempo.TotalHours;                    
                    TimeSpan tempoMinimo = new TimeSpan(06, 00, 00);

                    if (subtracaoDeTempo <= tempoMinimo)
                    { 
                        return servico.Valor = Horista(id);
                    }
                    else
                    {
                        servico.Valor = valoresFixos.Diarista();
                        decimal totalDias = decimal.Parse(diasQueFicou.ToString());
                        return servico.Valor *= totalDias;
                    }

                }
                else if (diaHojeD > diaDaSaida)
                {
                    DateTime dataCompletaHoje = DateTime.Now;
                    DateTime dataEntradaCompleta = servico.DiaEntrada.Value;
                    TimeSpan subtracaoDeTempo = dataCompletaHoje - dataEntradaCompleta;
                    var diasQueFicou = subtracaoDeTempo.TotalDays;
                    servico.Valor = valoresFixos.Diarista();
                    decimal totalDias = decimal.Parse(diasQueFicou.ToString());
                    return servico.Valor *= totalDias;
                }

            }
            else if (anoAgoraD != anoEntradaD || mesAgoraD != mesEntradaD)
            {
                DateTime dataCompletaHoje = DateTime.Now;
                DateTime dataEntradaCompleta = servico.DiaEntrada.Value;
                TimeSpan subtracaoDeTempo = dataCompletaHoje - dataEntradaCompleta;
                var diasQueFicou = subtracaoDeTempo.TotalDays;
                var horasQueFicou = subtracaoDeTempo.TotalHours;                
                TimeSpan tempoMinimo = new TimeSpan(06, 00, 00);
              
                if (subtracaoDeTempo <= tempoMinimo)
                {
                    return servico.Valor = valoresFixos.Horista();                 
                }
                else
                {
                    servico.Valor = valoresFixos.Diarista();
                    decimal totalDias = decimal.Parse(diasQueFicou.ToString());
                    return servico.Valor *= totalDias;
                }
            }

            return servico.Valor;
        }
    }
}