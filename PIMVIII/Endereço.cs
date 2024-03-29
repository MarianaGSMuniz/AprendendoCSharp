﻿using PIMVIII;
using System;
using System.Data.SqlClient;
using System.Configuration;

namespace PIMVIII
{
    public class Endereço
    {
    
        string strConnection = ConfigurationManager.ConnectionStrings["CharityManagement"].ConnectionString;
        protected internal Endereço()
        {
        }
        public Endereco consulte(int intEndereco)
        {
            SqlConnection conexao = new(strConnection);
            conexao.Open(); // abre a conexão com o banco
            Endereco endereco = null;
            SqlCommand cmd = new SqlCommand("SELECT * FROM ENDERECO WHERE id = " + intEndereco, conexao);
            using (var dr = cmd.ExecuteReader())
            {
                if (dr.HasRows && dr.Read())
                {
                    endereco = new(Convert.ToInt32(dr["id"]));
                    endereco.bairro = dr["bairro"].ToString();
                    endereco.cep = Convert.ToInt32(dr["cep"]);
                    endereco.cidade = dr["cidade"].ToString();
                    endereco.estado = dr["estado"].ToString();
                    endereco.logradouro = dr["logradouro"].ToString();
                    endereco.numero = Convert.ToInt32(dr["numero"]);
                }
            }
            conexao.Close();
            return endereco;
        }

        public bool insira(Endereco endereco)
        {
            int nlinhas = 0;
            SqlConnection conexao = new(strConnection);
            conexao.Open();
            using (SqlCommand cmd = new SqlCommand(@$"
INSERT INTO ENDERECO (
            LOGRADOURO, 
            NUMERO, 
            CEP, 
            BAIRRO, 
            CIDADE, 
            ESTADO)
     VALUES('{endereco.logradouro}', 
            {endereco.numero}, 
            {endereco.cep}, 
            '{endereco.bairro}', 
            '{endereco.cidade}', 
            '{endereco.estado}');", conexao))
                nlinhas = cmd.ExecuteNonQuery(); // executa cmd
            conexao.Close();
            return (nlinhas == 1);
        }

        internal int getId(Endereco endereco)
        {
            int retorno = 0;
            SqlConnection conexao = new(strConnection);
            conexao.Open();
            SqlCommand cmd = new SqlCommand($@"
SELECT id 
  FROM ENDERECO 
 WHERE bairro = '{endereco.bairro}'
   and cep = '{endereco.cep}'
   and cidade = '{endereco.cidade}'
   and estado = '{endereco.estado}'
   and logradouro = '{endereco.logradouro}'
   and numero = '{endereco.numero}'", conexao);
            using (var dr = cmd.ExecuteReader())
            {
                if (dr.HasRows && dr.Read())
                {
                    retorno = Convert.ToInt32(dr[0]);
                }
            }
            conexao.Close();
            return retorno;
        }
    }
}
