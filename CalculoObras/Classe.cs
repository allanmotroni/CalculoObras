using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoObras
{
    public class Classe
    {
        public Classe(DateTime data, string descricao = null/*, bool contabilizar = false*/)
        {
            this.Data = data.Date;
            this.Descricao = descricao;
            //this.Contabilizar = contabilizar;
        }

        public DateTime Data { get; set; }
        public string Descricao { get; set; }
        //public bool Contabilizar { get; set; }

        public override string ToString()
        {
            return string.Format("{0} - {1}", Data.ToShortDateString(), Descricao);
        }
    }
}
