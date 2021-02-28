using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoObras
{
    public class Historico
    {
        public Historico(int numero, DateTime data, string descricao = null)
        {
            this.Numero = numero;
            this.Data = data.Date;
            this.Descricao = descricao;
        }

        public int Numero { get; set; }
        public DateTime Data { get; set; }
        public string Descricao { get; set; }

        public override string ToString()
        {
            return string.Format("{0} - {1} - {2}", Numero, Data.ToShortDateString(), Descricao);
        }
    }
}
