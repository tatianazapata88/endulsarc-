using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace CapaDato
{
    public class CDpedido
    {
        CConexion oconexion = new CConexion();
        SqlCommand ocmd = new SqlCommand();

        public bool guardar(CEpedido opedido)
        {
            try
            {
                ocmd.CommandType = CommandType.StoredProcedure;
                ocmd.Connection = oconexion.conectar("BDendulsar");
                ocmd.CommandText = "crear_pedido";
                ocmd.Parameters.Add("@id_pedido", opedido.Id_pedido);
                ocmd.Parameters.Add("@id_producto1", opedido.Id_producto1);
                ocmd.Parameters.Add("@cantidad_producto", opedido.Cantidad_producto);
                ocmd.Parameters.Add("@id_cliente1", opedido.Id_cliente1);
                ocmd.Parameters.Add("@total", opedido.Total);
                ocmd.Parameters.Add("@fecha_creacion", opedido.Fecha_creacion);
                ocmd.Parameters.Add("@fecha_entrega", opedido.Fecha_entrega);

                ocmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception err)
            {
                throw new Exception(err.Message); // Es mensaje de error

            }
        }



        //metodo listar pedidos
        public DataSet listar_Pedidos(CEpedido opedido)
        {
            try
            {
                ocmd.CommandType = CommandType.StoredProcedure;
                ocmd.Connection = oconexion.conectar("BDendulsar");
                ocmd.CommandText = "listarPedidos";
                ocmd.Parameters.Add("@fecha_entrega", opedido.Fecha_entrega);
                SqlDataAdapter da = new SqlDataAdapter(ocmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;

            }
            catch (Exception err)
            {
                throw new Exception(err.Message); // Es mensaje de error

            }
        }

        //metodo eliminar pedido
        public bool eliminapedido(CEpedido opedido)
        {
            try
            {
                ocmd.CommandType = CommandType.StoredProcedure;
                ocmd.Connection = oconexion.conectar("BDendulsar");
                ocmd.CommandText = "eliminarpedido";
                ocmd.Parameters.Add("@id_pedido", opedido.Id_pedido);
                ocmd.ExecuteNonQuery();
                return true;

            }
            catch (Exception err)
            {
                throw new Exception(err.Message); // Es mensaje de error

            }
        }
    }
}
    

