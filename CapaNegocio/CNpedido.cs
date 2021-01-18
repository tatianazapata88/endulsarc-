using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDato;
using CapaEntidad;
using System.Data;


namespace CapaNegocio
{
    public class CNpedido
    {
        CDpedido odatpedido = new CDpedido();

        public bool crear_pedido(CEpedido oentpedido)
        {
            return odatpedido.guardar(oentpedido);
        }

        public bool eliminar_pedido(CEpedido oentpedido)
        {
            return odatpedido.eliminarpedido(oentpedido);
        }

        public DataSet consultar_pedido(CEpedido oentpedido)
        {
            return odatpedido.listarPedidos(oentpedido);
        }


    }
}
