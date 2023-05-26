using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_De_Casillero
{
    public partial class frmCategorias : Form
    {
        DBConexion conexion = new DBConexion();

        public frmCategorias()
        {
            InitializeComponent();
        }

        private void frmCategorias_Load(object sender, EventArgs e)
        {
            //Iniciando conexion a Base de Datos
            conexion.Conectar();
            //Cargando datos a la grid
            MostrarDatos();
            Vaciar();

            conexion.ConsultaTR("Select id_categoria as Código, nombre_categoria as Categoría, descripcion as Descripción from Categoria ", ref conexion.ds, "Categoria");
            conexion.miFiltro = ((DataTable)conexion.ds.Tables["Categoria"]).DefaultView;
            dgvCategorias.DataSource = conexion.miFiltro;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodCat.Text))
            {
                txtCodCat.Focus();
                lblErrorCod.Visible = true;
            }
            else if (string.IsNullOrEmpty(txtCategoria.Text))
            {
                txtCategoria.Focus();
                lblErrorCat.Visible = true;
            }
            else
            {
                string queryAgregar = "Insert into Categoria values ('" + txtCodCat.Text + "', '" + txtCategoria.Text + "', '" + txtDescripcion.Text + "')";
                if (conexion.Insertar(queryAgregar))
                {
                    MessageBox.Show("Datos agregados correctamente.");
                    MostrarDatos();
                }
                else
                {
                    MessageBox.Show("Error al agregar.");
                }
                Vaciar();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string queryActualizar = "nombre_categoria = '"+txtCategoria.Text+"', descripcion = '" + txtDescripcion.Text + "'";
            if (conexion.Actualizar("Categoria", queryActualizar, "id_categoria = '" + txtCodCat.Text + "'"))
            {
                MessageBox.Show("Datos actualizados correctamente.");
                MostrarDatos();
            }
            else
            {
                MessageBox.Show("No se pudo actualizar el registro.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (conexion.Eliminar("Categoria", "id_categoria = '" + txtCodCat.Text + "' "))
            {
                MessageBox.Show("Registro eliminado correctamente.");
                MostrarDatos();
            }
            else
            {
                MessageBox.Show("No se pudo eliminar el registro.");
            }
        }

        public void MostrarDatos()
        {

            conexion.Consulta("Select id_categoria as Código, nombre_categoria as Categoría, descripcion as Descripción from Categoria", "Categoria");
            dgvCategorias.DataSource = conexion.ds.Tables["Categoria"];
        }

        private void Vaciar()
        {
            txtCodCat.Clear();
            txtCategoria.Clear();
            txtDescripcion.Clear();

        }

        private void dgvCategorias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodCat.Text = dgvCategorias.SelectedCells[0].Value.ToString();
            txtCategoria.Text = dgvCategorias.SelectedCells[1].Value.ToString();
            txtDescripcion.Text = dgvCategorias.SelectedCells[2].Value.ToString();
        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {

            Vaciar();
            string salida = "";
            string[] palabras_busqueda = this.txtBuscar.Text.Split(' ');
            foreach (string palabra in palabras_busqueda)
            {
                if (salida.Length == 0)
                {
                    salida = " (Código LIKE '%" + palabra + "%'  OR Descripción LIKE '%" + palabra + "%' OR Categoría LIKE '%" + palabra + "%')";
                }
                else
                {
                    salida += " AND (Código LIKE '%" + palabra + "%' OR Descripción LIKE '%" + palabra + "%' OR Categoría LIKE '%" + palabra + "%')";
                }
            }
            conexion.miFiltro.RowFilter = salida;
        }

        private void txtCodCat_KeyUp(object sender, KeyEventArgs e)
        {
            lblErrorCod.Visible = false;
        }

        private void txtCategoria_KeyUp(object sender, KeyEventArgs e)
        {
            lblErrorCat.Visible = false;
        }
    }
}
