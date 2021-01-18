using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class CEpedido
    {
        private int id_pedido;
        private int id_producto1;
        private int cantidad_producto;
        private int id_cliente1;
        private double total;
        private DateTime fecha_creacion;
        private DateTime fecha_entrega;

        public int Id_pedido { get => id_pedido; set => id_pedido = value; }
        public int Id_producto1 { get => id_producto1; set => id_producto1 = value; }
        public int Cantidad_producto { get => cantidad_producto; set => cantidad_producto = value; }
        public int Id_cliente1 { get => id_cliente1; set => id_cliente1 = value; }
        public double Total { get => total; set => total = value; }
        public DateTime Fecha_creacion { get => fecha_creacion; set => fecha_creacion = value; }
        public DateTime Fecha_entrega { get => fecha_entrega; set => fecha_entrega = value; }
    }
}
