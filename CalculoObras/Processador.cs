using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoObras
{
    public static class Processador
    {
        public static List<Classe> Processar(Item item)
        {
            List<Classe> classes = new List<Classe>();            
            int contador = 0;
            DateTime dataAtual = item.Data;
            while (contador < item.Prazo)
            {
                Classe classe = new Classe(dataAtual);
                classes.Add(classe);

                dataAtual = dataAtual.AddDays(1);
                contador++;
            }

            return classes;
        }
    }
}
