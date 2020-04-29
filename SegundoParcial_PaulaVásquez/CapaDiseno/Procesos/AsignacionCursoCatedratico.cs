using CapaDiseno.Consultas;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDiseno.Procesos
{
    public partial class AsignacionCursoCatedratico : Form
    {
        Logica logic = new Logica();
        public AsignacionCursoCatedratico()
        {
            InitializeComponent();
            bloquear();
            Txt_1.Enabled = false;
            Txt_2.Enabled = false;
            Txt_3.Enabled = false;
            Txt_4.Enabled = false;
            Txt_5.Enabled = false;
            Txt_6.Enabled = false;
            Txt_7.Enabled = false;
        }
        public void limpiar()
        {
            Txt_1.Clear();
            Txt_2.Clear();
            Txt_3.Clear();
            Txt_4.Clear();
            Txt_5.Clear();
            Txt_6.Clear();
            Txt_7.Clear();
        }

        public void bloquear()
        {
            gpb_datos.Enabled = false;
        }

        public void desbloquear()
        {
            gpb_datos.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConsultMaestro concep = new ConsultMaestro();
            concep.ShowDialog();

            if (concep.DialogResult == DialogResult.OK)
            {
                Txt_1.Text = concep.Dgv_consulta1.Rows[concep.Dgv_consulta1.CurrentRow.Index].
                      Cells[0].Value.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ConsultCarrera concep = new ConsultCarrera();
            concep.ShowDialog();

            if (concep.DialogResult == DialogResult.OK)
            {
                Txt_2.Text = concep.Dgv_consulta2.Rows[concep.Dgv_consulta2.CurrentRow.Index].
                      Cells[0].Value.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ConsultSede concep = new ConsultSede();
            concep.ShowDialog();

            if (concep.DialogResult == DialogResult.OK)
            {
                Txt_3.Text = concep.Dgv_consulta2.Rows[concep.Dgv_consulta2.CurrentRow.Index].
                      Cells[0].Value.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            ConsultJornada concep = new ConsultJornada();
            concep.ShowDialog();

            if (concep.DialogResult == DialogResult.OK)
            {
                Txt_4.Text = concep.Dgv_consulta2.Rows[concep.Dgv_consulta2.CurrentRow.Index].
                      Cells[0].Value.ToString();
            }
        }

        private void Btn_consultaRuta_Click(object sender, EventArgs e)
        {

            ConsultSeccion concep = new ConsultSeccion();
            concep.ShowDialog();

            if (concep.DialogResult == DialogResult.OK)
            {
                Txt_5.Text = concep.Dgv_consulta2.Rows[concep.Dgv_consulta2.CurrentRow.Index].
                      Cells[0].Value.ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            ConsultAula concep = new ConsultAula();
            concep.ShowDialog();

            if (concep.DialogResult == DialogResult.OK)
            {
                Txt_6.Text = concep.Dgv_consulta2.Rows[concep.Dgv_consulta2.CurrentRow.Index].
                      Cells[0].Value.ToString();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

            ConsultCurso concep = new ConsultCurso();
            concep.ShowDialog();

            if (concep.DialogResult == DialogResult.OK)
            {
                Txt_7.Text = concep.Dgv_consulta2.Rows[concep.Dgv_consulta2.CurrentRow.Index].
                      Cells[0].Value.ToString();
            }
        }

        private void Btn_ingresar_Click(object sender, EventArgs e)
        {
            desbloquear();
        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
           
            OdbcDataReader cita = logic.guardar9( Txt_2.Text, Txt_3.Text,Txt_4.Text, Txt_5.Text, Txt_6.Text, Txt_7.Text, Txt_1.Text);
            MessageBox.Show("Datos registrados.");
            limpiar();
        }

        private void Btn_consultar_Click(object sender, EventArgs e)
        {
            ConsultAsignacion concep = new ConsultAsignacion();
            concep.ShowDialog();

            if (concep.DialogResult == DialogResult.OK)
            {
                Txt_2.Text = concep.Dgv_consulta1.Rows[concep.Dgv_consulta1.CurrentRow.Index].
                      Cells[0].Value.ToString();
                Txt_3.Text = concep.Dgv_consulta1.Rows[concep.Dgv_consulta1.CurrentRow.Index].
                      Cells[1].Value.ToString();
                Txt_4.Text = concep.Dgv_consulta1.Rows[concep.Dgv_consulta1.CurrentRow.Index].
                      Cells[2].Value.ToString();
                Txt_5.Text = concep.Dgv_consulta1.Rows[concep.Dgv_consulta1.CurrentRow.Index].
                      Cells[3].Value.ToString();
                Txt_6.Text = concep.Dgv_consulta1.Rows[concep.Dgv_consulta1.CurrentRow.Index].
                      Cells[4].Value.ToString();
                Txt_7.Text = concep.Dgv_consulta1.Rows[concep.Dgv_consulta1.CurrentRow.Index].
                     Cells[5].Value.ToString();
                Txt_1.Text = concep.Dgv_consulta1.Rows[concep.Dgv_consulta1.CurrentRow.Index].
                     Cells[6].Value.ToString();

            }
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
