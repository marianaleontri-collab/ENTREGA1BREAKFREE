using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ENTREGA1BREAKFREE
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_consultas_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                int columnaConsultas = dataGridView1.Columns["promp1"].Index;
                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[columnaConsultas];
                dataGridView1.BeginEdit(true);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_asesoria_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                int columnaAsesorias = dataGridView1.Columns["promp2"].Index;
                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[columnaAsesorias];
                dataGridView1.BeginEdit(true);
            }
        }

        private void btn_usuarios_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                int columnaUsuarios = dataGridView1.Columns["promp3"].Index;
                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[columnaUsuarios];
                dataGridView1.BeginEdit(true);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            Form formulario = new Form2();
            formulario.Show();
            this.Hide();
        }
    }
}
