using CapaDiseno.Consultas;
using CapaDiseno.Mantenimientos;
using CapaDiseno.Procesos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDiseno
{
    public partial class MDIParent1 : Form
    {
        private int childFormNumber = 0;

        public MDIParent1()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void toolStripStatusLabel_Click(object sender, EventArgs e)
        {

        }
        bool Mant_Uno = false;
        MantMaestro mant_uno = new MantMaestro();
        private void unoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is MantMaestro);
            if (Mant_Uno == false || frmC == null)
            {
                if (frmC == null)
                {
                    mant_uno = new MantMaestro();
                }

                mant_uno.MdiParent = this;
                mant_uno.Show();
                Application.DoEvents();
                Mant_Uno = true;
            }
            else
            {
                mant_uno.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }
        bool Proceso_Uno = false;
        Proceso proceso_uno = new Proceso();
        private void unoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Proceso);
            if (Proceso_Uno == false || frmC == null)
            {
                if (frmC == null)
                {
                    proceso_uno = new Proceso();
                }

                proceso_uno.MdiParent = this;
                proceso_uno.Show();
                Application.DoEvents();
                Proceso_Uno = true;
            }
            else
            {
                proceso_uno.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }
        bool Consult_Uno = false;
        ConsultMaestro consult_uno = new ConsultMaestro();
        private void unoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is ConsultMaestro);
            if (Consult_Uno == false || frmC == null)
            {
                if (frmC == null)
                {
                   consult_uno = new ConsultMaestro();
                }

                consult_uno.MdiParent = this;
                consult_uno.Show();
                Application.DoEvents();
                Consult_Uno = true;
            }
            else
            {
                consult_uno.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void maestroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        bool Mant_Dos = false;
        MantAulas mant_dos = new MantAulas();
        private void aulaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is MantAulas);
            if (Mant_Dos == false || frmC == null)
            {
                if (frmC == null)
                {
                    mant_dos = new MantAulas();
                }

                mant_dos.MdiParent = this;
                mant_dos.Show();
                Application.DoEvents();
                Mant_Dos = true;
            }
            else
            {
                mant_dos.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }
        bool Consult_Dos = false;
        ConsultAula consult_dos = new ConsultAula();
        private void aulaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is ConsultAula);
            if (Consult_Dos == false || frmC == null)
            {
                if (frmC == null)
                {
                    consult_dos = new ConsultAula();
                }

                consult_dos.MdiParent = this;
                consult_dos.Show();
                Application.DoEvents();
                Consult_Dos = true;
            }
            else
            {
                consult_dos.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }
        bool Mant_Tres = false;
        MantFacultad mant_tres = new MantFacultad();
        private void facultadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is MantFacultad);
            if (Mant_Tres == false || frmC == null)
            {
                if (frmC == null)
                {
                    mant_tres = new MantFacultad();
                }

                mant_tres.MdiParent = this;
                mant_tres.Show();
                Application.DoEvents();
                Mant_Tres = true;
            }
            else
            {
                mant_tres.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }
        bool Mant_4 = false;
        MantSeccion mant_4 = new MantSeccion();
        private void seccionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is MantSeccion);
            if (Mant_4 == false || frmC == null)
            {
                if (frmC == null)
                {
                    mant_4 = new MantSeccion();
                }

                mant_4.MdiParent = this;
                mant_4.Show();
                Application.DoEvents();
                Mant_4 = true;
            }
            else
            {
                mant_4.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }
        bool Mant_5 = false;
        MantSede mant_5 = new MantSede();
        private void sedesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is MantSede);
            if (Mant_5 == false || frmC == null)
            {
                if (frmC == null)
                {
                    mant_5 = new MantSede();
                }

                mant_5.MdiParent = this;
                mant_5.Show();
                Application.DoEvents();
                Mant_5 = true;
            }
            else
            {
                mant_5.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }
        bool Mant_6 = false;
        MantJornadas mant_6 = new MantJornadas();
        private void jornadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is MantJornadas);
            if (Mant_6 == false || frmC == null)
            {
                if (frmC == null)
                {
                    mant_6 = new MantJornadas();
                }

                mant_6.MdiParent = this;
                mant_6.Show();
                Application.DoEvents();
                Mant_6 = true;
            }
            else
            {
                mant_6.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }
        bool Mant_7 = false;
        MantCursos mant_7 = new MantCursos();
        private void cursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is MantCursos);
            if (Mant_7 == false || frmC == null)
            {
                if (frmC == null)
                {
                    mant_7 = new MantCursos();
                }

                mant_7.MdiParent = this;
                mant_7.Show();
                Application.DoEvents();
                Mant_7 = true;
            }
            else
            {
                mant_7.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }
        bool Proceso_Dos = false;
        Proceso proceso_dos = new Proceso();
        private void dosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Proceso);
            if (Proceso_Dos == false || frmC == null)
            {
                if (frmC == null)
                {
                    proceso_dos = new Proceso();
                }

                proceso_dos.MdiParent = this;
                proceso_dos.Show();
                Application.DoEvents();
                Proceso_Dos = true;
            }
            else
            {
                proceso_dos.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }
        bool Consult_3 = false;
        ConsultFacultad consult_3 = new ConsultFacultad();
        private void facultadToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is ConsultFacultad);
            if (Consult_3 == false || frmC == null)
            {
                if (frmC == null)
                {
                    consult_3 = new ConsultFacultad();
                }

                consult_3.MdiParent = this;
                consult_3.Show();
                Application.DoEvents();
                Consult_3 = true;
            }
            else
            {
                consult_3.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }
        bool Consult_4 = false;
        ConsultSeccion consult_4 = new ConsultSeccion();
        private void seccionesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is ConsultSeccion);
            if (Consult_4 == false || frmC == null)
            {
                if (frmC == null)
                {
                    consult_4 = new ConsultSeccion();
                }

                consult_4.MdiParent = this;
                consult_4.Show();
                Application.DoEvents();
                Consult_4 = true;
            }
            else
            {
                consult_4.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }
        bool Consult_5 = false;
        ConsultSede consult_5 = new ConsultSede();
        private void sedesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is ConsultSede);
            if (Consult_5 == false || frmC == null)
            {
                if (frmC == null)
                {
                    consult_5 = new ConsultSede();
                }

                consult_5.MdiParent = this;
                consult_5.Show();
                Application.DoEvents();
                Consult_5 = true;
            }
            else
            {
                consult_5.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }
        bool Consult_6 = false;
        ConsultJornada consult_6 = new ConsultJornada();
        private void jornadasToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is ConsultJornada);
            if (Consult_6 == false || frmC == null)
            {
                if (frmC == null)
                {
                    consult_6 = new ConsultJornada();
                }

                consult_6.MdiParent = this;
                consult_6.Show();
                Application.DoEvents();
                Consult_6 = true;
            }
            else
            {
                consult_6.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }
        bool Consult_7 = false;
        ConsultCurso consult_7 = new ConsultCurso();
        private void cursosToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is ConsultCurso);
            if (Consult_7 == false || frmC == null)
            {
                if (frmC == null)
                {
                    consult_7 = new ConsultCurso();
                }

                consult_7.MdiParent = this;
                consult_7.Show();
                Application.DoEvents();
                Consult_7 = true;
            }
            else
            {
                consult_7.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }
    }
}
