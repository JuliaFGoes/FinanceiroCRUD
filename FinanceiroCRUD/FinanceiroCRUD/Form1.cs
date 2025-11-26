using System.Data;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FinanceiroCRUD
{
    public partial class Form1 : Form
    {
        DataTable tabela = new DataTable();
        Banco banco = new Banco();

        public object BancoBaseHelpers { get; private set; }
        public bool validacao()
        {
            if (txbDescricao.Text == "")
            {
                MessageBox.Show("Insira a descrição!");
                return false;
            }
            if (txbValor.Text == "")
            {
                MessageBox.Show("Insira um valor");
                return false;
            }
            else if (double.Parse(txbValor.Text) <= 0)
            {
                MessageBox.Show("Insira um valor positivo!");
                return false;
            }
            if (cmbTipo.Text != "E" && cmbTipo.Text != "S")
            {
                MessageBox.Show("Apenas entradas ou saidas sao aceitas");
                return false;
            }

            return true;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void CarregarTabela()
        {
           
        }


        private void lblData_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Lancamentos l = new Lancamentos();
                l.Descricao = txbDescricao.Text;
                l.Valor = decimal.Parse(txbValor.Text);
                l.Data = dtData.Value;
                

                bool ok = banco.Adicionar(l);

                MessageBox.Show("Lançamento inserido!");
                CarregarTabela();
            }
            catch
            {
                MessageBox.Show("Erro: verifique os dados preenchidos.");
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            
            
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvDados.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione uma linha para excluir.");
                return;
            }

            int id = Convert.ToInt32(dgvDados.SelectedRows[0].Cells["Id"].Value);

            bool ok = banco.Excluir(id);

            MessageBox.Show("Excluído!");
            CarregarTabela();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (dgvDados.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione uma linha para alterar.");
                return;
            }

            try
            {
                int id = Convert.ToInt32(dgvDados.SelectedRows[0].Cells["Id"].Value);

                Lancamentos l = new Lancamentos();
                l.Id = id;
                l.Descricao = txbDescricao.Text;
                l.Valor = decimal.Parse(txbValor.Text);
                l.Data = dtData.Value;
                l.Tipo = cmbTipo.SelectedItem.ToString() == "Entrada" ? 'E' : 'S';

                bool ok = banco.Atualizar(l.Id, l.Descricao, l.Valor, l.Tipo.ToString(), l.Data);

                MessageBox.Show("Alterado com sucesso!");
                CarregarTabela();
            }
            catch
            {
                MessageBox.Show("Erro ao alterar: verifique os campos.");
            }
        }

        private void lblSaldoValor_Click(object sender, EventArgs e)
        {
            try
            {
                {
                    MessageBox.Show("Saldo atual: " + banco.CalcularSaldo().ToString("C2"));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao calcular saldo: " + ex.Message);
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            Banco bd = new Banco();

            string sql = "select * from lancamentos where 1=1";

            if (!string.IsNullOrEmpty(txbDescricaoF.Text))
            {
                sql += " and descricao = '" + txbDescricaoF.Text + "'";
            }

            if (!string.IsNullOrEmpty(cmbTipoF.Text))
            {
                sql += " and tipo = '" + cmbTipoF.Text + "'";
            }
        }
    }
}
