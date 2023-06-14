using System;
using System.Collections.Generic;
using System.Text;
using Projeto3Camadas.CODE.DTO;
using Projeto3Camadas.CODE.DAL;

namespace Projeto3Camadas.CODE.BLL
{
    class ClienteBLL
    {
        AcessoBancoDados bd = new AcessoBancoDados();
        public void Inserir(ClienteDTO dto) 
        {
            bd.Conectar();
            string comando = "INSERT INTO cliente(nome, email) VALUES('" + dto.Nome + "','" + dto.Email + "')";
            bd.ExecutarComandoSQL(comando);
        }

       
        public void Deleter(ClienteDTO dto) 
        {
            bd.Conectar();
            string comando_del = "call deletar_cliente('" + dto.Id + "')";
            bd.ExecutarComandoSQL(comando_del);
        }

        public void Alterar(ClienteDTO dto) 
        {
            bd.Conectar();
            string comando_alter = "call alterar_cliente('" + dto.Id + "','" + dto.NovoNome1 + "','" + dto.NovoEmail1 + "')";
            bd.ExecutarComandoSQL(comando_alter);
        }
    }
}
