using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ByteBank_Encapsulamento
{
    public class Cliente
    {
        public string nome;
        public string cpf;
        public string profissao;

        public string GetNome()
        {
            return nome; // olha só, o this não é obrigatório
        }
        public void SetNome(string nome)
        {
            this.nome = nome;
        }

        public string GetCpf()
        {
            return cpf;
        }
        public void SetCpf(string cpf)
        {
            this.cpf = cpf;
        }

        public string GetProfissao()
        {
            return profissao;
        }
        public void SetProfissao(string profissao)
        {
            this.profissao = profissao;
        }
    }
}
