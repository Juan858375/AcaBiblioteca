using System;
using System.Drawing;
using System.Windows.Forms;

namespace AcaBiblioteca
{
    public partial class FrmPrincipal : Form
    {
        private Form formularioActivo = null;

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void AbrirFormularioEnPanel(Form formularioHijo)
        {
            if (formularioActivo != null)
            {
                formularioActivo.Close();
            }

            formularioActivo = formularioHijo;
            formularioHijo.TopLevel = false;
            formularioHijo.FormBorderStyle = FormBorderStyle.None;
            formularioHijo.Dock = DockStyle.Fill;

            // Intenta usar pnlContenedor o el Panel que tengas en pantalla
            Control panelDestino = this.Controls["pnlContenedor"];
            if (panelDestino == null && this.Controls.Count > 0)
            {
                foreach (Control c in this.Controls)
                {
                    if (c is Panel)
                    {
                        panelDestino = c;
                        break;
                    }
                }
            }

            if (panelDestino != null)
            {
                panelDestino.Controls.Add(formularioHijo);
                panelDestino.Tag = formularioHijo;
                formularioHijo.BringToFront();
                formularioHijo.Show();
            }
            else
            {
                formularioHijo.Show();
            }
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new FrmInicio());
        }

        private void btnAutores_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new FrmAutores());
        }

        private void btnEditoriales_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new FrmEditoriales());
        }

        private void btnLibros_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new FrmLibros());
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new FrmUsuarios());
        }

        private void btnPrestamos_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new FrmPrestamos());
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new FrmReportes());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new FrmInicio());
        }
    }
}