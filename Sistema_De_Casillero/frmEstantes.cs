using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_De_Casillero
{
    public partial class frmEstantes : Form
    {
        DBConexion conexion = new DBConexion();
        ComboBox cat = new ComboBox();

        public frmEstantes()
        {
            InitializeComponent();            
        }
                
        private void frmEstantes_Load(object sender, EventArgs e)
        {
            //Iniciando conexion a Base de Datos
            conexion.Conectar();
            //Cargando datos a la grid
            MostrarDatos();
            //Llenando cboCategorias
            Vaciar();

            conexion.ConsultaTR("Select E.id_estante as Código, E.numero_estante as Número, C.nombre_categoria as Categoría, " +
                "E.descripcion as Descripción from Estante as E inner Join Categoria as C On E.id_categoria=C.id_categoria ", ref conexion.ds, "Estante");
            conexion.miFiltro = ((DataTable)conexion.ds.Tables["Estante"]).DefaultView;
            dgvEstantes.DataSource = conexion.miFiltro;

        }

        public void MostrarDatos()
        {
            cboCategorias.DataSource = cat.CargarComboCategoria();
            cboCategorias.DisplayMember = "nombre_categoria";
            cboCategorias.ValueMember = "id_categoria";

            conexion.Consulta("Select E.id_estante as Código, E.numero_estante as Número, C.nombre_categoria as Categoría, " +
                "E.descripcion as Descripción from Estante as E inner Join Categoria as C On E.id_categoria=C.id_categoria", "Estante");
            dgvEstantes.DataSource = conexion.ds.Tables["Estante"];
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(txtCodEstante.Text))
            {
                txtCodEstante.Focus();
                lblErrorCodEstante.Visible = true;
            } 
            else if (cboCategorias.Text == "Seleccione...")
            {
                cboCategorias.Focus();
                lblErrorCat.Visible = true;
            }
            else
            {
                string queryAgregar = "Insert into Estante values ('" + txtCodEstante.Text + "', " + nudNumEstante.Value + ", " +
                                                                   "'" + cboCategorias.SelectedValue + "', '" + txtDescripcion.Text + "')";
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (conexion.Eliminar("Estante", "id_estante = '"+txtCodEstante.Text+"' "))
            {
                MessageBox.Show("Registro eliminado correctamente.");
                MostrarDatos();
            }
            else
            {
                MessageBox.Show("No se pudo eliminar el registro.");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string queryActualizar = "numero_estante =" + nudNumEstante.Value + ", id_categoria = '" + cboCategorias.SelectedValue + "', " +
                                    "descripcion = '" + txtDescripcion.Text + "'";
            if (conexion.Actualizar("Estante", queryActualizar, "id_estante = '" + txtCodEstante.Text + "'"))
            {
                MessageBox.Show("Datos actualizados correctamente.");
                MostrarDatos();
            }
            else
            {
                MessageBox.Show("No se pudo actualizar el registro.");
            }

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

        //Mostrar datos en los campos
        private void dgvEstantes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodEstante.Text = dgvEstantes.SelectedCells[0].Value.ToString();
            nudNumEstante.Value = dgvEstantes.SelectedCells[1].RowIndex+1;
            cboCategorias.Text  = dgvEstantes.SelectedCells[2].Value.ToString();
            txtDescripcion.Text = dgvEstantes.SelectedCells[3].Value.ToString();
        }
                
        private void Vaciar()
        {
            txtCodEstante.Clear();
            nudNumEstante.Value = 1;
            cboCategorias.Text = "Seleccione...";
            txtDescripcion.Clear();
          
        }
                
        

        private void txtCodEstante_KeyUp(object sender, KeyEventArgs e)
        {
            lblErrorCodEstante.Visible = false;
        }

        private void cboCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblErrorCat.Visible = false;
        }

    }
}
