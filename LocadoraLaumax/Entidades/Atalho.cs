﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Atalho
    {
        public static double Porcento(double valor, int porcento)
        {
            double result = valor * porcento / 100 + valor;
            return result;
        }
        public static string LimpaData(string data)
        {
            string result = data.Substring(0, 10).Replace("/", "");
            return result;
        }
        public static string LimpaDataHora(string dataHora)
        {
            string result = dataHora.Replace("/", "").Replace(":", "").Replace(" ", "");
            return result;
        }
        public static string LimpaDataHora(DateTime dataHora)
        {
            string result = dataHora.ToString().Replace("/", "").Replace(":", "").Replace(" ", "");
            return result;
        }
        public static double LimpaPreco(string preco)
        {
            double result = Convert.ToDouble(preco.Replace("R", "").Replace("$", "").Replace(" ", ""));
            return result;
        }
        public static string LimpaDoc(string doc)
        {
            string result = doc.Replace("-", "").Replace(".", "").Replace(" ", "");
            return result;
        }
        public static string LimpaKm(string km)
        {
            string result = km.Replace(".", "").Replace(",", "").Replace(" ", "");
            return result;
        }
    }
}