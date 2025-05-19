using ProyectoFinal.Datos;
using ProyectoFinal.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class FrmServicios : Form
    {
        CLservicios cl_servicios = new CLservicios();
        CDservicios cd_servicios = new CDservicios();
        public FrmServicios()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(cboxTipo.Text) || string.IsNullOrEmpty(txtPrecio.Text) ||
               string.IsNullOrEmpty(dtpFechaVigencia.Text) || string.IsNullOrEmpty(dtpFechaVencimiento.Text) || string.IsNullOrEmpty(cboxEstado.Text))
            {
                MessageBox.Show("Favor ingresar todos los datos en pantalla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    string Nombre = txtNombre.Text;
                    string Tipo = cboxTipo.Text;
                    double Precio = cl_servicios.MtdPrecioServicio(Tipo);
                    DateTime FechaVigencia = dtpFechaVigencia.Value;
                    DateTime FechaVencimiento = dtpFechaVencimiento.Value;
                    string Estado = cboxEstado.Text;
                    string UsuarioSistema = "Yulian";

                    cd_habitaciones.MtdAgregarhabitacion(Numero, Ubicacion, Tipo, Precio, FechaSistema, Estado, UsuarioSistema);
                    MessageBox.Show("Habitacion agregada", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MtdConsultarHabitaciones();
                    MtdLimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void FrmServicios_Load(object sender, EventArgs e)
        {

        }
    
    }
}
