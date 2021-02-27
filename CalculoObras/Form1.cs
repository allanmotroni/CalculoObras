using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculoObras
{
    public partial class Form1 : Form
    {
        List<Classe> classes;
        List<Item> listaOrdemSuspensao;
        List<Item> listaTermoAditamento;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            classes = new List<Classe>();
            listaOrdemSuspensao = new List<Item>();
            listaTermoAditamento = new List<Item>();
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime dataInicio = dateTimePickerDataInicio.Value.Date;
                int prazoContratual = Convert.ToInt32(numericUpDownPrazoContratual.Value);
                Calcular(dataInicio, prazoContratual, listaOrdemSuspensao, listaTermoAditamento);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Calcular(DateTime dataInicio, int prazoContratual, List<Item> ordemSuspensao, List<Item> termoAditamento)
        {
            try
            {
                List<Classe> listaOrdemSuspensaoProcessado = new List<Classe>();
                foreach (var item in ordemSuspensao)
                {
                    foreach (var subItem in Processador.Processar(item))
                    {
                        if (!listaOrdemSuspensaoProcessado.Any(p => p.Data == subItem.Data))
                            listaOrdemSuspensaoProcessado.Add(subItem);
                    }
                }

                List<Classe> listaTermoAditamentoProcessado = new List<Classe>();
                foreach (var item in termoAditamento)
                {
                    foreach (var subItem in Processador.Processar(item))
                    {
                        if (!listaTermoAditamentoProcessado.Any(p => p.Data == subItem.Data))
                            listaTermoAditamentoProcessado.Add(subItem);
                    }
                }

                DateTime dataAtual = dataInicio.Date;
                int prazo = prazoContratual;
                int contador = 0;
                Classe classe;
                while (contador < prazo)
                {
                    if (Eh(dataAtual, listaOrdemSuspensaoProcessado) && !Eh(dataAtual, listaTermoAditamentoProcessado))
                    {
                        classe = new Classe(dataAtual, "OS");
                        prazo++;
                        
                    }
                    else if (Eh(dataAtual, listaTermoAditamentoProcessado))
                    {
                        classe = new Classe(dataAtual, "TA");
                    }
                    else
                    {
                        classe = new Classe(dataAtual, "");
                    }

                    classes.Add(classe);
                    PreencherRichTextBox(classe);

                    dataAtual = dataAtual.AddDays(1);
                    contador++;
                }

                DateTime dataFinal = dataAtual.AddDays(-1);
                MessageBox.Show(string.Format("Data fim: {0}", dataFinal.ToShortDateString()), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private bool Eh(DateTime data, List<Classe> lista)
        {
            return lista.Any(p => p.Data == data);
        }

        private void PreencherRichTextBox(Classe classe)
        {
            richTextBox1.AppendText(classe.ToString());
        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                Item item = new Item(dateTimePickerInicio.Value, Convert.ToInt32(numericUpDownPrazo.Value));
                listaOrdemSuspensao.Add(item);
                AdicionarPrazo(listBox1, listaOrdemSuspensao.ToList());
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
                Item item = new Item(dateTimePickerInicio2.Value, Convert.ToInt32(numericUpDownPrazo2.Value));
                listaTermoAditamento.Add(item);
                AdicionarPrazo(listBox2, listaTermoAditamento.ToList());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AdicionarPrazo(ListBox listBox, List<Item> itens)
        {
            try
            {
                listBox.DataSource = itens;
                listBox.DisplayMember = "Descricao";
                listBox.ValueMember = "Data";
            }
            catch (Exception)
            {
                throw;
            }
        }


    }
}
