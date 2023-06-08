using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppAgenda
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void tableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bdAgendaDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bdAgendaDataSet.Table'. Você pode movê-la ou removê-la conforme necessário.
            this.tableTableAdapter.Fill(this.bdAgendaDataSet.Table);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.tableTableAdapter.FillByName(this.bdAgendaDataSet.Table,textBox1.Text+"%");

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.tableTableAdapter.FillByName(this.bdAgendaDataSet.Table, textBox1.Text + "%");
        }
    }
}
