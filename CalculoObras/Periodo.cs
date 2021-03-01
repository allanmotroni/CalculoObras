using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoObras
{
    public class Periodo
    {

        public Periodo(string descricao, DateTime data, int dias, EnumTipo tipo)
        {
            Descricao = descricao;
            Data = data.Date;
            Dias = dias;
            Tipo = tipo;
        }

        public enum EnumTipo
        {
            Normal,
            TermoAditamento,
            OrdemSuspensao
        }

        public string Descricao { get; private set; }
        public int Contador { get; private set; }
        public DateTime Data { get; private set; }
        public int Dias { get; private set; }
        public int DiasUtilizados { get; private set; }
        public EnumTipo Tipo { get; private set; }

        public string DescricaoStr { get { return string.Format("{0} - {1} - {2}", Data.ToString("dd/MM/yyyy"), Descricao, Dias); } }


        public void Contabilizar()
        {
            DiasUtilizados++;
            Contador++;
        }

        public void Zerar()
        {
            DiasUtilizados = 0;
            Contador = 0;
        }

        public void Finalizar()
        {
            if (DiasUtilizados < Dias)
                DiasUtilizados = Dias;
        }

        public bool PossuiSaldo()
        {
            return DiasUtilizados < Dias;
        }

        public int Saldo()
        {
            return Dias - DiasUtilizados;
        }

        public void IncrementarDia()
        {
            Dias++;
        }

        public override string ToString()
        {
            return string.Format("Periodo => Contador: {0} - Data: {1} - Descricao: {2} - DiasUtilizados: {3} - Tipo: {4} - Saldo: {5}", Contador, Data.ToString("dd/MM/yyyy"), Descricao, DiasUtilizados, Tipo, Saldo());
        }

    }
}
