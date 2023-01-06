using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Correios.Net;
using System.Runtime.InteropServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BuscaCEP
{
    public partial class frmBuscaEndereco : Form
    {
        public frmBuscaEndereco()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }



        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);


        private void LimparCampos()
        {
            txtBairro.Clear();
            txtCidade.Clear();
            txtEndereco.Clear();
            mkdCEP.ResetText();
            mkdNum.ResetText();
            txtUF.Clear();
            textBox1.Clear();
        }
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                WSCorreios.AtendeClienteClient ws = new WSCorreios.AtendeClienteClient();

                WSCorreios.enderecoERP endereco = ws.consultaCEP(mkdCEP.Text);

                txtEndereco.Text = endereco.end;
                txtBairro.Text = endereco.bairro;
                txtCidade.Text = endereco.cidade;
                txtUF.Text = endereco.uf;
                


                txtCompleto.Text = (txtEndereco.Text) + (" ") + (mkdNum.Text) + (" ,") + (mkdCEP.Text) + (", ") + (txtBairro.Text) + (" , ") + (txtCidade.Text) + (" ,") + (txtUF.Text);
                textBox1.Text = txtCompleto.Text;
                txtCompleto.SelectAll();
            }
            catch (Exception)
            {

                MessageBox.Show("É necessário possuir um CEP para realizar a busca", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnLimpar_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que apagar as informações", "Atenção", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == DialogResult.OK)
            {
                MessageBox.Show("Informações apagadas", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                LimparCampos();
            }
            else
            {
                MessageBox.Show("Você clicou em cancelar, por isso a limpeza foi cancelada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Quer Realmente fechar o Busca Endereço ?", "Atenção", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.OK)
            {
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Você clicou em cancelar, por isso o fechamento foi cancelado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
        }
         

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Copiar_Click(object sender, EventArgs e)
        {
            txtCompleto.Text = (txtEndereco.Text) + (" ") + (mkdNum.Text) + (" ,") + (mkdCEP.Text) + (", ") + (txtBairro.Text) + (" , ") + (txtCidade.Text) + (" ,") + (txtUF.Text);
            textBox1.Text = txtCompleto.Text;
            txtCompleto.SelectAll();
            txtCompleto.Copy();
        }


        private void mkdCEP_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                btnPesquisar.Focus();
            }

        }

        private void btnPesquisar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                WSCorreios.AtendeClienteClient ws = new WSCorreios.AtendeClienteClient();

                WSCorreios.enderecoERP endereco = ws.consultaCEP(mkdCEP.Text);

                txtEndereco.Text = endereco.end;
                txtBairro.Text = endereco.bairro;
                txtCidade.Text = endereco.cidade;
                txtUF.Text = endereco.uf;
            }
        }


    }
}
