using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculoObras
{
    public partial class Form1 : Form
    {
        List<Periodo> listaOrdemSuspensao;
        List<Periodo> listaTermoAditamento;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listaOrdemSuspensao = new List<Periodo>();
            listaTermoAditamento = new List<Periodo>();
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                PreencherDadosMock();

                DateTime dataInicio = dateTimePickerDataInicio.Value.Date;
                int prazoContratual = Convert.ToInt32(numericUpDownPrazoContratual.Value);
                Calcular(dataInicio, prazoContratual);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PreencherDadosMock()
        {
            listaOrdemSuspensao = new List<Periodo>() {
                new Periodo("Ordem Suspensão 01",Convert.ToDateTime("22/06/2018"), 120, Periodo.EnumTipo.OrdemSuspensao),
                new Periodo("Ordem Suspensão 02",Convert.ToDateTime("17/10/2018"), 120, Periodo.EnumTipo.OrdemSuspensao),
                new Periodo("Ordem Suspensão 03",Convert.ToDateTime("14/02/2019"), 120, Periodo.EnumTipo.OrdemSuspensao),
                new Periodo("Ordem Suspensão 04",Convert.ToDateTime("10/06/2019"), 120, Periodo.EnumTipo.OrdemSuspensao),
                new Periodo("Ordem Suspensão 05",Convert.ToDateTime("08/10/2019"), 120, Periodo.EnumTipo.OrdemSuspensao),
                new Periodo("Ordem Suspensão 06",Convert.ToDateTime("01/06/2020"), 120, Periodo.EnumTipo.OrdemSuspensao)
            };

            listaTermoAditamento = new List<Periodo>() {
                new Periodo("Termo Aditamento 01",Convert.ToDateTime("28/08/2017"), 180, Periodo.EnumTipo.TermoAditamento),
                new Periodo("Termo Aditamento 02",Convert.ToDateTime("22/12/2017"), 180, Periodo.EnumTipo.TermoAditamento),
                new Periodo("Termo Aditamento 03",Convert.ToDateTime("30/01/2019"), 120, Periodo.EnumTipo.TermoAditamento),
                new Periodo("Termo Aditamento 04",Convert.ToDateTime("30/01/2020"), 240, Periodo.EnumTipo.TermoAditamento)
            };
        }

        private void Calcular(DateTime dataInicio, int prazoContratual)
        {
            try
            {
                DateTime dataAtual = dataInicio.Date;
                int prazo = prazoContratual;
                Processar(dataInicio.Date, prazo);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void Processar(DateTime data, int dias)
        {
            List<DateTime> datas = new List<DateTime>()
            {
                Convert.ToDateTime("28/08/2017"),
                Convert.ToDateTime("22/12/2017"),
                Convert.ToDateTime("22/06/2018"),
                Convert.ToDateTime("17/10/2018"),
                Convert.ToDateTime("30/01/2019"),
                Convert.ToDateTime("14/02/2019"),
                Convert.ToDateTime("16/06/2019"),
                Convert.ToDateTime("08/10/2019"),
                Convert.ToDateTime("30/01/2020")
            };

            DateTime dataAtual = data;
            List<DateTime> listaDataOrdemSuspensao = listaOrdemSuspensao.Select(p => p.Data).OrderBy(p => p).ToList();
            List<DateTime> listaDataTermoAditamento = listaTermoAditamento.Select(p => p.Data).OrderBy(p => p).ToList();

            int contador = 1;
            Periodo periodoNormal = new Periodo("Normal", dataAtual, dias, Periodo.EnumTipo.Normal);
            Periodo periodoAtual = periodoNormal;
            List<Historico> listaHistorico = new List<Historico>();
            while (contador < 1000)
            {
                if (datas.Contains(dataAtual))
                {
                    Debugger.Break();
                }

                bool ehTermoAditamento = listaTermoAditamento.Any(p => p.PossuiSaldo() && p.Data == dataAtual);
                bool ehOrdemSuspensao = listaOrdemSuspensao.Any(p => p.PossuiSaldo() && p.Data == dataAtual);
                if (ehTermoAditamento || ehOrdemSuspensao)
                {
                    if (periodoAtual.Tipo == Periodo.EnumTipo.OrdemSuspensao)
                        periodoAtual.Finalizar();

                    if (ehTermoAditamento)
                        periodoAtual = listaTermoAditamento.Where(p => p.Data == dataAtual).FirstOrDefault();

                    if (ehOrdemSuspensao)
                        periodoAtual = listaOrdemSuspensao.Where(p => p.Data == dataAtual).FirstOrDefault();

                }

                listaHistorico.Add(new Historico(periodoAtual.Contador, dataAtual, periodoAtual.Descricao));

                //Verificar se acabou Saldo do periodoAtual

                periodoAtual.Incrementar();
                periodoAtual.Contabilizar();

                dataAtual = dataAtual.AddDays(1);
                contador++;
            }
        }

        private void PreencherRichTextBox(Historico historico)
        {
            richTextBox1.AppendText(historico.ToString());
        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                Periodo ordemSuspensao = new Periodo("Ordem Suspensão", dateTimePickerInicio.Value, Convert.ToInt32(numericUpDownPrazo.Value), Periodo.EnumTipo.OrdemSuspensao);
                listaOrdemSuspensao.Add(ordemSuspensao);
                PreencherListBox(listBox1, ordemSuspensao);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAdicionar2_Click(object sender, EventArgs e)
        {
            try
            {
                Periodo termoAditamento = new Periodo("Termo Aditamento", dateTimePickerInicio2.Value, Convert.ToInt32(numericUpDownPrazo2.Value), Periodo.EnumTipo.TermoAditamento);
                listaTermoAditamento.Add(termoAditamento);
                listBox2.DisplayMember = "Descricao";
                PreencherListBox(listBox2, termoAditamento);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PreencherListBox(ListBox listBox, Periodo item)
        {
            listBox.DisplayMember = "Descricao";
            listBox.Items.Add(item);
        }

        private void listBox1_KeyDown(object sender, KeyEventArgs e)
        {
            bool comItemSelecionado = listBox1.SelectedIndex > -1;
            bool comItens = listBox1.Items.Count > 0;
            bool teclaDelete = e.KeyCode == Keys.Delete;
            int indice = listBox1.SelectedIndex;

            if (teclaDelete && comItens && comItemSelecionado)
            {
                Periodo periodoSelecionado = listBox1.Items[indice] as Periodo;
                if (periodoSelecionado != null)
                {
                    listBox1.Items.RemoveAt(indice);
                    listaOrdemSuspensao.Remove(periodoSelecionado);
                }
            }
        }

        private void listBox2_KeyDown(object sender, KeyEventArgs e)
        {
            bool comItemSelecionado = listBox2.SelectedIndex > -1;
            bool comItens = listBox2.Items.Count > 0;
            bool teclaDelete = e.KeyCode == Keys.Delete;
            int indice = listBox2.SelectedIndex;

            if (teclaDelete && comItens && comItemSelecionado)
            {
                Periodo periodoSelecionado = listBox2.Items[indice] as Periodo;
                if (periodoSelecionado != null)
                {
                    listBox2.Items.RemoveAt(indice);
                    listaTermoAditamento.Remove(periodoSelecionado);
                }
            }
        }
    }
}
