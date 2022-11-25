﻿using System;
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
    /// Lógica interna para FrmTelaDeCadastro_2.xaml
    /// </summary>
    public partial class FrmTelaDeCadastro_2 : Window
    {
        public FrmTelaDeCadastro_2()
        {
            InitializeComponent();
            AdicionaItensNoComboBoxEstadoDoUsuario();
            AdicionaItensNoComboBoxSexoDoUsuario();
        }

        private void AdicionaItensNoComboBoxEstadoDoUsuario()
        {
            txtEstadoDoUsuario.Items.Add("AC");
            txtEstadoDoUsuario.Items.Add("AL");
            txtEstadoDoUsuario.Items.Add("AP");
            txtEstadoDoUsuario.Items.Add("AM");
            txtEstadoDoUsuario.Items.Add("BA");
            txtEstadoDoUsuario.Items.Add("CE");
            txtEstadoDoUsuario.Items.Add("DF");
            txtEstadoDoUsuario.Items.Add("ES");
            txtEstadoDoUsuario.Items.Add("GO");
            txtEstadoDoUsuario.Items.Add("MA");
            txtEstadoDoUsuario.Items.Add("MT");
            txtEstadoDoUsuario.Items.Add("MS");
            txtEstadoDoUsuario.Items.Add("MG");
            txtEstadoDoUsuario.Items.Add("PA");
            txtEstadoDoUsuario.Items.Add("PB");
            txtEstadoDoUsuario.Items.Add("PR");
            txtEstadoDoUsuario.Items.Add("PE");
            txtEstadoDoUsuario.Items.Add("PI");
            txtEstadoDoUsuario.Items.Add("RJ");
            txtEstadoDoUsuario.Items.Add("RN");
            txtEstadoDoUsuario.Items.Add("RS");
            txtEstadoDoUsuario.Items.Add("RO");
            txtEstadoDoUsuario.Items.Add("RR");
            txtEstadoDoUsuario.Items.Add("SC");
            txtEstadoDoUsuario.Items.Add("SP");
            txtEstadoDoUsuario.Items.Add("SE");
            txtEstadoDoUsuario.Items.Add("TO");
        }
        private void AdicionaItensNoComboBoxSexoDoUsuario()
        {
            txtSexoDoUsuario1.Items.Add("Masculino");
            txtSexoDoUsuario1.Items.Add("Feminino");
            txtSexoDoUsuario1.Items.Add("Não Binário");
            txtSexoDoUsuario1.Items.Add("Outro");
        }

        private void AbrirTelaPrincipal(object sender, RoutedEventArgs e)
        {
            FrmTelaPrincipal frmTelaPrincipal = new FrmTelaPrincipal();
            frmTelaPrincipal.Show();
            Close();
        }
    }
}
