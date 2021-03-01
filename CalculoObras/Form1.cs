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
                DateTime dataInicio = dateTimePickerDataInicio.Value.Date;
                int prazoContratual = Convert.ToInt32(numericUpDownPrazoContratual.Value);

                List<Historico> listaHistorico = Calcular(dataInicio, prazoContratual);

                PreencherRichTextBox(listaHistorico);

                if (listaHistorico.Count > 0)
                    MostrarDataFinal(listaHistorico.OrderByDescending(p => p.Data).FirstOrDefault().Data);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MostrarDataFinal(DateTime data)
        {
            MessageBox.Show(data.ToString("dd/MM/yyyy"), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void PreencherDadosMock()
        {

            listaOrdemSuspensao = new List<Periodo>() {
                new Periodo("Ordem Suspensão 01",Convert.ToDateTime("22/06/2018"), 120, Periodo.EnumTipo.OrdemSuspensao),
                new Periodo("Ordem Suspensão 02",Convert.ToDateTime("17/10/2018"), 120, Periodo.EnumTipo.OrdemSuspensao),
                new Periodo("Ordem Suspensão 03",Convert.ToDateTime("14/02/2019"), 120, Periodo.EnumTipo.OrdemSuspensao),
                new Periodo("Ordem Suspensão 04",Convert.ToDateTime("16/06/2019"), 120, Periodo.EnumTipo.OrdemSuspensao),
                new Periodo("Ordem Suspensão 05",Convert.ToDateTime("08/10/2019"), 120, Periodo.EnumTipo.OrdemSuspensao),
            };

            listaTermoAditamento = new List<Periodo>() {
                new Periodo("Termo Aditamento 01",Convert.ToDateTime("28/08/2017"), 180, Periodo.EnumTipo.TermoAditamento),
                new Periodo("Termo Aditamento 02",Convert.ToDateTime("22/12/2017"), 180, Periodo.EnumTipo.TermoAditamento),
                new Periodo("Termo Aditamento 03",Convert.ToDateTime("30/01/2019"), 120, Periodo.EnumTipo.TermoAditamento),
                new Periodo("Termo Aditamento 04",Convert.ToDateTime("30/01/2020"), 240, Periodo.EnumTipo.TermoAditamento)
            };
        }

        private List<DateTime> DatasMock()
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

            return datas;
        }

        private List<Historico> Calcular(DateTime dataInicio, int prazoContratual)
        {
            try
            {

                List<Historico> listaHistorico = Processar(dataInicio.Date, prazoContratual);
                return listaHistorico;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private List<Historico> Processar(DateTime data, int dias)
        {
            //PreencherDadosMock();
            //data = Convert.ToDateTime("28/06/2017");
            //dias = 365;

            try
            {
                List<DateTime> datas = DatasMock();
                DateTime dataAtual = data;
                Periodo periodoNormal = new Periodo("Normal", dataAtual, dias, Periodo.EnumTipo.Normal);
                Periodo periodoAtual = periodoNormal;
                List<Historico> listaHistorico = new List<Historico>();
                bool condicao = true;
                Periodo termoAditamentoJaUtilizadoComSaldo = null;

                List<Periodo> listaTermoAditamentoLocal = new List<Periodo>(listaTermoAditamento);
                List<Periodo> listaOrdemSuspensaoLocal = new List<Periodo>(listaOrdemSuspensao);

                while (condicao)
                {
                    //if (datas.Contains(dataAtual))
                    //    Debugger.Break();

                    bool ehTermoAditamento = listaTermoAditamentoLocal.Any(p => p.PossuiSaldo() && p.Data == dataAtual);
                    bool ehOrdemSuspensao = listaOrdemSuspensaoLocal.Any(p => p.PossuiSaldo() && p.Data == dataAtual);
                    if (ehTermoAditamento || ehOrdemSuspensao)
                    {
                        if (periodoAtual.Tipo == Periodo.EnumTipo.OrdemSuspensao)
                            periodoAtual.Finalizar();

                        if (ehTermoAditamento)
                            periodoAtual = listaTermoAditamentoLocal.Where(p => p.Data == dataAtual).FirstOrDefault();

                        if (ehOrdemSuspensao)
                            periodoAtual = listaOrdemSuspensaoLocal.Where(p => p.Data == dataAtual).FirstOrDefault();

                    }
                    else if (!periodoAtual.PossuiSaldo())
                    {
                        termoAditamentoJaUtilizadoComSaldo = listaTermoAditamentoLocal.Where(p => p.Contador > 0 && p.PossuiSaldo()).OrderBy(p => p.Data).FirstOrDefault();
                        if (termoAditamentoJaUtilizadoComSaldo == null)
                        {
                            if (periodoNormal.PossuiSaldo() && periodoNormal.Data.AddDays(periodoNormal.Dias) >= dataAtual)
                                periodoAtual = periodoNormal;
                        }
                        else
                        {
                            periodoAtual = termoAditamentoJaUtilizadoComSaldo;
                        }
                    }

                    periodoAtual.Contabilizar();
                    if (periodoAtual.Tipo == Periodo.EnumTipo.OrdemSuspensao)
                        periodoNormal.IncrementarDia();

                    listaHistorico.Add(new Historico(periodoAtual.Contador, dataAtual, periodoAtual.Descricao));

                    dataAtual = dataAtual.AddDays(1);

                    condicao = listaTermoAditamentoLocal.Any(p => p.PossuiSaldo()) || listaOrdemSuspensaoLocal.Any(p => p.PossuiSaldo());
                    if (!condicao)
                        condicao = periodoNormal.PossuiSaldo() && periodoNormal.Data.AddDays(periodoNormal.Dias) > dataAtual;
                }

                return listaHistorico;

            }
            catch (Exception)
            {
                throw;
            }
        }

        private void PreencherRichTextBox(List<Historico> listaHistorico)
        {
            richTextBox1.Clear();
            if (listaHistorico.Count > 0)
                richTextBox1.AppendText(string.Join(Environment.NewLine, listaHistorico));
        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                Periodo.EnumTipo tipo = Periodo.EnumTipo.OrdemSuspensao;
                string descricao = string.IsNullOrWhiteSpace(textBoxDescricaoOrdemSuspensao.Text) ? tipo.ToString() : textBoxDescricaoOrdemSuspensao.Text;
                DateTime data = dateTimePickerInicio.Value;
                int prazo = Convert.ToInt32(numericUpDownPrazo.Value);

                Periodo ordemSuspensao = new Periodo(descricao, data, prazo, tipo);

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
                Periodo.EnumTipo tipo = Periodo.EnumTipo.TermoAditamento;
                string descricao = string.IsNullOrWhiteSpace(textBoxDescricaoTermoAditamento.Text) ? tipo.ToString() : textBoxDescricaoTermoAditamento.Text;
                DateTime data = dateTimePickerInicio2.Value;
                int prazo = Convert.ToInt32(numericUpDownPrazo2.Value);

                Periodo termoAditamento = new Periodo(descricao, data, prazo, tipo);

                listaTermoAditamento.Add(termoAditamento);

                PreencherListBox(listBox2, termoAditamento);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PreencherListBox(ListBox listBox, Periodo item)
        {
            listBox.DisplayMember = "DescricaoStr";
            listBox.Items.Add(item);
        }

        private void listBox1_KeyDown(object sender, KeyEventArgs e)
        {

            try
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listBox2_KeyDown(object sender, KeyEventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            try
            {
                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimparCampos()
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();

            textBoxDescricaoOrdemSuspensao.Clear();
            textBoxDescricaoTermoAditamento.Clear();

            richTextBox1.Clear();
        }

        private void numericUpDownDiaCalcularData_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                labelDataCalculada.Text = CalcularData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dateTimePickerDataCalcularData_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                labelDataCalculada.Text = CalcularData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string CalcularData()
        {
            DateTime data = dateTimePickerDataCalcularData.Value;
            int dias = Convert.ToInt32(numericUpDownDiaCalcularData.Value);

            return data.AddDays(dias).ToString("dd/MM/yyyy");
        }
    }
}
