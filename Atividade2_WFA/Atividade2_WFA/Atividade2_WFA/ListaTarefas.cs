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
    public partial class ListaTarefas : Form
    {
        public ListaTarefas()
        {
            InitializeComponent();
        }

        private void btnAdicioanr_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(txtBoxTarefa.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtBoxTarefa.Text = "";
            dataGridView1.Rows.Clear();
        }
    }
}
