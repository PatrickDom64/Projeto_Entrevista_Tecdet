using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Entrevista
{
    public class Passagem
    {
        public string Placa { get; set; }
        public string Data { get; set; }
        public string Hora { get; set; }
        public int Equipamento { get; set; }
        public int Faixa { get; set; }

        public Passagem(string placa, string data, string hora, int equipamento, int faixa)
        {
            Placa = placa;
            Data = data;
            Hora = hora;
            Equipamento = equipamento;
            Faixa = faixa;
        }
    }
}
