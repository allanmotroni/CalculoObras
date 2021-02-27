using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoObras
{
    public class Item
    {
        public Item(DateTime data, int prazo)
        {
            this.Data = data.Date;
            this.Prazo = prazo;
        }

        public DateTime Data { get; set; }
        public int Prazo { get; set; }

        public string Descricao { get { return this.ToString(); } }

        public override string ToString()
        {
            return string.Format("{0} - {1}", Data.ToShortDateString(), Prazo);
        }
    }
}
