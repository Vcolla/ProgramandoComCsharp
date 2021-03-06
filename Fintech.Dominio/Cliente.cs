using System;
using System.Collections.Generic;

namespace Fintech.Dominio
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public DateTime DataNascimento { get; set; }
        public Sexo Sexo { get; set; }

        public Endereco EnderecoResidencial { get; set; }

        public List<Conta> Contas { get; set; } = new List<Conta>();
        

    }
}