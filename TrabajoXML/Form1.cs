using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoXML
{
    public partial class Form1 : Form
    {
        //terminado
        Xml mixml = new Xml();
        string ruta;
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
            if (!txtObjeto.Text.Equals(string.Empty) && !ruta.Equals(string.Empty))
            {
                tabPage2.Enabled = true;
                mixml._crearXml(ruta, txtObjeto.Text.ToString());
                Limpiar();
            }
        }
        public void Limpiar()
        {
            txtObjeto.Clear();
            txtIdAgre.Clear();
            txtIdDel.Clear();
            txtIdMod.Clear();
            txtNombreAgre.Clear();
            txtNombreMod.Clear();
            txtApellidosAgre.Clear();
            txtApellidosMod.Clear();
            txtDireccionAgre.Clear();
            txtDireccionMod.Clear();
            txtInfo_xml.Clear();
        }
        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("Ingrese la direccion y el tipo");
            tabPage2.Enabled = false;
            tabPage3.Enabled = false;
            tabPage4.Enabled = false;
            tabPage5.Enabled = false;
        }

        private void btnGuardarAgre_Click(object sender, EventArgs e)
        {
            if (!(txtIdAgre.Text.Equals(string.Empty) && txtNombreAgre.Text.Equals(string.Empty) &&
                 txtApellidosAgre.Text.Equals(string.Empty) && txtDireccionAgre.Text.Equals(string.Empty)))
            {
                mixml._Añadir(txtIdAgre.Text.ToString(), txtNombreAgre.Text.ToString(), txtApellidosAgre.Text.ToString(), txtDireccionAgre.Text.ToString());
                tabPage3.Enabled = true;
                tabPage4.Enabled = true;
                tabPage5.Enabled = true;
                MessageBox.Show("Agregado");
                Limpiar();
            }
            else
            {
                MessageBox.Show("Hay campos en blanco");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (!(txtIdMod.Text.Equals(string.Empty) && txtNombreMod.Text.Equals(string.Empty) &&
                 txtApellidosMod.Text.Equals(string.Empty) && txtDireccionMod.Text.Equals(string.Empty)))
            {
                mixml._UpdateXml(txtIdMod.Text.ToString(), txtNombreMod.Text.ToString(), txtApellidosMod.Text.ToString(), txtDireccionMod.Text.ToString());
                MessageBox.Show("Modificado");
                Limpiar();
            }
            else
            {
                MessageBox.Show("Hay campos en blanco");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (!txtIdDel.Text.Equals(string.Empty))
            {
                mixml._DeleteNodo(txtIdDel.Text.ToString());
                MessageBox.Show("Eliminado");
                Limpiar();
            }
            else
            {
                MessageBox.Show("El campo esta en blanco");
            }
        }

        private void btnBuscarRuta_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    ruta = openFileDialog1.FileName;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Aqui empieza: " + ex);
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtInfo_xml.Text = mixml._ReadXml();
        }
    }
}
