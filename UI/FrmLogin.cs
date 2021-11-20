using _3C1felipe10.Code.BLL;
using _3C1felipe10.Code.dt;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _3C1felipe10.Code.BLL;
using _3C1felipe10.Code.dt;



namespace _3C1felipe10.UI
{
    public partial class FrmLogin : Form
    {

        loginBLL loginBLL = new loginBLL();
        loginDTO loginDTO = new loginDTO();
        public FrmLogin()
        {
            InitializeComponent();
        }

       

        private void btn_login_Click(object sender, EventArgs e)
        {
            loginDTO.email = txtemail.Text;
            loginDTO.senha = txtsenha.Text;

            if (loginBLL.RealizarLogin(loginDTO) != true)

            {
                EPA EPA = new EPA();
                EPA.ShowDialog();
            }
            else
            {
                MessageBox.Show("Verifique e-mail e senha.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
