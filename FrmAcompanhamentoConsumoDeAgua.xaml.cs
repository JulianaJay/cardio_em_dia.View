using cardio_em_dia.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace cardio_em_dia
{
    /// <summary>
    /// Lógica interna para FrmAcompanhamentoConsumoDeAgua.xaml
    /// </summary>
    public partial class FrmAcompanhamentoConsumoDeAgua : Window
    {
        int total = 0;
        int consumoHora = 0;
        public FrmAcompanhamentoConsumoDeAgua()
        {
            InitializeComponent();
        }

        private void VoltarParaAcompanhamentoMedico(object sender, RoutedEventArgs e)
        {
            FrmAcompanhamentoMedico frmSubAcompanhamentoMedico = new FrmAcompanhamentoMedico();
            frmSubAcompanhamentoMedico.Show();
        }

        private void PrimeiroHorario(object sender, RoutedEventArgs e)
        { 
            txtTotalDeAguaDoDia.Text = $"{total + 200} ml";
            total = total + 200;
            AtualizarBD();
        }

        private void SegundoHorario(object sender, RoutedEventArgs e)
        {
            txtTotalDeAguaDoDia.Text = $"{total + 200} ml";
            AtualizarBD();
        }

        private void TerceiroHorario(object sender, RoutedEventArgs e)
        {
            txtTotalDeAguaDoDia.Text = $"{total + 200} ml";
            total = total + 200;
            AtualizarBD();
        }

        private void QuartoHorario(object sender, RoutedEventArgs e)
        {
            txtTotalDeAguaDoDia.Text = $"{total + 200} ml";
            total = total + 200;
            AtualizarBD();
        }

        private void QuintoHorario(object sender, RoutedEventArgs e)
        {
            txtTotalDeAguaDoDia.Text = $"{total + 200} ml";
            total = total + 200;
            AtualizarBD();
        }

        private void SextoHorario(object sender, RoutedEventArgs e)
        {
            txtTotalDeAguaDoDia.Text = $"{total + 200} ml";
            total = total + 200;
            AtualizarBD();
        }

        private void SetimoHorario(object sender, RoutedEventArgs e)
        {
            txtTotalDeAguaDoDia.Text = $"{total + 200} ml";
            total = total + 200;
            AtualizarBD();
        }

        private void OitavoHorario(object sender, RoutedEventArgs e)
        {
            txtTotalDeAguaDoDia.Text = $"{total + 200} ml";
            total = total + 200;
            AtualizarBD();
        }

        private void NonoHorario(object sender, RoutedEventArgs e)
        {
            txtTotalDeAguaDoDia.Text = $"{total + 200} ml";
            total = total + 200;
            AtualizarBD();
        }

        private void AtualizarBD()
        {
            string qtd = txtTotalDeAguaDoDia.Text;
            bool validarCadastro = ConsultasUsuario.AdicionarConsumoDeAgua(qtd);
            if (validarCadastro == true)
            {
                CaixaDeMensagem.ConsumoDeAgua();
            }
            else
            {
                CaixaDeMensagem.ErroConsumoDeAgua();
            }
        }

        private void Limpar(object sender, RoutedEventArgs e)
        {
            txtTotalDeAguaDoDia.Text = "";

            string id = txtID.Text;
            bool validarExclusao = ConsultasUsuario.ExcluirUsuario(id);
            if (validarExclusao == true)
            {
                CaixaDeMensagem.ExcluirConsumoDeAgua();
            }
            else
            {
                CaixaDeMensagem.ErroExcluirConsumoDeAgua();
            }
        }
    }
    }

