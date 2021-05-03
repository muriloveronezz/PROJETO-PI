
namespace ProjetoPI
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.voltar = new System.Windows.Forms.Button();
            this.sair = new System.Windows.Forms.Button();
            this.botaoConsultas = new System.Windows.Forms.Button();
            this.panelNovaConsulta = new System.Windows.Forms.Panel();
            this.btpnLimpar = new System.Windows.Forms.Button();
            this.btpnCadastro = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPnEndereco = new System.Windows.Forms.TextBox();
            this.textBoxPncpf = new System.Windows.Forms.TextBox();
            this.textBoxPnTelefone = new System.Windows.Forms.TextBox();
            this.textBoxPnNome = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.botaoNovaConsulta = new System.Windows.Forms.Button();
            this.panelConsultas = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.listBoxPacientes = new System.Windows.Forms.ListBox();
            this.btPnConsultasBuscar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panelNovaConsulta.SuspendLayout();
            this.panelConsultas.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // voltar
            // 
            this.voltar.Location = new System.Drawing.Point(309, 34);
            this.voltar.Name = "voltar";
            this.voltar.Size = new System.Drawing.Size(122, 23);
            this.voltar.TabIndex = 9;
            this.voltar.Text = "Voltar";
            this.voltar.UseVisualStyleBackColor = true;
            this.voltar.Click += new System.EventHandler(this.voltar_Click);
            // 
            // sair
            // 
            this.sair.Location = new System.Drawing.Point(309, 63);
            this.sair.Name = "sair";
            this.sair.Size = new System.Drawing.Size(122, 23);
            this.sair.TabIndex = 8;
            this.sair.Text = "Deslogar";
            this.sair.UseVisualStyleBackColor = true;
            this.sair.Click += new System.EventHandler(this.sair_Click);
            // 
            // botaoConsultas
            // 
            this.botaoConsultas.Location = new System.Drawing.Point(162, 63);
            this.botaoConsultas.Name = "botaoConsultas";
            this.botaoConsultas.Size = new System.Drawing.Size(122, 23);
            this.botaoConsultas.TabIndex = 7;
            this.botaoConsultas.Text = "Consultas";
            this.botaoConsultas.UseVisualStyleBackColor = true;
            this.botaoConsultas.Click += new System.EventHandler(this.botaoConsultas_Click);
            // 
            // panelNovaConsulta
            // 
            this.panelNovaConsulta.Controls.Add(this.btpnLimpar);
            this.panelNovaConsulta.Controls.Add(this.btpnCadastro);
            this.panelNovaConsulta.Controls.Add(this.label4);
            this.panelNovaConsulta.Controls.Add(this.textBoxPnEndereco);
            this.panelNovaConsulta.Controls.Add(this.textBoxPncpf);
            this.panelNovaConsulta.Controls.Add(this.textBoxPnTelefone);
            this.panelNovaConsulta.Controls.Add(this.textBoxPnNome);
            this.panelNovaConsulta.Controls.Add(this.label6);
            this.panelNovaConsulta.Controls.Add(this.label5);
            this.panelNovaConsulta.Controls.Add(this.label3);
            this.panelNovaConsulta.Controls.Add(this.label2);
            this.panelNovaConsulta.Controls.Add(this.label1);
            this.panelNovaConsulta.Location = new System.Drawing.Point(12, 120);
            this.panelNovaConsulta.Name = "panelNovaConsulta";
            this.panelNovaConsulta.Size = new System.Drawing.Size(521, 437);
            this.panelNovaConsulta.TabIndex = 6;
            this.panelNovaConsulta.Visible = false;
            // 
            // btpnLimpar
            // 
            this.btpnLimpar.Location = new System.Drawing.Point(249, 245);
            this.btpnLimpar.Name = "btpnLimpar";
            this.btpnLimpar.Size = new System.Drawing.Size(103, 42);
            this.btpnLimpar.TabIndex = 14;
            this.btpnLimpar.Text = "Limpar";
            this.btpnLimpar.UseVisualStyleBackColor = true;
            this.btpnLimpar.Click += new System.EventHandler(this.btpnLimpar_Click);
            // 
            // btpnCadastro
            // 
            this.btpnCadastro.Location = new System.Drawing.Point(130, 245);
            this.btpnCadastro.Name = "btpnCadastro";
            this.btpnCadastro.Size = new System.Drawing.Size(103, 42);
            this.btpnCadastro.TabIndex = 13;
            this.btpnCadastro.Text = "Cadastrar";
            this.btpnCadastro.UseVisualStyleBackColor = true;
            this.btpnCadastro.Click += new System.EventHandler(this.btpnCadastro_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(224, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 22);
            this.label4.TabIndex = 12;
            this.label4.Text = "Cadastro";
            // 
            // textBoxPnEndereco
            // 
            this.textBoxPnEndereco.Location = new System.Drawing.Point(25, 136);
            this.textBoxPnEndereco.Name = "textBoxPnEndereco";
            this.textBoxPnEndereco.Size = new System.Drawing.Size(100, 20);
            this.textBoxPnEndereco.TabIndex = 11;
            // 
            // textBoxPncpf
            // 
            this.textBoxPncpf.Location = new System.Drawing.Point(159, 87);
            this.textBoxPncpf.Name = "textBoxPncpf";
            this.textBoxPncpf.Size = new System.Drawing.Size(100, 20);
            this.textBoxPncpf.TabIndex = 10;
            // 
            // textBoxPnTelefone
            // 
            this.textBoxPnTelefone.Location = new System.Drawing.Point(159, 136);
            this.textBoxPnTelefone.Name = "textBoxPnTelefone";
            this.textBoxPnTelefone.Size = new System.Drawing.Size(100, 20);
            this.textBoxPnTelefone.TabIndex = 9;
            // 
            // textBoxPnNome
            // 
            this.textBoxPnNome.Location = new System.Drawing.Point(25, 87);
            this.textBoxPnNome.Name = "textBoxPnNome";
            this.textBoxPnNome.Size = new System.Drawing.Size(100, 20);
            this.textBoxPnNome.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(156, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "CPF ou RG";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(156, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(156, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Endereço";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome completo";
            // 
            // botaoNovaConsulta
            // 
            this.botaoNovaConsulta.Location = new System.Drawing.Point(162, 34);
            this.botaoNovaConsulta.Name = "botaoNovaConsulta";
            this.botaoNovaConsulta.Size = new System.Drawing.Size(122, 23);
            this.botaoNovaConsulta.TabIndex = 5;
            this.botaoNovaConsulta.Text = "Nova Consulta";
            this.botaoNovaConsulta.UseVisualStyleBackColor = true;
            this.botaoNovaConsulta.Click += new System.EventHandler(this.botaoNovaConsulta_Click);
            // 
            // panelConsultas
            // 
            this.panelConsultas.Controls.Add(this.label10);
            this.panelConsultas.Controls.Add(this.label9);
            this.panelConsultas.Controls.Add(this.listBox1);
            this.panelConsultas.Controls.Add(this.label8);
            this.panelConsultas.Controls.Add(this.textBox1);
            this.panelConsultas.Controls.Add(this.label7);
            this.panelConsultas.Controls.Add(this.listBoxPacientes);
            this.panelConsultas.Controls.Add(this.btPnConsultasBuscar);
            this.panelConsultas.Location = new System.Drawing.Point(71, 105);
            this.panelConsultas.Name = "panelConsultas";
            this.panelConsultas.Size = new System.Drawing.Size(614, 437);
            this.panelConsultas.TabIndex = 10;
            this.panelConsultas.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(285, 86);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Historico de Consultas";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(460, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "ficha do paciente";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(438, 102);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(150, 160);
            this.listBox1.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(242, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 22);
            this.label8.TabIndex = 15;
            this.label8.Text = "Consultas";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(145, 126);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(124, 20);
            this.textBox1.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Nome do Paciente";
            // 
            // listBoxPacientes
            // 
            this.listBoxPacientes.FormattingEnabled = true;
            this.listBoxPacientes.Location = new System.Drawing.Point(275, 102);
            this.listBoxPacientes.Name = "listBoxPacientes";
            this.listBoxPacientes.Size = new System.Drawing.Size(157, 160);
            this.listBoxPacientes.TabIndex = 2;
            // 
            // btPnConsultasBuscar
            // 
            this.btPnConsultasBuscar.Location = new System.Drawing.Point(145, 245);
            this.btPnConsultasBuscar.Name = "btPnConsultasBuscar";
            this.btPnConsultasBuscar.Size = new System.Drawing.Size(124, 32);
            this.btPnConsultasBuscar.TabIndex = 0;
            this.btPnConsultasBuscar.Text = "Buscar";
            this.btPnConsultasBuscar.UseVisualStyleBackColor = true;
            this.btPnConsultasBuscar.Click += new System.EventHandler(this.btPnConsultasBuscar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(437, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Relatorios";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Location = new System.Drawing.Point(691, 105);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(451, 303);
            this.panel1.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(37, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Relatorios";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(37, 65);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(112, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Total de atendimentos";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(37, 103);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(98, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Tempo da consulta";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(438, 63);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Ficha Paciente";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(40, 135);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(172, 13);
            this.label14.TabIndex = 3;
            this.label14.Text = "Pacientes que não compareceram ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(40, 164);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 13);
            this.label15.TabIndex = 4;
            this.label15.Text = "label15";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1329, 686);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panelConsultas);
            this.Controls.Add(this.panelNovaConsulta);
            this.Controls.Add(this.voltar);
            this.Controls.Add(this.sair);
            this.Controls.Add(this.botaoConsultas);
            this.Controls.Add(this.botaoNovaConsulta);
            this.Name = "Form2";
            this.Text = "Form2";
            this.panelNovaConsulta.ResumeLayout(false);
            this.panelNovaConsulta.PerformLayout();
            this.panelConsultas.ResumeLayout(false);
            this.panelConsultas.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button voltar;
        private System.Windows.Forms.Button sair;
        private System.Windows.Forms.Button botaoConsultas;
        private System.Windows.Forms.Panel panelNovaConsulta;
        private System.Windows.Forms.TextBox textBoxPnEndereco;
        private System.Windows.Forms.TextBox textBoxPncpf;
        private System.Windows.Forms.TextBox textBoxPnTelefone;
        private System.Windows.Forms.TextBox textBoxPnNome;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button botaoNovaConsulta;
        private System.Windows.Forms.Button btpnLimpar;
        private System.Windows.Forms.Button btpnCadastro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelConsultas;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox listBoxPacientes;
        private System.Windows.Forms.Button btPnConsultasBuscar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button2;
    }
}