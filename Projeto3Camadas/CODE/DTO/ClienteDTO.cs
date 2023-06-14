using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto3Camadas.CODE.DTO
{
    class ClienteDTO
    {
        private int id;
        private string nome;
        private string email;

        private string NovoNome;
        private string NovoEmail;
        private string alter_id;
        

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Email { get => email; set => email = value; }
        public string NovoEmail1 { get => NovoEmail; set => NovoEmail = value; }
        public string NovoNome1 { get => NovoNome; set => NovoNome = value; }
        public string Alter_id { get => alter_id; set => alter_id = value; }
    }
}
