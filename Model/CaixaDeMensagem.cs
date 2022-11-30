using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace cardio_em_dia.Model
{
    public class CaixaDeMensagem
    {
        public static void ExibirMenssagemPreencherCampos()
        {
            MessageBoxResult result = MessageBox.Show(
                "Preencha todos os campos!",
                "Atenção",
                MessageBoxButton.OK,
                MessageBoxImage.Warning);
        }

        public static void ExibirMensagemEmailJaExisteNoSistema()
        {
            MessageBoxResult result = MessageBox.Show(
                "Esse email já está cadastrado no sistema!",
                "Atenção",
                MessageBoxButton.OK,
                MessageBoxImage.Warning);
        }

        public static void ExibirMensagemSenhaOuEmailIncorretos()
        {
            MessageBoxResult result = MessageBox.Show(
                    "Email ou senha incorretos, tente novamente mais tarde!",
                    "Aviso!",
                    MessageBoxButton.OK,
                    MessageBoxImage.Warning);
        }
    }
}
