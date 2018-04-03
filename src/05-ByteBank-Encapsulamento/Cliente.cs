using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ByteBank_Encapsulamento
{
    public class Cliente
    {
        private string _nome;
        private string _cpf;
        private string _profissao;

        public string GetNome()
        {
            return _nome; // olha só, o this não é obrigatório
        }
        public void SetNome(string nome)
        {
            this._nome = nome;
        }

        public string GetCpf()
        {
            return _cpf;
        }
        public void SetCpf(string cpf)
        {
            this._cpf = cpf;
        }

        public string GetProfissao()
        {
            return _profissao;
        }
        public void SetProfissao(string profissao)
        {
            this._profissao = profissao;
        }
    }
}
