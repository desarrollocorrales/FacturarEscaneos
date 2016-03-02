using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using FacturarEscaneos.Modelos;
using System.Data;

namespace FacturarEscaneos.DAL
{
    public class MySQL_DAL
    {
        MySqlConnection MyConn;
        MySqlCommand MyComm;
        MySqlDataAdapter MyAdapter;

        public MySQL_DAL()
        {
            MyConn = new MySqlConnection(getConnectionString());
            MyComm = new MySqlCommand();
            MyAdapter = new MySqlDataAdapter();
        }

        private string getConnectionString()
        {
            MySqlConnectionStringBuilder MyCSB = new MySqlConnectionStringBuilder();

            MyCSB.Server   = "servidorx";
            MyCSB.Database = "seguimiento_acc";
            MyCSB.UserID   = "etiquetas";
            MyCSB.Password = "corrales";
            MyCSB.Port = 3306;

            return MyCSB.ToString();
        }

        public List<VistaPrevia> getDatosEscaneo(string sCodigoSalida)
        {
            List<VistaPrevia> lstDatosEscaneo = new List<VistaPrevia>();

            try
            {
                MyConn.Open();

                MyComm.Connection = MyConn;
                MyComm.CommandText =
                    string.Format(@"SELECT 
	                                    e.clave_articulo,
                                        a.articulo,
                                        SUM(e.cantidad) as cantidad, 
                                        e.unidad
                                    FROM
                                        seguimiento_acc.vista_entregas_sucursales ves
                                        INNER JOIN seguimiento_acc.etiquetas e ON e.numero_etiqueta = ves.numero_etiqueta
                                        INNER JOIN seguimiento_acc.articulos a ON e.clave_articulo = a.clave 
                                    WHERE
                                        ves.codigo_salida LIKE '{0}'
                                    GROUP BY
	                                    e.clave_articulo,
                                        a.articulo,
                                        e.unidad
                                    ORDER BY
	                                    clave_articulo", sCodigoSalida);
                MyAdapter.SelectCommand = MyComm;

                DataTable dtResultado = new DataTable();
                MyAdapter.Fill(dtResultado);

                VistaPrevia datos;
                foreach (DataRow row in dtResultado.Rows)
                {
                    datos = new VistaPrevia();
                    datos.sClaveArticulo = Convert.ToString(row["clave_articulo"]);
                    datos.sNombreArticulo = Convert.ToString(row["articulo"]);
                    datos.dCantidad = Convert.ToDecimal(row["cantidad"]);
                    datos.sUnidad = Convert.ToString(row["unidad"]);

                    lstDatosEscaneo.Add(datos);
                }

                MyConn.Close();
            }
            catch (Exception ex)
            {
                if (MyConn.State != ConnectionState.Closed)
                    MyConn.Close();
                throw ex;
            }

            return lstDatosEscaneo;
        }
        public List<string> getSalidasPorDia(DateTime fecha)
        {
            string fecha1 = fecha.ToString("yyyy-MM-dd");
            string fecha2 = fecha.AddDays(1).ToString("yyyy-MM-dd");

            List<string> lstCodigosDeSalida = new List<string>();

            try
            {
                MyConn.Open();

                MyComm.Connection = MyConn;
                MyComm.CommandText =
                    string.Format(@"SELECT distinct
                                        codigo_salida
                                    FROM
                                        vista_entregas_sucursales 
                                    WHERE
                                        fecha BETWEEN '{0}' AND '{1}'
                                    ORDER BY fecha", fecha1, fecha2);
                MyAdapter.SelectCommand = MyComm;

                DataTable dtResultado = new DataTable();
                MyAdapter.Fill(dtResultado);

                string codigo;
                foreach (DataRow row in dtResultado.Rows)
                {
                    codigo = Convert.ToString(row["codigo_salida"]);

                    lstCodigosDeSalida.Add(codigo);
                }

                MyConn.Close();
            }
            catch (Exception ex)
            {
                if (MyConn.State != ConnectionState.Closed)
                    MyConn.Close();
                throw ex;
            }

            return lstCodigosDeSalida;
        }
        public List<VistaPrevia> getDetallesPedido(List<string> lstCodigosDeSalida)
        {
            try
            {
                List<VistaPrevia> lstDetalles = new List<VistaPrevia>();

                var sCodigosWhere = string.Empty;
                foreach (string sCodigo in lstCodigosDeSalida)
                {
                    sCodigosWhere += string.Format("'{0}', ", sCodigo);
                }
                sCodigosWhere += "'X'";

                MyConn.Open();
                MyComm.Connection = MyConn;
                MyComm.CommandText =
                      string.Format(@"SELECT 
	                                        e.clave_articulo,
                                            a.articulo,
                                            SUM(e.cantidad) as cantidad, 
                                            e.unidad
                                        FROM
                                            seguimiento_acc.vista_entregas_sucursales ves
                                            INNER JOIN seguimiento_acc.etiquetas e ON e.numero_etiqueta = ves.numero_etiqueta
                                            INNER JOIN seguimiento_acc.articulos a ON e.clave_articulo = a.clave 
                                        WHERE
                                            ves.codigo_salida IN ({0})
                                        GROUP BY
	                                        e.clave_articulo,
                                            a.articulo,
                                            e.unidad
                                        ORDER BY
	                                        clave_articulo", sCodigosWhere);
                
                MyAdapter.SelectCommand = MyComm;
                DataTable dtResultado = new DataTable();
                MyAdapter.Fill(dtResultado);

                VistaPrevia vpDetalle;
                foreach (DataRow row in dtResultado.Rows)
                {
                    vpDetalle = new VistaPrevia();
                    vpDetalle.sClaveArticulo = Convert.ToString(row["clave_articulo"]);
                    vpDetalle.sNombreArticulo = Convert.ToString(row["articulo"]);
                    vpDetalle.dCantidad = Convert.ToDecimal(row["cantidad"]);
                    vpDetalle.sUnidad = Convert.ToString(row["unidad"]);

                    lstDetalles.Add(vpDetalle);
                }

                MyConn.Close();

                return lstDetalles;
            }
            catch (Exception ex)
            {
                if (MyConn.State != ConnectionState.Closed)
                    MyConn.Close();
                throw ex;
            }
        }
    }
}
