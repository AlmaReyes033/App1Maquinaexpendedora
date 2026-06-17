using System;
using System.Windows.Forms;

namespace Maquina_expendedora
{
    internal class Producto
    {
        
        private string nombre;
        private double costo;
        private int existencia;
        private int codigo;

        public int Codigo
        {
            get { return codigo; }
        }
        public string Nombre
        {
            get { return nombre; }
        }

        public double Costo
        {
            get { return costo; }
        }

        public int Existencia
        {
            get { return existencia; }
        }

        public Producto(int codigo, string nombre, double costo, int existencia)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.costo = costo;
            this.existencia = existencia;
        }

        public void ProcesarCompra(int cantidadAPedir)
        {
            
            if (cantidadAPedir <= 0)
            {                                                                        
                MessageBox.Show("La cantidad " + cantidadAPedir + " no es válida", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

         
            if (existencia >= cantidadAPedir)
            {
                double totalCobro = costo * cantidadAPedir;
                existencia = existencia - cantidadAPedir; 

                
                MessageBox.Show("Su compra ha sido un exito \n\n compro : " + cantidadAPedir + " unidades de " + nombre + "\nEl total a pagar es: $" + totalCobro, " Despachando Producto ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                         
                MessageBox.Show("Transacción rechazada.\nNo hay suficiente cantidad de " + nombre + "\n\nDisponible en máquina: " + existencia, "Sin Inventario", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        public void Abastecer(int cantNuevosProductos)
        {
            
            if (cantNuevosProductos > 0)
            {
                existencia = existencia + cantNuevosProductos;                                                                                        
                MessageBox.Show(" Usted añadio " + cantNuevosProductos + " productos " + "\nNueva existencia disponible de " + nombre + " : " + existencia, "Modo Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                
                MessageBox.Show("La cantidad ha sido rechazada", "Error de Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
