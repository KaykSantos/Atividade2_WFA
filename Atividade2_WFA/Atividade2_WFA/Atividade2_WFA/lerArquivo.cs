using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade2_WFA
{
    public partial class lerArquivo : Form
    {
        string arquivo = "";
        public lerArquivo()
        {
            InitializeComponent();
        }

        private void abrirToolStripButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Abrir arquivo de texto";
            dialog.InitialDirectory = @"C:\Documentos";
            dialog.Filter = "todos arquivos|*.txt;*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                arquivo = dialog.FileName;
                AbrirArquivo(arquivo);
            }
        }
        public void AbrirArquivo(string filepath)
        {
            var conteudo = "";
            try
            {
                string[] linhas = System.IO.File.ReadAllLines(filepath);
                foreach (string linha in linhas)
                    conteudo = String.Concat(conteudo, linha, "\n");
                richTextBox1.Text = conteudo;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao abrir o arquivo!\n\n{ex.Message}");
            }
        }

        private void salvarToolStripButton_Click(object sender, EventArgs e)
        {
            if (arquivo != "")
            {
                SalvarArquivo();
                MessageBox.Show("Arquivo salvo!");
            }
            else
                MessageBox.Show("Primeiro abra e altere um arquivo!");
        }
        private void SalvarArquivo()
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(arquivo))
            {
                foreach (string linha in richTextBox1.Lines)
                    file.WriteLine(linha);
            }
        }

        private void novoToolStripButton_Click(object sender, EventArgs e)
        {
            arquivo = "";
            richTextBox1.Text = "";

        }
    }
}
