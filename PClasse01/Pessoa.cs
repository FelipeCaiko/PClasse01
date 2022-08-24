using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace PClasse01
{
    internal class Pessoa
    {
        String nome;
        DateTime dtnasc;
        String cpf;
        String telefone;
        public Pessoa()
        {
            this.nome = nome;
            this.dtnasc = dtnasc;
            this.cpf = cpf;
            this.telefone = telefone;
        }
        public void setNome(String nome)
        {
            this.nome = nome;
        }
        public void setDtNasc(DateTime dtnasc)
        {
            this.dtnasc = dtnasc;
        }
        public void setCpf(String cpf)
        {
            this.cpf = cpf;
        }
        public void setTelefone(String telefone)
        {
            this.telefone = telefone;
        }
        public String getNome()
        {
            return nome;
        }
        public DateTime getDtNasc()
        {
            return dtnasc;
        }
        public String getCpf()
        {
            return cpf;
        }
        public String getTelefone()
        {
            return telefone;
        }
        public override string ToString()
        {
            return "Nome: " + nome + "\n" +
                   "Data de Nascimento: " + dtnasc + "\n" +
                   "CPF: " + cpf + "\n" +
                   "Telefone: " + telefone + "\n";
        }
    }
}