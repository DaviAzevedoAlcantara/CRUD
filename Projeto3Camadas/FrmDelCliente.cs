using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using Projeto3Camadas.CODE.BLL;
using Projeto3Camadas.CODE.DTO;

namespace Projeto3Camadas
{
    public partial class FrmDelCliente : Form
    {
        ClienteBLL bll = new ClienteBLL();
        ClienteDTO dto = new ClienteDTO();
        public FrmDelCliente()
        {
            InitializeComponent();
        }

        private void FrmDelCliente_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dto.Id = int.Parse(textID_delete.Text);
            bll.Deleter(dto);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
