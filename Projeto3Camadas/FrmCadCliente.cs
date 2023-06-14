using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeto3Camadas.CODE.BLL;
using Projeto3Camadas.CODE.DTO;

namespace Projeto3Camadas
{
    public partial class FrmCadCliente : Form
    {

        ClienteBLL bll = new ClienteBLL();
        ClienteDTO dto = new ClienteDTO();

        public FrmCadCliente()
        {
            InitializeComponent();
        }


        private void btnIncluir_Click(object sender, EventArgs e)
        {
            dto.Nome = textNome.Text;
            dto.Email = textEmail.Text;
            bll.Inserir(dto);
        }

        private void FrmCadCliente_Load(object sender, EventArgs e)
        {

        }

        private void go_to_delete_Click(object sender, EventArgs e)
        {
            FrmDelCliente delete = new FrmDelCliente();
            delete.Show();
        }

        private void go_to_alter_Click(object sender, EventArgs e)
        {
            FrmAlterCliente alter = new FrmAlterCliente();  
            alter.Show();
        }
    }
}