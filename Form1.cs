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
    public partial class Form1 : Form
    {
        Thread nt;
        

        public Form1()
        {
            InitializeComponent();
         
        }
                                 
        
        private void BotaoEntrar_Click(object sender, EventArgs e)
        {

            //ADICIONAR O CADASTRAR
            // ABA PARA PACIENTE
            if (textboxLogin.Text == "murilo" && textboxSenha.Text == "1234")
            {
              
                this.Close();

                nt = new Thread(novoForm);
                nt.SetApartmentState(ApartmentState.STA);
                nt.Start();

            }
            else
            {
                MessageBox.Show("Login ou senha Incorreta");
            }

        }

        private void novoForm()
        {
            Application.Run(new Form2());
        }

        private void botaoSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
