using MAQUINA_EXPENDEDORA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAFFETERIA.MAQUINA_EXPENDEDORA
{
    public partial class MaquinaExpendedora : Form
    {
        private Producto[] vitrina = new Producto[4];
        public MaquinaExpendedora()
        {
            InitializeComponent();
            InicializarProductos();
            ActualizarVitrina();
        }

        
        private void InicializarProductos()
        {
            vitrina[0] = new Producto(1, "CocaCola", 50.00, 30);
            vitrina[1] = new Producto(2, "Agua 600ml", 12.00, 20);
            vitrina[2] = new Producto(3, "Takis Fuego", 23.00, 12);
            vitrina[3] = new Producto(4, "Boing", 22.00, 9);

            
            cmbProductos.Items.Clear();
            foreach (Producto prod in vitrina)
            {
                cmbProductos.Items.Add(prod.Nombre);
            }

            
            if (cmbProductos.Items.Count > 0)
            {
                cmbProductos.SelectedIndex = 0;
            }
        }

      
        private void ActualizarVitrina()
        {
            txtVitrina.Items.Clear();
            txtVitrina.Items.Add("CODIGO  PRODUCTO    PRECIO    EXISTENCIA");
            txtVitrina.Items.Add("\n");

            for (int i = 0; i < vitrina.Length; i++)
            {
                string renglon = $"{vitrina[i].Codigo,-5}  {vitrina[i].Nombre,-12}  ${vitrina[i].Costo,-9}  {vitrina[i].Existencia,-6}";
                txtVitrina.Items.Add(renglon);
            }
        }

        
        private void btnComprar_Click(object sender, EventArgs e)
        {
            int posicionSeleccionada = cmbProductos.SelectedIndex;

            if (posicionSeleccionada >= 0)
            {
                
                int cantidad = (int)txtCantidad.Value;
               
                vitrina[posicionSeleccionada].ProcesarCompra(cantidad);
                ActualizarVitrina();
            }
        }

        // 4. BOTÓN SURTIR
        private void txtAbastecer_Click(object sender, EventArgs e)
        {
            int posicionSeleccionada = cmbProductos.SelectedIndex;

            if (posicionSeleccionada >= 0)
            {
                int piezasNuevas = (int)txtCantidad.Value;
                vitrina[posicionSeleccionada].Abastecer(piezasNuevas);

                ActualizarVitrina();
            }
        }

        private void MaquinaExp_Load(object sender, EventArgs e)
        {

        }

        private void txtCantidad_ValueChanged(object sender, EventArgs e)
        {

        }

        private void grpOperaciones_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}