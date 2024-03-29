﻿using PimVIII;
using PimVIII.Entidade;
using System;
using System.Collections.Generic;

namespace Teste
{
    class Program
    {
        static void Main(string[] args)
        {
            Endereco endereco = new Endereco { logradouro = "Rua Girassol", numero = 400, cep = 13087420, bairro = "Chácara Primavera", cidade = "Campinas", estado = "SP" };
            Pessoa pessoa = new Pessoa { cpf = 123456,endereco = endereco, nome = "Maria Coelho da Silva" };
            List<Telefone> list = new List<Telefone>();
            list.Add(new Telefone { ddd = 19, numero = 991679999, tipo = new TipoTelefone { tipo = "Celular" } });
            list.Add(new Telefone { ddd = 19, numero = 32560978, tipo = new TipoTelefone { tipo = "Fixo" } });
            pessoa.telefones = list.ToArray();

            Pessoa Pessoa = new Pessoa();
            
            Pessoa.insira(pessoa);
            Pessoa pessoaConsulte = Pessoa.consulte(pessoa.cpf);
            if(pessoaConsulte.cpf == pessoa.cpf && pessoaConsulte.nome == pessoa.nome)
                Console.WriteLine($@"A pessoa com o cpf {pessoa.cpf} foi inserido no banco de dados.");

            pessoa.nome = "Teste alteração";
            Pessoa.altere(pessoa);
            pessoaConsulte = Pessoa.consulte(pessoa.cpf);
            if (pessoaConsulte.cpf == pessoa.cpf && pessoaConsulte.nome == pessoa.nome)
                Console.WriteLine($@"A pessoa mudou de nome de Maria Coelho da Silva para {pessoaConsulte.nome}.");

            Pessoa.exclua(pessoaConsulte);
            Pessoa pessoaConsulteExcluido = Pessoa.consulte(pessoa.cpf);
            if(pessoaConsulteExcluido == null)
                Console.WriteLine($@"A pessoa {pessoa.nome} foi excluida do banco de dados.");
        }
    }
}
