using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alum2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rbtMasculino_CheckedChanged(object sender, EventArgs e)
        {
            



           
        }

        private void Registrar_Click(object sender, EventArgs e)
        {
            Alumnos a = new Alumnos();
            a.pLegajo = Convert.ToInt32(txtLegajo.Text);
            a.pNombre = txtNombre.Text;
            a.pApellido = txtApellido.Text;
            if (rbtDni.Checked)
                a.pTipoDoc = 1;
            else
                if (rbtCedula.Checked)
                    a.pTipoDoc = 2;
                else
                    if (rbtPasaporte.Checked)
                        a.pTipoDoc = 3;
                    else
                        a.pTipoDoc = 4;
            a.pDoc = Convert.ToInt32(txtNroDocumento.Text);
            a.pSexo = rbtMasculino.Checked;
            a.pNota1 = double.Parse(txtNota1.Text);
            a.pNota2 = double.Parse(txtNota2.Text);
            a.pNota3 = double.Parse(txtNota3.Text);
            a.pFechaNacimiento = dtpFechaNac.Value;

            MessageBox.Show(a.toStringAlumnos());
        }
    }
}
