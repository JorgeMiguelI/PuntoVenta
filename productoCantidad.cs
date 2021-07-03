using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaAbarrotes
{
    class productoCantidad
    {
        public int id_Producto;
        public double cantidad;
    

        public productoCantidad(int id_Producto, double cantidad)
        {
            this.id_Producto = id_Producto;
            this.cantidad = cantidad;
        }

  


        public void SetCantidad(int cantidad)
        {
            this.cantidad = this.cantidad + cantidad;
        }

    }
}
