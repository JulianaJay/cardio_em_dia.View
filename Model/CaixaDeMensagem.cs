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
        public static void ConsumoDeAgua()
        {
            MessageBoxResult result = MessageBox.Show(
                        "Consumo d'água salvo com sucesso!",
                        "Informação!",
                        MessageBoxButton.OK,
                        MessageBoxImage.Information);
        }
        public static void ErroConsumoDeAgua()
        {
            MessageBoxResult result = MessageBox.Show(
                        "Não foi possível salvar seu consumo d'água!",
                        "Informação!",
                        MessageBoxButton.OK,
                        MessageBoxImage.Information);
        }
        public static void AtualizarConsumoDeAgua()
        {
            MessageBoxResult result = MessageBox.Show(
                        "Consumo d'água foi atualizado com sucesso!",
                        "Informação!",
                        MessageBoxButton.OK,
                        MessageBoxImage.Information);
        }
        public static void ErroAtualizarConsumoDeAgua()
        {
            MessageBoxResult result = MessageBox.Show(
                        "Não foi possível atulizar seu consumo d'água!",
                        "Informação!",
                        MessageBoxButton.OK,
                        MessageBoxImage.Information);
        }
        public static void ExcluirConsumoDeAgua()
        {
            MessageBoxResult result = MessageBox.Show(
                        "Consumo d'água foi excluído com sucesso!",
                        "Informação!",
                        MessageBoxButton.OK,
                        MessageBoxImage.Information);
        }
        public static void ErroExcluirConsumoDeAgua()
        {
            MessageBoxResult result = MessageBox.Show(
                        "Não foi possível excluir seu consumo d'água!",
                        "Informação!",
                        MessageBoxButton.OK,
                        MessageBoxImage.Information);
        }
    }
}
