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

        public static void ExibirMensagemUsuarioCadastrado()
        {
            MessageBoxResult result = MessageBox.Show(
                        "Usuario cadastrado com sucesso",
                        "Informação!",
                        MessageBoxButton.OK,
                        MessageBoxImage.Information);
        }
        public static void ExibirMensagemErroUsuarioCadastrado()
        {
            MessageBoxResult result = MessageBox.Show(
            "Não foi possível fazer o cadastro, tente novamente mais tarde!",
            "Error!",
            MessageBoxButton.OK,
            MessageBoxImage.Error);
        }
        public static void ExibirMensagemUsuarioAtualizado()
        {
            MessageBoxResult result = MessageBox.Show(
                        "Usuario atualizado com sucesso",
                        "Informação!",
                        MessageBoxButton.OK,
                        MessageBoxImage.Information);
        }
        public static void ExibirMensagemErroUsuarioAtualizado()
        {
            MessageBoxResult result = MessageBox.Show(
                        "Não foi possível atualizar o usuario, tente novamente mais tarde!",
                        "Error!",
                        MessageBoxButton.OK,
                        MessageBoxImage.Error);
        }
        public static void ExibirMensagemUsuarioExcluido()
        {
            MessageBoxResult result = MessageBox.Show(
                        "Usuario excluido com sucesso",
                        "Informação!",
                        MessageBoxButton.OK,
                        MessageBoxImage.Information);
        }
        public static void ExibirMensagemErroUsuarioExcluido()
        {
            MessageBoxResult result = MessageBox.Show(
                        "Não foi possível excluir o usuario, tente novamente mais tarde!",
                        "Informação!",
                        MessageBoxButton.OK,
                        MessageBoxImage.Information);
        }
    }
}
