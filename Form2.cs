using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ProjetoPI
{
    public partial class Form2 : Form
    {
        Thread nt;
        public Form2()
        {
            InitializeComponent();
            panelNovaConsulta.Visible = false;
            panelConsultas.Visible = false;

        }

        private void botaoNovaConsulta_Click(object sender, EventArgs e)
        {
            panelNovaConsulta.Visible = true;
            panelConsultas.Visible = false;
            botaoNovaConsulta.Visible = false;
            botaoConsultas.Visible = false;

        }

        private void voltar_Click(object sender, EventArgs e)
        {
            panelNovaConsulta.Visible = false;
            panelConsultas.Visible = false;
            botaoNovaConsulta.Visible = true;
            botaoConsultas.Visible = true;


        }

        private void sair_Click(object sender, EventArgs e)
        {

                        
            this.Close();

            nt = new Thread(novoForm);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        private void novoForm()
        {
            Application.Run(new Form1());
        }

        private void botaoConsultas_Click(object sender, EventArgs e)
        {
            panelNovaConsulta.Visible = false;
            panelConsultas.Visible = true;
            botaoConsultas.Visible = false;
            botaoNovaConsulta.Visible = false;
            

        }

        private void btpnLimpar_Click(object sender, EventArgs e)
        {
            textBoxPncpf.Text = "";
            textBoxPnEndereco.Text = "";
            textBoxPnNome.Text = "";
            textBoxPnTelefone.Text = "";


        }

        private void btpnCadastro_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Cadastrado com sucesso!");
           
            
            textBoxPncpf.Text = "";
            textBoxPnEndereco.Text = "";
            textBoxPnNome.Text = "";
            textBoxPnTelefone.Text = "";

        }

        private void btPnConsultasBuscar_Click(object sender, EventArgs e)
        {



        }

      
    }
}
