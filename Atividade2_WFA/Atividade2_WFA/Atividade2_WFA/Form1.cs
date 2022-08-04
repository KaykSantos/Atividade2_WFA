using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;

namespace Atividade2_WFA
{
    public partial class Form1 : Form
    {
        string nome, email, senha, cpf, rg, logradouro, cidade, UF, pais, numero;

        private void listaToDoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaTarefas tarefas = new ListaTarefas();
            tarefas.Show();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void excelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process prcExecutor = new Process();
            prcExecutor.StartInfo.FileName = "C:\\Program Files\\Microsoft Office\\root\\Office16\\excel";
            prcExecutor.Start();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "O Aplicativo será encerrado! Deseja prosseguir?";
            string caption = "Atenção";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                MessageBox.Show("O aplicativo será encerrado!", "Encerrando", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Aperte OK para continuar!", "OK", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void wordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process prcExecutor = new Process();
            prcExecutor.StartInfo.FileName = "C:\\Program Files\\Microsoft Office\\root\\Office16\\winword";
            prcExecutor.Start();
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process prcExecutor = new Process();
            prcExecutor.StartInfo.FileName = "Calc.Exe";
            prcExecutor.Start();
        }

        private void lerArquivosDeTextoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lerArquivo formLer = new lerArquivo();
            formLer.Show();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            nome = txtBoxName.Text;
            email = txtBoxEmail.Text;
            senha = txtBoxSenha.Text;
            cpf = txtBoxCPF.Text;
            rg = txtBoxRG.Text;

            logradouro = txtBoxLogradouro.Text;
            cidade = txtBoxCidade.Text;
            UF = txtBoxUF.Text;
            pais = txtBoxPais.Text;
            numero = txtBoxNumero.Text;

            toolStripStatusLabel1.Text = "Cadastrando usuário. Tempo: 3 segundos";
            statusStrip1.Refresh();
            Thread.Sleep(1000);

            toolStripStatusLabel1.Text = "Cadastrando usuário. Tempo: 2 segundos";
            statusStrip1.Refresh();
            Thread.Sleep(1000);

            toolStripStatusLabel1.Text = "Cadastrando usuário. Tempo: 1 segundos";
            statusStrip1.Refresh();
            Thread.Sleep(1000);

            toolStripStatusLabel1.Text = "Cadastro finalizado!";
            MessageBox.Show("Cadastro finalizado com sucesso!");
            
        }
    }
}
