using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Projeto3Camadas.CODE.DTO;
using Projeto3Camadas.CODE.BLL;

namespace Projeto3Camadas
{
    public partial class FrmAlterCliente : Form
    {
        ClienteDTO dto = new ClienteDTO();
        ClienteBLL bll = new ClienteBLL();
        public FrmAlterCliente()
        {
            InitializeComponent();
        }

        private void lblNome_Click(object sender, EventArgs e)
        {

        }

        private void btnAterar_Click(object sender, EventArgs e)
        {
            dto.Id = int.Parse(textIdAlter.Text);
            dto.NovoNome1 = textNovoNome.Text;
            dto.NovoEmail1 = textNovoEmail.Text;
            bll.Alterar(dto);
        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }
    }
}
