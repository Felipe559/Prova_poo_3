using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _3C1felipe10.Code.dt;
using _3C1felipe10.Code.BLL;

namespace _3C1felipe10
{
    
    public partial class EPA : Form
    {
        produtoBLL prdbll = new EPABLL();
    produtoDTO prddto = new EPADTO();
        private produtoDTO prdDTO;
        private object dgvproduto;

        public EPA()
        {
            InitializeComponent();
        }

        private void btn_cad_Click(object sender, EventArgs e)
        {
            produtoDTO.produto = txtproduto.Text;
            produtoDTO.Preco = txtpreco.Text;

            EPABLL.inserir(prdDTO);

            MessageBox.Show("Cadastro realizado", "Produto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtid.Clear();
            txtproduto.Clear();
            txtpreco.Clear();


        }

        private void btn_alt_Click(object sender, EventArgs e)
        {
            produtoDTO.ID = int.Parse(txtid.Text);
            produtoDTO.Produto = txtpreco.Text;
            produtoDTO.Preco = txtpreco.Text;

            prdbll.Listar();

            DialogResult dialogResult = MessageBox.Show("Alterado realizado", "Produto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtid.Clear();
            txtproduto.Clear();
            txtpreco.Clear();

        }

        private void btn_exc_Click(object sender, EventArgs e)
        {
            produtoDTO.ID = int.Parse(txtid.Text);
            produtoDTO.Produto = txtpreco.Text;
            produtoDTO.Preco = txtpreco.Text;

            prdbll.Listar();

            DialogResult dialogResult = MessageBox.Show("Excluido realizado", "Produto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtid.Clear();
            txtproduto.Clear();
            txtpreco.Clear();
        }
        private void EPA.cs(object sender, EventArgs e)
        {
            dgvproduto.DataSource = prdbll.Listar();
        }

        private void dgvproduto_CellcontentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = dgvproduto.Rows[e.RowIndex].Cells[0].Value.Tostring();
            txtproduto.Text = dgvproduto.Rows[e.RowIndex].Cells[1].Value.Tostring();
            txtpreco.Text = dgvproduto.Rows[e.RowIndex].Cells[0].Value.Tostring();
        }
    }
}
