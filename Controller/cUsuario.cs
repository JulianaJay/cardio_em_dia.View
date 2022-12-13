using cardio_em_dia.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class cUsuario
{
    public static bool NovoUsuario(string email, string senha)
    {
        return ConsultasUsuario.NovoUsuario(email,senha);
    }
    public static bool AtualizarUsuario(string email, string nome, string sobrenome, string telefone, string sexo, string cpf, string cep, string uf)
    {
        return ConsultasUsuario.AtualizarUsuario(email, nome, sobrenome, telefone, sexo, cpf, cep, uf);
    }
    public static bool AtualizarSenhaUsuario(string email, string senha)
    {
        return ConsultasUsuario.AtualizarSenhaUsuario(email, senha);
    }
    public static bool ExcluirUsuario(string email)
    {
        return ConsultasUsuario.ExcluirUsuario(email);
    }
    public static Usuario ObterUsuario(string email, string senha)
    {
        return ConsultasUsuario.ObterUsuario(email, senha);
    }
    public static bool VerificarUsuarioExistente(string email)
    {
        return ConsultasUsuario.VerificarUsuarioExistente(email);
    }
    public static bool VerificarSeCPFExistente(string cpf)
    {
        return ConsultasUsuario.VerificarSeCPFExistente(cpf);
    }



    public static bool AdicionarConsumoDeAgua(string qtd)
    {
        return ConsultasUsuario.AdicionarConsumoDeAgua(qtd);
    }
    public static bool ExcluirConsumoDeAgua(int id)
    {
        return ConsultasUsuario.ExcluirConsumoDeAgua(id);
    }
    public static bool AtualizarConsumoDaAgua(int id, string qtd)
    {
        return ConsultasUsuario.AtualizarConsumoDaAgua(id, qtd);
    }
}
